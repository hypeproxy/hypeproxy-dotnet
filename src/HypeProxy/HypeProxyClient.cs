using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using HypeProxy.Infrastructure.Accessors;
using HypeProxy.Requests;
using HypeProxy.Responses;

// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable UnusedMember.Global
namespace HypeProxy;

public class HypeProxyClient
{
    private readonly HttpClient _httpClient;
    public HypeProxyClientOptions Options { get; set; } = new();
    public bool IsLogged { get; set; }
    
    #region Service Accessors
    public Purchases Purchases { get; } = new();
    #endregion
    
    private TokenResponse? _apiTokenArtifact;
    
    public HypeProxyClient(HypeProxyClientOptions? options = null)
    {
        _httpClient = new HttpClient(new HttpClientHandler
        {
        });

        _httpClient.BaseAddress = new Uri("https://localhost:7721");
        
        Purchases = Purchases.CreateInstance<Purchases>(_httpClient);
    }

    /// <summary>
    /// Sign-in using email and password.
    /// </summary>
    /// <param name="email">HypeProxy.io's account email.</param>
    /// <param name="password">HypeProxy.io's account password.</param>
    public async Task<TokenResponse> SignInAsync(string email, string password)
    {
        var response = await _httpClient.PostAsJsonAsync("/v3/authentication/sign-in", new SignInRequest
        {
            Email = email,
            Password = password
        });
        
        // TODO: Handle OTP
        switch (response.StatusCode)
        {
            case HttpStatusCode.OK:
                var apiResponseWithTokenResponse = await response.Content.ReadFromJsonAsync<ApiResponse<TokenResponse>>() ?? throw new Exception();
                _apiTokenArtifact = apiResponseWithTokenResponse.Data;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiTokenArtifact?.Token);
                IsLogged = true;
                return apiResponseWithTokenResponse.Data ?? throw new Exception();
            
            default:
                IsLogged = false;
                throw new Exception("Unable to sign-in the user.");
        }
    }

    /// <summary>
    /// Sign-in using JWT token.
    /// </summary>
    /// <param name="token">HypeProxy.io API Token.</param>
    public HypeProxyClient SignInAsync(string token)
    {
        _apiTokenArtifact = new TokenResponse
        {
            Token = token,
        };
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiTokenArtifact?.Token);
        IsLogged = true;
        return this;
    }

    public async Task<bool> HealthyAsync() => string.Equals(await _httpClient.GetStringAsync("/health"), "Healthy", StringComparison.CurrentCultureIgnoreCase);

    public HypeProxyClient SignOut()
    {
        _apiTokenArtifact = null;
        IsLogged = false;
        return this;
    }
}