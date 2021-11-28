using AutoMapper;

namespace DesignStudioErp.Dto.AutoMapper;

public interface IMapWith<T>
{
    void Mapping(Profile profile); // TODO => profile.CreateMap(typeof(T), GetType());
}
