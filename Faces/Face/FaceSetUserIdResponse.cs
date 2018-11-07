using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Face
{
    public class FaceSetUserIdResponse : BaseResponse
    {
        /// <summary>
        /// The id of the face
        /// </summary>
        [JsonProperty("face_token")]
        public string FaceToken { get; set; }
        
        /// <summary>
        /// Custom id of face. If not defined, this string is []
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}