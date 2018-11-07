using Newtonsoft.Json;

namespace FacePlusPlusLib
{
    public class ErrorMessage
    {
        [JsonProperty("time_used")]
        public int TimeUsed { get; set; }

        [JsonProperty("error_message")]
        public string Message { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}