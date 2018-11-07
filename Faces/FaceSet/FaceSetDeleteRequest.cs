using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.FaceSet
{
    public class FaceSetDeleteRequest : FaceSetBaseRequest
    {
        /// <summary>
        /// Check if the FaceSet contains face_token when deleting.
        /// false:  do not check
        /// true: check
        /// default: true
        /// If the value is 1, when the FaceSet contains face_token, it cannot be deleted.
        /// </summary>
        public bool? CheckEmpty { get; set; } = null;

        public override (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries()
        {
            var dictionaries = base.ConvertToDictionaries();
            return (new Dictionary<string, string>(dictionaries.Item1)
            {
                ["check_empty"] = CheckEmpty.HasValue ? (CheckEmpty.Value ? "1" : "0") : null
            }, dictionaries.Item2);
        }
    }
}