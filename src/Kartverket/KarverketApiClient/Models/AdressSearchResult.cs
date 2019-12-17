using System;
using System.Collections.Generic;
using System.Text;

namespace KarverketApiClient.Models
{
    public class AdressSearchResult
    {
        public Adresser[] adresser { get; set; }
        public Metadata metadata { get; set; }
    }
}
