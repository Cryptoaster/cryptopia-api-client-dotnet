using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptoaster.ExchangeApi.Cryptopia.Responses
{
    public interface IResponse
    {
        bool Success { get; set; }
        string Error { get; set; }
    }
}
