using Newtonsoft.Json;

namespace TibiaCharInfo.Models
{
    public class DateFormat
    {
        public string Date { get; set; }
        [JsonProperty(PropertyName = "timezone_type")]
        public int TimezoneType { get; set; }
        public string Timezone { get; set; }
    }
}
