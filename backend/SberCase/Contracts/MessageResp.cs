using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SberCase.Contracts
{
    public class MessageResp
    {
        [JsonPropertyName("code")]
        public int Code { get; private set; }
        [JsonPropertyName("message")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; private set; }

        public static MessageResp New(int code) => 
            new MessageResp { Code = code };
        public static MessageResp New(int code, string message) => 
            new MessageResp { Code = code, Message = message };
    }
}
