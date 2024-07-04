namespace TestePraticoDeMaria.Forms
{
    partial class frmConfiguracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.krPallet = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnTestarConexao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtBancoDeDados = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorta = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarConfiguracao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpClienteControles = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles.Panel)).BeginInit();
            this.grpClienteControles.Panel.SuspendLayout();
            this.grpClienteControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // krPallet
            // 
            this.krPallet.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.krPallet.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.krPallet.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.Linen;
            this.krPallet.FormStyles.FormCommon.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.krPallet.FormStyles.FormCommon.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.krPallet.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krPallet.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.krPallet.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.Linen;
            this.krPallet.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krPallet.FormStyles.FormMain.StateCommon.Border.Rounding = 18;
            this.krPallet.FormStyles.FormMain.StateInactive.Back.Color1 = System.Drawing.Color.Linen;
            this.krPallet.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.krPallet.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Linen;
            this.krPallet.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(0, 5, 10, -1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servidor:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(27, 26);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(210, 33);
            this.txtServidor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtServidor.StateCommon.Border.Rounding = 18;
            this.txtServidor.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidor.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtServidor.TabIndex = 3;
            // 
            // btnTestarConexao
            // 
            this.btnTestarConexao.Location = new System.Drawing.Point(38, 329);
            this.btnTestarConexao.Name = "btnTestarConexao";
            this.btnTestarConexao.Size = new System.Drawing.Size(184, 48);
            this.btnTestarConexao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTestarConexao.StateCommon.Border.Rounding = 20;
            this.btnTestarConexao.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnTestarConexao.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnTestarConexao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarConexao.TabIndex = 16;
            this.btnTestarConexao.Values.Image = global::TestePraticoDeMaria.Properties.Resources.rede__2_;
            this.btnTestarConexao.Values.Text = "\tTestar Conexão";
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);
            // 
            // txtBancoDeDados
            // 
            this.txtBancoDeDados.Location = new System.Drawing.Point(27, 91);
            this.txtBancoDeDados.Name = "txtBancoDeDados";
            this.txtBancoDeDados.Size = new System.Drawing.Size(210, 33);
            this.txtBancoDeDados.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBancoDeDados.StateCommon.Border.Rounding = 18;
            this.txtBancoDeDados.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBancoDeDados.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBancoDeDados.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banco de Dados:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(27, 156);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 33);
            this.txtUsuario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsuario.StateCommon.Border.Rounding = 18;
            this.txtUsuario.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(27, 221);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(210, 33);
            this.txtSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSenha.StateCommon.Border.Rounding = 18;
            this.txtSenha.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSenha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Senha:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(27, 286);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(210, 33);
            this.txtPorta.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPorta.StateCommon.Border.Rounding = 18;
            this.txtPorta.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPorta.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Porta:";
            // 
            // btnSalvarConfiguracao
            // 
            this.btnSalvarConfiguracao.Location = new System.Drawing.Point(38, 387);
            this.btnSalvarConfiguracao.Name = "btnSalvarConfiguracao";
            this.btnSalvarConfiguracao.Size = new System.Drawing.Size(184, 48);
            this.btnSalvarConfiguracao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvarConfiguracao.StateCommon.Border.Rounding = 20;
            this.btnSalvarConfiguracao.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnSalvarConfiguracao.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnSalvarConfiguracao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConfiguracao.TabIndex = 16;
            this.btnSalvarConfiguracao.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Salvar;
            this.btnSalvarConfiguracao.Values.Text = "\tSalvar";
            this.btnSalvarConfiguracao.Click += new System.EventHandler(this.btnSalvarConfiguracao_Click);
            // 
            // grpClienteControles
            // 
            this.grpClienteControles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClienteControles.CaptionOverlap = 0D;
            this.grpClienteControles.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpClienteControles.Location = new System.Drawing.Point(6, 3);
            this.grpClienteControles.Name = "grpClienteControles";
            // 
            // grpClienteControles.Panel
            // 
            this.grpClienteControles.Panel.Controls.Add(this.txtServidor);
            this.grpClienteControles.Panel.Controls.Add(this.btnSalvarConfiguracao);
            this.grpClienteControles.Panel.Controls.Add(this.txtBancoDeDados);
            this.grpClienteControles.Panel.Controls.Add(this.btnTestarConexao);
            this.grpClienteControles.Panel.Controls.Add(this.txtUsuario);
            this.grpClienteControles.Panel.Controls.Add(this.label5);
            this.grpClienteControles.Panel.Controls.Add(this.txtSenha);
            this.grpClienteControles.Panel.Controls.Add(this.label4);
            this.grpClienteControles.Panel.Controls.Add(this.txtPorta);
            this.grpClienteControles.Panel.Controls.Add(this.label3);
            this.grpClienteControles.Panel.Controls.Add(this.label1);
            this.grpClienteControles.Panel.Controls.Add(this.label2);
            this.grpClienteControles.Size = new System.Drawing.Size(283, 453);
            this.grpClienteControles.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.grpClienteControles.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpClienteControles.StateCommon.Border.Rounding = 20;
            this.grpClienteControles.TabIndex = 17;
            this.grpClienteControles.Values.Heading = "";
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(301, 457);
            this.Controls.Add(this.grpClienteControles);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 496);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(317, 496);
            this.Name = "frmConfiguracao";
            this.Palette = this.krPallet;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar - Banco de Dados";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles.Panel)).EndInit();
            this.grpClienteControles.Panel.ResumeLayout(false);
            this.grpClienteControles.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles)).EndInit();
            this.grpClienteControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette krPallet;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtServidor;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTestarConexao;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBancoDeDados;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPorta;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvarConfiguracao;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpClienteControles;
    }
}