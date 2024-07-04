using System;
using System.Net.Http;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestePraticoDeMaria.Classes.Integracoes
{
    public class clsCorreios
    {
        private static readonly HttpClient client = new HttpClient();

        private async Task<CepResponse> ConsultarCepAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CepResponse>(jsonResponse);
            }
            else
            {
                throw new Exception("Erro ao consultar o CEP.");
               
            }
        }

        public async Task<clsendereco> ConsultaCEPAsync(string cep)
        {
            var cepResponse = await ConsultarCepAsync(cep);
            clsendereco endereco = new clsendereco(
                cep,
                cepResponse.Logradouro,
                0,
                cepResponse.Complemento,
                cepResponse.Bairro,
                cepResponse.Localidade,
                cepResponse.Uf,
                0);

            return endereco;
        }
    }

    public class CepResponse
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("ibge")]
        public string Ibge { get; set; }

        [JsonProperty("gia")]
        public string Gia { get; set; }

        [JsonProperty("ddd")]
        public string Ddd { get; set; }

        [JsonProperty("siafi")]
        public string Siafi { get; set; }
    }
}
