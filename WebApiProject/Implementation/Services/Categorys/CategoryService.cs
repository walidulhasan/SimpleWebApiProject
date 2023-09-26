using WebApiProject.Interface.Repositorys.Categorys;
using WebApiProject.Interface.Services.Categorys;
using WebApiProject.Models;

namespace WebApiProject.Implementation.Services.Categorys;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<List<Category>> GetCategoriesList()
    {
        return await _categoryRepository.GetCategoriesList();
    }
}
