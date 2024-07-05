using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using TestePraticoDeMaria.Classes;
using TestePraticoDeMaria.Classes.Integracoes;
using TestePraticoDeMaria.Classes.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestePraticoDeMaria.Forms
{
    public partial class frmMenuPrincipal : KryptonForm
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        #region Variaveis e Instâncias

        // Instâncias
        clsCliente cliente = new clsCliente(null, null, null, null, false);
        clsendereco endereco = new clsendereco(null, null, 0, null, null, null, null, 0);
        clsProduto produto = new clsProduto(null, 0, 0, null);
        clsPedido pedido = new clsPedido(0, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, false, false, null, 0);
        clsCaixa caixa = new clsCaixa();
        clsUtilisForm utilisForm = new clsUtilisForm();
        clsValidadorCpfCNPJ validadorCpfCNPJ = new clsValidadorCpfCNPJ();
        clsCorreios correios = new clsCorreios();
        clsIBGE ibge = new clsIBGE();
        clsUtilsConsultas consultas = new clsUtilsConsultas();
        clsRelatorios relatorios = new clsRelatorios();

        //Variaveis
        DataTable dtClientes = new DataTable();
        DataTable dtProdutos = new DataTable();
        DataTable dtListaClientes = new DataTable();
        DataTable dtListaProdutos = new DataTable();
        DataTable dtPedidoProdutos = new DataTable();

        #endregion

        #region Métodos

        #region MetodosCliente
        private void ValidarCPFCPNJ()
        {
            bool valido = validadorCpfCNPJ.ValidaCPFCNPJ(txtClienteCpfCnpj.Text); ;

            if (!valido) { txtClienteCpfCnpj.StateCommon.Content.Color1 = Color.Red; }
            else { txtClienteCpfCnpj.StateCommon.Content.Color1 = Color.Green; }
        }
        private void VerificaTipoCPFCNPJ()
        {
            string documento = Regex.Replace(txtClienteCpfCnpj.Text, "[^0-9]", "");

            if (documento.Length <= 11)
                chkPessoaJuridica.Checked = false;
            else if (documento.Length <= 14)
                chkPessoaJuridica.Checked = true;
        }
        private async Task consultarCEP()
        {
            clsendereco endereco = await correios.ConsultaCEPAsync(txtClienteEnderecoCEP.Text);

            txtClienteEnderecoLogradouro.Text = endereco.Logradouro;
            txtClienteEnderecoComplemento.Text = endereco.Complemento;
            txtClienteEnderecoBairro.Text = endereco.Bairro;
            txtClienteEnderecoLocalidade.Text = endereco.Localidade;
            cmbClienteEnderecoUf.SelectedItem = endereco.UF;
        }
        private async void PreencherComboBoxEstados()
        {
            List<string> siglas = await ibge.ConsultarEstadosAsync();
            cmbClienteEnderecoUf.DataSource = siglas;
            cmbClienteEnderecoUf.SelectedIndex = -1;
        }
        private void CarregarGridClientes()
        {
            dtClientes = consultas.ObterListaCompletaClientes();

            if (dtClientes.Rows.Count > 0) { dgvClientePesquisa.DataSource = dtClientes; }

        }
        private void CarregarListaClientes()
        {
            dtListaClientes = consultas.ObterListaCompletaClientes();
            cmbPedidoClientes.ValueMember = "cliente_id";
            cmbPedidoClientes.DisplayMember = "nome";
            cmbPedidoClientes.DataSource = dtListaClientes;
            cmbPedidoClientes.SelectedIndex = -1;
        }
        private void PesquisarCliente()
        {
            dtClientes = cliente.PesquisarCliente(txtClientePesquisa.Text);
            if (dtClientes.Rows.Count > 0) { dgvClientePesquisa.DataSource = dtClientes; }
        }
        private void SalvarCliente()
        {
            this.Cursor = Cursors.WaitCursor;

            VerificaTipoCPFCNPJ();
            if (!string.IsNullOrEmpty(txtClienteEnderecoCEP.Text))
            {
                if (txtClienteEnderecoCEP.Text.Length == 9) { btnClientePesquisarCEP_Click(null, null); }
                else { return; }
            }

            if (cliente.id != 0)
            {
                cliente.CarregarCliente(txtClienteNome.Text, txtClienteCpfCnpj.Text, txtClienteEmail.Text, txtClienteTelefoneCelular.Text, chkPessoaJuridica.Checked, cliente.id);
                if (cliente.AtualizarOuCadastrarCliente())
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Cadastro - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falaha ao atualizar o cliente verifique os campos e tente novmaente", "Cadastro - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cliente = new clsCliente(txtClienteNome.Text, txtClienteCpfCnpj.Text, txtClienteEmail.Text, txtClienteTelefoneCelular.Text, chkPessoaJuridica.Checked);
                if (cliente.AtualizarOuCadastrarCliente())
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falaha ao cadastradar o cliente verifique os campos e tente novmaente", "Cadastro - Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (endereco.id != 0)
            {
                endereco.CarregarEndereco(txtClienteEnderecoCEP.Text, txtClienteEnderecoLogradouro.Text, Convert.ToInt32(txtClienteEnderecoNumero.Text), txtClienteEnderecoComplemento.Text, txtClienteEnderecoBairro.Text, txtClienteEnderecoLocalidade.Text, cmbClienteEnderecoUf.Text, cliente.id, endereco.id);
                endereco.AtualizarOuCadastrarEndereco();
            }
            else
            {
                endereco = new clsendereco(txtClienteEnderecoCEP.Text, txtClienteEnderecoLogradouro.Text, Convert.ToInt32(txtClienteEnderecoNumero.Text), txtClienteEnderecoComplemento.Text, txtClienteEnderecoBairro.Text, txtClienteEnderecoLocalidade.Text, cmbClienteEnderecoUf.Text, cliente.id);
                endereco.AtualizarOuCadastrarEndereco();
            }

            btnClienteNovo_Click(null, null);

            this.Cursor = Cursors.Default;
        }
        private void DeletarCliente()
        {
            if (cliente.id == 0) { return; }

            DialogResult result = MessageBox.Show("Atenção! ao remover o cliente será perdido todo o histórico de vendas para o mesmo! \n Deseja Continuar?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                endereco.DeletarEndereco();
                cliente.DeletarCliente();
                btnClienteNovo_Click(null, null);
            }
        }
        private void CapturarDadosCliente(DataGridViewRow row)
        {

            int clienteId = Convert.ToInt32(row.Cells["colClienteId"].Value);
            bool pj = Convert.ToBoolean(row.Cells["colPessoaJuridica"].Value);
            string nome = row.Cells["colNome"].Value.ToString();
            string cpfCnpj = row.Cells["colCpfCnpj"].Value.ToString();
            string email = row.Cells["colEmail"].Value.ToString();
            string telefone = row.Cells["colTelefoneCelular"].Value.ToString();

            cliente.CarregarCliente(nome, cpfCnpj, email, telefone, pj, clienteId);

            int enderecoId = row.Cells["colEnderecoId"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["colEnderecoId"].Value);
            int numero = row.Cells["colNumero"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["colNumero"].Value);
            string cep = row.Cells["colCep"].Value == DBNull.Value ? string.Empty : row.Cells["colCep"].Value.ToString();
            string logradouro = row.Cells["colLogradouro"].Value == DBNull.Value ? string.Empty : row.Cells["colLogradouro"].Value.ToString();
            string complemento = row.Cells["colComplemento"].Value == DBNull.Value ? string.Empty : row.Cells["colComplemento"].Value.ToString();
            string bairro = row.Cells["colBairro"].Value == DBNull.Value ? string.Empty : row.Cells["colBairro"].Value.ToString();
            string localidade = row.Cells["colLocalidade"].Value == DBNull.Value ? string.Empty : row.Cells["colLocalidade"].Value.ToString();
            string estado = row.Cells["ColEstado"].Value == DBNull.Value ? string.Empty : row.Cells["ColEstado"].Value.ToString();

            if (enderecoId != 0)
            {
                endereco.CarregarEndereco(cep, logradouro, numero, complemento, bairro, localidade, estado,cliente.id,enderecoId);
            }



        }
        private void CarregarDadosCliente()
        {
            txtClienteNome.Text = cliente.Nome;
            txtClienteCpfCnpj.Text = cliente.CpfCnpj;
            chkPessoaJuridica.Checked = cliente.PessoaJuridica;
            txtClienteEmail.Text = cliente.Email;
            txtClienteTelefoneCelular.Text = cliente.TelefoneCelular;

            txtClienteEnderecoCEP.Text = endereco.CEP;
            txtClienteEnderecoLogradouro.Text = endereco.Logradouro;
            txtClienteEnderecoNumero.Text = endereco.Numero.ToString();
            txtClienteEnderecoComplemento.Text = endereco.Complemento;
            txtClienteEnderecoBairro.Text = endereco.Bairro;
            txtClienteEnderecoLocalidade.Text = endereco.Localidade;
            cmbClienteEnderecoUf.SelectedItem = endereco.UF;

        }
        #endregion

        #region MetodosProduto

        private void CarregarGridProdutos()
        {
            dtProdutos = consultas.ObterListaCompletaProdutos();

            if (dtProdutos.Rows.Count > 0) { dgvProdutoPesquisa.DataSource = dtProdutos; }

        }
        private void CarregarListaProdutos()
        {
            dtListaProdutos = consultas.ObterListaCompletaProdutos();
            cmbPedidoProdutos.ValueMember = "id";
            cmbPedidoProdutos.DisplayMember = "produto";
            cmbPedidoProdutos.DataSource = dtListaProdutos;
            cmbPedidoProdutos.SelectedIndex = -1;
            cmbPedidoProdutos.SelectedIndex = -1;
        }
        private void SalvarProduto()
        {
            if (produto.id != 0)
            {
                produto.CarregarProduto(txtProdutoNome.Text, Convert.ToInt32(nudProdutoQuantidadeEstoque.Value), Convert.ToDecimal(txtProdutoPreco.Text), txtProdutoDescricao.Text, produto.id);
                produto.AtualizarOuCadastrarProduto();
            }
            else
            {
                produto = new clsProduto(txtProdutoNome.Text, Convert.ToInt32(nudProdutoQuantidadeEstoque.Value), Convert.ToDecimal(txtProdutoPreco.Text), txtProdutoDescricao.Text);
                produto.AtualizarOuCadastrarProduto();

            }
        }
        private void RemoverProduto()
        {
            if (produto.id == 0) { return; }

            DialogResult result = MessageBox.Show("Atenção! Remover o produto poderá resultar na perca todo o histórico, isso pode afetar os relatórios! \n deseja continuar?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (produto.Deletar()) { MessageBox.Show("Produto Removido com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Falha ao remover Produto! se necessário contate o suporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }
        private void CapturarDadosProduto(DataGridViewRow row)
        {

            int id = Convert.ToInt32(row.Cells["colId"].Value);
            string nome = row.Cells["colProduto"].Value.ToString();
            string descricao = row.Cells["colDescricao"].Value.ToString();
            int quantidade = Convert.ToInt32(row.Cells["colEstoque"].Value);
            decimal valorUnitario = Convert.ToDecimal(row.Cells["colPrecoUnitario"].Value);

            produto.CarregarProduto(nome, quantidade, valorUnitario, descricao, id);
        }
        private void CarregarDadosProduto()
        {
            txtProdutoNome.Text = produto.produto;
            txtProdutoDescricao.Text = produto.descricao;
            txtProdutoPreco.Text = produto.precoUnitario.ToString();
            nudProdutoQuantidadeEstoque.Value = produto.quantidadeEstoque;
        }
        private void PesquisarProduto()
        {
            dtProdutos = produto.PesquisarProduto(txtProdutoPesquisa.Text);
            if (dtProdutos.Rows.Count > 0) { dgvProdutoPesquisa.DataSource = dtProdutos; }
            else { MessageBox.Show("Produto não Localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        #endregion

        #region MetodosVendas

        private void CalcularTotalProduto()
        {
            decimal valor = produto.precoUnitario * nudPedidoProdutoQuantidade.Value;
            txtPedidoProdutoValorTotal.Text = valor.ToString("F2");
        }
        private void SalvarPedido()
        {

            if (pedido.id == 0)
            {
                DialogResult result = MessageBox.Show("Deseja Abrir um novo pedido?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (cmbPedidoClientes.SelectedValue == null && cliente.id == 0)
                    {
                        MessageBox.Show("Selecione um cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (cliente.id != 0)
                    {
                        cmbPedidoClientes.SelectedValue = cliente.id;
                    }

                    txtPedidoDataInclusao.Text = DateTime.Now.ToShortDateString();
                    pedido = new clsPedido(cliente.id, DateTime.Now, DateTime.MinValue, DateTime.MinValue, false, false, null, 0);
                    pedido.AtualizarOuCadastrarPedido();
                    txtPedidoNumero.Text = pedido.id.ToString();
                }
                else { return; }
            }
            else
            {
                pedido.CarregarPedido(cliente.id, txtPedidoObservacao.Text, Convert.ToDecimal(txtPedidoValorTotal.Text));
                pedido.AtualizarOuCadastrarPedido();
            }

            MessageBox.Show("Pedido Salvo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FinalizarPedido()
        {
            if (pedido.id == 0) { return; }

            if (pedido.cancelado)
            {
                MessageBox.Show("Pedido cancelado!\n não é possivel finalizar um pedido cancelado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            DialogResult result = MessageBox.Show("Deseja Finalizar o pedido?\nApós finalizado não é possivel editar-lo!", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!AtualizarEstoque()) { return; }
                pedido.finalizar(); txtPedidoDataFinalizado.Text = DateTime.Now.ToShortDateString();
                btnPedidoSalvar_Click(null, null);

            }
            else { return; }
        }
        private void CancelarPedido()
        {
            if (pedido.id == 0) { return; }
            if (pedido.finalizado)
            {
                MessageBox.Show("Pedido finalizado!\n não é possivel cancelar um pedido finalizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            DialogResult result = MessageBox.Show("Deseja cancelar o pedido?\nApós cancelado não é possivel recupera-lo!", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pedido.Cancelar(); txtPedidoDataCancelado.Text = DateTime.Now.ToShortDateString();
                btnPedidoSalvar_Click(null, null);
            }
            else { return; }

        }
        private void PesquisarPedido()
        {
            btnPedidoNovo_Click(null, null);
            if (string.IsNullOrEmpty(txtPedidoPesquisa.Text)) { return; }

            if (pedido.Pesquisar(Convert.ToInt32(txtPedidoPesquisa.Text)))
            {
                txtPedidoNumero.Text = pedido.id.ToString();
                txtPedidoDataInclusao.Text = pedido.dataPedido.ToShortDateString();
                txtPedidoObservacao.Text = pedido.observacao;
                cmbPedidoClientes.SelectedValue = pedido.cliente_id;

                if (pedido.finalizado) { txtPedidoDataFinalizado.Text = pedido.dataConcluido.ToShortDateString(); }
                if (pedido.cancelado) { txtPedidoDataCancelado.Text = pedido.dataCancelado.ToShortDateString(); }

                CarregarListaItensPedido();
                SomarColunaValorTotal();
                AtualizarResumo();
            }
            else
            {
                MessageBox.Show("Pedido não localizado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CarregarListaItensPedido()
        {
            dtPedidoProdutos = pedido.ObterListaProdutosPedido();
            dgvPedidoProdutos.DataSource = dtPedidoProdutos;

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

            txtPedidoValorTotal.Text = soma.ToString("F2");

        }
        private void CapturarDadosPedidoProduto(DataGridViewRow row)
        {
            cmbPedidoProdutos.SelectedValue = Convert.ToInt32(row.Cells["colProdutoId"].Value);
            txtPedidoProdutoValorTotal.Text = row.Cells["colValorTotal"].Value.ToString();
            nudPedidoProdutoQuantidade.Value = Convert.ToDecimal(row.Cells["colQuantiade"].Value);

        }
        private void PesquisarPedidoProximoOuAnterior(bool proximo)
        {
            int filtro = pedido.id;

            if (proximo) { filtro++; }
            else { filtro--; }

            txtPedidoPesquisa.Text = filtro.ToString();
            PesquisarPedido();
            txtPedidoPesquisa.Text = string.Empty;

        }
        private void AdicionarItemPedido()
        {
            if (pedido.id == 0)
            {
                MessageBox.Show("O pedido ainda não foi aberto!\nSó é possivel adicionar produtos em um pedido aberto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (pedido.cancelado)
            {
                MessageBox.Show("O pedido foi cancelado!\nNão é possivel adicionar produtos em um pedido cancelado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (pedido.finalizado)
            {
                MessageBox.Show("O pedido foi finalizado!\nNão é possivel adicionar produtos em um pedido finalizado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (produto.id == 0)
            {
                MessageBox.Show("Selecione um Produto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPedidoProdutos.Focus();
                return;
            }
            if (pedido.AdicionarProdutoNoPedido(produto.id, Convert.ToInt32(nudPedidoProdutoQuantidade.Value), produto.precoUnitario, Convert.ToDecimal(txtPedidoProdutoValorTotal.Text)))
            {
                cmbPedidoProdutos.SelectedIndex = -1;
                nudPedidoProdutoQuantidade.Value = 1;
                cmbPedidoProdutos.SelectedIndex = -1;
                produto.Limpar();
                utilisForm.LimparTextBoxes(txtPedidoProdutoValorUnitario, txtPedidoProdutoValorTotal);
                CarregarListaItensPedido();
            }
            else
            {
                MessageBox.Show("Não foi possivel adicionar/Atualizar o produto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void RemoverItemPedido()
        {
            if (pedido.id == 0)
            {
                MessageBox.Show("Nenhum Pedido Selecionado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (pedido.cancelado)
            {
                MessageBox.Show("O pedido foi cancelado!\nNão é possivel remover produtos em um pedido cancelado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (pedido.finalizado)
            {
                MessageBox.Show("O pedido foi finalizado!\nNão é possivel remover produtos em um pedido finalizado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (produto.id == 0)
            {
                MessageBox.Show("Selecione um Produto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvPedidoProdutos.Focus();
                return;
            }
            if (pedido.RemoverProdutoNoPedido(produto.id))
            {
                cmbPedidoProdutos.SelectedIndex = -1;
                nudPedidoProdutoQuantidade.Value = 1;
                cmbPedidoProdutos.SelectedIndex = -1;
                produto.Limpar();
                utilisForm.LimparTextBoxes(txtPedidoProdutoValorUnitario, txtPedidoProdutoValorTotal);
                CarregarListaItensPedido();
            }
            else
            {
                MessageBox.Show("Não foi possivel Remover o produto!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CarregarProdutoSelecionado()
        {
            if (cmbPedidoProdutos.SelectedIndex != -1)
            {
                produto.CarregarProduto(Convert.ToInt32(cmbPedidoProdutos.SelectedValue));
                txtPedidoProdutoValorUnitario.Text = produto.precoUnitario.ToString("F2");
                txtPedidoProdutoValorTotal.Text = produto.precoUnitario.ToString("F2");
                if (produto.quantidadeEstoque > 0)
                {
                    nudPedidoProdutoQuantidade.Value = 1;
                }
               
            }
        }
        private void AtualizarResumo()
        {
            decimal valorNoCaixa = caixa.ValorNoCaixa(pedido.id);
            decimal saldo = 0;
            if (valorNoCaixa > 0) { saldo = valorNoCaixa - pedido.valorTotalPedido; }

            txtPedidoSaldo.Text = saldo.ToString("F2");
            txtPedidoValorPago.Text = valorNoCaixa.ToString("F2");


            if (saldo < 0) { txtPedidoSaldo.StateCommon.Content.Color1 = Color.Red; }
            else if (saldo > 0) { txtPedidoSaldo.StateCommon.Content.Color1 = Color.Green; }
            else { txtPedidoSaldo.StateCommon.Content.Color1 = Color.Black; }
        }
        private bool AtualizarEstoque()
        {
            if (pedido.id == 0) { return false; }

            dtListaProdutos = pedido.ObterListaProdutosPedido();
            int quantidadeSaida = 0;
            int quantidadeEstoque = 0;
            int estoqueAtual = 0;
            foreach (DataRow row in dtListaProdutos.Rows)
            {
                produto.CarregarProduto(Convert.ToInt32(row["produtos_id"]));
                quantidadeEstoque = produto.quantidadeEstoque;
                quantidadeSaida = Convert.ToInt32(row["quantidade"]);

                if (quantidadeSaida > quantidadeEstoque)
                {
                    MessageBox.Show($"Não é possivel finalizar o pedido pois a quantidade de {produto.produto} é maior que a em estoque!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                estoqueAtual = quantidadeEstoque - quantidadeSaida;
                produto.CarregarProduto(produto.produto, estoqueAtual, produto.precoUnitario, produto.descricao, produto.id);
                produto.AtualizarOuCadastrarProduto();
            }

            return true;

        }

        #endregion

        #endregion

        #region Eventos

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            dgvClientePesquisa.AutoGenerateColumns = false;
            dgvProdutoPesquisa.AutoGenerateColumns = false;
            dgvPedidoProdutos.AutoGenerateColumns = false;

            this.rvwRelatorios.Refresh();

            PreencherComboBoxEstados();
            CarregarGridClientes();
            CarregarGridProdutos();
            CarregarListaClientes();
            CarregarListaProdutos();

            btnPedidoNovo_Click(null, null);
            produto.Limpar();
            cliente.Limpar();
            produto.Limpar();
        }

        #region Menu
        private void btnClientes_Click(object sender, EventArgs e)
        {
            tabInterface.SelectedTab = tabInterface.TabPages["tpCliente"];
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            tabInterface.SelectedTab = tabInterface.TabPages["tpProdutos"];
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            tabInterface.SelectedTab = tabInterface.TabPages["tpVenda"];
            btnPedidoNovo_Click(null, null);
        }
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            tabInterface.SelectedTab = tabInterface.TabPages["tpRelatorios"];
        }
        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frmConfiguracao frmConfig = new frmConfiguracao();
            frmConfig.ShowDialog();
        }

        #endregion

        #region EventosCliente

        private async void btnClientePesquisarCEP_Click(object sender, EventArgs e)
        {

            await consultarCEP();
        }
        private void btnClientePesquisar_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }
        private void btnClienteNovo_Click(object sender, EventArgs e)
        {
            cmbClienteEnderecoUf.SelectedIndex = -1;
            chkPessoaJuridica.Checked = false;
            utilisForm.LimparTextBoxes(txtClienteNome, txtClienteCpfCnpj, txtClienteEmail, txtClienteTelefoneCelular, txtClienteEnderecoCEP, txtClienteEnderecoLogradouro, txtClienteEnderecoNumero, txtClienteEnderecoComplemento, txtClienteEnderecoLocalidade, txtClienteEnderecoBairro);
            cmbClienteEnderecoUf.SelectedIndex = -1;
            cliente.Limpar();
            endereco.Limpar();

        }
        private void btnClienteSalvar_Click(object sender, EventArgs e)
        {
            if (!utilisForm.VerificarTextBoxesObrigatorios(txtClienteNome, txtClienteCpfCnpj, txtClienteEmail, txtClienteEnderecoCEP)) { return; }
            SalvarCliente();
            CarregarGridClientes();
            CarregarListaClientes();
        }
        private void btnClienteAbrirNovoPedido_Click(object sender, EventArgs e)
        {
            if (cliente.id == 0)
            {
                MessageBox.Show("Nenhum cliente Selecionado!", "Gestor - Abrir Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tabInterface.SelectedTab = tabInterface.TabPages["tpVenda"];
                cmbPedidoClientes.SelectedValue = cliente.id;

            }
        }
        private void btnClienteRemover_Click(object sender, EventArgs e)
        {
            DeletarCliente();
            CarregarGridClientes();
            CarregarListaClientes();
        }
        private void txtClienteCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            txtClienteCpfCnpj.Text = utilisForm.ValidarTextoNumerosComSimbolo(txtClienteCpfCnpj.Text);
            txtClienteCpfCnpj.Text = validadorCpfCNPJ.FormatarCPFCNPJ(txtClienteCpfCnpj.Text);
            txtClienteCpfCnpj.SelectionStart = txtClienteCpfCnpj.Text.Length;
            ValidarCPFCPNJ();
        }
        private void txtClienteTelefoneCelular_TextChanged(object sender, EventArgs e)
        {

            txtClienteTelefoneCelular.Text = utilisForm.ValidarEFormatarTelefones(txtClienteTelefoneCelular.Text);
            txtClienteTelefoneCelular.SelectionStart = txtClienteTelefoneCelular.Text.Length;

        }
        private void txtClienteEnderecoNumero_TextChanged(object sender, EventArgs e)
        {
            txtClienteEnderecoNumero.Text = utilisForm.ValidarTextoNumeros(txtClienteEnderecoNumero.Text);
            txtClienteEnderecoNumero.SelectionStart = txtClienteEnderecoNumero.Text.Length;
        }
        private void txtClienteEnderecoCEP_TextChanged(object sender, EventArgs e)
        {
            txtClienteEnderecoCEP.Text = utilisForm.ValidarEFormatarCEP(txtClienteEnderecoCEP.Text);
            txtClienteEnderecoCEP.SelectionStart = txtClienteEnderecoCEP.Text.Length;
        }
        private void txtClientePesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtClientePesquisa.Text.Length <= 0)
            {
                CarregarGridClientes();
            }
        }
        private void dgvClientePesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientePesquisa.Rows[e.RowIndex];
                CapturarDadosCliente(row);
                CarregarDadosCliente();
            }

        }

        #endregion

        #region EventosProduto
        private void btnProdutoNovo_Click(object sender, EventArgs e)
        {
            produto.Limpar();
            utilisForm.LimparTextBoxes(txtProdutoNome, txtProdutoPreco, txtProdutoDescricao);
            nudProdutoQuantidadeEstoque.Value = 0;

        }
        private void btnProdutoSalvar_Click(object sender, EventArgs e)
        {
            if (!utilisForm.VerificarTextBoxesObrigatorios(txtProdutoNome, txtProdutoPreco)) { return; }
            SalvarProduto();
            CarregarListaProdutos();
            CarregarGridProdutos();
            btnProdutoNovo_Click(null, null);
        }
        private void btnProdutoRemover_Click(object sender, EventArgs e)
        {
            RemoverProduto();
            CarregarListaProdutos();
            CarregarGridProdutos();
            btnProdutoNovo_Click(null, null);
        }
        private void txtProdutoPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProdutoPesquisa.Text)) { CarregarGridProdutos(); }
        }
        private void dgvProdutoPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutoPesquisa.Rows[e.RowIndex];
                CapturarDadosProduto(row);
                CarregarDadosProduto();
            }
        }
        private void btnProdutoPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }
        private void txtProdutoPreco_TextChanged(object sender, EventArgs e)
        {
            txtProdutoPreco.Text = utilisForm.ValidarTextoNumerosComSimbolo(txtProdutoPreco.Text);
            txtProdutoPreco.SelectionStart = txtProdutoPreco.Text.Length;
        }

        #endregion

        #region EventosVendas

        private void btnPedidoNovo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            dtPedidoProdutos.Clear();
            cmbPedidoClientes.SelectedIndex = -1;
            cmbPedidoProdutos.SelectedIndex = -1;
            nudPedidoProdutoQuantidade.Value = 1;
            produto.Limpar();
            pedido.Limpar();
            cliente.Limpar();
            utilisForm.LimparTextBoxes(txtPedidoNumero, txtPedidoObservacao, txtPedidoProdutoValorTotal, txtPedidoProdutoValorUnitario, txtPedidoValorTotal, txtPedidoValorPago, txtPedidoSaldo, txtPedidoDataInclusao, txtPedidoDataFinalizado, txtPedidoDataCancelado);
            cmbPedidoClientes.SelectedIndex = -1;
            cmbPedidoProdutos.SelectedIndex = -1;
            this.Cursor = Cursors.Default;
        }
        private void btnPedidoSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            SalvarPedido();

            this.Cursor = Cursors.Default;
        }
        private void nudPedidoProdutoQuantidade_ValueChanged(object sender, EventArgs e)
        {

            if (produto.id == 0)
            {
                MessageBox.Show($"Selecione um produto!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudPedidoProdutoQuantidade.Value == 0)
            {
                nudPedidoProdutoQuantidade.Value = 1;
                return;
            }

            if (nudPedidoProdutoQuantidade.Value > produto.quantidadeEstoque)
            {
                if (produto.quantidadeEstoque == 0)
                {
                    MessageBox.Show($"Produto: {produto.produto} sem estoque!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show($"Quantidade máxima atingida, só existem {produto.quantidadeEstoque} unidades do produto: {produto.produto} em estoque!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudPedidoProdutoQuantidade.Value = produto.quantidadeEstoque;

                }

                return;
            }
            CalcularTotalProduto();
        }
        private void cmbPedidoProdutos_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregarProdutoSelecionado();
        }
        private void btnPedidoCaixa_Click(object sender, EventArgs e)
        {
            if (pedido.id == 0) { return; }
            frmCaixa frm = new frmCaixa(pedido.id);
            frm.ShowDialog();
            AtualizarResumo();

        }
        private void btnPedidoFinalizar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Convert.ToDecimal(txtPedidoSaldo.Text) != 0)
            {
                MessageBox.Show("Para Finalizar a venda, acerte o caixa!, não é possivel finalizar com saldo pendente de troco ou recebimento!","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }

            FinalizarPedido();
            this.Cursor = Cursors.Default;
        }
        private void btnPedidoCancelar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            CancelarPedido();

            this.Cursor = Cursors.Default;
        }
        private void btnPedidoSalvarProduto_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            AdicionarItemPedido();
            SomarColunaValorTotal();
            SalvarPedido();
            AtualizarResumo();
            this.Cursor = Cursors.Default;
        }
        private void btnPedidoRemoverProduto_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            RemoverItemPedido();
            SalvarPedido();
            SomarColunaValorTotal();
            AtualizarResumo();
            this.Cursor = Cursors.Default;
        }
        private void btnPedidoVoltar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            PesquisarPedidoProximoOuAnterior(false);
            this.Cursor = Cursors.Default;
        }
        private void btnPedidoAvancar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            PesquisarPedidoProximoOuAnterior(true);
            this.Cursor = Cursors.Default;
        }
        private void btnPedidoPesquisar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            PesquisarPedido();
            this.Cursor = Cursors.Default;
        }
        private void dgvPedidoProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPedidoProdutos.Rows[e.RowIndex];
                CapturarDadosPedidoProduto(row);
            }
        }
        private void cmbPedidoClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPedidoClientes.SelectedIndex != -1)
            {
                cliente.CarregarCliente(Convert.ToInt32(cmbPedidoClientes.SelectedValue));
            }
        }
        #endregion

        #region EventosRelatorios
        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (lstRelatorios.SelectedItem is null) { MessageBox.Show("selecione um relatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            string relatorio = lstRelatorios.SelectedItem.ToString();

            relatorios.CarregarRelatorio(rvwRelatorios, relatorio,dtpDataInicial.Value.ToString("yyyy-MM-dd"), dtpDataFinal.Value.ToString("yyyy-MM-dd"));

            this.Cursor = Cursors.Default;
        }

        private void lstRelatorios_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstRelatorios.SelectedItem.ToString() == "Vendas Finalizadas") { dtpDataFinal.Enabled = true; dtpDataInicial.Enabled = true; }
            else { dtpDataFinal.Enabled = false; dtpDataInicial.Enabled = false; }
        }
        #endregion

        #endregion


    }
}
