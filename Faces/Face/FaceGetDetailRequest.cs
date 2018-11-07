using System;
using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib.Faces.Face
{
    public class FaceGetDetailRequest : IRequest
    {
        /// <summary>
        /// The id of the first face. 
        /// </summary>
        public string FaceToken { get; set; } = null;
        
        public (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            Validate();
            return (new Dictionary<string, string>()
            {
                ["face_token"] = FaceToken
            }, new Dictionary<string, Stream>());
        }

        private void Validate()
        {
            if(FaceToken == null)
                throw new ArgumentException("FaceToken cannot be null");
        }
    }
}