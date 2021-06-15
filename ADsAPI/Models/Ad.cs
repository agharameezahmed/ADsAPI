using System.Text.Json.Serialization;

namespace ADsAPI.Models
{
    public class Ad
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("campaignId")]
        public int CampaignId { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("image")]
        public string ImageUrl { get; set; }
        [JsonPropertyName("sponsoredBy")]
        public string SponsoredBy { get; set; }
        [JsonPropertyName("trackingUrl")]
        public string TrackingUrl { get; set; }

    }
}
