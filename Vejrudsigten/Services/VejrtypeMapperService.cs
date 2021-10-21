using System;
using System.Collections.Generic;

namespace Vejrudsigten.Services
{
   public class VejrtypeÆndring
   {
      string conditionigår;
      string conditionidag;

      public VejrtypeÆndring(string conditionigår, string conditionidag)
      {
         this.conditionigår = conditionigår;
         this.conditionidag = conditionidag;
      }

      public override bool Equals(Object obj)
      {         
         if ((obj == null) || !this.GetType().Equals(obj.GetType()))
         {
            return false;
         }
         else
         {
            VejrtypeÆndring p = (VejrtypeÆndring)obj;
            return (conditionidag == p.conditionidag) && (conditionigår == p.conditionigår);
         }
      }

      public override int GetHashCode()
      {
         return 42;
      }
   }
   

   public class VejrtypeMapperService
   {
      private Dictionary<VejrtypeÆndring, VejrtypeskiftTilTextService.TextId> mapper = new();

      private static readonly string Klartvejr = "Klart vejr";
      private static readonly string Regn = "Regn";
      private static readonly string Sne = "Sne";
      private static readonly string Skyet = "Skyet";
      private static readonly string Andet = "Andet";

      public VejrtypeMapperService()
      {
         mapper.Add(new VejrtypeÆndring(Klartvejr, Klartvejr), VejrtypeskiftTilTextService.TextId.Textid1);
         mapper.Add(new VejrtypeÆndring(Klartvejr, Regn), VejrtypeskiftTilTextService.TextId.Textid2);
         mapper.Add(new VejrtypeÆndring(Klartvejr, Sne), VejrtypeskiftTilTextService.TextId.Textid3);
         mapper.Add(new VejrtypeÆndring(Klartvejr, Skyet), VejrtypeskiftTilTextService.TextId.Textid4);
         mapper.Add(new VejrtypeÆndring(Klartvejr, Andet), VejrtypeskiftTilTextService.TextId.Textid5);

         mapper.Add(new VejrtypeÆndring(Regn, Klartvejr), VejrtypeskiftTilTextService.TextId.Textid6);
         mapper.Add(new VejrtypeÆndring(Regn, Regn), VejrtypeskiftTilTextService.TextId.Textid7);
         mapper.Add(new VejrtypeÆndring(Regn, Sne), VejrtypeskiftTilTextService.TextId.Textid8);
         mapper.Add(new VejrtypeÆndring(Regn, Skyet), VejrtypeskiftTilTextService.TextId.Textid9);
         mapper.Add(new VejrtypeÆndring(Regn, Andet), VejrtypeskiftTilTextService.TextId.Textid10);

         mapper.Add(new VejrtypeÆndring(Sne, Klartvejr), VejrtypeskiftTilTextService.TextId.Textid11);
         mapper.Add(new VejrtypeÆndring(Sne, Regn), VejrtypeskiftTilTextService.TextId.Textid12);
         mapper.Add(new VejrtypeÆndring(Sne, Sne), VejrtypeskiftTilTextService.TextId.Textid13);
         mapper.Add(new VejrtypeÆndring(Sne, Skyet), VejrtypeskiftTilTextService.TextId.Textid14);
         mapper.Add(new VejrtypeÆndring(Sne, Andet), VejrtypeskiftTilTextService.TextId.Textid15);

         mapper.Add(new VejrtypeÆndring(Skyet, Klartvejr), VejrtypeskiftTilTextService.TextId.Textid16);
         mapper.Add(new VejrtypeÆndring(Skyet, Regn), VejrtypeskiftTilTextService.TextId.Textid17);
         mapper.Add(new VejrtypeÆndring(Skyet, Sne), VejrtypeskiftTilTextService.TextId.Textid18);
         mapper.Add(new VejrtypeÆndring(Skyet, Skyet), VejrtypeskiftTilTextService.TextId.Textid19);
         mapper.Add(new VejrtypeÆndring(Skyet, Andet), VejrtypeskiftTilTextService.TextId.Textid20);

         mapper.Add(new VejrtypeÆndring(Andet, Klartvejr), VejrtypeskiftTilTextService.TextId.Textid21);
         mapper.Add(new VejrtypeÆndring(Andet, Regn), VejrtypeskiftTilTextService.TextId.Textid22);
         mapper.Add(new VejrtypeÆndring(Andet, Sne), VejrtypeskiftTilTextService.TextId.Textid23);
         mapper.Add(new VejrtypeÆndring(Andet, Skyet), VejrtypeskiftTilTextService.TextId.Textid24);
         mapper.Add(new VejrtypeÆndring(Andet, Andet), VejrtypeskiftTilTextService.TextId.Textid25);
      }

      public VejrtypeskiftTilTextService.TextId GetText(VejrtypeÆndring vejrtypeÆndring)
      {
         try
         {
            return mapper[vejrtypeÆndring];
         }
         catch {
            throw new ArgumentOutOfRangeException();
         }
      }
   }
}