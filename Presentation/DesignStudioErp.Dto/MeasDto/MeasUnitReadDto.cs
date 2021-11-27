using AutoMapper;
using DesignStudioErp.Domain;
using DesignStudioErp.Dto.Interfaces;
using System.Text.Json.Serialization;

namespace DesignStudioErp.Dto.MeasDto;

public class MeasUnitReadDto : MeasUnitBaseDto, IMapWith<MeasUnit>
{
    /// <summary>
    /// Id
    /// </summary>
    [JsonPropertyOrder(-1)]
    public Guid Id { get; set; }

    public void Mapping(Profile profile)
    {
        // Model => Dto
        profile.CreateMap(typeof(MeasUnit), GetType());
    }
}
