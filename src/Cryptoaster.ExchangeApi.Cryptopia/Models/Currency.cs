using System;
using Cryptoaster.ExchangeApi.Cryptopia.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Cryptoaster.ExchangeApi.Cryptopia.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Algorithm { get; set; }
        public decimal WithdrawFee { get; set; }
        public decimal MinWithdraw { get; set; }
        public decimal MinBaseTrade { get; set; }
        public bool IsTipEnabled { get; set; }
        public decimal MinTip { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CurrencyStatus Status { get; set; }
        public string StatusMessage { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ListingStatus ListingStatus { get; set; }
    }
}