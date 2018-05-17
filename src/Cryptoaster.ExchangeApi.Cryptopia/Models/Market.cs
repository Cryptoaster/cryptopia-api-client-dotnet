using System;
using Cryptoaster.ExchangeApi.Cryptopia.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cryptoaster.ExchangeApi.Cryptopia.Models
{
    public class Market
    {
        public int TradePairId { get; set; }
        public string Label { get; set; }
        public decimal AskPrice { get; set; }
        public decimal BidPrice { get; set; }
        public decimal Low { get; set; }
        public decimal High { get; set; }
        public decimal Volume { get; set; }
        public decimal LastPrice { get; set; }
        public decimal BuyVolume { get; set; }
        public decimal SellVolume { get; set; }
        public decimal Change { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal BaseVolume { get; set; }
        public decimal BaseBuyVolume { get; set; }
        public decimal BaseSellVolume { get; set; }
    }
}