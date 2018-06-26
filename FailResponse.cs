﻿
using Newtonsoft.Json;

namespace CloudCoinCsharpSDK
{
    class FailResponse : IBankResponse
    {
        [JsonProperty("bank_server")]
        public string bank_server { get ; set ; }

        [JsonProperty("time")]
        public string time { get ; set ; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("account")]
        public string account { get; set; }

        [JsonProperty("receipt")]
        public string receipt { get; set; }

        public FailResponse()
        {

        }
    }
}
