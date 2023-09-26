using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using WebApiProject.Context;
using WebApiProject.Interface.Repositorys.Categorys;
using WebApiProject.Models;

namespace WebApiProject.Implementation.Repositorys.Categorys
{
    public class CategoryRepository : CommonRepository<Models.Category>, ICategoryRepository
    {
        private readonly DatabaseContext _dbCon;

        public CategoryRepository(DatabaseContext dbCon):base(dbCon) 
        {
            _dbCon = dbCon;
        }
        public async Task<List<Category>> GetCategoriesList(CancellationToken cancellationToken)
        {
            return await _dbCon.Category.ToListAsync(cancellationToken);
        }
    }
}
