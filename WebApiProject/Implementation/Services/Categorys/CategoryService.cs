using AutoMapper;
using WebApiProject.Interface.Repositorys.Categorys;
using WebApiProject.Interface.Services.Categorys;
using WebApiProject.Models;
using WebApiProject.RequestResponseModels.Category;

namespace WebApiProject.Implementation.Services.Categorys;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository,IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    public async Task<List<Category>> GetCategoriesList(CancellationToken cancellationToken)
    {
        return await _categoryRepository.GetCategoriesList(cancellationToken);
    }


    public async Task<bool> CategorySaveCommand(CategoryRM category)
    {
        var model = _mapper.Map<Category>(category);
        return await _categoryRepository.AddAsync(model);
    }

    public async Task<bool> CategoryUpdateCommand(CategoryRM category)
    {
        var model = _mapper.Map<Category>(category);
        return await _categoryRepository.UpdateAsync(model);
    }

    public async Task<bool> CategoryDeleteCommand(CategoryRM category)
    {
        var model = _mapper.Map<Category>(category);
        return await _categoryRepository.DeleteAsync(model);
    }
}
