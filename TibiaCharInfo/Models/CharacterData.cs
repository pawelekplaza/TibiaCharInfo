using Newtonsoft.Json;
using System.Collections.Generic;

namespace TibiaCharInfo.Models
{
    public class CharacterData
    {
        public string Name { get; set; }
        public Sex Sex { get; set; }
        public Vocation Vocation { get; set; }
        public int Level { get; set; }
        [JsonProperty(PropertyName = "achievement_points")]
        public int AchievementPoints { get; set; }
        public string World { get; set; }
        public string Residence { get; set; }
        [JsonProperty(PropertyName = "married_to")]
        public Character MarriedTo { get; set; }
        [JsonProperty(PropertyName = "last_login")]
        public ICollection<DateFormat> LastLogins { get; set; }
        [JsonProperty(PropertyName = "account_status")]
        public string AccountStatus { get; set; }
        public Status Status { get; set; }
    }
}
