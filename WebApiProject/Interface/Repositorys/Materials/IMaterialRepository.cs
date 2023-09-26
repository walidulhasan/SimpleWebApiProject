using EF.Core.Repository.Interface.Repository;
using WebApiProject.Models;

namespace WebApiProject.Interface.Repositorys.Materials
{
    public interface IMaterialRepository:ICommonRepository<Material>
    {
        Task<List<Material>> GetAllMaterialList(CancellationToken cancellationToken);
    }
}
