using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestePraticoDeMaria.Classes.DataBase;
using TestePraticoDeMaria.Classes.Utils;

namespace TestePraticoDeMaria.Classes
{
    public class clsCliente
    {
        public string Nome { get; private set; }
        public string CpfCnpj { get; private set; }
        public string Email { get; private set; }
        public string TelefoneCelular { get; private set; }
        public bool PessoaJuridica { get; private set; }
        public int id { get; private set; }

        clsComandosSQL cmdSQL = new clsComandosSQL();
        clsUtilisForm utilisForm = new clsUtilisForm();

        public clsCliente(string nome, string cpfCnpj, string email, string telefoneCelular, bool pessoaJuridica)
        {
            Nome = nome;
            CpfCnpj = cpfCnpj;
            Email = email;
            TelefoneCelular = telefoneCelular;
            PessoaJuridica = pessoaJuridica;
        }

        public void Limpar()
        {
            Nome = string.Empty;
            CpfCnpj = string.Empty;
            Email = string.Empty;
            TelefoneCelular = string.Empty;
            PessoaJuridica = false;
            id = 0;
        }

        public void AtualizarOuCadastrarCliente()
        {
            if (id == 0) { id = cmdSQL.AdicionarNovoCliente(Nome, CpfCnpj, TelefoneCelular, Email, PessoaJuridica); }
            else { cmdSQL.AtualizarCliente(id, Nome, CpfCnpj, TelefoneCelular, Email, PessoaJuridica); }
        }

        public void DeletarCliente()
        {
            cmdSQL.RemoverCliente(id);
        }

        public void CarregarCliente(string nome, string cpfCnpj, string email, string telefoneCelular, bool pessoaJuridica, int clienteId)
        {
            Nome = nome;
            CpfCnpj = cpfCnpj;
            Email = email;
            TelefoneCelular = telefoneCelular;
            PessoaJuridica = pessoaJuridica;
            id = clienteId;
        }

        public DataTable PesquisarCliente(string filtro)
        {
            DataTable dt = new DataTable();
            string cepCnpj = utilisForm.ValidarTextoNumerosComSimbolo(filtro);

            if (!string.IsNullOrEmpty(cepCnpj))
            {
                dt = cmdSQL.ObterCliente(cepCnpj, true);
            }
            else
            {
                dt = cmdSQL.ObterCliente(filtro, false);
            }

            return dt;
        }

    }
}
