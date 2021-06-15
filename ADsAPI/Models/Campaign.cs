using System.Text.Json.Serialization;

namespace ADsAPI.Models
{
    public class Campaign
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("advertiserId")]
        public int AdvertiserId { get; set; }
    }
}
