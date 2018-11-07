using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class FaceSetFailureDetail
    {
        [JsonProperty("reason")]
        public string Reason { get; set; }
        
        [JsonProperty("face_token")]
        public string FaceToken { get; set; }
    }
}