using Microsoft.Extensions.Configuration;
using System;
using Vejrudsigten;

namespace Unittest
{
   public static class TestHelper
   {

      public static IServiceProvider CreateWebAppContainerServices()
      {
         return Program.CreateHostBuilder(new string[] { })
                         .ConfigureAppConfiguration((hostContext, builder) =>
                         {                                                        
                            builder.AddUserSecrets<Program>();                            
                         })
                     .Build().Services;
      }

   }
}