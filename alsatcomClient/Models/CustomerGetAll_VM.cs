using System.Text.Json.Serialization;

namespace alsatcomClient.Models
{
    public class CustomerGetAll_VM
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
