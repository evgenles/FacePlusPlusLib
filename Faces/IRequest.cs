using System.Collections.Generic;
using System.IO;

namespace FacePlusPlusLib.Faces
{
    public interface IRequest
    {
        (Dictionary<string, string>, Dictionary<string, Stream>) ConvertToDictionaries();
    }
}