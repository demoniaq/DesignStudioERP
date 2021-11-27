using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public class MeasUnitService : BaseService<MeasUnit>, IService<MeasUnit>
{
    /// <summary>
    /// ctor
    /// </summary>
    public MeasUnitService(IRepository<MeasUnit> repository) : base(repository) { }

    public override async Task<IEnumerable<MeasUnit>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }
}

