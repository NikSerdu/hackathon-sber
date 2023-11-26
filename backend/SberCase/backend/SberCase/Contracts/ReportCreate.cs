using SberCase.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SberCase.Contracts
{
    public class ReportCreate
    {
        [Required]
        [JsonPropertyName("score")]
        public int Score { get; set; } // скорбалл (оценка кредитной истории в баллах)

        public static ReportCreate FromDomain(Report report)
        {
            return new ReportCreate { Score = report.Score, };
        }

        public Report ToDomain()
        {
            return new Report { Score = Score, };
        }
    }
}
