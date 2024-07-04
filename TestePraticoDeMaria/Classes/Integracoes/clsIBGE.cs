using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestePraticoDeMaria.Classes.Integracoes
{
    internal class clsIBGE
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<string>> ConsultarEstadosAsync()
        {
            var url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
            var response = await client.GetStringAsync(url);
            var unidadesFederacao = JsonConvert.DeserializeObject<List<UnidadeFederacao>>(response);
            var siglas = new List<string>();

            foreach (var uf in unidadesFederacao)
            {
                siglas.Add(uf.Sigla);
            }

            return siglas;
        }
    }

    public class UnidadeFederacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public Regiao Regiao { get; set; }
    }

    public class Regiao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
