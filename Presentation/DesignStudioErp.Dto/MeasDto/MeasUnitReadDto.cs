using System.Text.Json.Serialization;
using AutoMapper;
using DesignStudioErp.Application.AutoMapper;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

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
