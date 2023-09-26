using WebApiProject.Common.Mappings;
using WebApiProject.Models;

namespace WebApiProject.RequestResponseModels.Materials;

public class MaterialRM : IMapFrom<Material>
{
    public int MaterialId { get; set; }
    public int CategoryId { get; set; }
    public string MaterialName { get; set; } = string.Empty;
    public string Unit { get; set; } = string.Empty;
    public string ImageUrl { get; set; }
    public void Mapping(MappingProfile profile)
    {
        profile.CreateMap<MaterialRM, Material>().ReverseMap();
    }
}
