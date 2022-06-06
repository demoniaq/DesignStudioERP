using DesignStudioErp.Application.Interfaces.Context;
using DesignStudioErp.Application.Interfaces.Services;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public class MeasUnitService : BaseService<MeasUnit>, IMeasUnitService
{
    public MeasUnitService(IRepository<MeasUnit> repository) : base(repository) { }

    public async Task<IEnumerable<MeasUnit>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<MeasUnit> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }
}