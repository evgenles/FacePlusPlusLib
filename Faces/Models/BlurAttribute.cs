using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class BlurAttribute
    {
        [JsonProperty("blurness")]
        public Blur Blurness { get; set; }

        [JsonProperty("threshold")]
        public double Threshold { get; set; }
    }
}