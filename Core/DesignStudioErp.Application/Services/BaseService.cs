using System;
using DesignStudioErp.Application.Interfaces;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public abstract class BaseService<TModel> where TModel : BaseModel
{
    protected readonly IRepository<TModel> _repository;

    /// <summary>
    /// ctor
    /// </summary>
    public BaseService(IRepository<TModel> repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }
}

