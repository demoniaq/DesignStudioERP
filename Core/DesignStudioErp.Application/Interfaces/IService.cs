using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces;

public interface IService<TModel>
{
    Task<IEnumerable<TModel>> GetAllAsync();

}

