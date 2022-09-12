using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces.Services;

public interface IMeasUnitService : IBaseService<MeasUnit>
{
    int GetMeasUnitCount1();
    int GetMeasUnitCount2();
}