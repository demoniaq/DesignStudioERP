using DesignStudioErp.Application.Interfaces.Context;
using DesignStudioErp.Application.Interfaces.Services;
using DesignStudioErp.Domain;

using Microsoft.EntityFrameworkCore;

namespace DesignStudioErp.Application.Services;

public class MaterialService : BaseService<Material>, IMaterialService
{
    private readonly IMeasUnitService _measUnitService;

    public MaterialService(IRepository<Material> repository,
                           IMeasUnitService measUnitService) : base(repository)
    {
        _measUnitService = measUnitService;
    }

    public async Task<IEnumerable<MaterialWithMeasUnitName>> GetAllMaterialWithMeasUnitNameAsync()
    => await _repository.GetAll()
            .Join(_measUnitService.GetAll(),
                  material => material.MeasUnitId,
                  measUnit => measUnit.Id,
                  (material, measUnit) => new MaterialWithMeasUnitName
                  {
                      Id = material.Id,
                      Name = material.Name,
                      MeasUnitName = measUnit.Name
                  })
            .ToListAsync();
}