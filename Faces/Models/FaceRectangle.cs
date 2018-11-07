
using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class FaceRectangle
    {
        /// <summary>
        /// X-coordinate of upper left corner
        /// </summary>
        [JsonProperty("top")]
        public int X { get; set; }
        
        /// <summary>
        /// Y-coordinate of upper left corner
        /// </summary>
        [JsonProperty("left")]
        public int Y { get; set; }

        /// <summary>
        /// Width of the rectangle frame
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        
        /// <summary>
        /// Height of the rectangle frame 
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        public override string ToString()
        {
            return $"{Y},{X},{Width},{Height}";
        }
    }
}