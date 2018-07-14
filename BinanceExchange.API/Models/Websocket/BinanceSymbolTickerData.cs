using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using BinanceExchange.API.Converter;
using BinanceExchange.API.Models.Response;
using BinanceExchange.API.Models.WebSocket.Interfaces;
using Newtonsoft.Json;
using BinanceExchange.API.Models.WebSocket;

namespace BinanceExchange.API.Models.WebSocket
{
    [DataContract]
    public class BinanceSymbolTickerData : BinanceWebSocketResponse
    {
        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "s")]
        public string Symbol { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "p")]
        public decimal PriceChange { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "P")]
        public decimal PriceChangePercent { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "w")]
        public decimal WeightedAveragePrice { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "x")]
        public decimal PreviousClosePrice{ get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "c")]
        public decimal CurrentClosePrice { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "Q")]
        public decimal CloseTradeQuantity { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "b")]
        public decimal BestBidPrice { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "B")]
        public decimal BestBidQuantity { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "a")]
        public decimal BestAskPrice { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "A")]
        public decimal BestAskQuantity { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "o")]
        public decimal OpenPrice { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "h")]
        public decimal HighPrice { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "l")]
        public decimal LowPrice { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "v")]
        public decimal TotalTradedBaseAssetVolume { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "q")]
        public decimal TotalTradedQuoteAssetVolume { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "O")]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime OpenTime { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "C")]
        [JsonConverter(typeof(EpochTimeConverter))]
        public DateTime CloseTime { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "F")]
        public long FirstTradeId { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "L")]
        public long LastTradeId { get; set; }

        [DataMember(Order = 3)]
        [JsonProperty(PropertyName = "n")]
        public long TotalTrades { get; set; }
    }
}
