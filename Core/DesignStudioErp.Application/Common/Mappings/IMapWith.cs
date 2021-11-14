using AutoMapper;

namespace DesignStudioErp.Application.Common.Mappings;

public interface IMapWith<T>
{
    void Mapping(Profile profile); // TODO => profile.CreateMap(typeof(T), GetType());
}
