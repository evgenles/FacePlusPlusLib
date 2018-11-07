using System.Collections.Generic;
using FacePlusPlusLib.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FacePlusPlusLib.Faces
{
    public class FaceDetectResponse : BaseResponse
    {
        /// <summary>
        /// Array of detected faces
        /// Note: if no face is detected, the array is []
        /// </summary>
        [JsonProperty("faces")]
        public List<Faces> Faces { get; set; }

        /// <summary>
        /// Unique id of an image
        /// </summary>
        [JsonProperty("image_id")]
        public string ImageId { get; set; }
    }
}