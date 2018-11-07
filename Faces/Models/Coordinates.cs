using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class Coordintates
    {
        [JsonProperty("x")]
        public int X { get; set; }
        
        
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}