using WebApiProject.Common.Mappings;

namespace WebApiProject.RequestResponseModels.Category;

public class CategoryRM:IMapFrom<Models.Category>
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public void Mapping(MappingProfile profile)
    {
        profile.CreateMap<CategoryRM, Models.Category>().ReverseMap();
    }
}
