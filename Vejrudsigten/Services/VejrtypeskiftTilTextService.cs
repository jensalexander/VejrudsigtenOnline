using System.Collections.Generic;
using Vejrudsigten.Tekster;

namespace Vejrudsigten.Services
{

    public class VejrtypeskiftTilTextService
    {
			public enum TextId
			{
				Textid1,
				Textid2,
				Textid3,
				Textid4,
				Textid5,
				Textid6,
				Textid7,
				Textid8,
				Textid9,
				Textid10,
				Textid11,
				Textid12,
				Textid13,
				Textid14,
				Textid15,
				Textid16,
				Textid17,
				Textid18,
				Textid19,
				Textid20,
				Textid21,
				Textid22,
				Textid23,
				Textid24,
				Textid25,
			}

			private Dictionary<TextId, string> mapper = new();

        public VejrtypeskiftTilTextService()
        {
			mapper.Add(TextId.Textid1, "Det gode vejr fortsætter med klart vejr.");
			mapper.Add(TextId.Textid2, "Farvel til solen i denne omgang – find sylvesten frem.");
			mapper.Add(TextId.Textid3, "Pas på i trafikken, det blir glat.");
			mapper.Add(TextId.Textid4, "Solen gemmer sig i dag bage skyerne.");
			mapper.Add(TextId.Textid5, "Så er erstattes det gode af en ustabil periode.");
			mapper.Add(TextId.Textid6, "Vi kan gemme paraplyen væk og kan hive parasollen frem.");
			mapper.Add(TextId.Textid7, "Vådt i vådt fortsætter i dag med.");
			mapper.Add(TextId.Textid8, "Advarsel om glatte vejbaner.");
			mapper.Add(TextId.Textid9, "Gråt men vi slipper da for regnen i denne omgang.");
			mapper.Add(TextId.Textid10, "Det bliver et misk-maks af et vejr i dag.");
			mapper.Add(TextId.Textid11, "Frem med solbrillerne, så du ikke bliver sneblind.");
			mapper.Add(TextId.Textid12, "Det bliver lidt pludde-agtigt i dag når sneen afløses af regn.");
			mapper.Add(TextId.Textid13, "Jaaaa, sne med sne på. Så spænd skiene på."); 
			mapper.Add(TextId.Textid14, "Sneen smeltes afløses af skyer.");
			mapper.Add(TextId.Textid15, "Ustabilt vejr i sigte, nu troede vi lige sneen blev ved.");
			mapper.Add(TextId.Textid16, "Endelig titter solen frem.");
			mapper.Add(TextId.Textid17, "Vi tænkte det nok. Det bliver gummistøvlevejr.");
			mapper.Add(TextId.Textid18, "Så falder skyerne ned fra himlen.");
			mapper.Add(TextId.Textid19, "Som i går - masser af sky til leverståhejen.");
			mapper.Add(TextId.Textid20, "Ustabilt vejr i sigte.");
			mapper.Add(TextId.Textid21, "Klaring og mere stabilt vejr på vej.");
			mapper.Add(TextId.Textid22, "Ved snart ikke hvad der er bedst og regn bliver det."); 
			mapper.Add(TextId.Textid23, "Kedeligt vejr erstattes af sne.");
			mapper.Add(TextId.Textid24, "Kedeligt vejr erstattes af noget andet kedeligt vejr – skyer så langt øjet rækker.");
			mapper.Add(TextId.Textid25, "De ustabile vejr fortsætter.");
		}

        public string GetText(TextId id)
        {
			return mapper[id];
        }

    }
}
