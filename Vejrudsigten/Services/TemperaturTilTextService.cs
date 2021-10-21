using System.Collections.Generic;

namespace Vejrudsigten.Services
{
    public class TemperaturTilTextService
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
		}

		private Dictionary<TextId, string> mapper = new();

        public TemperaturTilTextService()
        {
			mapper.Add(TextId.Textid1,  "Temperaturen falder endnu mere og frosten fortsætter.");
			mapper.Add(TextId.Textid2,  "Kulden sætter virkelig ind nu.");
			mapper.Add(TextId.Textid3,  "Temperaturen er kraftigt faldende); men det bliver stadig lunt.");
			mapper.Add(TextId.Textid4,  "Helt skørt med vejret i dag for varmen slår over i frost.");
			mapper.Add(TextId.Textid5,  "Det bliver under frysepunktet som i går, temperatur er uændret.");
			mapper.Add(TextId.Textid6,  "Samme kolde temperatur som i går.");
			mapper.Add(TextId.Textid7,  "Temperaturen er stabil og det blir lunt igen i dag.");
			mapper.Add(TextId.Textid8,  "Strandvejr, som i går med samme temperatur.");
			mapper.Add(TextId.Textid9,  "Selvom temperaturen rykker meget opad fra i går, så er det stadig iskoldt. ");
			mapper.Add(TextId.Textid10, "Det virker som om rigtig koldt pludselig erstattes af koldt.");
			mapper.Add(TextId.Textid11, "Det bliver meget lunere i dag.");
			mapper.Add(TextId.Textid12, "Jaaa, nu får vi varmen fra nord, syd, øst eller vest.");
			mapper.Add(TextId.Textid13, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid14, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid15, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid16, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid17, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid18, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid19, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid20, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid21, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid22, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid23, "Højest et lille fald i temperaturen.");
			mapper.Add(TextId.Textid24, "Højest et lille fald i temperaturen.");

		}

        public string GetText(TextId id)
        {
			return mapper[id];
        }

    }
}
