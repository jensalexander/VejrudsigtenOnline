using System;
using Vejrudsigten.Forretningslogik;
using Vejrudsigten.Services;
using Xunit;

namespace Unittest.Forretningslogik
{
   public class TemperaturMapperTest
   {

      [Theory]
      [InlineData(-0.1, TemperaturMapperService.Frost)]
      [InlineData(0.0, TemperaturMapperService.Frost)]
      [InlineData(0.1, TemperaturMapperService.Koldt)]
      [InlineData(14.9, TemperaturMapperService.Koldt)]
      [InlineData(15.0, TemperaturMapperService.Lunt)]
      [InlineData(19.9, TemperaturMapperService.Lunt)]
      [InlineData(20.0, TemperaturMapperService.Varmt)]
      public void Grænseværditest(double temp, string expectedPartition)
      {
         var actual = TemperaturMapper.GetText(temp);

         Assert.Equal(expectedPartition, actual);
      }

   }
}
