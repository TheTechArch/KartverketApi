using System;
using System.Collections.Generic;
using System.Text;

namespace KarverketApiClient.Models
{
    public class Adresser
    {
        public string objtype { get; set; }
        public int nummer { get; set; }
        public string kommunenavn { get; set; }
        public int gardsnummer { get; set; }
        public string poststed { get; set; }
        public int festenummer { get; set; }
        public string bokstav { get; set; }
        public int adressekode { get; set; }
        public string adressetilleggsnavn { get; set; }
        public Representasjonspunkt representasjonspunkt { get; set; }
        public string adressenavn { get; set; }
        public string oppdateringsdato { get; set; }
        public string postnummer { get; set; }
        public int bruksnummer { get; set; }
        public bool stedfestingverifisert { get; set; }
        public string adressetekst { get; set; }
        public string adressetekstutenadressetilleggsnavn { get; set; }
        public int? undernummer { get; set; }
        public string kommunenummer { get; set; }
        public string[] bruksenhetsnummer { get; set; }
    }
}
