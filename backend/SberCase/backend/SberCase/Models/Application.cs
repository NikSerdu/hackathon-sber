using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SberCase.Models
{
    //заявка
    public class Application : IBaseModel<int>
    {
        [Key]
        public int Id { get; set; } // идентификатор заявки
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; } // сумма кредита

        [Required]
        public string Type { get; set; } = default!;
        [Required]
        public string Date { get; set; } = default!;

        public string Decision { get; set; } = default!; // решение андеррайтера

        public string Comment { get; set; } = default!; // комментарий андеррайтера
        public int ProfileId { get; set; } = default!;
        [ForeignKey("ApplicationId")]
        [JsonIgnore]
        public virtual Profile Profile { get; set; } = default!; // анкета участника сделки
    }
}
