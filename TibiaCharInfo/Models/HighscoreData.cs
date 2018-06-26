using Newtonsoft.Json;
using TibiaCharInfo.JsonConverters;

namespace TibiaCharInfo.Models
{
    public class HighscoreData
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        [JsonProperty(PropertyName = "voc")]
        [JsonConverter(typeof(SpaceToUnderscoreConverter))]
        public Vocation Vocation { get; set; }
        public long Points { get; set; }
        public int Level { get; set; }
    }
}
