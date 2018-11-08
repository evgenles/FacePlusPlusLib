using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace FacePlusPlusLib.Logging
{
    public class LogRequest<T> : BaseLog where T:IRequest
    {
        public LogRequest([CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int lineNumber = 0) : base(methodName, sourceFilePath, lineNumber)
        {
        }

        public string RequestUrl { get; set; }
        
        public T Request { get; set; }

        public Dictionary<string,string> StringsInRequest { get; set; }
        
        public Dictionary<string,Stream> StreamsInRequest { get; set; }

        public HttpContent ContentForRequest { get; set; }
    }
}