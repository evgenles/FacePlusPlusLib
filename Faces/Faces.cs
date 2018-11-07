using System.Collections.Generic;
using FacePlusPlusLib.Faces.Models;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces
{
    public class Faces
    {
        /// <summary>
        /// Unique id of the detected face
        /// </summary>
        [JsonProperty("face_token")]
        public string FaceToken { get; set; }

        /// <summary>
        /// A rectangle area for the face location on image. 
        /// </summary>
        [JsonProperty("face_rectangle")]
        public FaceRectangle FaceRectangle { get; set; }

        /// <summary>
        /// Dictionary of face landmarks.
        /// </summary>
        [JsonProperty("landmark")]
        public Dictionary<string, Coordintates> LandMark { get; set; }
        
        /// <summary>
        /// Face attributes, detailed information can be found in the following table.
        /// </summary>
        [JsonProperty("attributes")]
        public FaceAttributes Attributes { get; set; }
    }
}