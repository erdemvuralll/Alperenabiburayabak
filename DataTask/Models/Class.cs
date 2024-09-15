using System.ComponentModel.DataAnnotations;

namespace DataTask.Models
{
    public class Class
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Class name is required")]
        [StringLength(50, ErrorMessage = "Class name can't be longer than 50 characters")]
        public string Name { get; set; } = string.Empty; // Name alanı null olamaz
    }
}
