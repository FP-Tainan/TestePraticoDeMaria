using System;
using System.Data;
using TestePraticoDeMaria.Classes.DataBase;

namespace TestePraticoDeMaria.Classes
{
    public class clsPedido
    {
        public int id { get; private set; }
        public int cliente_id { get; private set; }
        public DateTime dataPedido { get; private set; }
        public DateTime dataConcluido { get; private set; }
        public DateTime dataCancelado { get; private set; }
        public bool cancelado { get; private set; }
        public bool finalizado { get; private set; }
        public string observacao { get; private set; }
        public decimal valorTotalPedido { get; private set; }

        clsComandosSQL cmdSQL = new clsComandosSQL();
        public clsPedido(int cliente_id, DateTime dataPedido, DateTime dataConcluido, DateTime dataCancelado, bool cancelado, bool finalizado, string observacao, decimal valorTotalPedido)
        {
            this.cliente_id = cliente_id;
            this.dataPedido = dataPedido;
            this.dataConcluido = dataConcluido;
            this.dataCancelado = dataCancelado;
            this.cancelado = cancelado;
            this.finalizado = finalizado;
            this.observacao = observacao;
            this.valorTotalPedido = valorTotalPedido;
        }

        public void Limpar()
        {
            this.id = 0;
            this.cliente_id = 0;
            this.dataPedido = DateTime.MinValue;
            this.dataConcluido = DateTime.MinValue;
            this.dataCancelado = DateTime.MinValue;
            this.cancelado = false;
            this.finalizado = false;
            this.observacao = string.Empty;
            this.valorTotalPedido = 0;
        }
        public void finalizar()
        {
            finalizado = true;
            dataConcluido = DateTime.Now;
        }
        public void Cancelar()
        {
            cancelado = true;
            dataCancelado = DateTime.Now;
        }
        public bool Pesquisar(int pedidoId)
        {
            DataTable dt = cmdSQL.ObterPedidoPeloId(pedidoId);

            if (dt.Rows.Count == 0) { return false; }
            else
            {
                observacao = dt.Rows[0]["observacao"].ToString();
                id = Convert.ToInt32(dt.Rows[0]["id"]);
                cliente_id = Convert.ToInt32(dt.Rows[0]["cliente_id"]);
                valorTotalPedido = Convert.ToDecimal(dt.Rows[0]["valorTotalPedido"]);

                finalizado = dt.Rows[0]["finalizado"] != DBNull.Value && Convert.ToBoolean(dt.Rows[0]["finalizado"]);
                cancelado = dt.Rows[0]["cancelado"] != DBNull.Value && Convert.ToBoolean(dt.Rows[0]["cancelado"]);

                dataPedido = Convert.ToDateTime(dt.Rows[0]["dataPedido"]);

                if(finalizado) { dataConcluido = Convert.ToDateTime(dt.Rows[0]["dataConcluido"]); }
                if(cancelado) { dataCancelado = Convert.ToDateTime(dt.Rows[0]["dataCancelado"]); }

                return true;
            }

        }
        public void AtualizarOuCadastrarPedido()
        {
            string dtConcluido = null;
            string dtCancelado = null;
            if (dataConcluido != DateTime.MinValue)
            {
                dtConcluido = dataConcluido.ToString("yyyy-MM-dd");
            }
            if (dataCancelado != DateTime.MinValue)
            {
                dtCancelado = dataCancelado.ToString("yyyy-MM-dd");
            }
            if (id == 0) { id = cmdSQL.AdicionarNovoPedido(cliente_id, dataPedido.ToString("yyyy-MM-dd"), observacao, valorTotalPedido); }
            else { cmdSQL.AtualizarPedido(id, cliente_id, dtConcluido, dtCancelado,cancelado,finalizado,observacao,valorTotalPedido); }
        }
        public void CarregarPedido(int cliente_id, string observacao, decimal valorTotalPedido)
        {
            this.cliente_id = cliente_id;
            this.observacao = observacao;
            this.valorTotalPedido = valorTotalPedido;
        }
        public bool AdicionarProdutoNoPedido(int produto_id,int quantidade,decimal valorUnitario, decimal valorTotal)
        {
            bool retorno = cmdSQL.AdicionarProdutoNoPedido(id, produto_id, quantidade, valorUnitario, valorTotal);

            if (!retorno)
            {
              retorno = cmdSQL.AtualizarProdutoNoPedido(id, produto_id, quantidade, valorUnitario, valorTotal);
            }

            return retorno;
        }
        public DataTable ObterListaProdutosPedido()
        {
            DataTable dtProdutos = new DataTable();
           return dtProdutos = cmdSQL.ObterListaProdutosPedido(id);
        }
        public bool RemoverProdutoNoPedido(int produto_id)
        {
            return cmdSQL.RemoverProdutoNoPedido(id,produto_id);
        }
    }
}
