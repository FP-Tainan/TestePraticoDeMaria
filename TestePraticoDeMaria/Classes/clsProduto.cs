using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TestePraticoDeMaria.Classes.DataBase;

namespace TestePraticoDeMaria.Classes
{
    public class clsProduto
    {
        public int id { get; private set; }
        public string produto { get; private set; }
        public int quantidadeEstoque { get; private set; }
        public decimal precoUnitario { get; private set; }
        public string descricao { get; private set; }

        clsComandosSQL cmdSQL = new clsComandosSQL();

        public clsProduto(string nome, int QuantidadeEstoque, decimal valorUnitario, string Descricao)
        {
            produto = nome;
            quantidadeEstoque = QuantidadeEstoque;
            precoUnitario = valorUnitario;
            descricao = descricao;
        }

        public bool AtualizarOuCadastrarProduto()
        {
            if (id == 0)
            {
                id = cmdSQL.AdicionarNovoProduto(produto, quantidadeEstoque, precoUnitario, descricao);
                if (id != 0) { return true; } else { return false; }
            }
            else
            {
                return cmdSQL.AtualizarProduto(id, produto, quantidadeEstoque, precoUnitario, descricao);
            }
        }
        public bool Deletar()
        {
            return cmdSQL.RemoverProduto(id);
        }
        public void CarregarProduto(string nome, int QuantidadeEstoque, decimal valorUnitario, string Descricao, int produto_id)
        {
            produto = nome;
            quantidadeEstoque = QuantidadeEstoque;
            precoUnitario = valorUnitario;
            descricao = Descricao;
            id = produto_id;
        }

        public void CarregarProduto(int produto_id)
        {
            DataTable dt = cmdSQL.ObterProdutoPeloId(produto_id);

            if (dt.Rows.Count > 0)
            {
                produto = dt.Rows[0]["produto"].ToString();
                quantidadeEstoque = Convert.ToInt32(dt.Rows[0]["quantidadeEstoque"]);
                precoUnitario = Convert.ToDecimal(dt.Rows[0]["precoUnitario"]);
                descricao = dt.Rows[0]["descricao"].ToString();
                id = produto_id;
            }
        }

        public void Limpar()
        {
            id = 0;
            produto = string.Empty;
            quantidadeEstoque = 0;
            precoUnitario = 0;
            descricao = string.Empty;
        }
        public DataTable PesquisarProduto(string filtro)
        {
            DataTable dt = new DataTable();

            dt = cmdSQL.ObterProduto(filtro);


            return dt;
        }

    }
}
