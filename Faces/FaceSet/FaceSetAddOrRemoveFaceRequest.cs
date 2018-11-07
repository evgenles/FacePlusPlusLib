using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetAddOrRemoveFaceRequest : FaceSetBaseRequest
    {
        /// <summary>
        /// One or more face_token. The number of face_token count must be  from 1 to 5.
        /// </summary>
        [JsonProperty("face_tokens")]
        public List<string> FaceTokens { get; set; } = null;

        public override (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            var dictionaries = base.ConvertToDictionaries();
            Validate();
            return (new Dictionary<string, string>(dictionaries.Item1)
            {
                ["face_tokens"] = string.Join(",", FaceTokens).ToLower()
            }, dictionaries.Item2);
        }

        private void Validate()
        {
           if (FaceTokens.Count < 1 || FaceTokens.Count > 5)
                throw new ArgumentException("Required from one to five face tokens");
        }
    }
}