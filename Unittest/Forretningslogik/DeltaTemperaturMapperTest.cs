using System;
using Vejrudsigten.Forretningslogik;
using Vejrudsigten.Services;
using Xunit;

namespace Unittest.Forretningslogik
{
   public class DeltaTemperaturMapperTest
   {

      [Theory]
      [InlineData(5.0, 5.1, TemperaturMapperService.Faldende)]
      [InlineData(5.0, 5.0, TemperaturMapperService.U�ndret)]
      [InlineData(5.1, 5.0, TemperaturMapperService.Stigende)]

      public void Gr�nsev�rditest(double idagTemp, double ig�rTemp, string expectedPartition)
      {
         var actual = DeltaTemperaturMapper.GetText(idagTemp, ig�rTemp);

         Assert.Equal(expectedPartition, actual);
      }

   }
}
