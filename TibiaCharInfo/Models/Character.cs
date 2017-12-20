using System.Collections.Generic;

namespace TibiaCharInfo.Models
{
    public class Character
    {
        public CharacterData Data { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<Death> Deaths { get; set; }
        public ICollection<AccountInformation> AccountInformation { get; set; }
        public ICollection<Character> OtherCharacters { get; set; }
        public Status Status { get; set; }
    }
}
