using AutoMapper;

namespace DesignStudioErp.Application.AutoMapper;

public interface IMapWith<T>
{
    void Mapping(Profile profile); // TODO => profile.CreateMap(typeof(T), GetType());
}
