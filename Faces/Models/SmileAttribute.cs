using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class ValueWithThresholdAttribute
    {
        /// <summary>
        /// a floating-point number with 3 decimal places between [0,100]
        /// </summary>
        [JsonProperty("value")]
        public float Value { get; set; }

        /// <summary>
        /// a smiling face can be confirmed if this number goes beyond the threshold value.
        /// </summary>
        [JsonProperty("threshold")]
        public double Threshold { get; set; }
    }
}