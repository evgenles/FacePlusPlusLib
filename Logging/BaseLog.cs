using System.Runtime.CompilerServices;

namespace FacePlusPlusLib.Logging
{
    public abstract class BaseLog
    {
        public string CallerMethod { get; protected set; }
        public string SourceFilePath { get; protected set; }
        public int SourceLineNumber { get; protected set; }

        public string Exception { get; set; } = null;

        public double Duration { get; set; }

        public string AdditionalInfo { get; set; } = null;

        protected BaseLog([CallerMemberName] string methodName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            CallerMethod = methodName;
            SourceFilePath = sourceFilePath;
            SourceLineNumber = lineNumber;
        }
    }
}