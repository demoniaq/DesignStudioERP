using DesignStudioErp.Application.Common.Mappings;
using DesignStudioErp.Domain;

namespace DesignStudioErp.WebApi.Dtos.MaterialDto;

internal class MaterialReadDto : MaterialBaseDto, IMapWith<Material>
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; set; }
}
