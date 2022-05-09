using System.Text.Json.Serialization;

namespace first_api.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
         Knight,

         Mage,

         Cleric   
    }
}