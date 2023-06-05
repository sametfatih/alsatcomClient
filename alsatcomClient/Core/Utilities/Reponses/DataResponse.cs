using System.Text.Json.Serialization;

namespace alsatcomClient.Core.Utilities.Reponses
{
    public class DataResponse<T>
    {
        [JsonPropertyName("data")]
        public T Data { get; set; }
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
