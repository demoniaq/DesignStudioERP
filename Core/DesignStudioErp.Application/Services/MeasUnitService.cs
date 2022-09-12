using DesignStudioErp.Application.Interfaces.Context;
using DesignStudioErp.Application.Interfaces.Services;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public class MeasUnitService : BaseService<MeasUnit>, IMeasUnitService
{
    public MeasUnitService(IRepository<MeasUnit> repository) : base(repository) { }

    public int GetMeasUnitCount1()
    {
        return _repository.Query.Where(x => x.Name == "Кг").Count();
    }

    public int GetMeasUnitCount2()
    {
        return _repository.Context.Materials.Where(x => x.Name != "Кг").Count();
    }

}