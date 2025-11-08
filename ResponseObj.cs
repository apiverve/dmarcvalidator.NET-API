using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Rua data
    /// </summary>
    public class Rua
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

    }
    /// <summary>
    /// Ruf data
    /// </summary>
    public class Ruf
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("dmarcHost")]
        public string DmarcHost { get; set; }

        [JsonProperty("dmarc_record")]
        public string Dmarcrecord { get; set; }

        [JsonProperty("hasDmarc")]
        public bool HasDmarc { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("p")]
        public string P { get; set; }

        [JsonProperty("rua")]
        public Rua Rua { get; set; }

        [JsonProperty("ruf")]
        public Ruf Ruf { get; set; }

        [JsonProperty("v")]
        public string V { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

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
