using Microsoft.AspNetCore.Mvc;
using WebApiProject.Interface.Services.Categorys;
using WebApiProject.Models;
using WebApiProject.RequestResponseModels.Category;

namespace WebApiProject.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class CategoryController : ControllerBase
{

    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {

        _categoryService = categoryService;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Category>>> GetCategoryList(CancellationToken cancellationToken)
    {
        return await _categoryService.GetCategoriesList(cancellationToken);
    }

    [HttpPost]
    public async Task<ActionResult<string>> CategorySave([FromBody] CategoryRM category)
    {
        var returnResult = "";
        bool result = await _categoryService.CategorySaveCommand(category);
        if (result)
        {
            returnResult = "Data Save Successfully!";
        }
        else
        {
            returnResult = "Data Save Failed!";
        }
        return returnResult;
    }
    [HttpPut]
    public async Task<ActionResult<string>> CategoryUpdate([FromBody] CategoryRM category)
    {
        var returnResult = "";
        bool result = await _categoryService.CategoryUpdateCommand(category);
        if (result)
        {
            returnResult = "Data Update Successfully!";
        }
        else
        {
            returnResult = "Data Update Failed!";
        }
        return returnResult;
    }
    [HttpDelete]
    public async Task<ActionResult<string>> CategoryDelete([FromBody] CategoryRM category)
    {
        var returnResult = "";
        bool result = await _categoryService.CategoryDeleteCommand(category);
        if (result)
        {
            returnResult = "Data Delete Successfully!";
        }
        else
        {
            returnResult = "Data Delete Failed!";
        }
        return returnResult;
    }
}
