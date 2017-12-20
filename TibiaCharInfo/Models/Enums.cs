namespace TibiaCharInfo.Models
{
    public enum Sex { Male, Female }
    public enum Vocation { Knight, Paladin, Druid, Sorcerer, Elite_Knight, Royal_Paladin, Elder_Druid, Master_Sorcerer }

    public static class EnumExtensions
    {
        public static string GetProperString(this Vocation vocation)
            => vocation.ToString().Replace("_", " ");
    }
}
