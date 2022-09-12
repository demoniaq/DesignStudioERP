using DesignStudioErp.Application.Interfaces.Context;
using DesignStudioErp.Application.Interfaces.Services;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public class MeasUnitService : BaseService<MeasUnit>, IMeasUnitService
{
    public MeasUnitService(IRepository<MeasUnit> repository) : base(repository) { }
}