using System.Text.Json.Serialization;

namespace alsatcomClient.Core.Utilities.Reponses
{
    public class Response
    {
        [JsonPropertyName("success")]
        public bool Success { get; }
        [JsonPropertyName("message")]
        public string Message { get; }
    }
}
