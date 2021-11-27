using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Interfaces;

public interface IService<TEntity> where TEntity : BaseModel
{
    Task<IEnumerable<TEntity>> GetAllAsync();

}

