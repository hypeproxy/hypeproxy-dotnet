namespace HypeProxy.Infrastructure.Accessors;

// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMemberInSuper.Global

public interface IControllerAccessor<TEntity>
{
    public Task<IEnumerable<TEntity>> GetAsync();
    public Task<TEntity?> GetAsync(Guid entityId);
}

// public interface ICrudControllerAccessor<TEntity>
// {
//     public Task<Task<ApiResponse?>> CreateAsync(TEntity entity);
// }