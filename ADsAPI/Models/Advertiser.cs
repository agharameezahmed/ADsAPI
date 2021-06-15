
using System.Text.Json.Serialization;

namespace ADsAPI.Models
{
    public class Advertiser
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
