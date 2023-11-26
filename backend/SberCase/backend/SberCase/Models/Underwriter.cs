using System.ComponentModel.DataAnnotations;

namespace SberCase.Models
{
    public class Underwriter : IBaseModel<int>
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = default!;
        [Required]
        public string Password { get; set; } = default!;
    }
}
