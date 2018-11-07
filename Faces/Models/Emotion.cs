using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class Emotion
    {
        [JsonProperty("anger")]
        public float Anger { get; set; }

        [JsonProperty("disgust")]
        public float Disgust { get; set; }

        [JsonProperty("fear")]
        public float Fear { get; set; }

        [JsonProperty("happiness")]
        public float Happiness { get; set; }

        [JsonProperty("neutral")]
        public float Neutral { get; set; }

        [JsonProperty("sadness")]
        public float Sadness { get; set; }

        [JsonProperty("surprise")]
        public float Surprise { get; set; }
    }
}