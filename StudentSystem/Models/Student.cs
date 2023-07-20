using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Score { get; set; }
    }
}
