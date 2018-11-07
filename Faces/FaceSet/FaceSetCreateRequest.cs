using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetCreateRequest : IRequest
    {
        /// <summary>
        /// The name of FaceSet. No more than 256 characters, and must not contain characters ^@,&=*'"
        /// </summary>
        public string DisplayName { get; set; } = null;

        /// <summary>
        /// Custom unique id of FaceSet under your account, used for managing FaceSet objects. No more than 255 characters, and must not contain characters ^@,&=*'"
        /// </summary>
        public string OuterId { get; set; } = null;

        /// <summary>
        /// String consists of FaceSet custom tags, used for categorizing FaceSet. No more than 255 characters, and must not contain characters ^@,&=*'"
        /// </summary>
        public List<string> Tags { get; set; } = null;

        /// <summary>
        /// One or more face_token. The number of face_token must not be larger than 5.
        /// </summary>
        public List<string> FaceTokens { get; set; } = null;

        /// <summary>
        /// Custom user information. No larger than 16KB, and must not contain characters ^@,&=*'"
        /// </summary>
        public string UserData { get; set; } = null;

        /// <summary>
        /// Determine whether or not add face_token into existing FaceSet, if outer_id is passed and outer_id already exists.
        /// false: face_tokens will not be added into existing FaceSet, and return FACESET_EXIST error message instead.
        /// true: add face_tokens into existing FaceSet.
        /// </summary>
        public bool? ForceMerge { get; set; } = null;


        public (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            var tagStr = string.Join(",", Tags).ToLower();
            Validate(tagStr);
            return (new Dictionary<string, string>
            {
                ["display_name"] = DisplayName,
                ["outer_id"] = OuterId,
                ["tags"] = tagStr,
                ["face_tokens"] = string.Join(",", FaceTokens).ToLower(),
                ["user_data"] = UserData,
                ["force_merge"] = (ForceMerge.HasValue ? (ForceMerge.Value ? "1" : "0") : null)
            }, new Dictionary<string, Stream>());
        }

        private void Validate(string tagStr)
        {
            if (DisplayName?.Length > 256 || DisplayName?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(DisplayName)} must be less than 256 characters, and must not contain characters ^@,&=*'\"");


            if (OuterId?.Length > 255 || OuterId?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(OuterId)} must be less than 255 characters, and must not contain characters ^@,&=*'\"");


            if (tagStr?.Length > 255 || tagStr?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(Tags)} must be less than 255 characters, and must not contain characters ^@,&=*'\"");

            if (FaceTokens?.Count > 5)
                throw new ArgumentException($"Property {nameof(FaceTokens)} must contain less then 5 string");

            if (UserData.Length * sizeof(char) > 16 * 1024 || UserData.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    $"Property {nameof(DisplayName)} must be less than 16KB, and must not contain characters ^@,&=*'\"");
        }
    }
}