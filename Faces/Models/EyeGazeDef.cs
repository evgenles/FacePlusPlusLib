using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class EyeGazeDef
    {
        /// <summary>
        ///  the x coordinate of eye center
        /// </summary>
        [JsonProperty("position_x_coordinate")]
        public float PositionX { get; set; }
        
        /// <summary>
        /// the y coordinate of eye center
        /// </summary>
        [JsonProperty("position_y_coordinate")]
        public float PositionY { get; set; }

        /// <summary>
        /// the x component of eye gaze direction vector
        /// </summary>
        [JsonProperty("vector_x_component")]
        public float VectorX { get; set; }
        
        /// <summary>
        /// the y component of eye gaze direction vector
        /// </summary>
        [JsonProperty("vector_y_component")]
        public float VectorY { get; set; }
        
        /// <summary>
        /// the z component of eye gaze direction vector
        /// </summary>
        [JsonProperty("vector_z_component")]
        public float VectorZ { get; set; }

    }
}