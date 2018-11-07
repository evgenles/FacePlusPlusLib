using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FacePlusPlusLib.Faces.Models
{
    public class FaceSetModel
    {
        /// <summary>
        /// id of FaceSet
        /// </summary>
        [JsonProperty("faceset_token")]
        public string FaceSetToken { get; set; }

        /// <summary>
        /// custom id of FaceSet. If not defined, this string is []
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
    }
}