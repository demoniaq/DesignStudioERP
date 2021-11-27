using System;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public abstract class BaseService<TEntity> : IService<TEntity> where TEntity : BaseModel
{
    protected readonly IRepository<TEntity> _repository;

    /// <summary>
    /// ctor
    /// </summary>
    public BaseService(IRepository<TEntity> repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public abstract Task<IEnumerable<TEntity>> GetAllAsync();
}

