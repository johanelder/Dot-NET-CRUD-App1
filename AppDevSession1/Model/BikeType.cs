using System.ComponentModel.DataAnnotations;

namespace AppDevSession1.Model
{
    public class BikeType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
        [Required]
        public string Brand { get; set; }

        [Required]
        public string ModelName { get; set; }

        [Required]
        [Display(Name="Size of the Bike")]
        [Range(48, 61, ErrorMessage = "Size of bike must be between 48 and 61")]
        public int Size { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
