using AutoMapper;
using DesignStudioErp.Application.Common.Mappings;
using DesignStudioErp.Domain;

namespace DesignStudioErp.WebApi.Dtos.MaterialDto;

public class MaterialReadDto : MaterialBaseDto, IMapWith<Material>
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }

    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());   
}
