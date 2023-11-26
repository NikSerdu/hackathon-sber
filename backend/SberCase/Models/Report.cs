using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SberCase.Models
{
    // Модель для отчета по заявке
    public class Report : IBaseModel<int>
    {
        [Key]
        public int Id { get; set; } // идентификатор отчета

        [Required]
        [Range(0, 1000)]
        public int Score { get; set; } // скорбалл (оценка кредитной истории в баллах)
        public virtual List<Obligation> Obligations { get; set; } = default!; // коллекция обязательств по заявке

        public int ApplicationId { get; set; } // идентификатор заявки
        [JsonIgnore]
        public virtual Application Application { get; set; } = default!; // заявка
    }
}
