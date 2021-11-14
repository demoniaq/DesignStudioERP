using DesignStudioErp.Application.Common.Mappings;
using DesignStudioErp.Domain;

namespace DesignStudioErp.WebApi.Dtos.MeasDto;

public class MeasReadDto : MeasBaseDto, IMapWith<Meas>
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
}
