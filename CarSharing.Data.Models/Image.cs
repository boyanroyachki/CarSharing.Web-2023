using System.ComponentModel.DataAnnotations;

namespace CarSharing.Data.Models
{
    public class Image
    {
        public Image() //not done
        {
            Id = Guid.NewGuid();  
        }

        [Key]
        public Guid Id { get; set; }
        public string? ImageUrl { get; set; } //or this

        [Required]
        public Guid VehicleId { get; set; } //connection to the vehicle that the photo represents

        [Required]
        public Vehicle Vehicle { get; set; } = null!;
    }
}
