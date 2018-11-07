using System.Collections.Generic;
using FacePlusPlusLib.Faces.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FacePlusPlusLib.Faces
{
    public class FaceCompareResponse :BaseResponse
    {
        /// <summary>
        /// Indicates the similarity of two faces, a floating-point number with 3 decimal places between [0,100]. Higher confidence indicates higher possibility that two faces belong to same person.
        /// Note: if no face is detected within the image uploaded, this string will not be returned.
        /// </summary>
        [JsonProperty("confidence")]
        public float Confidence { get; set; }

        /// <summary>
        /// A set of thresholds including 3 floating-point numbers with 3 decimal places between [0,100].
        /// If the confidence does not meet the "1e-3" threshold, it is highly suggested that the two faces are not from the same person. While if the confidence is beyond the "1e-5" threshold, there's high possibility that they are from the same person.
        /// Note: seeing that thresholds are not static, there's no need to store values of thresholds in a persistent form, especially not to compare the confidence with a previously returned threshold.
        /// If no face is detected within the image uploaded, this string will not be returned.
        /// </summary>
        [JsonProperty("thresholds")]
        public Thresholds Thresholds { get; set; }

        /// <summary>
        /// Unique id of an image uploaded by image_url1, image_file1 or image_base64_1.
        /// Note: if none of image_url1, image_file1 or image_base64_1 is used, this string will not be returned.
        /// </summary>
        [JsonProperty("image_id1")]
        public string FirstImageId { get; set; }

        /// <summary>
        /// Unique id of an image uploaded by image_url2, image_file2 or image_base64_2.
        /// Note: if none of image_url2, image_file2 or image_base64_2 is used, this string will not be returned.
        /// </summary>
        [JsonProperty("image_id2")]
        public string SecondImageId { get; set; }

        /// <summary>
        /// Array of detected faces within the image uploaded by image_url1, image_file1 or image_base64_1. The first face in this array will be used for face comparing.
        /// Note: if none of image_url1, image_file1 or image_base64_1 is used, this array will not be returned. If no face is detected, the array is [].
        /// </summary>
        [JsonProperty("faces1")]
        public List<FacesCompareResult> FirstFaces  { get; set; }
        
        /// <summary>
        /// Array of detected faces within the image uploaded by image_url2, image_file2 or image_base64_2. The first face in this array will be used for face comparing.
        /// Note: if none of image_url2, image_file2 or image_base64_2 is used, this array will not be returned. If no face is detected, the array is [].
        /// </summary>
        [JsonProperty("faces2")]
        public List<FacesCompareResult> SecondFaces  { get; set; }

    }
}