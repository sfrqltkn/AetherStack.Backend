using AetherStack.Backend.Domain.Common;

namespace AetherStack.Backend.Application.Abstractions.Persistence.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IWriteRepository<TEntity, TId> WriteRepository<TEntity, TId>() where TEntity : BaseEntity<TId> where TId : notnull;
        IReadRepository<TEntity, TId> ReadRepository<TEntity, TId>() where TEntity : BaseEntity<TId> where TId : notnull;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);
        Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
    }
}
