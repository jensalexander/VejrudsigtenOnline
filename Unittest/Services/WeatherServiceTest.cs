using System;
using Vejrudsigten.Services;
using Vejrudsigten.Forretningslogik;
using Xunit;

namespace Unittest.Services
{
   public class WeatherServiceTest
   {
      [Fact]
      public async System.Threading.Tasks.Task NårDeranvendesUlovligeVærdierSåKastesException()
      {
         var yesterday = CreateWeatherInfo("xxx", 1);
         var today = CreateWeatherInfo("yyy", 2);

         var sut = new WeatherService();

         await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => sut.GetWeatherPresentation(today, yesterday));
      }
      
      [Theory]
      [InlineData("Sne", 0, "Sne", 0, VejrtypeskiftTilTextService.TextId.Textid13, TemperaturTilTextService.TextId.Textid17)]
      [InlineData("Andet", 9.9, "Skyet", 10, VejrtypeskiftTilTextService.TextId.Textid24, TemperaturTilTextService.TextId.Textid22)]
      [InlineData("Klart vejr", -10, "Regn", 20, VejrtypeskiftTilTextService.TextId.Textid2, TemperaturTilTextService.TextId.Textid12)]

      public async System.Threading.Tasks.Task Skiftet_I_Vejret_ForventKorrektTekst(string vejrtypeIgår, double t0, string vejrtypeIdag, double t1, VejrtypeskiftTilTextService.TextId forventetTextIdForDelprognose1, TemperaturTilTextService.TextId forventetTextIdForDelprognose2)
      {
         var weatherTextOut1Service = new VejrtypeskiftTilTextService();
         var temperaturTilTextService = new TemperaturTilTextService();
         var yesterday = CreateWeatherInfo(vejrtypeIgår, t0);
         var today = CreateWeatherInfo(vejrtypeIdag, t1);
         var sut = new WeatherService();

         var actual = await sut.GetWeatherPresentation(today, yesterday);

         var expectedOut1 = weatherTextOut1Service.GetText(forventetTextIdForDelprognose1);
         var expectedOut2 = temperaturTilTextService.GetText(forventetTextIdForDelprognose2);

         var expectedResult = string.Format(VejrudsigtLayout.format, expectedOut1, expectedOut2, today.Temperature);
         Assert.Equal(expectedResult, actual);
      }


      private WeatherInfo CreateWeatherInfo(string c, double t)
      {
         return new WeatherInfo { Conditions = c, Temperature = t };
      }
      
   }
}
