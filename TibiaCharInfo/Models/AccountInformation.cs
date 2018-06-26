using Newtonsoft.Json;

namespace TibiaCharInfo.Models
{
    public class AccountInformation
    {
        [JsonProperty(PropertyName = "loyalty_title")]
        public string LoyaltyTitle { get; set; }
        public DateFormat Created { get; set; }
    }
}
