using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using HypeProxy.Entities;
using HypeProxy.Entities.Infrastructure;
using HypeProxy.Entities.Proxies;
using HypeProxy.Requests;
using HypeProxy.Responses;

namespace HypeProxy;

public class HypeProxyClient
{
    private HypeProxyClientOptions? _hypeProxyClientOptions;
    private readonly HttpClient _httpClient;
    private ApiKeyResponse? _apiKeyArtifact;
    public bool Logged { get; set; }
    
    #region Entities Accessor
    public EntitiesAccessor<Product> Products { get; set; }
    public EntitiesAccessor<Location> Locations { get; set; }
    public EntitiesAccessor<Provider> Providers { get; set; }
    public EntitiesAccessor<Bay> Bays { get; set; }
    public EntitiesAccessor<Purchase> Purchases { get; set; }
    public EntitiesAccessor<Feature> Features { get; set; }
    public EntitiesAccessor<Proxy> Proxies { get; set; }
    #endregion

    public HypeProxyClient()
    {
    }
    
    public HypeProxyClient(HypeProxyClientOptions? options)
    {
        _hypeProxyClientOptions = options;
        _httpClient = new HttpClient(new HttpClientHandler
        {
        });
        Products = new EntitiesAccessor<Product>(_httpClient);
        _httpClient.BaseAddress = options?.BaseApiAddress;
        // _httpClient.DefaultRequestHeaders.UserAgent = new HttpHeaderValueCollection<ProductInfoHeaderValue>()
        
        #region Initialize entities accessors
        Products = new EntitiesAccessor<Product>(_httpClient);
        Locations = new EntitiesAccessor<Location>(_httpClient);
        Providers = new EntitiesAccessor<Provider>(_httpClient);
        Bays = new EntitiesAccessor<Bay>(_httpClient);
        Purchases = new EntitiesAccessor<Purchase>(_httpClient);
        Features = new EntitiesAccessor<Feature>(_httpClient);
        Proxies = new EntitiesAccessor<Proxy>(_httpClient);
        #endregion
    }

    /// <summary>
    /// Sign-in using email and password.
    /// </summary>
    /// <param name="email">HypeProxy.io's account email</param>
    /// <param name="password">HypeProxy.io's account password</param>
    public async Task<ApiKeyResponse> SignInAsync(string email, string password)
    {
        var response = await _httpClient.PostAsJsonAsync("/v3/authentication/sign-in", new SignInRequest
        {
            Email = email,
            Password = password
        });
        
        // TODO: Handle OTP
        switch (response.StatusCode)
        {
            default:
                Logged = false;
                throw new Exception("Unable to sign-in the user.");
            
            case HttpStatusCode.OK:
                _apiKeyArtifact = await response.Content.ReadFromJsonAsync<ApiKeyResponse>() ?? throw new Exception();
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKeyArtifact?.Token);
                Logged = true;
                return _apiKeyArtifact ?? throw new Exception();
        }
    }

    /// <summary>
    /// Sign-in using JWT token.
    /// </summary>
    /// <param name="token">HypeProxy.io API Token.</param>
    public HypeProxyClient SignInAsync(string token)
    {
        _apiKeyArtifact = new ApiKeyResponse
        {
            Token = token,
        };
        return this;
    }

    public async Task<bool> HealthyAsync() => string.Equals(await _httpClient.GetStringAsync("/health"), "Healthy", StringComparison.CurrentCultureIgnoreCase);

    public HypeProxyClient SignOut()
    {
        _apiKeyArtifact = null;
        return this;
    }
}