using CarSharing.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarSharing.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories());
        }
        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();
            Category category;
            category = new Category()
            {
                Id = 1,
                Name = "Trucks",
                Description = "kurec"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Sport cars",
                Description = "kurec"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Economy",
                Description = "kurec"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
