using System.Text.Json.Serialization;

namespace SberCase.Contracts
{
    public class PatchApplication
    {
        [JsonPropertyName("decision")]
        public string Decision { get; set; } = default!;
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = default!;
    }
}
