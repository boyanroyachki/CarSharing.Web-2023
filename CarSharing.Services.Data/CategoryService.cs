using CarSharing.Data;
using CarSharing.Data.Models;
using CarSharing.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarSharing.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext data;
        public CategoryService(ApplicationDbContext data) => this.data = data;

        //block 1
        public async Task<bool> CategoryExistsByIdAsync(int categoryId)
        {
            var category = await this.data.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
            return category != null;
        }

        public async Task<bool> CategoryExistsByNameAsync(string name)
        {
            var category = await this.data.Categories.FirstOrDefaultAsync(c => c.Name == name);
            return category != null;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await this.data.Categories.ToListAsync();
        }
        //
    }
}
