using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProject.Context;
using WebApiProject.Interface.Repositorys.Categorys;
using WebApiProject.Interface.Services.Categorys;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        
        private readonly DatabaseContext _databaseContext;

        public CategoryController(DatabaseContext databaseContext)
        {
            
            _databaseContext = databaseContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategoryList()
        {
            return await _databaseContext.Category.ToListAsync();
        }
    }
}
