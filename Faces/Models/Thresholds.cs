using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FacePlusPlusLib.Faces.Models
{
    public class Thresholds
    {
        /// <summary>
        /// confidence threshold at the 0.1% error rate;
        /// </summary>
        [JsonProperty("1e-3")]
        public float ThirdLevel { get; set; }

        /// <summary>
        /// confidence threshold at the 0.01% error rate;
        /// </summary>
        [JsonProperty("1e-4")]
        public float FourthLevel { get; set; }

        /// <summary>
        /// confidence threshold at the 0.001% error rate;
        /// </summary>
        [JsonProperty("1e-5")]
        public float FifthLevel { get; set; }
    }
}