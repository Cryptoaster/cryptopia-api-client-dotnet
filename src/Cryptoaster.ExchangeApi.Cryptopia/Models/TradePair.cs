using System;
using Cryptoaster.ExchangeApi.Cryptopia.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cryptoaster.ExchangeApi.Cryptopia.Models
{
    public class TradePair
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Symbol { get; set; }
        public string Currency { get; set; }
        public string BaseCurrency { get; set; }
        public string BaseSymbol { get; set; }
        public decimal TradeFee { get; set; }
        public decimal MinimumTrade { get; set; }
        public decimal MaximumTrade { get; set; }
        public decimal MinimumBaseTrade { get; set; }
        public decimal MaximumBaseTrade { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal MaximumPrice { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TradePairStatus Status { get; set; }
        public string StatusMessage { get; set; }
    }
}