using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class Age
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}