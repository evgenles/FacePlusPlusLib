using System.Collections.Generic;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Face
{
    public class FaceAnalyzeResponse : BaseResponse
    {
        // <summary>
        /// Array of detected faces
        /// Note: if no face is detected, the array is []
        /// </summary>
        [JsonProperty("faces")]
        public List<Faces> Faces { get; set; }
    }
}