using System.Collections.Generic;
using FacePlusPlusLib.Faces.Models;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetGetFaceSetsResponse : BaseResponse
    {
        /// <summary>
        /// Array of FaceSet, including the followings
        /// </summary>
        [JsonProperty("facesets")]
        public List<FaceSetModel> FaceSets { get; set; }

        /// <summary>
        /// This string is used for next request. Its value indicates the sequence number of the faceset_token sorted after all the faceset_token returned in this request.
        /// If this string is returned, then not all faceset_token under this API Key has been returned. The value can be passed to `start` in next request to get the following faceset_token.
        /// If this string is not returned, then all faceset_token under this API Key has been returned.
        /// </summary>
        [JsonProperty("next")]
        public int? Next { get; set; }
        
    }
}