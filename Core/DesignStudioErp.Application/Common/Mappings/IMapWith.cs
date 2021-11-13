using AutoMapper;

namespace DesignStudioErp.Application.Common.Mappings
{
    internal interface IMapWith<T>
    {
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());
    }
}
