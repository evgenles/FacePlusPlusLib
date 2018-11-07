using System;
using System.Collections.Generic;
using System.IO;
using FacePlusPlusLib.Enums;
using FacePlusPlusLib.Faces.Models;

namespace FacePlusPlusLib.Faces
{
    public class FaceDetectRequest : IRequest
    {
        /// <summary>
        /// URL of the image.
        /// Note: getting images from URLs may take a long time due to internet connection problems, so it is recommended that you upload images directly by using ImageFile.
        /// REQUIRED ONE OF ImageFile, ImageBase64, ImageUrl
        /// </summary>
        public string ImageUrl { get; set; } = null;

        /// <summary>
        /// The stream data of the image.
        /// REQUIRED ONE OF ImageFile, ImageBase64, ImageUrl
        /// </summary>
        public Stream ImageFile { get; set; } = null;

        /// <summary>
        /// Base64 encoded binary data of the image.
        /// REQUIRED ONE OF ImageFile, ImageBase64, ImageUrl
        /// </summary>
        public string ImageBase64 { get; set; } = null;

        /// <summary>
        /// Whether or not detect and return key points of facial features and contour
        /// </summary>
        public LandMarkEnum ReturnLandmark { get; set; } = LandMarkEnum.NotDetect;

        /// <summary>
        /// Whether or not detect and return face attributes
        /// Please use | to select a lot of attributes
        /// </summary>
        public FaceReturnAttributesEnum ReturnAttributes { get; set; } = FaceReturnAttributesEnum.None;

        /// <summary>
        /// REQUIRED STANDARD API KEY
        /// Whether or not analyze and return attributes and landmarks of all the detected faces. If not used, only the 5 largest faces by its bounding box size will be analyzed
        /// </summary>
        public bool? CalculateAll { get; set; } = null;

        /// <summary>
        /// REQUIRED STANDARD API KEY
        /// Whether or not specify a rectangle to perform face detection.
        /// If not used, this API will detect within the entire image.
        /// If valid values are passed in this parameter with a Standard API Key, this feature will be used. You will need to pass a string to indicate the face rectangle, according to which this API will perform face detection and analysis within the specified area. The face rectangle will be the same as you passed. For areas out of the rectangle you passed, this API will not perform face detection, nor will return other face information.
        /// </summary>
        public FaceRectangle FaceRectangle { get; set; } = null;

        public (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            Validate();
            return (new Dictionary<string, string>
            {
                ["image_url"] = ImageUrl,
                ["image_base64"] = ImageBase64,
                ["return_landmark"] = ((int) ReturnLandmark).ToString(),
                ["return_attributes"] = ReturnAttributes.ToString().ToLower().Replace(" ", ""),
                ["calculate_all"] = CalculateAll.HasValue ? (CalculateAll.Value ? "1" : "0") : null,
                ["face_rectangle"] = FaceRectangle?.ToString()
            }, new Dictionary<string, Stream>
            {
                ["image_file"] = ImageFile
            });
        }

        private void Validate()
        {
            if (ImageBase64 == null && ImageUrl == null && ImageFile == null)
                throw new ArgumentException("Required one file property");
        }
    }
}