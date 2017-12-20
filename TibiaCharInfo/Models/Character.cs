using System.Collections.Generic;

namespace TibiaCharInfo.Models
{
    public class Character
    {
        public CharacterData Data { get; set; }
        public IEnumerable<Achievement> Achievements { get; set; }
        public IEnumerable<Death> Deaths { get; set; }
        public IEnumerable<AccountInformation> AccountInformation { get; set; }
        public IEnumerable<Character> OtherCharacters { get; set; }
    }
}
