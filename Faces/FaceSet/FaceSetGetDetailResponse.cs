using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetGetDetailResponse : BaseResponse
    {
        /// <summary>
        /// The id of FaceSet
        /// </summary>
        [JsonProperty("faceset_token")]
        public string FaceSetToken { get; set; }
        
        /// <summary>
        /// Custom id of FaceSet. If not defined, this string is []
        /// </summary>
        [JsonProperty("outer_id")] 
        public string OuterId { get; set; }

        /// <summary>
        /// Name of FaceSet. If not defined, this string is []
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// custom tags. If not defined, this string is []
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Custom user information.
        /// </summary>
        [JsonProperty("user_data")]
        public string UserData { get; set; }
        
        /// <summary>
        /// The total number of face_token in FaceSet after this operation
        /// </summary>
        [JsonProperty("face_count")]
        public int FaceCount { get; set; }

        /// <summary>
        /// Array of face_token
        /// Note: if this FaceSet does not hold any face_token, an empty array will be returned.
        /// </summary>
        [JsonProperty("face_tokens")]
        public List<string> FaceTokens { get; set; }

        /// <summary>
        /// This string is used for next request. Its value indicates the sequence number of the face_token sorted after all the face_token returned in this request.
        /// If this string is returned, then not all face_token within this FaceSet has been returned. The value can be passed to `start` in next request to get the following face_token.
        /// If this string is not returned, then all face_token within this FaceSet has been returned.
        /// </summary>
        [JsonProperty("next")]
        public int? Next { get; set; }
    }
}