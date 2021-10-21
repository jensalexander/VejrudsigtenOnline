using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Vejrudsigten.Forretningslogik;

namespace Vejrudsigten.Services
{

   public class WeatherService
    {
        public async Task<WeatherInfo> GetTodaysWeather(string key, string location)
        {
            HttpClient client = new HttpClient();
            String urlPattern = "https://smartweatherdk.azurewebsites.net/api/GetTodaysWeather?key={0}&location={1}";            
            var url = String.Format(urlPattern, key, location);
            var streamTask = client.GetStreamAsync(url);            
            var weatherInfo = await JsonSerializer.DeserializeAsync<WeatherInfo>(await streamTask);            
            return weatherInfo;
        }

        public async Task<string> GetWeatherPresentation(WeatherInfo todayInfo, WeatherInfo yesterdayInfo)
        {
            var vejrtypeMapperService = new VejrtypeMapperService();
            var temperaturMapperService = new TemperaturMapperService();
            var weatherTextOut1Service = new VejrtypeskiftTilTextService();
            var weatherTextOut2Service = new TemperaturTilTextService();
            
            var out1 = GetVejrDelprognose1(vejrtypeMapperService, weatherTextOut1Service, yesterdayInfo, todayInfo);
            var out2 = GetVejrDelprognose2(temperaturMapperService, weatherTextOut2Service, yesterdayInfo, todayInfo);
            
            var resultat = string.Format(VejrudsigtLayout.format, out1, out2, todayInfo.Temperature);
         
            return resultat;
        }

      private string GetVejrDelprognose2(TemperaturMapperService temperaturMapperService, TemperaturTilTextService weatherTextOut2Service, WeatherInfo yesterdayInfo, WeatherInfo todayInfo)
      {
         var temperaturKlassificeringsText = TemperaturMapper.GetText(todayInfo.Temperature);
         var deltaTemperaturKlassificeringsText = DeltaTemperaturMapper.GetText(todayInfo.Temperature, yesterdayInfo.Temperature);
         var deltaDeltaTemperaturKlassificeringsText = DeltaDeltaTemperaturMapper.GetText(todayInfo.Temperature, yesterdayInfo.Temperature);
         var textIdTemperatur = temperaturMapperService.GetText(new TemperaturKlassificeringsInput(temperaturKlassificeringsText, deltaTemperaturKlassificeringsText, deltaDeltaTemperaturKlassificeringsText));
         Debug.WriteLine("textIdTemperatur = " + textIdTemperatur);
         return weatherTextOut2Service.GetText(textIdTemperatur);
      }

      private string GetVejrDelprognose1(VejrtypeMapperService vejrtypeMapperService, VejrtypeskiftTilTextService weatherTextOut1Service, WeatherInfo yesterdayInfo, WeatherInfo todayInfo)
      {         
         var textIdVejrtype = vejrtypeMapperService.GetText(new VejrtypeÆndring(yesterdayInfo.Conditions, todayInfo.Conditions));
         Debug.WriteLine("textIdVejrtype = " + textIdVejrtype);
         return weatherTextOut1Service.GetText(textIdVejrtype);
      }

      public async Task<WeatherInfo> GetYesterdaysWeather(string key, string location)
        {
            HttpClient client = new HttpClient();
            String urlPattern = "https://smartweatherdk.azurewebsites.net/api/GetYesterdaysWeather?key={0}&location={1}";
            var url = String.Format(urlPattern, key, location);
            var streamTask = client.GetStreamAsync(url);
            var weatherInfo = await JsonSerializer.DeserializeAsync<WeatherInfo>(await streamTask);
            return weatherInfo;
        }

    }
}
