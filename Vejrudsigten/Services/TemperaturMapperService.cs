using System;
using System.Collections.Generic;

namespace Vejrudsigten.Services
{
   
   public class TemperaturKlassificeringsInput
   {
      string temperaturKlasseIdag;
      string deltaTemperaturKlasseIdag;
      string deltaDeltaTemperaturKlasseIdag;

      public TemperaturKlassificeringsInput( string temperaturKlasseIdag,string deltaTemperaturKlasseIdag, string deltaDeltaTemperaturKlasseIdag)
      {
         this.temperaturKlasseIdag = temperaturKlasseIdag;          
         this.deltaTemperaturKlasseIdag = deltaTemperaturKlasseIdag;       
         this.deltaDeltaTemperaturKlasseIdag = deltaDeltaTemperaturKlasseIdag;
      }

      public override bool Equals(Object obj)
      {
         if ((obj == null) || !this.GetType().Equals(obj.GetType()))
         {
            return false;
         }
         else
         {
            TemperaturKlassificeringsInput p = (TemperaturKlassificeringsInput)obj;
            return (temperaturKlasseIdag == p.temperaturKlasseIdag) && (deltaTemperaturKlasseIdag == p.deltaTemperaturKlasseIdag) && (deltaDeltaTemperaturKlasseIdag == p.deltaDeltaTemperaturKlasseIdag);
         }
      }

      public override int GetHashCode()
      {
         return 42;
      }
   }
  
   public class TemperaturMapperService 
   {
      private Dictionary<TemperaturKlassificeringsInput, TemperaturTilTextService.TextId> mapper = new();

      public const string Frost = "Frost";
      public const string Koldt = "Koldt";
      public const string Lunt = "Lunt";
      public const string Varmt = "Varmt";
      
      public const string Faldende = "Faldende";
      public const string Uændret = "Uændret";
      public const string Stigende = "Stigende";
      
      public const string Lille = "Lille";
      public const string Stor = "Stor";
      public const string Voldsom = "Voldsom";

      public TemperaturMapperService()
      {
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Faldende, Voldsom), TemperaturTilTextService.TextId.Textid1);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Faldende, Voldsom), TemperaturTilTextService.TextId.Textid2);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Faldende, Voldsom), TemperaturTilTextService.TextId.Textid3);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Faldende, Voldsom), TemperaturTilTextService.TextId.Textid4);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Uændret, Voldsom), TemperaturTilTextService.TextId.Textid5);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Uændret, Voldsom), TemperaturTilTextService.TextId.Textid6);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Uændret, Voldsom), TemperaturTilTextService.TextId.Textid7);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Uændret, Voldsom), TemperaturTilTextService.TextId.Textid8);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Stigende, Voldsom), TemperaturTilTextService.TextId.Textid9);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Stigende, Voldsom), TemperaturTilTextService.TextId.Textid10);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Stigende, Voldsom), TemperaturTilTextService.TextId.Textid11);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Stigende, Voldsom), TemperaturTilTextService.TextId.Textid12);

         mapper.Add(new TemperaturKlassificeringsInput(Frost, Faldende, Stor), TemperaturTilTextService.TextId.Textid1);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Faldende, Stor), TemperaturTilTextService.TextId.Textid2);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Faldende, Stor), TemperaturTilTextService.TextId.Textid3);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Faldende, Stor), TemperaturTilTextService.TextId.Textid4);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Uændret, Stor), TemperaturTilTextService.TextId.Textid5);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Uændret, Stor), TemperaturTilTextService.TextId.Textid6);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Uændret, Stor), TemperaturTilTextService.TextId.Textid7);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Uændret, Stor), TemperaturTilTextService.TextId.Textid8);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Stigende, Stor), TemperaturTilTextService.TextId.Textid9);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Stigende, Stor), TemperaturTilTextService.TextId.Textid10);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Stigende, Stor), TemperaturTilTextService.TextId.Textid11);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Stigende, Stor), TemperaturTilTextService.TextId.Textid12);

         mapper.Add(new TemperaturKlassificeringsInput(Frost, Faldende, Uændret), TemperaturTilTextService.TextId.Textid13);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Faldende, Uændret), TemperaturTilTextService.TextId.Textid14);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Faldende, Uændret), TemperaturTilTextService.TextId.Textid15);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Faldende, Uændret), TemperaturTilTextService.TextId.Textid16);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Uændret, Uændret), TemperaturTilTextService.TextId.Textid17);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Uændret, Uændret), TemperaturTilTextService.TextId.Textid18);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Uændret, Uændret), TemperaturTilTextService.TextId.Textid19);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Uændret, Uændret), TemperaturTilTextService.TextId.Textid20);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Stigende, Uændret), TemperaturTilTextService.TextId.Textid21);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Stigende, Uændret), TemperaturTilTextService.TextId.Textid22);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Stigende, Uændret), TemperaturTilTextService.TextId.Textid23);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Stigende, Uændret), TemperaturTilTextService.TextId.Textid24);

         mapper.Add(new TemperaturKlassificeringsInput(Frost, Faldende, Lille), TemperaturTilTextService.TextId.Textid13);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Faldende, Lille), TemperaturTilTextService.TextId.Textid14);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Faldende, Lille), TemperaturTilTextService.TextId.Textid15);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Faldende, Lille), TemperaturTilTextService.TextId.Textid16);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Uændret, Lille), TemperaturTilTextService.TextId.Textid17);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Uændret, Lille), TemperaturTilTextService.TextId.Textid18);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Uændret, Lille), TemperaturTilTextService.TextId.Textid19);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Uændret, Lille), TemperaturTilTextService.TextId.Textid20);
         mapper.Add(new TemperaturKlassificeringsInput(Frost, Stigende, Lille), TemperaturTilTextService.TextId.Textid21);
         mapper.Add(new TemperaturKlassificeringsInput(Koldt, Stigende, Lille), TemperaturTilTextService.TextId.Textid22);
         mapper.Add(new TemperaturKlassificeringsInput(Lunt, Stigende, Lille), TemperaturTilTextService.TextId.Textid23);
         mapper.Add(new TemperaturKlassificeringsInput(Varmt, Stigende, Lille), TemperaturTilTextService.TextId.Textid24);
      }

      public TemperaturTilTextService.TextId GetText(TemperaturKlassificeringsInput temperaturKlassificeringsInput)
      {         
         try
         {
            return mapper[temperaturKlassificeringsInput];
         }
         catch
         {
            throw new ArgumentOutOfRangeException();
         }
      }
   }
}