using SberCase.Models;
using System.ComponentModel.DataAnnotations;

namespace SberCase.Contracts
{
    public class ObligationCreate
    {
        [Required]
        [StringLength(100)]
        public string Type { get; set; } = default!; // вид обязательства

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; } // дата открытия

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; } // дата планового закрытия

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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

        public int ReportId { get; set; } // идентификатор отчета

        public static ObligationCreate FromDomain(Obligation obligation)
        {
            return new ObligationCreate
            {
                Type = obligation.Type,
                StartDate = obligation.StartDate,
                EndDate = obligation.EndDate,
                ActualEndDate = obligation.ActualEndDate,
                Role = obligation.Role,
                Status = obligation.Status,
                Amount = obligation.Amount,
                InterestRate = obligation.InterestRate,
                Balance = obligation.Balance,
                OverdueDays = obligation.OverdueDays,
                OverdueAmount = obligation.OverdueAmount,
                ReportId = obligation.ReportId
            };
        }

        public Obligation ToDomain()
        {
            return new Obligation
            {
                Type = this.Type,
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                ActualEndDate = this.ActualEndDate,
                Role = this.Role,
                Status = this.Status,
                Amount = this.Amount,
                InterestRate = this.InterestRate,
                Balance = this.Balance,
                OverdueDays = this.OverdueDays,
                OverdueAmount = this.OverdueAmount,
                ReportId = this.ReportId
            };
        }
    }
}
