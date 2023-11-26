using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SberCase.Models;

// ������ ��� ������ ��������� ������
public class Profile : IBaseModel<int>
{
    [Key]
    public int Id { get; set; } // ������������� ������

    [Required]
    [StringLength(100)]
    public string FullName { get; set; } = default!; // ���

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; } // ���� ��������

    [Required]
    [StringLength(20)]
    public string Passport { get; set; } = default!; // ���������� ������

    [Required]
    [StringLength(100)]
    public string RegistrationAddress { get; set; } = default!; // ����� �����������

    [Required]
    [StringLength(100)]
    public string ResidenceAddress { get; set; } = default!; // ����� ����������

    [Required]
    [StringLength(20)]
    public string MaritalStatus { get; set; } = default!; // �������� ���������

    [Required]
    public bool HasChildren { get; set; } // ������� �����

    [Required]
    [StringLength(100)]
    public string Workplace { get; set; } = default!; // ����� ������

    [Required]
    [DataType(DataType.Duration)]
    public string WorkExperience { get; set; } = default!; // ���� ������

    [Required]
    [StringLength(100)]
    public string Position { get; set; } = default!; // ���������

    [Required]
    [Range(0, double.MaxValue)]
    public decimal MonthlyIncome { get; set; } // ����������� �������������� �����

    [Required]
    public string IncomeDocument { get; set; } = default!; // ��������, �������������� �����

    [Range(0, double.MaxValue)]
    public decimal? AdditionalIncome { get; set; } // ����������� �������������� �����

    public bool? IsAdditionalIncomeConfirmed { get; set; } // �������������� ����� ����������� �������������

    public string AdditionalIncomeDocument { get; set; } = default!; // �������� ��������������� ������

    public bool? HasSavings { get; set; } // ������� ���������� �� ������ � �����

    [StringLength(100)]
    public string SavingsCategory { get; set; } = default!; // ��������� ����������

    [Range(0, double.MaxValue)]
    public decimal? SavingsAmount { get; set; } // ������ ����������

    public int ApplicationId { get; set; } // ������������� ������
    [ForeignKey("ProfileId")]
    [JsonIgnore]
    public Application Application { get; set; } = default!;
}