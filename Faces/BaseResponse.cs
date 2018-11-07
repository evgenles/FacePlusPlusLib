using Newtonsoft.Json;

namespace FacePlusPlusLib.Faces
{
    public abstract class BaseResponse : IResponse
    {
        /// <summary>
        /// Unique id of each request
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
        
        /// <summary>
        /// This string will not be returned unless request fails
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
        
        /// <summary>
        /// Time that the whole request takes. Unit: millisecond
        /// </summary>
        [JsonProperty("time_used")]
        public int TimeUsed { get; set; }
    }
}