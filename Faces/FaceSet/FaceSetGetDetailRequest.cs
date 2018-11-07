using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetGetDetailRequest : FaceSetBaseRequest
    {
        /// <summary>
        /// An integer between  [1,10000], indicating the sequence number of the face_token in this FaceSet. All the face_token returned in this request will start from this face_token. face_token is sorted by its creation time. Each request returns 100 face_token at the most.
        /// Default value: 1.
        /// You can pass the value of `next `parameter in last request, to get the next 100 face_token.
        /// </summary>
        public int? Start { get; set; } = null;
        
        public override (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            var dictionaries = base.ConvertToDictionaries();
            return (new Dictionary<string, string>(dictionaries.Item1)
            {
                ["start"] = Start?.ToString()
            }, dictionaries.Item2);
        }
    }
}