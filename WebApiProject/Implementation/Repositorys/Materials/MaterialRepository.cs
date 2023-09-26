using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using WebApiProject.Context;
using WebApiProject.Interface.Repositorys.Materials;
using WebApiProject.Models;

namespace WebApiProject.Implementation.Repositorys.Materials
{
    public class MaterialRepository : CommonRepository<Material>, IMaterialRepository
    {
        private readonly DatabaseContext _database;

        public MaterialRepository(DatabaseContext database):base(database) 
        {
            _database = database;
        }
        public async Task<List<Material>> GetAllMaterialList(CancellationToken cancellationToken)
        {
            return await _database.Material.ToListAsync(cancellationToken);
        }
    }
}
