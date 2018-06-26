using System.Collections.Generic;
using TibiaCharInfo.Models;

namespace TibiaCharInfo.Responses
{
    public class CharacterResponse
    {
        public Character Characters { get; set; }
        public Information Information { get; set; }
    }
}
