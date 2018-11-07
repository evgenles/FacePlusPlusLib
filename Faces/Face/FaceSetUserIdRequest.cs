using System;
using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib.Faces.Face
{
    public class FaceSetUserIdRequest : IRequest
    {
        /// <summary>
        /// The id of the first face. 
        /// </summary>
        public string FaceToken { get; set; } = null;

        /// <summary>
        /// Custom user_id. No more than 255 characters, and must not contain characters ^@,&=*'"
        /// It is recommended that all the face_token belonging to a same person should be set the same user_id.
        /// </summary>
        public string UserId { get; set; } = null;

        public (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            Validate();
            return (new Dictionary<string, string>()
            {
                ["face_token"] = FaceToken,
                ["user_id"] = UserId
            }, new Dictionary<string, Stream>());
        }

        private void Validate()
        {
            if (FaceToken == null)
                throw new ArgumentException("FaceToken cannot be null");

            if (UserId == null || UserId?.Length > 255 || UserId?.IndexOfAny("^@,&=*'\"".ToCharArray()) > -1)
                throw new ArgumentException(
                    "UserId cannot be null and must be less then 255 characters and not contain ^@,&=*'\"");
        }
    }
}