using WebApiProject.Models;

namespace WebApiProject.Interface.Services.Categorys
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesList();
    }
}
