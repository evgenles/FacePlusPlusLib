using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class EyeStatus
    {
        /// <summary>
        /// the confidence that the eye is blocked
        /// </summary>
        [JsonProperty("occlusion")]
        public float Occlusion { get; set; }

        /// <summary>
        /// the confidence that not wear glass and the eye is open
        /// </summary>
        [JsonProperty("no_glass_eye_open")]
        public float NoGlassEyeOpen { get; set; }

        /// <summary>
        /// the confidence that wear ordinary glass and the eye is closed
        /// </summary>
        [JsonProperty("normal_glass_eye_close")]
        public float NormalGlassEyeClose { get; set; }

        /// <summary>
        /// the confidence that wear ordinary glass and the eye is open
        /// </summary>
        [JsonProperty("normal_glass_eye_open")]
        public float NormalGlassEyeOpen { get; set; }

        /// <summary>
        /// the confidence that wear dark glass
        /// </summary>
        [JsonProperty("dark_glasses")]
        public float DarkGlasses { get; set; }

        /// <summary>
        /// the confidence that not wear glass and the eye is closed
        /// </summary>
        [JsonProperty("no_glass_eye_close")]
        public float NoGlassEyeClose { get; set; }
    }
}