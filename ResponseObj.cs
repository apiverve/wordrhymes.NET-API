using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Rhymes data
    /// </summary>
    public class Rhymes
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("pron")]
        public string Pron { get; set; }

        [JsonProperty("word")]
        public string Word { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("rhymeCount")]
        public int RhymeCount { get; set; }

        [JsonProperty("rhymes")]
        public Rhymes[] Rhymes { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
