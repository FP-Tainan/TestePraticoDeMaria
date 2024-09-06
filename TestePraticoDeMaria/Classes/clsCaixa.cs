using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using TestePraticoDeMaria.Classes.DataBase;

namespace TestePraticoDeMaria.Classes
{
    internal class clsCaixa
    {
        public bool entrada { get; private set; }
        public bool saida { get; private set; }
        public decimal valorMovimentacao { get; private set; }
        public string formaPagamento { get; private set; }

        clsComandosSQL cmdSQL = new clsComandosSQL();

        public clsCaixa() { }

        public clsCaixa(bool entrada, bool saida, decimal valorMovimentacao, string formaPagamento)
        {
            this.entrada = entrada;
            this.saida = saida;
            this.valorMovimentacao = valorMovimentacao;
            this.formaPagamento = formaPagamento;
        }

        public bool Salvar(int pedidoId)
        {
            return cmdSQL.SalvarMovimentacaoCaixa(pedidoId, entrada, saida, valorMovimentacao, formaPagamento);
        }
        public DataTable CarregarMovimentacoesPedido(int pedidoId)
        {
            return cmdSQL.ObterMovimentacoesPedido(pedidoId);
        }

        public decimal ValorNoCaixa(int pedidoId)
        {
            decimal valorEntrada = cmdSQL.caixaValorEntradaTotal(pedidoId);
            decimal valorSaida = cmdSQL.caixaValorSaidaTotal(pedidoId);

            return valorEntrada - valorSaida;

            int testeDeCommit = 0;
        }

     

    }
}
