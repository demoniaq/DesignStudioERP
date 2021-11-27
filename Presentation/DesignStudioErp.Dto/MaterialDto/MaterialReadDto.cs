using AutoMapper;
using DesignStudioErp.Domain;
using DesignStudioErp.Dto.Interfaces;
using System.Text.Json.Serialization;

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
