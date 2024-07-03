using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using TestePraticoDeMaria.Classes;

namespace TestePraticoDeMaria.Forms
{
    public partial class frmMenuPrincipal : KryptonForm
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        #region Variaveis e Instâncias

        clsUtilisForm utilisForm = new clsUtilisForm();

        int clienteID = 0;

        #endregion

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

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

        #endregion

        #region Cliente

        private void btnClientePesquisarCEP_Click(object sender, EventArgs e)
        {

        }

        private void btnClientePesquisar_Click(object sender, EventArgs e)
        {

        }


        private void btnClienteNovo_Click(object sender, EventArgs e)
        {
            chkPessoaJuridica.Checked = false;
            cmbClienteEnderecoUf.SelectedIndex = -1;
            utilisForm.LimparTextBoxes(txtClienteNome,txtClienteCpfCnpj,txtClienteEmail,txtClienteTelefoneCelular,txtClienteEnderecoCEP,txtClienteEnderecoLogradouro,txtClienteEnderecoNumero,txtClienteEnderecoComplemento,txtClienteEnderecoLocalidade);
        }

        private void btnClienteSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnClienteAbrirNovoPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnClienteRemover_Click(object sender, EventArgs e)
        {

        }


        #endregion




    }
}
