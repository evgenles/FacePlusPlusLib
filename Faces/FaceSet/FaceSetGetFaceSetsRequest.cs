using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetGetFaceSetsRequest : IRequest
    {
        /// <summary>
        /// Tags of the FaceSet to be searched
        /// </summary>
        public List<string> Tags { get; set; } = null;

        /// <summary>
        /// An integer, indicating the sequence number of the faceset_token under this API Key. All the faceset_token returned in this request will start from this faceset_token. faceset_token is sorted by its creation time. Each request returns 100 faceset_token at the most.
        /// Default value: 1.
        /// </summary>
        public int? Start { get; set; } = null;

        public (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            return (new Dictionary<string, string>
            {
                ["tags"] = Tags != null ? string.Join(",", Tags)?.ToLower() : null,
                ["start"] = Start?.ToString()
            }, new Dictionary<string, Stream>());
        }
    }
}