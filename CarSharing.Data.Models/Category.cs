using System.ComponentModel.DataAnnotations;

namespace CarSharing.Data.Models
{
    public class Category
    {
        public Category()
        {
                Vehicles = new HashSet<Vehicle>();
        }
        [Key]
        public int Id { get; set; }  //the id in int 

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
