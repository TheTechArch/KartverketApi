using KarverketApiClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KarverketApiClient.Service
{
    public class KartverketApiSI
    {

        private string url = "https://ws.geonorge.no/adresser/v1/sok?sok={0}&treffPerSide=10&side=0&asciiKompatibel=true";


        public async Task<AdressSearchResult> SearchAdress(AdressSearch search)
        {
            AdressSearchResult result = new AdressSearchResult();

            HttpClient client = new HttpClient();
            HttpResponseMessage respons = await client.GetAsync(string.Format(url, search.sok));
            if (respons.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string responseData = respons.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<AdressSearchResult>(responseData);
            }

            return result;
        }
    }
}
