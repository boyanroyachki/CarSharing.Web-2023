using CarSharing.Common.Attributes;
using System.ComponentModel.DataAnnotations;
using static CarSharing.Common.EntityValidationConstants.Vehicle;

namespace CarSharing.Data.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Id = Guid.NewGuid();
            ImageGalery = new HashSet<Image>(); //not done
            IsDeleted = false;
            IsRented = false;
        }

        [Key]
        public Guid Id { get; set; } //the Id of the vehicle, Guid

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [MinLength(DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [PositiveDecimal]
        public decimal PricePerHour { get; set; } //the price for one hour

        [Required]
        [MaxLength(MakeMaxLength)]
        [MinLength(MakeMinLength)]
        public string Make { get; set; } = null!; //The brand of the vehicle

        [Required]
        [MaxLength(ModelMaxLength)]
        [MinLength(ModelMinLength)]
        public string Model { get; set; } = null!; //The Model of the brand

        [Required]
        [MaxLength(ModelYearMaxLength)]
        [MinLength(ModelYearMinLength)]
        public string ModelYear { get; set; } = null!; //The year that the model was created

        [Required]
        [MaxLength(PlateNumberMaxLength)]
        [MinLength(PlateNumberMinLength)]
        public string PlateNumber { get; set; } = null!; //The plate number of the vehicle

        [Required]
        [MaxLength(FuelTypeMaxLength)]
        [MinLength(FuelTypeMinLength)]
        public string FuelType { get; set; } = null!; //The type of fuel that the vehicle runs on

        [Required]
        public virtual ICollection<Image> ImageGalery { get; set; } //collection of images

        [Required]
        [MaxLength(NoteFromOwnerMaxLength)]
        [MinLength(NoteFromOwnerMinLength)]
        public string NoteFromOwner { get; set; } = null!; //some additional onfo from the owner of the vehicle

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public bool IsRented { get; set; }



        [Required]
        public Guid AgentId { get; set; }

        public virtual Agent Agent { get; set; } = null!;
    }
}
