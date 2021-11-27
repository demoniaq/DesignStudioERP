using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces;

public interface IService<TEntity>
{
    Task<IEnumerable<TEntity>> GetAllAsync();

}

