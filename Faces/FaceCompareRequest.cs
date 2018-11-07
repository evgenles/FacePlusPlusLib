using System;
using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib.Faces
{
    public class FaceCompareRequest : IRequest
    {
        /// <summary>
        /// The id of the first face. (Highest precedence)
        /// REQUIRED ONE OF FaceTokenFirst, ImageFileFirst, ImageBase64First, ImageUrlFirst
        /// </summary>
        public string FaceTokenFirst { get; set; }
        
        /// <summary>
        /// URL of the image.
        /// REQUIRED ONE OF FaceTokenFirst, ImageFileFirst, ImageBase64First, ImageUrlFirst
        /// </summary>
        public string ImageUrlFirst { get; set; } = null;

        /// <summary>
        /// The stream data of the image.
        /// REQUIRED ONE OF FaceTokenFirst, ImageFileFirst, ImageBase64First, ImageUrlFirst
        /// </summary>
        public Stream ImageFileFirst { get; set; } = null;

        /// <summary>
        /// Base64 encoded binary data of the image.
        /// REQUIRED ONE OF FaceTokenFirst, ImageFileFirst, ImageBase64First, ImageUrlFirst
        /// </summary>
        public string ImageBase64First { get; set; } = null;
        
        /// <summary>
        /// The id of the second face. (Highest precedence)
        /// REQUIRED ONE OF FaceTokenSecond, ImageFileSecond, ImageBase64Second, ImageUrlSecond
        /// </summary>
        public string FaceTokenSecond { get; set; }
        
        /// <summary>
        /// URL of the image.
        /// REQUIRED ONE OF FaceTokenSecond, ImageFileSecond, ImageBase64Second, ImageUrlSecond
        /// </summary>
        public string ImageUrlSecond { get; set; } = null;

        /// <summary>
        /// The stream data of the image.
        /// REQUIRED ONE OF FaceTokenSecond, ImageFileSecond, ImageBase64Second, ImageUrlSecond
        /// </summary>
        public Stream ImageFileSecond { get; set; } = null;

        /// <summary>
        /// Base64 encoded binary data of the image.
        /// REQUIRED ONE OF FaceTokenSecond, ImageFileSecond, ImageBase64Second, ImageUrlSecond
        /// </summary>
        public string ImageBase64Second { get; set; } = null;

        public (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            Validate();
            return (new Dictionary<string, string>
            {
                ["face_token1"] = FaceTokenFirst,
                ["image_url1"] = ImageUrlFirst,
                ["image_base64_1"] = ImageBase64First,
                ["face_token2"] = FaceTokenSecond,
                ["image_url2"] = ImageUrlSecond,
                ["image_base64_2"] = ImageBase64Second
            }, new Dictionary<string, Stream>()
            {
                ["image_file1"] = ImageFileFirst,
                ["image_file2"] = ImageFileSecond
            });
        }


        private void Validate()
        {
            if (FaceTokenFirst == null &&  ImageBase64First == null && ImageUrlFirst == null && ImageFileFirst == null)
                throw new ArgumentException("Required one first file property");
            if (FaceTokenSecond == null &&  ImageBase64Second == null && ImageUrlSecond == null && ImageFileSecond == null)
                throw new ArgumentException("Required one second file property");
        }
    }
}