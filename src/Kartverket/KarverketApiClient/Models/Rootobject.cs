using System;
using System.Collections.Generic;
using System.Text;

namespace KarverketApiClient.Models
{
    public class Rootobject
    {
        public Adresser[] adresser { get; set; }
        public Metadata metadata { get; set; }
    }
}
