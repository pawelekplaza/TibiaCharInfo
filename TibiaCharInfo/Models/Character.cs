using Newtonsoft.Json;
using System.Collections.Generic;

namespace TibiaCharInfo.Models
{
    public class Character
    {
        public CharacterData Data { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<Death> Deaths { get; set; }
        [JsonProperty(PropertyName = "account_information")]
        public AccountInformation AccountInformation { get; set; }
        [JsonProperty(PropertyName = "other_characters")]
        public ICollection<OtherCharacter> OtherCharacters { get; set; }
        public Status Status { get; set; }
    }
}
