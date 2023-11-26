using SberCase.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SberCase.Contracts
{
    public class ApplicationCreate
    {
        [Required]
        [Range(0, double.MaxValue)]
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; } // сумма кредита

        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;
        [Required]
        [JsonPropertyName("date")]
        public string Date { get; set; } = default!;

        [JsonPropertyName("decision")]
        public string Decision { get; set; } = default!; // решение андеррайтера
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = default!; // комментарий андеррайтера

        [Required]
        [JsonPropertyName("profileId")]
        public int ProfileId { get; set; } = default!;

        public static ApplicationCreate FromDomain(Application application)
        {
            return new ApplicationCreate
            {
                Amount = application.Amount,
                Type = application.Type,
                Date = application.Date,
                Decision = application.Decision,
                Comment = application.Comment,
                ProfileId = application.ProfileId
            };
        }

        public Application ToDomain()
        {
            return new Application
            {
                Amount = this.Amount,
                Type = this.Type,
                Date = this.Date,
                Decision = this.Decision,
                Comment = this.Comment,
                ProfileId = this.ProfileId
            };
        }
    }
}
