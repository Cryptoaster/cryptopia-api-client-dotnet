using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cryptoaster.ExchangeApi.Cryptopia.Models;

namespace Cryptoaster.ExchangeApi.Cryptopia
{
    public interface ICryptopiaApiClient
    {
        Task<IList<Currency>> GetCurrencies();
        Task<IList<TradePair>> GetTradePairs();
        Task<IList<Market>> GetMarkets(string baseMarket, int hours);
    }
}
