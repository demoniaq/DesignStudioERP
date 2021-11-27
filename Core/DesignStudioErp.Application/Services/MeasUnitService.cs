using System;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public class MeasUnitService : BaseService<MeasUnit>, IService<MeasUnit>
{
    public MeasUnitService(IRepository<MeasUnit> repository) : base(repository) { }

    public async Task<IEnumerable<MeasUnit>> GetAllAsync()
    {
        var rez = await _repository.GetAllAsync();

        return rez;
    }
}

