using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Windows.Data;

namespace TibiaCharInfo.JsonConverters
{
    public class SpaceToUnderscoreConverter : JsonConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{            
        //    var correctName = value.ToString().Replace(' ', '_');
        //    return Enum.Parse(targetType, correctName);
        //}

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    return value.ToString().Replace('_', ' ');
        //}
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var correctName = existingValue.ToString().Replace(' ', '_');
            return Enum.Parse(objectType, correctName);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var x = "xx";
        }
    }
}
