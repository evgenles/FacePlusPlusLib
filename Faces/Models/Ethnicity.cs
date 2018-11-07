using FacePlusPlusLib.Enums;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class Ethnicity
    {
        [JsonProperty("value")]
        public EthnicityEnum Value { get; set; }
    }
}