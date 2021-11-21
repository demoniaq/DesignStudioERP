using System.Text.Json.Serialization;
using AutoMapper;
using DesignStudioErp.Application.AutoMapper;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Dto.MaterialDto;

public class MaterialReadDto : MaterialBaseDto, IMapWith<Material>
{
    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyOrder(-1)]
    public Guid Id { get; set; }

    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());
}
