using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using TestePraticoDeMaria.Classes;
using TestePraticoDeMaria.Classes.Enum;
using TestePraticoDeMaria.Classes.Utils;

namespace TestePraticoDeMaria.Forms
{
    public partial class frmCaixa : KryptonForm
    {
        public int pedidoID { get; private set; }
        public frmCaixa(int pedidoId)
        {
            pedidoID = pedidoId;
            InitializeComponent();
        }

        #region Variaveis e Instâncias
        clsUtilisForm utilisForm = new clsUtilisForm();
        clsPedido pedido = new clsPedido(0, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, false, false, null, 0);
        clsCaixa caixa = new clsCaixa();

        DataTable dtPedidoProdutos = new DataTable();
        DataTable dtMovimentacoes = new DataTable();
        #endregion

        #region Métodos
        private void CarregarFormasPagamento()
        {
            var formasPagamento = Enum.GetValues(typeof(clsFormaPagamento))
                                      .Cast<clsFormaPagamento>()
                                      .ToList();

            cmbFormaPagamento.DataSource = formasPagamento;

            cmbFormaPagamento.SelectedIndex = -1;
        }
        private bool ValidarSalvar()
        {
            if (!utilisForm.VerificarTextBoxesObrigatorios(txtValorMovimentacao)) { return false; }
            if (cmbFormaPagamento.SelectedIndex == -1) { cmbFormaPagamento.Focus(); MessageBox.Show("Selecione a forma de pagamento!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            if (!rbtnSaida.Checked && !rbtnEntrada.Checked) { grbTipoMovimentacao.Focus(); MessageBox.Show("Selecione o tipo de movimentação!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            return true;
        }
        private void SalvarMovimentacao()
        {
             caixa = new clsCaixa(rbtnEntrada.Checked, rbtnSaida.Checked, Convert.ToDecimal(txtValorMovimentacao.Text), cmbFormaPagamento.SelectedValue.ToString());
            if (caixa.Salvar(pedido.id))
            {
                MessageBox.Show("Movimentação Salva!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao salvar Movimentação!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnNovaMovimentacao_Click(null, null);
        }
        private void SomarColunaValorTotal()
        {
            decimal soma = 0;

            foreach (DataGridViewRow row in dgvPedidoProdutos.Rows)
            {
                if (row.Cells["colValorTotal"].Value != null && row.Cells["colValorTotal"].Value != DBNull.Value)
                {
                    decimal valor;
                    if (decimal.TryParse(row.Cells["colValorTotal"].Value.ToString(), out valor))
                    {
                        soma += valor;
                    }
                }
            }

            txtValorTotal.Text = soma.ToString("F2");

        }
        private void SomarColunaQuantidade()
        {
            int soma = 0;

            foreach (DataGridViewRow row in dgvPedidoProdutos.Rows)
            {
                if (row.Cells["colQuantiade"].Value != null && row.Cells["colQuantiade"].Value != DBNull.Value)
                {
                    int valor;
                    if (int.TryParse(row.Cells["colQuantiade"].Value.ToString(), out valor))
                    {
                        soma += valor;
                    }
                }
            }

            txtQuantidadeTotal.Text = soma.ToString();

        }
        private void CarregarListaItensPedido()
        {
            dtPedidoProdutos = pedido.ObterListaProdutosPedido();
            dgvPedidoProdutos.DataSource = dtPedidoProdutos;

        }
        private void CarregarMovimentacoes()
        {
            dtMovimentacoes = caixa.CarregarMovimentacoesPedido(pedidoID);
            dgvCaixaMovimentacoes.DataSource = dtMovimentacoes;
        }
        private void CarregarPedido()
        {
            pedido.Pesquisar(pedidoID);
            txtPedidoNumero.Text = pedidoID.ToString();
            CarregarFormasPagamento();
            CarregarListaItensPedido();
            SomarColunaValorTotal();
            SomarColunaQuantidade();
            CarregarMovimentacoes();
        }

        #endregion

        #region Eventos
        private void frmCaixa_Load(object sender, EventArgs e)
        {
            dgvPedidoProdutos.AutoGenerateColumns = false;
            dgvCaixaMovimentacoes.AutoGenerateColumns = false;
            CarregarPedido();
        }
        private void btnSalvarMovimentacao_Click(object sender, EventArgs e)
        {
            if (!ValidarSalvar()) { return; }
            SalvarMovimentacao();
            CarregarMovimentacoes();
        }
        private void txtValorMovimentacao_TextChanged(object sender, EventArgs e)
        {
            txtValorMovimentacao.Text = utilisForm.ValidarTextoNumerosComSimbolo(txtValorMovimentacao.Text);
            txtValorMovimentacao.SelectionStart = txtValorMovimentacao.Text.Length;
        }
        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {
            txtValorMovimentacao.Text = string.Empty;
            cmbFormaPagamento.SelectedIndex = -1;
            caixa = new clsCaixa();
        }
       
        #endregion
    }
}
