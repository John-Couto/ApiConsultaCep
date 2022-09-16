using Refit;
using System.Threading.Tasks;

namespace ApiConsultaCep
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
