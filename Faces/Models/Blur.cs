using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class Blur
    {
        [JsonProperty("value")]
        public float Value { get; set; }
    }
}