using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class rua
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("email")]
    public string email { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

}

public class ruf
{
    [JsonProperty("domain")]
    public string domain { get; set; }

    [JsonProperty("email")]
    public string email { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

}

public class data
{
    [JsonProperty("dmarcHost")]
    public string dmarcHost { get; set; }

    [JsonProperty("dmarc_record")]
    public string dmarcrecord { get; set; }

    [JsonProperty("hasDmarc")]
    public bool hasDmarc { get; set; }

    [JsonProperty("host")]
    public string host { get; set; }

    [JsonProperty("p")]
    public string p { get; set; }

    [JsonProperty("rua")]
    public rua rua { get; set; }

    [JsonProperty("ruf")]
    public ruf ruf { get; set; }

    [JsonProperty("v")]
    public string v { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

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
