using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces.Models
{
    public class Beauty
    {
        /// <summary>
        /// beauty score of the detected face given by male
        /// </summary>
        [JsonProperty("male_score")]
        public float MaleScore { get; set; }
        
        /// <summary>
        /// beauty score of the detected face given by female
        /// </summary>
        [JsonProperty("female_score")]
        public float FemaleScore { get; set; }
    }
}