using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        [Required]
        public string Course { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
