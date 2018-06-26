using Newtonsoft.Json;
using System;

namespace TibiaCharInfo.Responses
{
    public class Information
    {
        [JsonProperty(PropertyName = "api_version")]
        public double ApiVersion { get; set; }
        [JsonProperty(PropertyName = "execution_time")]
        public double ExecutionTime { get; set; }
        [JsonProperty(PropertyName = "last_updated")]
        public DateTime LastUpdated { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
