using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Cryptoaster.ExchangeApi.Cryptopia.Models;
using Cryptoaster.ExchangeApi.Cryptopia.Responses;
using Newtonsoft.Json;

namespace Cryptoaster.ExchangeApi.Cryptopia
{
    public class CryptopiaApiClient : ICryptopiaApiClient
    {
        private static string BaseUrl => "https://www.cryptopia.co.nz";
        private HttpClient _httpClient;

        public CryptopiaApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IList<Currency>> GetCurrencies()
        {
            string url = "/api/GetCurrencies";

            var response = await GetAsync<GetCurrenciesResponse>(url);

            return response.Data;
        }

        public async Task<IList<TradePair>> GetTradePairs()
        {
            string url = "/api/GetTradePairs";

            var response = await GetAsync<GetTradePairsResponse>(url);

            return response.Data;
        }

        public async Task<IList<Market>> GetMarkets(string baseMarket = null, int hours = 24)
        {
            string url = $"/api/GetMarkets/{baseMarket}/{hours}";

            var response = await GetAsync<GetMarketsResponse>(url);

            return response.Data;
        }

        private async Task<T> GetAsync<T>(string url) where T : IResponse
        {
            var responseString = await _httpClient.GetStringAsync(BaseUrl + url);

            var response = JsonConvert.DeserializeObject<T>(responseString);

            if (!response.Success)
            {
                throw new Exception(response.Error);
            }

            return response;
        }
    }
}
