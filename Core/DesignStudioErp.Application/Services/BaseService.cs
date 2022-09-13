using DesignStudioErp.Application.Interfaces.Context;
using DesignStudioErp.Domain;

namespace DesignStudioErp.Application.Services;

public abstract class BaseService<TEntity> where TEntity : BaseModel
{
    private readonly IRepository<TEntity> _repository;

    public BaseService(IRepository<TEntity> repository)
        => _repository = repository ?? throw new ArgumentNullException(nameof(repository));

    public IQueryable<TEntity> GetAll()
        => _repository.GetAll();

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _repository.GetAllAsync();

    public async Task<TEntity> GetByIdAsync(Guid id)
        => await _repository.GetByIdAsync(id);
}