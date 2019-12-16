using System;
using System.Collections.Generic;
using System.Text;

namespace KarverketApiClient.Models
{
    public class Metadata
    {
        public string sokeStreng { get; set; }
        public int viserTil { get; set; }
        public int treffPerSide { get; set; }
        public int totaltAntallTreff { get; set; }
        public int viserFra { get; set; }
        public bool asciiKompatibel { get; set; }
        public int side { get; set; }
    }
}
