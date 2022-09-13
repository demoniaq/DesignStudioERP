using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DesignStudioErp.Dto.MaterialDto;

public abstract class MaterialBaseDto
{
    /// <summary>
    /// Material name
    /// </summary>
    [Required]
    [JsonPropertyOrder(-1)]
    public string? Name { get; set; }
}