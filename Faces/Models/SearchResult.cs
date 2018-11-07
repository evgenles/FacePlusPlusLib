using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class SearchResult
    {
        /// <summary>
        /// face_token in the Faceset.
        /// </summary>
        [JsonProperty("face_token")]
        public string FaceToken { get; set; }

        /// <summary>
        /// Indicates the similarity of two faces, a floating-point number with 3 decimal places between [0,100]. Higher confidence indicates higher possibility that two faces belong to same person.
        /// </summary>
        [JsonProperty("confidence")]
        public float Confidence { get; set; }

        /// <summary>
        /// User-defined id of face. This string will not be returned if not exists.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        
        
    }
}