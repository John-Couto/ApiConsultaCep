using Newtonsoft.Json;
using System;
namespace ApiConsultaCep
{
    public class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; } = null!;
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; } = null!; 
        [JsonProperty("complemento")]
        public string Complemento{ get; set; } = null!;
        [JsonProperty("bairro")] 
        public string Bairro { get; set; } = null!;
        [JsonProperty("localidade")]
        public string Localidade { get; set; } = null!;
        [JsonProperty("uf")] 
        public string Uf { get; set; } = null!;
        [JsonProperty("unidade")]
        public string Unidade { get; set; } = null!;
        [JsonProperty("ibge")]
        public string Ibge { get; set; } = null!;
        [JsonProperty("gia")]
        public string gia { get; set; } = null!;
    }
}