using AutoMapper;

using DesignStudioErp.Domain;
using DesignStudioErp.Dto.AutoMapper;

using System.Text.Json.Serialization;

namespace DesignStudioErp.Dto.MaterialDto;

public class MaterialReadDto : MaterialBaseDto, IMapWith<Material>
{
    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyOrder(-2)]
    public Guid Id { get; set; }

    /// <summary>
    /// Name of meas unit
    /// </summary>
    public string? MeasUnitName { get; set; }

    public void Mapping(Profile profile) => profile.CreateMap(typeof(MaterialWithMeasUnitName), GetType());
}