using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class rhymes
{
    [JsonProperty("score")]
    public int score { get; set; }

    [JsonProperty("pron")]
    public string pron { get; set; }

    [JsonProperty("word")]
    public string word { get; set; }

}

public class data
{
    [JsonProperty("word")]
    public string word { get; set; }

    [JsonProperty("rhymeCount")]
    public int rhymeCount { get; set; }

    [JsonProperty("rhymes")]
    public rhymes[] rhymes { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
