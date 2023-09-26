using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProject.Interface.Services.Materials;
using WebApiProject.Models;
using WebApiProject.RequestResponseModels.Category;
using WebApiProject.RequestResponseModels.Materials;

namespace WebApiProject.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MaterialController : ControllerBase
{
    private readonly IMaterialService _materialService;

    public MaterialController(IMaterialService materialService)
    {
        _materialService = materialService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Material>>> GetMaterialList(CancellationToken cancellationToken)
    {
        return await _materialService.GetAllMaterialList(cancellationToken);
    }
    [HttpPost]
    public async Task<ActionResult<string>> CategorySave([FromBody] MaterialRM material)
    {
        var returnResult = "";
        bool result = await _materialService.MaterialSaveCommand(material);
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
    public async Task<ActionResult<string>> CategoryUpdate([FromBody] MaterialRM material)
    {
        var returnResult = "";
        bool result = await _materialService.MaterialUpdateCommand(material);
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
    public async Task<ActionResult<string>> CategoryDelete([FromBody] MaterialRM material)
    {
        var returnResult = "";
        bool result = await _materialService.MaterialDeleteCommand(material);
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
