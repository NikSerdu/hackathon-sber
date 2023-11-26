using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SberCase.Models
{
    // Модель для обязательства по заявке
    public class Obligation : IBaseModel<int>
    {
        [Key]
        public int Id { get; set; } // идентификатор обязательства

        [Required]
        [StringLength(100)]
        public string Type { get; set; } = default!; // вид обязательства

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } // дата открытия

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } // дата планового закрытия

        [DataType(DataType.Date)]
        public DateTime? ActualEndDate { get; set; } // дата фактического закрытия

        [Required]
        [StringLength(100)]
        public string Role { get; set; } = default!; // роль (заемщик, поручитель, созаемщик)

        [Required]
        [StringLength(100)]
        public string Status { get; set; } = default!; // статус (текущий, завершенный)

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; } // сумма

        [Required]
        [Range(0, 100)]
        public decimal InterestRate { get; set; } // % ставка

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Balance { get; set; } // остаток к выплате

        [Required]
        [Range(0, int.MaxValue)]
        public int OverdueDays { get; set; } // просрочка в днях

        [Required]
        [Range(0, double.MaxValue)]
        public decimal OverdueAmount { get; set; } // сумма просрочки

        //public int ReportId { get; set; } // идентификатор отчета
        //[JsonIgnore]
        //public virtual Report Report { get; set; } = default!; // отчет
    }
}
