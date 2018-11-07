using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetUpdateResponse : BaseResponse
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
    }
}