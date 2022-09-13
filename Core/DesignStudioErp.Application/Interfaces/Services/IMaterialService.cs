using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces.Services;

public interface IMaterialService : IBaseService<Material>
{
    Task<IEnumerable<MaterialWithMeasUnitName>> GetAllMaterialWithMeasUnitNameAsync();
}