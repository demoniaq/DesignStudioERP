using AutoMapper;
using DesignStudioErp.Domain;
using DesignStudioErp.Dto.Interfaces;

namespace DesignStudioErp.Dto.MeasDto;

public class MeasUnitUpdateDto : MeasUnitBaseDto, IMapWith<MeasUnit>
{
    public void Mapping(Profile profile) => profile.CreateMap(typeof(MeasUnit), GetType());
}
