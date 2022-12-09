using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectoryApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Gender { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? GivenName { get; set; }
        [Required]
        public string? MiddleInitial { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        public string? ZipCode { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        
    }
}
