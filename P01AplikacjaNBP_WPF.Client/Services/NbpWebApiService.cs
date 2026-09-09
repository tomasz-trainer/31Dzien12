using Newtonsoft.Json;
using P01AplikacjaNBP_WPF.Client.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace P01AplikacjaNBP_WPF.Client.Services
{
    internal class NbpWebApiService : IWebApiService
    {
        private const string nbp_base_url = $"https://api.nbp.pl/api/exchangerates/";

        public async Task<Rate[]> GetExchangeRatesAsync()
        {
            string url = $"{nbp_base_url}tables/A?format=json";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<CurrencyTable[]>(json);

                return result[0]?.Rates?.ToArray() ?? Array.Empty<Rate>();
            }
        }
    }
}
