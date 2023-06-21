using System.Text.Json.Serialization;

namespace alsatcomClient.Areas.Seller.Models
{
    public class ProductListModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("brandName")]
        public string BrandName { get; set; }
        [JsonPropertyName("stock")]
        public int Stock { get; set; }
        [JsonPropertyName("price")]
        public float Price { get; set; }
        [JsonPropertyName("status")]
        public bool Status { get; set; }
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }
        [JsonPropertyName("updatedDate")]
        public DateTime UpdatedDate { get; set; }
        [JsonPropertyName("discountedPrice")]
        public float DiscountedPrice { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
