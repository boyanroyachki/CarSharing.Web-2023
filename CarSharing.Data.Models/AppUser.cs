using Microsoft.AspNetCore.Identity;

namespace CarSharing.Data.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public AppUser()
        {
              AdoptedVehicles = new HashSet<Vehicle>();
        }
        public virtual ICollection<Vehicle> AdoptedVehicles { get; set; } 
    }
}