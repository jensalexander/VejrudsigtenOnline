using System.Threading.Tasks;

namespace Vejrudsigten.Services
{
   public static class WeatherForecast
    {
        public static async Task<string> GetForecastAsync(string key)
        {
            WeatherService service = new WeatherService();         
            var todayInfo = await service.GetTodaysWeather(key, "Kolding");
            var yesterdayInfo = await service.GetYesterdaysWeather(key, "Kolding");            
            return await service.GetWeatherPresentation(todayInfo, yesterdayInfo);            
        }
    }
}
