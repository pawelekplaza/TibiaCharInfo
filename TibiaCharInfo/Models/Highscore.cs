using System.Collections.Generic;

namespace TibiaCharInfo.Models
{
    public class Highscore
    {
        public string World { get; set; }
        public HighscoreType Type { get; set; }
        public ICollection<HighscoreData> Data { get; set; }
    }
}
