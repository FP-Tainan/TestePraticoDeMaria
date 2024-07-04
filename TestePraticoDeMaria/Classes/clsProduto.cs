using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TestePraticoDeMaria.Classes.DataBase;

namespace TestePraticoDeMaria.Classes
{
    public class clsProduto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public string Descricao { get; private set; }

        clsComandosSQL cmdSQL = new clsComandosSQL();

        public clsProduto(string nome, int quantidadeEstoque, decimal valorUnitario, string descricao)
        {
            Nome = nome;
            QuantidadeEstoque = quantidadeEstoque;
            ValorUnitario = valorUnitario;
            Descricao = descricao;
        }

        public bool AtualizarOuCadastrarProduto()
        {
            if (Id == 0)
            {
                Id = cmdSQL.AdicionarNovoProduto(Nome, QuantidadeEstoque, ValorUnitario, Descricao);
                if (Id != 0) { return true; } else { return false; }
            }
            else
            {
                return cmdSQL.AtualizarProduto(Id, Nome, QuantidadeEstoque, ValorUnitario, Descricao);
            }
        }

    }
}
