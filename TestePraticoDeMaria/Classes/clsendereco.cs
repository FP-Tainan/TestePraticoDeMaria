using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TestePraticoDeMaria.Classes.DataBase;

namespace TestePraticoDeMaria.Classes
{
    public class clsendereco
    {

        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public int id { get; set; }
        public int Cliente_id { get; set; }

        clsComandosSQL cmdSQL = new clsComandosSQL();

        public clsendereco(string cep, string logradouro, int numero, string complemento, string bairro, string localidade, string uf, int cliente_id)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Localidade = localidade;
            UF = uf;
            Cliente_id = cliente_id;
        }
        public void AtualizarOuCadastrarEndereco()
        {
            if (id == 0) { id = cmdSQL.AdicionarNovoEndereco(Cliente_id, CEP, Logradouro, Numero, Complemento, Bairro, Localidade, UF); }
            else { cmdSQL.AtualizarEndereco(id, CEP, Logradouro, Numero, Complemento, Bairro, Localidade, UF); }
        }

        public void Limpar()
        {
            CEP = string.Empty;
            Logradouro = string.Empty;
            Numero = 0;
            Complemento = string.Empty;
            Bairro = string.Empty;
            Localidade = string.Empty;
            UF = string.Empty;
            Cliente_id = 0;
            id = 0;
        }

        public void CarregarEndereco(string cep, string logradouro, int numero, string complemento, string bairro, string localidade, string uf, int cliente_id, int endereco_id)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Localidade = localidade;
            UF = uf;
            Cliente_id = cliente_id;
            id = endereco_id;
        }

        public void DeletarEndereco()
        {
            cmdSQL.RemoverEndereco(id);
        }
    }
}
