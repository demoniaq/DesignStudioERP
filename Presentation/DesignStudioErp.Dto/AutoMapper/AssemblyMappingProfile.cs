using AutoMapper;
using DesignStudioErp.Dto.Interfaces;
using System.Reflection;

namespace DesignStudioErp.Dto.AutoMapper;

/// <summary>
/// Class for searching Automapper profiles
/// </summary>
public class AssemblyMappingProfile : Profile
{
    /// <summary>
    /// ctor
    /// </summary>
    public AssemblyMappingProfile(Assembly assembly) => ApplyMappingsFromAssembly(assembly);

    /// <summary>
    /// Search all methods "Mapping" for classes with interface IMapWith<>
    /// </summary>
    private void ApplyMappingsFromAssembly(Assembly assembly)
    {
        var types = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces()
                         .Any(i => i.IsGenericType &&
                              i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
            .ToList();

        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);
            var methodInfo = type.GetMethod("Mapping");
            methodInfo?.Invoke(instance, new object[] { this });
        }
    }
}
