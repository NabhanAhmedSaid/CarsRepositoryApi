using System.ComponentModel.DataAnnotations;

namespace CarsRepositoryApi.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; } = null;
        [Required]
        public string Name { get; set; }
        public string? Color { get; set; }
    }
}
