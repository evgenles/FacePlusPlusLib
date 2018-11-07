using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace FacePlusPlusLib.Helpers
{
    public class MultipartContentHelper
    {
        public static MultipartFormDataContent CreateMultipart(Dictionary<string, string> stringDictionary,
            Dictionary<string, Stream> streamDictionary)
        {
            var content = new MultipartFormDataContent();
            foreach (var param in stringDictionary)
            {
                if(param.Value != null) content.Add(new StringContent(param.Value), param.Key);
            }

            foreach (var param in streamDictionary)
            {
                if(param.Value != null)  content.Add(new StreamContent(param.Value), param.Key);
            }

            return content;
        }
    }
}