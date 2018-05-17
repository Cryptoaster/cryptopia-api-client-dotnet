using System;
using System.Collections.Generic;
using System.Text;

namespace Cryptoaster.ExchangeApi.Cryptopia.Responses
{
    public abstract class BaseResponse<T> : IResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public T Data { get; set; }
    }
}
