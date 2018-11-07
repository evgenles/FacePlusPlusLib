using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class SkinStatus
    {
        [JsonProperty("health")]
        public float Health { get; set; }

        [JsonProperty("stain")]
        public float Stain { get; set; }

        [JsonProperty("acne")]
        public float Acne { get; set; }

        [JsonProperty("dark_circle")]
        public float DarkCircle { get; set; }
    }
}