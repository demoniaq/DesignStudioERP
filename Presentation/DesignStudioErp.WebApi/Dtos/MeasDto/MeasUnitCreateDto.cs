using AutoMapper;
using DesignStudioErp.Application.Common.Mappings;
using DesignStudioErp.Domain;

namespace DesignStudioErp.WebApi.Dtos.MeasDto;

internal class MeasUnitCreateDto : MeasUnitBaseDto, IMapWith<MeasUnit>
{
    public void Mapping(Profile profile) => profile.CreateMap(typeof(MeasUnit), GetType());
}
