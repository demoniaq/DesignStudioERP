using AutoMapper;
using DesignStudioErp.Domain;
using DesignStudioErp.Dto.Interfaces;

namespace DesignStudioErp.Dto.MaterialDto;

public class MaterialUpdateDto : MaterialBaseDto, IMapWith<Material>
{
    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());
}
