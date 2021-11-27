using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

/// <summary>
/// <inheritdoc/>
/// </summary>
public class MeasUnitService : BaseService<MeasUnit>, IService<MeasUnit>
{
    /// <summary>
    /// ctor
    /// </summary>
    public MeasUnitService(IRepository<MeasUnit> repository) : base(repository) { }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<IEnumerable<MeasUnit>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public async Task<MeasUnit> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }
}

