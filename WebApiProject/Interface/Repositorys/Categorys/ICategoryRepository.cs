using EF.Core.Repository.Interface.Repository;
using WebApiProject.Models;

namespace WebApiProject.Interface.Repositorys.Categorys
{
    public interface ICategoryRepository : ICommonRepository<Category>
    {
        Task<List<Category>> GetCategoriesList(CancellationToken cancellationToken);
    }
}
