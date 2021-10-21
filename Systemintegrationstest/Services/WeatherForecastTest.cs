using System;
using Vejrudsigten.Services;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Unittest;

namespace Systemintegrationstest.Services
{
   public class WeatherForecastTest
   {
      public IServiceProvider services = TestHelper.CreateWebAppContainerServices();

      [Fact]
      public async System.Threading.Tasks.Task OnlineServiceHulIgennemTest()
      {
         var scope = services.CreateScope();
         var configuration = scope.ServiceProvider.GetService<IConfiguration>();
         var key = configuration["key"];

         var actual = await WeatherForecast.GetForecastAsync(key);

         Assert.True(actual.Length > 0);
      }

   }
}
