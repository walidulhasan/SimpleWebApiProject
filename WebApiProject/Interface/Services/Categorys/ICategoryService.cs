using WebApiProject.Models;
using WebApiProject.RequestResponseModels.Category;

namespace WebApiProject.Interface.Services.Categorys
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesList(CancellationToken cancellationToken);
        Task<bool> CategorySaveCommand (CategoryRM category);
        Task<bool> CategoryUpdateCommand(CategoryRM category);
        Task<bool> CategoryDeleteCommand(CategoryRM category);
    }
}
