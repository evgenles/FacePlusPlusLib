using FacePlusPlusLib.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FacePlusPlusLib.Faces.Models
{
    public class Gender
    {
        [JsonProperty("value"), JsonConverter(typeof(StringEnumConverter))]
        public GenderEnum Value { get; set; }
    }
}