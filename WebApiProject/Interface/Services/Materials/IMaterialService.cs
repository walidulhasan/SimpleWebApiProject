using WebApiProject.Models;
using WebApiProject.RequestResponseModels.Materials;

namespace WebApiProject.Interface.Services.Materials;

public interface IMaterialService
{
    Task<List<Material>> GetAllMaterialList(CancellationToken cancellationToken);
    Task<bool> MaterialSaveCommand(MaterialRM material);
    Task<bool> MaterialUpdateCommand(MaterialRM material);
    Task<bool> MaterialDeleteCommand(MaterialRM material);
}
