using Vejrudsigten.Services;

namespace Vejrudsigten.Forretningslogik
{
   public static class TemperaturMapper
   {
      public static string GetText(double t)
      {
         if (t <= 0) return TemperaturMapperService.Frost;
         if (t < 15) return TemperaturMapperService.Koldt;
         if (t < 20) return TemperaturMapperService.Lunt;
         return TemperaturMapperService.Varmt;
      }
   }
}
