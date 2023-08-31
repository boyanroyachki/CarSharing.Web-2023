using System.ComponentModel.DataAnnotations;

namespace CarSharing.Data.Models
{
    public class Agent
    {
        public Agent()
        {
            Id = Guid.NewGuid();
            OwnedVehicles = new HashSet<Vehicle>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        public virtual AppUser User { get; set; } = null!;

        public virtual ICollection<Vehicle> OwnedVehicles { get; set; }
    }
}
