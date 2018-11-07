using System;
using System.Collections.Generic;
using System.IO;
using FacePlusPlusLib.Faces.FaceSet;

namespace FacePlusPlusLib.Faces
{
    public class FaceSearchRequest : FaceSetBaseRequest
    {
        /// <summary>
        /// The id of the first face. (Highest precedence)
        /// REQUIRED ONE OF FaceToken, ImageFile, ImageBase64, ImageUrl
        /// </summary>
        public string FaceToken { get; set; }
        
        /// <summary>
        /// URL of the image.
        /// REQUIRED ONE OF FaceToken, ImageFile, ImageBase64, ImageUrl
        /// </summary>
        public string ImageUrl { get; set; } = null;

        /// <summary>
        /// The stream data of the image.
        /// REQUIRED ONE OF FaceToken, ImageFile, ImageBase64, ImageUrl
        /// </summary>
        public Stream ImageFile { get; set; } = null;

        /// <summary>
        /// Base64 encoded binary data of the image.
        /// REQUIRED ONE OF FaceToken, ImageFile, ImageBase64, ImageUrl
        /// </summary>
        public string ImageBase64 { get; set; } = null;

        /// <summary>
        /// The number of returned results that have highest confidence score, between [1,5]. The default value is 1.
        /// </summary>
        public int? ReturnResultCount { get; set; } = null;

        public override (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            var dictionaries = base.ConvertToDictionaries();
            Validate();
            return (new Dictionary<string, string>(dictionaries.Item1)
            {
                ["face_token"] = FaceToken,
                ["image_url"] = ImageUrl,
                ["image_base64"] = ImageBase64,
                ["return_result_count"] = ReturnResultCount?.ToString()
            }, new Dictionary<string, Stream>(dictionaries.Item2)
            {
                ["image_file"] = ImageFile
            });
        }

        private void Validate()
        {
            if (FaceToken == null && ImageBase64 == null && ImageUrl == null && ImageFile == null)
                throw new ArgumentException("Required one file property");
            if(ReturnResultCount < 1 || ReturnResultCount > 5)
                throw new ArgumentException("The number of returned results that have highest confidence score, between [1,5]");
        }
    }
}