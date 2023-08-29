using System.ComponentModel.DataAnnotations;

namespace CarSharing.Data.Models
{
    public class Image
    {
        public Image()
        {
            Id = Guid.NewGuid();
            Data = new HashSet<byte>();
        }
        [Key]
        public Guid Id { get; set; }

        public virtual ICollection<byte> Data { get; set; } //either this

        public string? ImageUrl { get; set; } //or this

        [Required]
        public Guid VehicleId { get; set; } //connection to the vehicle that the photo represents

        [Required]
        public Vehicle Vehicle { get; set; } = null!;
    }
}
