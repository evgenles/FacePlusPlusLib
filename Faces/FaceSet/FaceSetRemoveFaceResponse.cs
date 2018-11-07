using System.Collections.Generic;
using FacePlusPlusLib.Faces.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetRemoveFaceResponse : BaseResponse
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
        /// The number of face_token removed from FaceSet successfully in this operation.
        /// </summary>
        [JsonProperty("face_removed")]
        public int FaceRemoved { get; set; }

        /// <summary>
        /// The total number of face_token in FaceSet after this operation.
        /// </summary>
        [JsonProperty("face_count")]
        public int FaceCount { get; set; }

        /// <summary>
        /// The face_token failed to remove face_token and the failure reason
        /// reason: the failure reason, including the follows:
        /// INVALID_FACE_TOKEN: face_token not found.
        /// </summary>
        [JsonProperty("failure_detail")]
        public List<FaceSetFailureDetail> FailureDetail { get; set; }
    }
}