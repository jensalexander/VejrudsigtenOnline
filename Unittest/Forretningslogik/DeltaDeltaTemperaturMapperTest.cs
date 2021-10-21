using System;
using Vejrudsigten.Forretningslogik;
using Vejrudsigten.Services;
using Xunit;

namespace Unittest.Forretningslogik
{
   public class DeltaDeltaTemperaturMapperTest
   {


      [Theory]
      [InlineData(5.0, 5.0, TemperaturMapperService.Uændret)]
      [InlineData(5.0, 5.1, TemperaturMapperService.Lille)]
      [InlineData(5.1, 5.0, TemperaturMapperService.Lille)]
      [InlineData(10, 5.1, TemperaturMapperService.Lille)]
      [InlineData(5, 10, TemperaturMapperService.Stor)]
      [InlineData(20, 10.1, TemperaturMapperService.Stor)]
      [InlineData(20, 10, TemperaturMapperService.Voldsom)]
      [InlineData(40, 10, TemperaturMapperService.Voldsom)]

      public void Grænseværditest(double t1, double t0, string expectedPartition)
      {
         var actual = DeltaDeltaTemperaturMapper.GetText(t1, t0);

         Assert.Equal(expectedPartition, actual);
      }

   }
}
