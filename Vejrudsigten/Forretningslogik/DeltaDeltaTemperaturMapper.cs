using System;
using Vejrudsigten.Services;

namespace Vejrudsigten.Forretningslogik
{
   public static class DeltaDeltaTemperaturMapper
   {
      public static string GetText(double t1, double t0)
      {
         var deltaDeltaT = Math.Abs(t1 - t0);
         if (deltaDeltaT == 0) return TemperaturMapperService.Uændret;
         if (deltaDeltaT < 5) return TemperaturMapperService.Lille;
         if (deltaDeltaT < 10) return TemperaturMapperService.Stor;
         return TemperaturMapperService.Voldsom;         
      }
   }
}
