using System.Net.Http.Json;

namespace HypeProxy;

public class EntitiesAccessor<TEntity>
{
    private readonly HttpClient _httpClient;
    private static string Resource => $"{typeof(TEntity).Name}s".ToLower();

    public EntitiesAccessor(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<IEnumerable<TEntity>> FindAsync() => 
        await _httpClient.GetFromJsonAsync<IEnumerable<TEntity>>($"/v3/{Resource}") ?? throw new Exception("lol");

    public async Task<TEntity> FindAsync(Guid entityId) => 
        await _httpClient.GetFromJsonAsync<TEntity>($"/v3/{Resource}/{entityId}") ?? throw new Exception();
}