using AutoMapper;
using DesignStudioErp.Domain;
using DesignStudioErp.Dto.AutoMapper;

namespace DesignStudioErp.Dto.MaterialDto;

public class MaterialCreateDto : MaterialBaseDto, IMapWith<Material>
{
    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());
}
