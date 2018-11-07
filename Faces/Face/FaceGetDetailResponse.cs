using System.Collections.Generic;
using FacePlusPlusLib.Faces.Models;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Face
{
    public class FaceGetDetailResponse : BaseResponse
    {
        /// <summary>
        /// Unique id of image that the face_token belongs to
        /// </summary>
        [JsonProperty("image_id")]
        public string ImageId { get; set; }

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
        
        /// <summary>
        /// A rectangle area for the face location on image. 
        /// </summary>
        [JsonProperty("face_rectangle")]
        public FaceRectangle FaceRectangle { get; set; }
        
        /// <summary>
        /// Array of FaceSet that contain this face_token.
        /// </summary>
        [JsonProperty("facesets")]
        public List<FaceSetModel> FaceSets { get; set; }
    }
}