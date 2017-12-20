using System.Collections.Generic;

namespace TibiaCharInfo.Models
{
    public class Highscores
    {
        public string World { get; set; }
        public ICollection<HighscoreData> Data { get; set; }
    }
}
