using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace alsatcomClient.Areas.Admin.Models
{
    public class DealerListModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("adress")]
        public string Adress { get; set; }
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
        [JsonPropertyName("rating")]
        public int Rating { get; set; }
        [JsonPropertyName("status")]
        public bool Status { get; set; }
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }
        [JsonPropertyName("updatedDate")]
        public DateTime UpdatedDate { get; set; }
    }
}
