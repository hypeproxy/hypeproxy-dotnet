using System.Net.Http.Json;

namespace HypeProxy.Infrastructure.Accessors;

#pragma warning disable CS0618 // Type or member is obsolete
public class BaseControllerAccessor<TEntity> : IControllerAccessor<TEntity>
{
    private readonly string? _baseAddress;
    protected HttpClient? Client { get; set; }

    internal string BaseAddress
    {
        get => _baseAddress ?? $"/v3/{typeof(TEntity).Name + "s".ToLower()}";
        init => _baseAddress = value;
    }

    internal void PreventNullClient()
    {
        if (Client == null) throw new Exception();
    }

    internal TService CreateInstance<TService>(HttpClient httpClient) where TService : class
    {
        Client = httpClient;
        return this as TService ?? throw new NotImplementedException("FUCK IT");
    }

    // public async Task<Task<ApiResponse?>> CreateAsync(TEntity entity)
    // {
    //     if (Client == null) throw new Exception();
    //     var xx = await Client.PostAsJsonAsync(BaseAddress, entity);
    //     return xx.Content.ReadFromJsonAsync<ApiResponse>();
    // }

    public async Task<IEnumerable<TEntity>> GetAsync()
    {
        if (Client == null) throw new Exception();
        return await Client.GetFromJsonAsync<IEnumerable<TEntity>>(BaseAddress) ?? Array.Empty<TEntity>();
    }

    public async Task<TEntity?> GetAsync(Guid entityId)
    {
        if (Client == null) throw new Exception();
        return await Client.GetFromJsonAsync<TEntity>($"{BaseAddress}/{entityId}");
    }
    
    private static string Resource => $"{typeof(TEntity).Name}s".ToLower();
}