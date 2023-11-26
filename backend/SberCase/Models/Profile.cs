using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SberCase.Models;

// Модель для анкеты участника сделки
public class Profile : IBaseModel<int>
{
    [Key]
    public int Id { get; set; } // идентификатор анкеты

    [Required]
    [StringLength(100)]
    public string FullName { get; set; } = default!; // ФИО

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; } // дата рождения

    [Required]
    [StringLength(20)]
    public string Passport { get; set; } = default!; // паспортные данные

    [Required]
    [StringLength(100)]
    public string RegistrationAddress { get; set; } = default!; // адрес регистрации

    [Required]
    [StringLength(100)]
    public string ResidenceAddress { get; set; } = default!; // адрес проживания

    [Required]
    [StringLength(20)]
    public string MaritalStatus { get; set; } = default!; // семейное положение

    [Required]
    public bool HasChildren { get; set; } // наличие детей

    [Required]
    [StringLength(100)]
    public string Workplace { get; set; } = default!; // место работы

    [Required]
    [DataType(DataType.Duration)]
    public string WorkExperience { get; set; } = default!; // стаж работы

    [Required]
    [StringLength(100)]
    public string Position { get; set; } = default!; // должность

    [Required]
    [Range(0, double.MaxValue)]
    public decimal MonthlyIncome { get; set; } // ежемесячный подтвержденный доход

    [Required]
    public string IncomeDocument { get; set; } = default!; // документ, подтверждающий доход

    [Range(0, double.MaxValue)]
    public decimal? AdditionalIncome { get; set; } // ежемесячный дополнительный доход

    public bool? IsAdditionalIncomeConfirmed { get; set; } // дополнительный доход подтвержден документально

    public string AdditionalIncomeDocument { get; set; } = default!; // источник дополнительного дохода

    public bool? HasSavings { get; set; } // наличие сбережений на счетах в банке

    [StringLength(100)]
    public string SavingsCategory { get; set; } = default!; // категория сбережений

    [Range(0, double.MaxValue)]
    public decimal? SavingsAmount { get; set; } // размер сбережений

    public int ApplicationId { get; set; } // идентификатор заявки
    [ForeignKey("ProfileId")]
    [JsonIgnore]
    public Application Application { get; set; } = default!;
}