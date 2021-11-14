using AutoMapper;
using DesignStudioErp.Application.Common.Mappings;
using DesignStudioErp.Domain;

namespace DesignStudioErp.WebApi.Dtos.MaterialDto;

public class MaterialCreateDto : MaterialBaseDto, IMapWith<Material>
{
    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());
}
