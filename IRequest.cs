using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib
{
    public interface IRequest
    {
        (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries();
    }
}