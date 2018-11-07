using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class EyeStatuses
    {
        [JsonProperty("left_eye_status")]
        public EyeStatus LeftEyeStatus { get; set; }
        
        [JsonProperty("right_eye_status")]
        public EyeStatus RightEyeStatus { get; set; }
    }
}