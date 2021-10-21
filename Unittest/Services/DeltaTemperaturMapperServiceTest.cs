using System;
using Vejrudsigten.Services;
using Xunit;

namespace Unittest.Services
{
   public class DeltaTemperaturMapperServiceTest
   {
      [Fact]
      public void NÂrTemperaturKlassificeringIkkeFindesSÂSmidesExpection()
      {
         var temperaturKlassificeringsInput = new TemperaturKlassificeringsInput("", "", "");
         var sut = new TemperaturMapperService();

         Assert.Throws<ArgumentOutOfRangeException>(() => sut.GetText(temperaturKlassificeringsInput));
      }

      [Fact]
      public void NÂrMapningFindesSÂReturnesKorrektText()
      {
         var temperaturKlassificeringsInput = new TemperaturKlassificeringsInput("Lunt", "Stigende", "UÊndret");
         var sut = new TemperaturMapperService();

         var actual = sut.GetText(temperaturKlassificeringsInput);

         Assert.Equal(TemperaturTilTextService.TextId.Textid23, actual);
      }

   }
}
