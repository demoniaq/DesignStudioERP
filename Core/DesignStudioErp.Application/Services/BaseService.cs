using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public abstract class BaseService<TEntity> where TEntity : BaseModel
{
    protected readonly IRepository<TEntity> _repository;

    /// <summary>
    /// ctor
    /// </summary>
    public BaseService(IRepository<TEntity> repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }
}

