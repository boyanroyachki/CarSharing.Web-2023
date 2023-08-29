﻿using System.ComponentModel.DataAnnotations;

namespace CarSharing.Data.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Id = Guid.NewGuid();
            ImageGalery = new HashSet<Image>();
        }
        [Key]
        public Guid Id { get; set; } //the Id of the vehicle, Guid

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string Make { get; set; } = null!; //The brand of the vehicle

        [Required]
        public string Model { get; set; } = null!; //The Model of the brand

        [Required]
        public string ModelYear { get; set; } = null!; //The year that the model was created

        [Required]
        public string PlateNumber { get; set; } = null!; //The plate number of the vehicle

        [Required]
        public string FuelType { get; set; } = null!; //The type of fuel that the vehicle runs on

        [Required]
        public virtual ICollection<Image> ImageGalery { get; set; } //collection of images

        [Required]
        public string NoteFromOwner { get; set; } = null!; //some additional onfo from the owner of the vehicle

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;


        [Required]
        public Guid AgentId { get; set; }

        public virtual Agent Agent { get; set; } = null!;
    }
}
