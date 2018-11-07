using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public abstract class FaceSetBaseRequest : IRequest
    {
        /// <summary>
        /// The id of FaceSet.
        /// REQUIRE ONE OF FaceSetToken or OuterId
        /// </summary>
        [JsonProperty("faceset_token")]
        public string FaceSetToken { get; set; } = null;

        /// <summary>
        /// User-defined id of FaceSet.
        /// REQUIRE ONE OF FaceSetToken or OuterId
        /// </summary>
        [JsonProperty("outer_id")]
        public string OuterId { get; set; } = null;

        public virtual (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            Validate();
            return (new Dictionary<string, string>
            {
                ["faceset_token"] = FaceSetToken,
                ["outer_id"] = OuterId
            }, new Dictionary<string, Stream>());
        }

        private void Validate()
        {
            if (FaceSetToken == null && OuterId == null)
                throw new ArgumentException("Required one FaceSetToken or OuterId");
        }
    }
}