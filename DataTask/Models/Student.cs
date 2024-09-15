using System.ComponentModel.DataAnnotations;

namespace DataTask.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Name { get; set; } = string.Empty; // Name alanı null olamaz

        [Required(ErrorMessage = "Student ID is required")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Class is required")]
        public int ClassId { get; set; }

        // Class ile ilişki
        public Class Class { get; set; } = new Class(); // Class alanı null olamaz
    }
}
