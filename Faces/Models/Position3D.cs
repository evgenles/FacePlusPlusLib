using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class Position3D
    {
        [JsonProperty("pitch_angle")]
        public float PitchAngle { get; set; }

        [JsonProperty("roll_angle")]
        public float RollAngle { get; set; }

        [JsonProperty("yaw_angle")]
        public float YawAngle { get; set; }
    }
}