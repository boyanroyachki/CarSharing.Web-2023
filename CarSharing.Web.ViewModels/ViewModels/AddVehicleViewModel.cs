using AutoMapper;
using CarSharing.Common.Attributes;
using CarSharing.Data.Models;
using CarSharing.Services.Mapping.Interfaces;
using System.ComponentModel.DataAnnotations;
using static CarSharing.Common.EntityValidationConstants.Vehicle;

namespace CarSharing.Web.ViewModels.ViewModels
{
    public class AddVehicleViewModel : IMapTo<Vehicle>, IHaveCustomMappings
    {
        public AddVehicleViewModel()
        {
            ImageGalery = new HashSet<Image>();
        }
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

        public void CreateMappings(IProfileExpression configuration)
        {
           configuration.CreateMap<AddVehicleViewModel, Vehicle>()
                .ForMember(vehicle => vehicle.AgentId, opt => opt.Ignore());
        }
    }
}
