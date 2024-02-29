using ChallengeIntuit.Banco;
using ChallengeIntuit.Modelos;
using System.Net.Http.Json;
using System.Threading.Tasks.Dataflow;

namespace ChallengeIntuit.Web.Services
{
    public class ClientesAPI
    {
        private readonly HttpClient _httpClient;
        public ClientesAPI(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }
        public async Task<ICollection<Clientes>?> GetClientesAsync()
        {
            return await _httpClient.GetFromJsonAsync<ICollection<Clientes>>("Clientes");
        }
        public async Task AddClientesAsync(Clientes clientes)
        {
            await _httpClient.PostAsJsonAsync("Clientes", clientes);
        }
    }
}
