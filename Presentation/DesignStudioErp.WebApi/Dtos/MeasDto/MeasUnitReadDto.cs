using AutoMapper;
using DesignStudioErp.Application.AutoMapper;
using DesignStudioErp.Domain;

namespace DesignStudioErp.WebApi.Dtos.MeasDto;

public class MeasUnitReadDto : MeasUnitBaseDto, IMapWith<MeasUnit>
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }

    public void Mapping(Profile profile)
    {
        // Model => Dto
        profile.CreateMap(typeof(MeasUnit), GetType());
    }
}
