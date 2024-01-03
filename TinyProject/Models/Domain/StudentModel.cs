using System.ComponentModel.DataAnnotations;

namespace TinyProject.Models.Domain
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
