using AutoMapper;

namespace DesignStudioErp.Application.Interfaces;

public interface IMapWith<T>
{
    void Mapping(Profile profile); // TODO => profile.CreateMap(typeof(T), GetType());
}
