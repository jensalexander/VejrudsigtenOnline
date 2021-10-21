using System;
using Vejrudsigten.Services;
using Xunit;

namespace Unittest.Services
{
   public class DeltaTemperaturMapperServiceTest
   {
      [Fact]
      public void N�rTemperaturKlassificeringIkkeFindesS�SmidesExpection()
      {
         var temperaturKlassificeringsInput = new TemperaturKlassificeringsInput("", "", "");
         var sut = new TemperaturMapperService();

         Assert.Throws<ArgumentOutOfRangeException>(() => sut.GetText(temperaturKlassificeringsInput));
      }

      [Fact]
      public void N�rMapningFindesS�ReturnesKorrektText()
      {
         var temperaturKlassificeringsInput = new TemperaturKlassificeringsInput("Lunt", "Stigende", "U�ndret");
         var sut = new TemperaturMapperService();

         var actual = sut.GetText(temperaturKlassificeringsInput);

         Assert.Equal(TemperaturTilTextService.TextId.Textid23, actual);
      }

   }
}
