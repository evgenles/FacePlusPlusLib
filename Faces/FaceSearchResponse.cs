using System.Collections.Generic;
using FacePlusPlusLib.Faces.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FacePlusPlusLib.Faces
{
    public class FaceSearchResponse : BaseResponse
    {
        /// <summary>
        /// Array of search results.
        /// If no face is detected within the image uploaded, this array will not be returned.
        /// </summary>
        [JsonProperty("results")]
        public List<SearchResult> Results { get; set; }

        /// <summary>
        /// A set of thresholds including 3 floating-point numbers with 3 decimal places between [0,100].
        /// </summary>
        [JsonProperty("thresholds")]
        public Thresholds Thresholds { get; set; }

        /// <summary>
        /// Unique id of an image uploaded by image_url, image_file or image_base64.
        /// Note: if none of image_url, image_file or image_base64 is used, this string will not be returned.
        /// </summary>
        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// Array of detected faces within the image uploaded by image_url, image_file or image_base64. The first face in this array will be used for face comparing.
        /// Note: if none of image_url, image_file or image_base64 is used, this array will not be returned. If no face is detected, the array is [].
        /// </summary>
        [JsonProperty("faces")]
        public List<FacesCompareResult> Faces { get; set; }
    }
}