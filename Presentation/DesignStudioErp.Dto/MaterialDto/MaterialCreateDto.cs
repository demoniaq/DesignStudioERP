using AutoMapper;
using DesignStudioErp.Application.AutoMapper;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Dto.MaterialDto;

public class MaterialCreateDto : MaterialBaseDto, IMapWith<Material>
{
    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());
}
