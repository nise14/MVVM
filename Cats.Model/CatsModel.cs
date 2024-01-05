namespace Cats.Model;

public class CatsModel : ICatsModel
{
    private readonly HttpClient _client;
    private readonly CatsEndpoints _endpoints;

    public CatsModel(HttpClient client, CatsEndpoints endpoints)
    {
        _client = client;
        _endpoints = endpoints;
    }

    public async Task<IReadOnlyCollection<Cat>> GetCatsAsync()
    {
        return await _client.GetFromJsonAsync<IReadOnlyCollection<Cat>>(_endpoints.Cats, options: new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })??Array.Empty<Cat>();    }
}