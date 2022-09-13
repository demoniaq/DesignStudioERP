using System.ComponentModel.DataAnnotations;

using AutoMapper;

using DesignStudioErp.Domain;
using DesignStudioErp.Dto.AutoMapper;

namespace DesignStudioErp.Dto.MaterialDto;

public class MaterialUpdateDto : MaterialBaseDto, IMapWith<Material>
{
    /// <summary>
    /// FK meas
    /// </summary>
    [Required]
    public Guid MeasUnitId { get; set; }

    public void Mapping(Profile profile) => profile.CreateMap(typeof(Material), GetType());
}