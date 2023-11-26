using System.Text.Json.Serialization;

namespace SberCase.Contracts
{
    public class PdnResp
    {
        /*
         {
            "risk_points": points,
            "risk_level": rate
        }
         */
        [JsonPropertyName("risk_points")]
        public double RiskPoints { get; set; }
        [JsonPropertyName("risk_level")]
        public double RickLevel { get; set; }
    }
}
