using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class MouthStatus
    {
        /// <summary>
        /// the confidence that the mouth is blocked by surgical mask or respirator
        /// </summary>
        [JsonProperty("surgical_mask_or_respirator")]
        public float SurgicalMaskOrRespirator { get; set; }

        /// <summary>
        /// the confidence that the mouth is blocked by other object
        /// </summary>
        [JsonProperty("other_occlusion")]
        public float OtherOcclusion { get; set; }

        /// <summary>
        /// the confidence that the mouth is closed, not blocked
        /// </summary>
        [JsonProperty("close")]
        public float Close { get; set; }

        /// <summary>
        /// the confidence that the mouth is open, not blocked
        /// </summary>
        [JsonProperty("open")]
        public float Open { get; set; }
    }
}