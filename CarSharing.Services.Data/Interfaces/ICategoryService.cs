using CarSharing.Data.Models;

namespace CarSharing.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        //block 1
        Task<IEnumerable<Category>> GetAllCategoriesAsync();

        Task<bool> CategoryExistsByIdAsync(int categoryId);

        Task<bool> CategoryExistsByNameAsync(string name);
        //
    }
}
