using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
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
        clsUtilisForm utilisForm = new clsUtilisForm();
        clsValidadorCpfCNPJ validadorCpfCNPJ = new clsValidadorCpfCNPJ();
        clsCorreios correios = new clsCorreios();
        clsIBGE ibge = new clsIBGE();
        clsUtilsConsultas consultas = new clsUtilsConsultas();

        //Variaveis
        DataTable dtListaClientes = new DataTable();


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
        private void CarregarListaClientes()
        {
            dtListaClientes = consultas.ObterListaCompletaClientes();

            if (dtListaClientes.Rows.Count > 0) { dgvClientePesquisa.DataSource = dtListaClientes; }

        }
        private void PesquisarCliente()
        {
            dtListaClientes = cliente.PesquisarCliente(txtClientePesquisa.Text);
            if (dtListaClientes.Rows.Count > 0) { dgvClientePesquisa.DataSource = dtListaClientes; }
        }
        private void SalvarCliente()
        {
            this.Cursor = Cursors.WaitCursor;
            VerificaTipoCPFCNPJ();

            if (cliente.id != 0)
            {
                cliente.CarregarCliente(txtClienteNome.Text, txtClienteCpfCnpj.Text, txtClienteEmail.Text, txtClienteTelefoneCelular.Text, chkPessoaJuridica.Checked, cliente.id);
                cliente.AtualizarOuCadastrarCliente();
            }
            else
            {
                cliente = new clsCliente(txtClienteNome.Text, txtClienteCpfCnpj.Text, txtClienteEmail.Text, txtClienteTelefoneCelular.Text, chkPessoaJuridica.Checked);
                cliente.AtualizarOuCadastrarCliente();
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
            DialogResult result = MessageBox.Show("Atenção! ao remover o cliente será perdido todo o histórico de vendas para o mesmo! \n Deseja Continuar?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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


            int enderecoId = Convert.ToInt32(row.Cells["colEnderecoId"].Value);
            int numero = Convert.ToInt32(row.Cells["colNumero"].Value);
            string cep = row.Cells["colCep"].Value.ToString();
            string logradouro = row.Cells["colLogradouro"].Value.ToString();
            string complemento = row.Cells["colComplemento"].Value.ToString();
            string bairro = row.Cells["colBairro"].Value.ToString();
            string localidade = row.Cells["colLocalidade"].Value.ToString();
            string estado = row.Cells["ColEstado"].Value.ToString();

            endereco.CarregarEndereco(cep, logradouro, numero, complemento, bairro, localidade, estado, clienteId, enderecoId);

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
       
        #endregion

        #region Eventos

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            PreencherComboBoxEstados();
            CarregarListaClientes();
            dgvClientePesquisa.AutoGenerateColumns = false;
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
            SalvarCliente();
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
            }
        }
        private void btnClienteRemover_Click(object sender, EventArgs e)
        {
            DeletarCliente();
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
            txtClienteEnderecoCEP.Text = utilisForm.ValidarTextoNumerosComSimbolo(txtClienteEnderecoCEP.Text);
            txtClienteEnderecoCEP.SelectionStart = txtClienteEnderecoCEP.Text.Length;
        }
        private void txtClientePesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtClientePesquisa.Text.Length <= 0)
            {
                CarregarListaClientes();
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

        #endregion


    }
}
