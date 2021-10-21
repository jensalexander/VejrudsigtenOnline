using Vejrudsigten.Services;

namespace Vejrudsigten.Forretningslogik
{
   public static class DeltaTemperaturMapper
   {
      public static string GetText(double t1, double t0)
      {
         var deltaT = t1 - t0;
         if (deltaT < 0) return TemperaturMapperService.Faldende;
         if (deltaT == 0) return TemperaturMapperService.Uændret;
         return TemperaturMapperService.Stigende;
      }
   }
}
