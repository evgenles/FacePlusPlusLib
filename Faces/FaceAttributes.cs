using FacePlusPlusLib.Enums;
using FacePlusPlusLib.Faces.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FacePlusPlusLib.Faces
{
    public class FaceAttributes
    {
        /// <summary>
        /// Result of gender analysis
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }
        
        /// <summary>
        /// Result of age analysis
        /// </summary>
        [JsonProperty("age")] 
        public Age Age { get; set; }

        /// <summary>
        /// Smile intensity
        /// </summary>
        [JsonProperty("smile")]
        public ValueWithThresholdAttribute Smile { get; set; }
        
        /// <summary>
        /// 3D head pose analysis results, including the following objects. The value of each object is a floating-point number with 6 decimal places between [-180,180]
        /// </summary>
        [JsonProperty("headpose")] 
        public Position3D HeadPosition { get; set; }

        /// <summary>
        /// Face blur condition
        /// </summary>
        [JsonProperty("blur")]
        public BlurAttribute Blur { get; set; }
        
        /// <summary>
        /// Status of eyes
        /// </summary>
        [JsonProperty("eyestatus")]
        public EyeStatuses EyeStatus { get; set; }

        /// <summary>
        /// Emotion expressed, including the following fields. The value of each field is a floating-point number with 3 decimal places between [0,100]. Bigger value of a field indicates greater confidence of the emotion which the field represents. The sum of all values is 100.
        /// </summary>
        [JsonProperty("emotion")]
        public Emotion Emotion { get; set; }

        /// <summary>
        /// How suitable the image quality of face is for face comparing
        /// </summary>
        [JsonProperty("facequality")]
        public ValueWithThresholdAttribute FaceQuality { get; set; }

        /// <summary>
        /// Result of ethnicity analysis
        /// </summary>
        [JsonProperty("ethnicity")]
        public Ethnicity Ethnicity { get; set; }

        /// <summary>
        /// Result of beauty analysis, including the following fields. The value of each field is a floating-point number with 3 decimal places between [0,100]. Higher beauty score indicates the detected face is more beautiful.
        /// </summary>
        [JsonProperty("beauty")]
        public Beauty Beauty { get; set; }

        /// <summary>
        /// Status of mouth, including the following fields. The value of each field is a floating-point number with 3 decimal places between [0,100]. The sum of all values is 100.
        /// </summary>
        [JsonProperty("mouthstatus")]
        public MouthStatus MouthStatus { get; set; }

        /// <summary>
        /// Eye center locations and eye gaze directions, including the following objects.
        /// </summary>
        [JsonProperty("eyegaze")]
        public EyeGaze EyeGaze { get; set; }

        /// <summary>
        /// Status of skin, including the following fields. The value of each field is a floating-point number with 3 decimal places between [0,100]. Bigger value of a field indicates greater confidence of the status which the field represents.
        /// </summary>
        [JsonProperty("skinstatus")]
        public SkinStatus SkinStatus { get; set; }
        
    }

   
}