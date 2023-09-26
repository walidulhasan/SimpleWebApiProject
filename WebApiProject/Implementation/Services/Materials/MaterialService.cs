using AutoMapper;
using WebApiProject.Interface.Repositorys.Materials;
using WebApiProject.Interface.Services.Materials;
using WebApiProject.Models;
using WebApiProject.RequestResponseModels.Materials;

namespace WebApiProject.Implementation.Services.Materials
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IMapper _mapper;

        public MaterialService(IMaterialRepository materialRepository,IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }
        public async Task<List<Material>> GetAllMaterialList(CancellationToken cancellationToken)
        {
            return await _materialRepository.GetAllMaterialList(cancellationToken);
        }

        public async Task<bool> MaterialDeleteCommand(MaterialRM material)
        {
            var model = _mapper.Map<Material>(material);
            return await _materialRepository.DeleteAsync(model);
        }

        public async Task<bool> MaterialSaveCommand(MaterialRM material)
        {
            var model = _mapper.Map<Material>(material);
            return await _materialRepository.AddAsync(model);
        }

        public async Task<bool> MaterialUpdateCommand(MaterialRM material)
        {
            var model = _mapper.Map<Material>(material);
            return await _materialRepository.UpdateAsync(model);
        }
    }
}
