using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FacePlusPlusLib.Faces.Models
{
    public class FacesCompareResult
    {
        /// <summary>
        /// Unique id of the detected face
        /// </summary>
        [JsonProperty("face_token")]
        public string FaceToken { get; set; }

        /// <summary>
        /// A rectangle area for the face location on image
        /// </summary>
        [JsonProperty("face_rectangle")]
        public FaceRectangle FaceRectangle { get; set; }
    }
}