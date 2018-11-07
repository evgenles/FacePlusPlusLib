using System;
using System.Collections.Generic;
using System.IO;
using FacePlusPlusLib.Enums;

namespace FacePlusPlusLib.Faces.Face
{
    public class FaceAnalyzeRequest : IRequest
    {
        /// <summary>
        /// One or more face_token The number of face_token must not be larger than 5.
        /// </summary>
        public List<string> FaceTokens { get; set; } = null;

        /// <summary>
        /// Whether or not detect and return key points of facial features and contour
        /// </summary>
        public LandMarkEnum ReturnLandmark { get; set; } = LandMarkEnum.NotDetect;

        /// <summary>
        /// Whether or not detect and return face attributes
        /// Please use | to select a lot of attributes
        /// </summary>
        public FaceReturnAttributesEnum ReturnAttributes { get; set; } = FaceReturnAttributesEnum.None;

        public (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            Validate();
            return (new Dictionary<string, string>
            {
                ["face_tokens"] = string.Join(",", FaceTokens),
                ["return_landmark"] = ((int) ReturnLandmark).ToString(),
                ["return_attributes"] = ReturnAttributes.ToString().ToLower().Replace(" ", "")
            }, new Dictionary<string, Stream>());
        }

        private void Validate()
        {
            if (FaceTokens == null || FaceTokens.Count < 1 || FaceTokens.Count > 5)
                throw new ArgumentException("Length of FaceTokens must from 1 to 5");
        }
    }
}