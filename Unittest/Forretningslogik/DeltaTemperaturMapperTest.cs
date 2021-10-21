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
      [InlineData(5.0, 5.0, TemperaturMapperService.Uændret)]
      [InlineData(5.1, 5.0, TemperaturMapperService.Stigende)]

      public void Grænseværditest(double idagTemp, double igårTemp, string expectedPartition)
      {
         var actual = DeltaTemperaturMapper.GetText(idagTemp, igårTemp);

         Assert.Equal(expectedPartition, actual);
      }

   }
}
