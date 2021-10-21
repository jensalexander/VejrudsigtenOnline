using System;
using Vejrudsigten.Services;
using Xunit;

namespace Unittest.Services
{
   public class DeltaVejrtypeMapperServiceTest
   {
      [Fact]
      public void NÂrVejrtypeIkkeFindesSÂSmidesExpection()
      {
         var vejrtype∆ndring = new Vejrtype∆ndring("", "");
         var sut = new VejrtypeMapperService();

         Assert.Throws<ArgumentOutOfRangeException>(() => sut.GetText(vejrtype∆ndring));
      }

      [Fact]
      public void NÂrMapningFindesSÂReturnesKorrektText()
      {
         var vejrtype∆ndring = new Vejrtype∆ndring("Klart vejr", "Sne");
         var sut = new VejrtypeMapperService();

         var actual = sut.GetText(vejrtype∆ndring);

         Assert.Equal(VejrtypeskiftTilTextService.TextId.Textid3, actual);
      }

   }
}
