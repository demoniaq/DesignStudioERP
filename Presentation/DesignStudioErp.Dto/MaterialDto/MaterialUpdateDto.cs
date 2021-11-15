using AutoMapper;
using DesignStudioErp.Application.AutoMapper;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Dto.MaterialDto;

internal class MaterialUpdateDto : MaterialBaseDto, IMapWith<Material>
{
    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());
}