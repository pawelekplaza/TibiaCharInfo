namespace TibiaCharInfo.Models
{
    public enum Sex { Male, Female }
    public enum Vocation { Knight, Paladin, Druid, Sorcerer, Elite_Knight, Royal_Paladin, Elder_Druid, Master_Sorcerer }
    public enum Status { Offline, Online }
    public enum PageId { Base, Welcome, Character, Highscore }
    public enum HighscoreType { Experience, Magic, Shielding, Distance, Sword, Club, Axe, Fist, Fishing, Achievements, Loyality }

    public static class EnumExtensions
    {
        public static string GetProperString(this Vocation vocation) =>
            vocation.ToString().Replace("_", " ");

        public static string GetQueryString(this Vocation vocation) =>
            vocation.ToString().Replace("_", "+");

        public static string GetProperString(this HighscoreType type)
            => type.ToString().ToLower();
    }
}
