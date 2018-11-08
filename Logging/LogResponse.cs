using System.Runtime.CompilerServices;

namespace FacePlusPlusLib.Logging
{
    public class LogResponse<TRequest, TResponse> : BaseLog 
        where TRequest : IRequest
        where TResponse: IResponse
    {
        public LogResponse([CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int lineNumber = 0) : base(methodName, sourceFilePath, lineNumber)
        {
        }

        public TRequest Request { get; set; }
        public int StatusCode { get; set; }
        public string ResponseContent { get; set; }
        public TResponse Response { get; set; }
    }
}