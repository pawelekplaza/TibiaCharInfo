namespace TibiaCharInfo.Models
{
    public class CharacterData
    {
        public string Name { get; set; }
        public Sex Sex { get; set; }
        public Vocation Vocation { get; set; }
        public int Level { get; set; }
        public int AchievementPoints { get; set; }
        public string World { get; set; }
        public string Residence { get; set; }
        public Character MarriedTo { get; set; }
    }
}
