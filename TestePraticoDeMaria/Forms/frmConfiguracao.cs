using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using TestePraticoDeMaria.Classes.DataBase;
using System.Windows.Forms;

namespace TestePraticoDeMaria.Forms
{
    public partial class frmConfiguracao : KryptonForm
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        string servidor = string.Empty;
        string bancoDeDados = string.Empty;
        string usuario = string.Empty;
        string senha = string.Empty;
        string porta = string.Empty;

        clsConexaoDB clsConexao = new clsConexaoDB();

        private bool ValidarCampos()
        {
             servidor = txtServidor.Text;
             bancoDeDados = txtBancoDeDados.Text;
             usuario = txtUsuario.Text;
             senha = txtSenha.Text;

            if (string.IsNullOrEmpty(servidor))
            {
                MessageBox.Show("Faltou preencher o servidor", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtServidor.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(bancoDeDados))
            {
                MessageBox.Show("Faltou preencher o banco de dados", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBancoDeDados.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Faltou preencher o usuário", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Faltou preencher o senha", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Focus();
                return false;
            }

            return true;
        }

        private void CarregarConfig()
        {
           clsConexao = clsConexao.CarregarConfiguracao();
            txtServidor.Text = clsConexao.Servidor;
            txtBancoDeDados.Text = clsConexao.BancoDeDados;
            txtUsuario.Text = clsConexao.Usuario;
            txtSenha.Text = clsConexao.Senha;
            txtPorta.Text = clsConexao.Porta.ToString();
        }


        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            CarregarConfig();
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (!ValidarCampos()) { return; }

             servidor = txtServidor.Text;
             bancoDeDados = txtBancoDeDados.Text;
             usuario = txtUsuario.Text;
             senha = txtSenha.Text;
             porta = txtPorta.Text;

            if (string.IsNullOrEmpty(porta))
            {
               clsConexao = new clsConexaoDB(servidor,bancoDeDados,usuario,senha);
               MessageBox.Show(clsConexao.TestarConexao(),"Configuração",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsConexao = new clsConexaoDB(servidor, bancoDeDados, usuario, senha,Convert.ToInt32(porta));
                MessageBox.Show(clsConexao.TestarConexao(), "Configuração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Cursor= Cursors.Default;
        }

        private void btnSalvarConfiguracao_Click(object sender, EventArgs e)
        {
            servidor = txtServidor.Text;
            bancoDeDados = txtBancoDeDados.Text;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            porta = txtPorta.Text;

            if (string.IsNullOrEmpty(porta))
            {
                clsConexao = new clsConexaoDB(servidor, bancoDeDados, usuario, senha);
                clsConexao.SalvarConfiguracao();  
            }
            else
            {
                clsConexao = new clsConexaoDB(servidor, bancoDeDados, usuario, senha, Convert.ToInt32(porta));
                clsConexao.SalvarConfiguracao();
            }
        }
    }
}
