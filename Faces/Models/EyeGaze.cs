using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class EyeGaze
    {
        /// <summary>
        /// eye center location and eye gaze direction of left eye
        /// </summary>
        [JsonProperty("left_eye_gaze")]
        public EyeGazeDef LeftEyeGaze { get; set; }
        
        /// <summary>
        /// eye center location and eye gaze direction of right eye
        /// </summary>
        [JsonProperty("right_eye_gaze")]
        public EyeGazeDef RightEyeGaze { get; set; }
    }
}