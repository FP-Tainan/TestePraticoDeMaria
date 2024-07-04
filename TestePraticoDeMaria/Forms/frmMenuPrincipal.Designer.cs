namespace TestePraticoDeMaria.Forms
{
    partial class frmMenuPrincipal
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
            this.tabInterface = new System.Windows.Forms.TabControl();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.tpCliente = new System.Windows.Forms.TabPage();
            this.dgvClientePesquisa = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPessoaJuridica = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDadosCliente = new System.Windows.Forms.GroupBox();
            this.cmbClienteEnderecoUf = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClientePesquisarCEP = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPessoaJuridica = new System.Windows.Forms.CheckBox();
            this.txtClienteEnderecoNumero = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteEnderecoComplemento = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteTelefoneCelular = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteEnderecoCEP = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteCpfCnpj = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteEnderecoLocalidade = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteEnderecoBairro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteEnderecoLogradouro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtClienteNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grpClienteControles = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnClienteAbrirNovoPedido = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClienteRemover = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClienteSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClienteNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtClientePesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnClientePesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label13 = new System.Windows.Forms.Label();
            this.tpProdutos = new System.Windows.Forms.TabPage();
            this.dgvProdutoPesquisa = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudProdutoQuantidadeEstoque = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProdutoPreco = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProdutoNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grpProdutoControles = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnProdutoRemover = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProdutoSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProdutoNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtProdutoPesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnProdutoPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label26 = new System.Windows.Forms.Label();
            this.tpVenda = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.kryptonTextBox5 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoValorTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtPedidoPesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton9 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvPedidoProdutos = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.kryptonButton5 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbPedidoProdutos = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPedidoProdutoValorTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoProdutoValorUnitario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nudPedidoProdutoQuantidade = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPedidoObservacao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbPedidoClientes = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.kryptonTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoNumero = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tpRelatorios = new System.Windows.Forms.TabPage();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kryptonButton8 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClientes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProdutos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVendas = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRelatorios = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpNavMenu = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnConfiguracao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.colProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantiade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabInterface.SuspendLayout();
            this.tpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientePesquisa)).BeginInit();
            this.grpDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClienteEnderecoUf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles.Panel)).BeginInit();
            this.grpClienteControles.Panel.SuspendLayout();
            this.grpClienteControles.SuspendLayout();
            this.tpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoPesquisa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles.Panel)).BeginInit();
            this.grpProdutoControles.Panel.SuspendLayout();
            this.grpProdutoControles.SuspendLayout();
            this.tpVenda.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPedidoProdutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPedidoClientes)).BeginInit();
            this.tpRelatorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpNavMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNavMenu.Panel)).BeginInit();
            this.grpNavMenu.Panel.SuspendLayout();
            this.grpNavMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // krPallet
            // 
            this.krPallet.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.krPallet.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.krPallet.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.krPallet.FormStyles.FormMain.StateCommon.Border.Rounding = 18;
            this.krPallet.FormStyles.FormMain.StateInactive.Back.Color1 = System.Drawing.Color.White;
            this.krPallet.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.krPallet.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.krPallet.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(0, 5, 10, -1);
            // 
            // tabInterface
            // 
            this.tabInterface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabInterface.Controls.Add(this.tpMenu);
            this.tabInterface.Controls.Add(this.tpCliente);
            this.tabInterface.Controls.Add(this.tpProdutos);
            this.tabInterface.Controls.Add(this.tpVenda);
            this.tabInterface.Controls.Add(this.tpRelatorios);
            this.tabInterface.Location = new System.Drawing.Point(33, 58);
            this.tabInterface.Name = "tabInterface";
            this.tabInterface.SelectedIndex = 0;
            this.tabInterface.Size = new System.Drawing.Size(1205, 594);
            this.tabInterface.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.Location = new System.Drawing.Point(4, 25);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(1197, 565);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.dgvClientePesquisa);
            this.tpCliente.Controls.Add(this.label3);
            this.tpCliente.Controls.Add(this.grpDadosCliente);
            this.tpCliente.Controls.Add(this.grpClienteControles);
            this.tpCliente.Controls.Add(this.txtClientePesquisa);
            this.tpCliente.Controls.Add(this.btnClientePesquisar);
            this.tpCliente.Controls.Add(this.label13);
            this.tpCliente.Location = new System.Drawing.Point(4, 25);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(1197, 565);
            this.tpCliente.TabIndex = 1;
            this.tpCliente.Text = "Clientes";
            this.tpCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientePesquisa
            // 
            this.dgvClientePesquisa.AllowUserToAddRows = false;
            this.dgvClientePesquisa.AllowUserToDeleteRows = false;
            this.dgvClientePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientePesquisa.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvClientePesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientePesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colCpfCnpj,
            this.colPessoaJuridica,
            this.colEmail,
            this.colTelefoneCelular,
            this.colCep,
            this.colLogradouro,
            this.colNumero,
            this.colComplemento,
            this.colBairro,
            this.colLocalidade,
            this.ColEstado,
            this.colClienteId,
            this.colEnderecoId});
            this.dgvClientePesquisa.Location = new System.Drawing.Point(19, 406);
            this.dgvClientePesquisa.MultiSelect = false;
            this.dgvClientePesquisa.Name = "dgvClientePesquisa";
            this.dgvClientePesquisa.ReadOnly = true;
            this.dgvClientePesquisa.Size = new System.Drawing.Size(1157, 145);
            this.dgvClientePesquisa.TabIndex = 5;
            this.dgvClientePesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientePesquisa_CellClick);
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 250;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colCpfCnpj
            // 
            this.colCpfCnpj.DataPropertyName = "cpfcnpj";
            this.colCpfCnpj.HeaderText = "CPF / CNPJ";
            this.colCpfCnpj.Name = "colCpfCnpj";
            this.colCpfCnpj.ReadOnly = true;
            this.colCpfCnpj.Width = 150;
            // 
            // colPessoaJuridica
            // 
            this.colPessoaJuridica.DataPropertyName = "PessoaJuridica";
            this.colPessoaJuridica.HeaderText = "Pessoa Juridica";
            this.colPessoaJuridica.Name = "colPessoaJuridica";
            this.colPessoaJuridica.ReadOnly = true;
            this.colPessoaJuridica.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 69;
            // 
            // colTelefoneCelular
            // 
            this.colTelefoneCelular.DataPropertyName = "telefone";
            this.colTelefoneCelular.HeaderText = "Telefone / Celular";
            this.colTelefoneCelular.Name = "colTelefoneCelular";
            this.colTelefoneCelular.ReadOnly = true;
            this.colTelefoneCelular.Width = 150;
            // 
            // colCep
            // 
            this.colCep.DataPropertyName = "cep";
            this.colCep.HeaderText = "CEP";
            this.colCep.Name = "colCep";
            this.colCep.ReadOnly = true;
            // 
            // colLogradouro
            // 
            this.colLogradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLogradouro.DataPropertyName = "logradouro";
            this.colLogradouro.HeaderText = "Logradouro";
            this.colLogradouro.Name = "colLogradouro";
            this.colLogradouro.ReadOnly = true;
            this.colLogradouro.Width = 96;
            // 
            // colNumero
            // 
            this.colNumero.DataPropertyName = "numero";
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            // 
            // colComplemento
            // 
            this.colComplemento.DataPropertyName = "numeroComplemento";
            this.colComplemento.HeaderText = "Complemento";
            this.colComplemento.Name = "colComplemento";
            this.colComplemento.ReadOnly = true;
            // 
            // colBairro
            // 
            this.colBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBairro.DataPropertyName = "bairro";
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Width = 66;
            // 
            // colLocalidade
            // 
            this.colLocalidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLocalidade.DataPropertyName = "localidade";
            this.colLocalidade.HeaderText = "Localidade";
            this.colLocalidade.Name = "colLocalidade";
            this.colLocalidade.ReadOnly = true;
            this.colLocalidade.Width = 94;
            // 
            // ColEstado
            // 
            this.ColEstado.DataPropertyName = "uf";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // colClienteId
            // 
            this.colClienteId.DataPropertyName = "cliente_id";
            this.colClienteId.HeaderText = "Cliente_id";
            this.colClienteId.Name = "colClienteId";
            this.colClienteId.ReadOnly = true;
            this.colClienteId.Visible = false;
            // 
            // colEnderecoId
            // 
            this.colEnderecoId.DataPropertyName = "endereco_id";
            this.colEnderecoId.HeaderText = "Endereco_id";
            this.colEnderecoId.Name = "colEnderecoId";
            this.colEnderecoId.ReadOnly = true;
            this.colEnderecoId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesquisar Cliente (Nome, CPF ou CNPJ)";
            // 
            // grpDadosCliente
            // 
            this.grpDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosCliente.Controls.Add(this.cmbClienteEnderecoUf);
            this.grpDadosCliente.Controls.Add(this.label9);
            this.grpDadosCliente.Controls.Add(this.label6);
            this.grpDadosCliente.Controls.Add(this.label2);
            this.grpDadosCliente.Controls.Add(this.label12);
            this.grpDadosCliente.Controls.Add(this.label8);
            this.grpDadosCliente.Controls.Add(this.label5);
            this.grpDadosCliente.Controls.Add(this.label11);
            this.grpDadosCliente.Controls.Add(this.label10);
            this.grpDadosCliente.Controls.Add(this.label7);
            this.grpDadosCliente.Controls.Add(this.label4);
            this.grpDadosCliente.Controls.Add(this.btnClientePesquisarCEP);
            this.grpDadosCliente.Controls.Add(this.label1);
            this.grpDadosCliente.Controls.Add(this.chkPessoaJuridica);
            this.grpDadosCliente.Controls.Add(this.txtClienteEnderecoNumero);
            this.grpDadosCliente.Controls.Add(this.txtClienteEnderecoComplemento);
            this.grpDadosCliente.Controls.Add(this.txtClienteTelefoneCelular);
            this.grpDadosCliente.Controls.Add(this.txtClienteEnderecoCEP);
            this.grpDadosCliente.Controls.Add(this.txtClienteCpfCnpj);
            this.grpDadosCliente.Controls.Add(this.txtClienteEnderecoLocalidade);
            this.grpDadosCliente.Controls.Add(this.txtClienteEnderecoBairro);
            this.grpDadosCliente.Controls.Add(this.txtClienteEnderecoLogradouro);
            this.grpDadosCliente.Controls.Add(this.txtClienteEmail);
            this.grpDadosCliente.Controls.Add(this.txtClienteNome);
            this.grpDadosCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosCliente.Location = new System.Drawing.Point(19, 75);
            this.grpDadosCliente.Name = "grpDadosCliente";
            this.grpDadosCliente.Size = new System.Drawing.Size(868, 295);
            this.grpDadosCliente.TabIndex = 2;
            this.grpDadosCliente.TabStop = false;
            this.grpDadosCliente.Text = "Dados do Cliente";
            // 
            // cmbClienteEnderecoUf
            // 
            this.cmbClienteEnderecoUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClienteEnderecoUf.DropDownWidth = 60;
            this.cmbClienteEnderecoUf.Location = new System.Drawing.Point(746, 251);
            this.cmbClienteEnderecoUf.Name = "cmbClienteEnderecoUf";
            this.cmbClienteEnderecoUf.Size = new System.Drawing.Size(66, 30);
            this.cmbClienteEnderecoUf.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbClienteEnderecoUf.StateCommon.ComboBox.Border.Rounding = 10;
            this.cmbClienteEnderecoUf.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cmbClienteEnderecoUf.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbClienteEnderecoUf.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "CEP:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF / CNPJ:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(755, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "UF:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefone / Celular:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Localidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Logradouro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-mail:";
            // 
            // btnClientePesquisarCEP
            // 
            this.btnClientePesquisarCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientePesquisarCEP.Location = new System.Drawing.Point(761, 116);
            this.btnClientePesquisarCEP.Name = "btnClientePesquisarCEP";
            this.btnClientePesquisarCEP.Size = new System.Drawing.Size(51, 48);
            this.btnClientePesquisarCEP.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClientePesquisarCEP.StateCommon.Border.Rounding = 20;
            this.btnClientePesquisarCEP.TabIndex = 6;
            this.btnClientePesquisarCEP.Values.Image = global::TestePraticoDeMaria.Properties.Resources.pesquisar__2_;
            this.btnClientePesquisarCEP.Values.Text = "";
            this.btnClientePesquisarCEP.Click += new System.EventHandler(this.btnClientePesquisarCEP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome completo:";
            // 
            // chkPessoaJuridica
            // 
            this.chkPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPessoaJuridica.AutoSize = true;
            this.chkPessoaJuridica.Location = new System.Drawing.Point(687, 62);
            this.chkPessoaJuridica.Name = "chkPessoaJuridica";
            this.chkPessoaJuridica.Size = new System.Drawing.Size(126, 20);
            this.chkPessoaJuridica.TabIndex = 2;
            this.chkPessoaJuridica.Text = "Pessoa Juridica";
            this.chkPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // txtClienteEnderecoNumero
            // 
            this.txtClienteEnderecoNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEnderecoNumero.Location = new System.Drawing.Point(326, 185);
            this.txtClienteEnderecoNumero.Name = "txtClienteEnderecoNumero";
            this.txtClienteEnderecoNumero.Size = new System.Drawing.Size(96, 33);
            this.txtClienteEnderecoNumero.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteEnderecoNumero.StateCommon.Border.Rounding = 18;
            this.txtClienteEnderecoNumero.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEnderecoNumero.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteEnderecoNumero.TabIndex = 8;
            this.txtClienteEnderecoNumero.TextChanged += new System.EventHandler(this.txtClienteEnderecoNumero_TextChanged);
            // 
            // txtClienteEnderecoComplemento
            // 
            this.txtClienteEnderecoComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEnderecoComplemento.Location = new System.Drawing.Point(435, 185);
            this.txtClienteEnderecoComplemento.Name = "txtClienteEnderecoComplemento";
            this.txtClienteEnderecoComplemento.Size = new System.Drawing.Size(377, 33);
            this.txtClienteEnderecoComplemento.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteEnderecoComplemento.StateCommon.Border.Rounding = 18;
            this.txtClienteEnderecoComplemento.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEnderecoComplemento.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteEnderecoComplemento.TabIndex = 9;
            // 
            // txtClienteTelefoneCelular
            // 
            this.txtClienteTelefoneCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteTelefoneCelular.Location = new System.Drawing.Point(430, 124);
            this.txtClienteTelefoneCelular.Name = "txtClienteTelefoneCelular";
            this.txtClienteTelefoneCelular.Size = new System.Drawing.Size(157, 33);
            this.txtClienteTelefoneCelular.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteTelefoneCelular.StateCommon.Border.Rounding = 18;
            this.txtClienteTelefoneCelular.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteTelefoneCelular.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteTelefoneCelular.TabIndex = 4;
            this.txtClienteTelefoneCelular.TextChanged += new System.EventHandler(this.txtClienteTelefoneCelular_TextChanged);
            // 
            // txtClienteEnderecoCEP
            // 
            this.txtClienteEnderecoCEP.AccessibleName = "CEP";
            this.txtClienteEnderecoCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEnderecoCEP.Location = new System.Drawing.Point(595, 124);
            this.txtClienteEnderecoCEP.Name = "txtClienteEnderecoCEP";
            this.txtClienteEnderecoCEP.Size = new System.Drawing.Size(157, 33);
            this.txtClienteEnderecoCEP.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteEnderecoCEP.StateCommon.Border.Rounding = 18;
            this.txtClienteEnderecoCEP.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEnderecoCEP.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteEnderecoCEP.TabIndex = 5;
            this.txtClienteEnderecoCEP.TextChanged += new System.EventHandler(this.txtClienteEnderecoCEP_TextChanged);
            // 
            // txtClienteCpfCnpj
            // 
            this.txtClienteCpfCnpj.AccessibleName = "CPF / CNPJ";
            this.txtClienteCpfCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteCpfCnpj.Location = new System.Drawing.Point(496, 54);
            this.txtClienteCpfCnpj.Name = "txtClienteCpfCnpj";
            this.txtClienteCpfCnpj.Size = new System.Drawing.Size(157, 33);
            this.txtClienteCpfCnpj.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteCpfCnpj.StateCommon.Border.Rounding = 18;
            this.txtClienteCpfCnpj.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteCpfCnpj.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteCpfCnpj.TabIndex = 1;
            this.txtClienteCpfCnpj.TextChanged += new System.EventHandler(this.txtClienteCpfCnpj_TextChanged);
            // 
            // txtClienteEnderecoLocalidade
            // 
            this.txtClienteEnderecoLocalidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEnderecoLocalidade.Location = new System.Drawing.Point(348, 248);
            this.txtClienteEnderecoLocalidade.Name = "txtClienteEnderecoLocalidade";
            this.txtClienteEnderecoLocalidade.Size = new System.Drawing.Size(392, 33);
            this.txtClienteEnderecoLocalidade.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteEnderecoLocalidade.StateCommon.Border.Rounding = 18;
            this.txtClienteEnderecoLocalidade.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEnderecoLocalidade.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteEnderecoLocalidade.TabIndex = 11;
            // 
            // txtClienteEnderecoBairro
            // 
            this.txtClienteEnderecoBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEnderecoBairro.Location = new System.Drawing.Point(22, 248);
            this.txtClienteEnderecoBairro.Name = "txtClienteEnderecoBairro";
            this.txtClienteEnderecoBairro.Size = new System.Drawing.Size(320, 33);
            this.txtClienteEnderecoBairro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteEnderecoBairro.StateCommon.Border.Rounding = 18;
            this.txtClienteEnderecoBairro.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEnderecoBairro.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteEnderecoBairro.TabIndex = 10;
            // 
            // txtClienteEnderecoLogradouro
            // 
            this.txtClienteEnderecoLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEnderecoLogradouro.Location = new System.Drawing.Point(22, 185);
            this.txtClienteEnderecoLogradouro.Name = "txtClienteEnderecoLogradouro";
            this.txtClienteEnderecoLogradouro.Size = new System.Drawing.Size(291, 33);
            this.txtClienteEnderecoLogradouro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteEnderecoLogradouro.StateCommon.Border.Rounding = 18;
            this.txtClienteEnderecoLogradouro.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEnderecoLogradouro.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteEnderecoLogradouro.TabIndex = 7;
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.AccessibleName = "E-mail";
            this.txtClienteEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEmail.Location = new System.Drawing.Point(22, 120);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.Size = new System.Drawing.Size(400, 33);
            this.txtClienteEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteEmail.StateCommon.Border.Rounding = 18;
            this.txtClienteEmail.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteEmail.TabIndex = 3;
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.AccessibleName = "Nome Completo";
            this.txtClienteNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteNome.Location = new System.Drawing.Point(22, 55);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(455, 33);
            this.txtClienteNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClienteNome.StateCommon.Border.Rounding = 18;
            this.txtClienteNome.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteNome.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClienteNome.TabIndex = 0;
            // 
            // grpClienteControles
            // 
            this.grpClienteControles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClienteControles.CaptionOverlap = 0D;
            this.grpClienteControles.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpClienteControles.Location = new System.Drawing.Point(893, 21);
            this.grpClienteControles.Name = "grpClienteControles";
            // 
            // grpClienteControles.Panel
            // 
            this.grpClienteControles.Panel.Controls.Add(this.btnClienteAbrirNovoPedido);
            this.grpClienteControles.Panel.Controls.Add(this.btnClienteRemover);
            this.grpClienteControles.Panel.Controls.Add(this.btnClienteSalvar);
            this.grpClienteControles.Panel.Controls.Add(this.btnClienteNovo);
            this.grpClienteControles.Size = new System.Drawing.Size(283, 349);
            this.grpClienteControles.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.grpClienteControles.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpClienteControles.StateCommon.Border.Rounding = 10;
            this.grpClienteControles.TabIndex = 13;
            this.grpClienteControles.Values.Heading = "";
            // 
            // btnClienteAbrirNovoPedido
            // 
            this.btnClienteAbrirNovoPedido.Location = new System.Drawing.Point(15, 166);
            this.btnClienteAbrirNovoPedido.Name = "btnClienteAbrirNovoPedido";
            this.btnClienteAbrirNovoPedido.Size = new System.Drawing.Size(245, 48);
            this.btnClienteAbrirNovoPedido.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClienteAbrirNovoPedido.StateCommon.Border.Rounding = 20;
            this.btnClienteAbrirNovoPedido.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnClienteAbrirNovoPedido.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnClienteAbrirNovoPedido.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAbrirNovoPedido.TabIndex = 16;
            this.btnClienteAbrirNovoPedido.Values.Image = global::TestePraticoDeMaria.Properties.Resources.carrinho;
            this.btnClienteAbrirNovoPedido.Values.Text = "  Abrir Novo Pedido";
            this.btnClienteAbrirNovoPedido.Click += new System.EventHandler(this.btnClienteAbrirNovoPedido_Click);
            // 
            // btnClienteRemover
            // 
            this.btnClienteRemover.Location = new System.Drawing.Point(15, 233);
            this.btnClienteRemover.Name = "btnClienteRemover";
            this.btnClienteRemover.Size = new System.Drawing.Size(245, 48);
            this.btnClienteRemover.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClienteRemover.StateCommon.Border.Rounding = 20;
            this.btnClienteRemover.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnClienteRemover.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnClienteRemover.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteRemover.TabIndex = 17;
            this.btnClienteRemover.Values.Image = global::TestePraticoDeMaria.Properties.Resources.remover__2_;
            this.btnClienteRemover.Values.Text = " Remover";
            this.btnClienteRemover.Click += new System.EventHandler(this.btnClienteRemover_Click);
            // 
            // btnClienteSalvar
            // 
            this.btnClienteSalvar.Location = new System.Drawing.Point(15, 99);
            this.btnClienteSalvar.Name = "btnClienteSalvar";
            this.btnClienteSalvar.Size = new System.Drawing.Size(245, 48);
            this.btnClienteSalvar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClienteSalvar.StateCommon.Border.Rounding = 20;
            this.btnClienteSalvar.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnClienteSalvar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnClienteSalvar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteSalvar.TabIndex = 15;
            this.btnClienteSalvar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Salvar;
            this.btnClienteSalvar.Values.Text = "\tSalvar";
            this.btnClienteSalvar.Click += new System.EventHandler(this.btnClienteSalvar_Click);
            // 
            // btnClienteNovo
            // 
            this.btnClienteNovo.Location = new System.Drawing.Point(15, 32);
            this.btnClienteNovo.Name = "btnClienteNovo";
            this.btnClienteNovo.Size = new System.Drawing.Size(245, 48);
            this.btnClienteNovo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClienteNovo.StateCommon.Border.Rounding = 20;
            this.btnClienteNovo.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnClienteNovo.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnClienteNovo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteNovo.TabIndex = 14;
            this.btnClienteNovo.Values.Image = global::TestePraticoDeMaria.Properties.Resources.arquivo__1_;
            this.btnClienteNovo.Values.Text = "\tNovo";
            this.btnClienteNovo.Click += new System.EventHandler(this.btnClienteNovo_Click);
            // 
            // txtClientePesquisa
            // 
            this.txtClientePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientePesquisa.Location = new System.Drawing.Point(335, 30);
            this.txtClientePesquisa.Name = "txtClientePesquisa";
            this.txtClientePesquisa.Size = new System.Drawing.Size(403, 33);
            this.txtClientePesquisa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtClientePesquisa.StateCommon.Border.Rounding = 18;
            this.txtClientePesquisa.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientePesquisa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtClientePesquisa.TabIndex = 0;
            this.txtClientePesquisa.TextChanged += new System.EventHandler(this.txtClientePesquisa_TextChanged);
            // 
            // btnClientePesquisar
            // 
            this.btnClientePesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientePesquisar.Location = new System.Drawing.Point(744, 21);
            this.btnClientePesquisar.Name = "btnClientePesquisar";
            this.btnClientePesquisar.Size = new System.Drawing.Size(51, 48);
            this.btnClientePesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClientePesquisar.StateCommon.Border.Rounding = 20;
            this.btnClientePesquisar.TabIndex = 1;
            this.btnClientePesquisar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.pesquisar__2_;
            this.btnClientePesquisar.Values.Text = "";
            this.btnClientePesquisar.Click += new System.EventHandler(this.btnClientePesquisar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 387);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Resultado da consulta";
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.dgvProdutoPesquisa);
            this.tpProdutos.Controls.Add(this.label14);
            this.tpProdutos.Controls.Add(this.groupBox1);
            this.tpProdutos.Controls.Add(this.grpProdutoControles);
            this.tpProdutos.Controls.Add(this.txtProdutoPesquisa);
            this.tpProdutos.Controls.Add(this.btnProdutoPesquisar);
            this.tpProdutos.Controls.Add(this.label26);
            this.tpProdutos.Location = new System.Drawing.Point(4, 25);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdutos.Size = new System.Drawing.Size(1197, 565);
            this.tpProdutos.TabIndex = 2;
            this.tpProdutos.Text = "Produtos";
            this.tpProdutos.UseVisualStyleBackColor = true;
            // 
            // dgvProdutoPesquisa
            // 
            this.dgvProdutoPesquisa.AllowUserToAddRows = false;
            this.dgvProdutoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutoPesquisa.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvProdutoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutoPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProduto,
            this.colPrecoUnitario,
            this.colEstoque,
            this.colDescricao,
            this.colId});
            this.dgvProdutoPesquisa.Location = new System.Drawing.Point(20, 408);
            this.dgvProdutoPesquisa.Name = "dgvProdutoPesquisa";
            this.dgvProdutoPesquisa.ReadOnly = true;
            this.dgvProdutoPesquisa.Size = new System.Drawing.Size(1157, 139);
            this.dgvProdutoPesquisa.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(354, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 16);
            this.label14.TabIndex = 16;
            this.label14.Text = "Pesquisar Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudProdutoQuantidadeEstoque);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtProdutoDescricao);
            this.groupBox1.Controls.Add(this.txtProdutoPreco);
            this.groupBox1.Controls.Add(this.txtProdutoNome);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 295);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Produto";
            // 
            // nudProdutoQuantidadeEstoque
            // 
            this.nudProdutoQuantidadeEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudProdutoQuantidadeEstoque.Location = new System.Drawing.Point(628, 112);
            this.nudProdutoQuantidadeEstoque.Name = "nudProdutoQuantidadeEstoque";
            this.nudProdutoQuantidadeEstoque.Size = new System.Drawing.Size(184, 37);
            this.nudProdutoQuantidadeEstoque.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nudProdutoQuantidadeEstoque.StateCommon.Border.Rounding = 18;
            this.nudProdutoQuantidadeEstoque.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.nudProdutoQuantidadeEstoque.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nudProdutoQuantidadeEstoque.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(39, 155);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "Descrição:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(639, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Quantidade em Estoque:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Preço:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(39, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(48, 16);
            this.label25.TabIndex = 2;
            this.label25.Text = "Nome:";
            // 
            // txtProdutoDescricao
            // 
            this.txtProdutoDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdutoDescricao.Location = new System.Drawing.Point(22, 174);
            this.txtProdutoDescricao.Multiline = true;
            this.txtProdutoDescricao.Name = "txtProdutoDescricao";
            this.txtProdutoDescricao.Size = new System.Drawing.Size(790, 106);
            this.txtProdutoDescricao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProdutoDescricao.StateCommon.Border.Rounding = 18;
            this.txtProdutoDescricao.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoDescricao.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProdutoDescricao.TabIndex = 3;
            // 
            // txtProdutoPreco
            // 
            this.txtProdutoPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdutoPreco.Location = new System.Drawing.Point(22, 112);
            this.txtProdutoPreco.Name = "txtProdutoPreco";
            this.txtProdutoPreco.Size = new System.Drawing.Size(600, 33);
            this.txtProdutoPreco.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProdutoPreco.StateCommon.Border.Rounding = 18;
            this.txtProdutoPreco.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoPreco.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProdutoPreco.TabIndex = 0;
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdutoNome.Location = new System.Drawing.Point(22, 55);
            this.txtProdutoNome.Name = "txtProdutoNome";
            this.txtProdutoNome.Size = new System.Drawing.Size(790, 33);
            this.txtProdutoNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProdutoNome.StateCommon.Border.Rounding = 18;
            this.txtProdutoNome.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoNome.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProdutoNome.TabIndex = 0;
            // 
            // grpProdutoControles
            // 
            this.grpProdutoControles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProdutoControles.CaptionOverlap = 0D;
            this.grpProdutoControles.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpProdutoControles.Location = new System.Drawing.Point(894, 23);
            this.grpProdutoControles.Name = "grpProdutoControles";
            // 
            // grpProdutoControles.Panel
            // 
            this.grpProdutoControles.Panel.Controls.Add(this.btnProdutoRemover);
            this.grpProdutoControles.Panel.Controls.Add(this.btnProdutoSalvar);
            this.grpProdutoControles.Panel.Controls.Add(this.btnProdutoNovo);
            this.grpProdutoControles.Size = new System.Drawing.Size(283, 349);
            this.grpProdutoControles.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.grpProdutoControles.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpProdutoControles.StateCommon.Border.Rounding = 10;
            this.grpProdutoControles.TabIndex = 20;
            this.grpProdutoControles.Values.Heading = "";
            // 
            // btnProdutoRemover
            // 
            this.btnProdutoRemover.Location = new System.Drawing.Point(15, 162);
            this.btnProdutoRemover.Name = "btnProdutoRemover";
            this.btnProdutoRemover.Size = new System.Drawing.Size(245, 48);
            this.btnProdutoRemover.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProdutoRemover.StateCommon.Border.Rounding = 20;
            this.btnProdutoRemover.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnProdutoRemover.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnProdutoRemover.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoRemover.TabIndex = 17;
            this.btnProdutoRemover.Values.Image = global::TestePraticoDeMaria.Properties.Resources.remover__2_;
            this.btnProdutoRemover.Values.Text = " Remover";
            this.btnProdutoRemover.Click += new System.EventHandler(this.btnProdutoRemover_Click);
            // 
            // btnProdutoSalvar
            // 
            this.btnProdutoSalvar.Location = new System.Drawing.Point(15, 99);
            this.btnProdutoSalvar.Name = "btnProdutoSalvar";
            this.btnProdutoSalvar.Size = new System.Drawing.Size(245, 48);
            this.btnProdutoSalvar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProdutoSalvar.StateCommon.Border.Rounding = 20;
            this.btnProdutoSalvar.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnProdutoSalvar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnProdutoSalvar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoSalvar.TabIndex = 15;
            this.btnProdutoSalvar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Salvar;
            this.btnProdutoSalvar.Values.Text = "\tSalvar";
            this.btnProdutoSalvar.Click += new System.EventHandler(this.btnProdutoSalvar_Click);
            // 
            // btnProdutoNovo
            // 
            this.btnProdutoNovo.Location = new System.Drawing.Point(15, 32);
            this.btnProdutoNovo.Name = "btnProdutoNovo";
            this.btnProdutoNovo.Size = new System.Drawing.Size(245, 48);
            this.btnProdutoNovo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProdutoNovo.StateCommon.Border.Rounding = 20;
            this.btnProdutoNovo.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnProdutoNovo.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnProdutoNovo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutoNovo.TabIndex = 14;
            this.btnProdutoNovo.Values.Image = global::TestePraticoDeMaria.Properties.Resources.arquivo__1_;
            this.btnProdutoNovo.Values.Text = "\tNovo";
            this.btnProdutoNovo.Click += new System.EventHandler(this.btnProdutoNovo_Click);
            // 
            // txtProdutoPesquisa
            // 
            this.txtProdutoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdutoPesquisa.Location = new System.Drawing.Point(336, 32);
            this.txtProdutoPesquisa.Name = "txtProdutoPesquisa";
            this.txtProdutoPesquisa.Size = new System.Drawing.Size(403, 33);
            this.txtProdutoPesquisa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProdutoPesquisa.StateCommon.Border.Rounding = 18;
            this.txtProdutoPesquisa.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoPesquisa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProdutoPesquisa.TabIndex = 14;
            this.txtProdutoPesquisa.TextChanged += new System.EventHandler(this.txtProdutoPesquisa_TextChanged);
            // 
            // btnProdutoPesquisar
            // 
            this.btnProdutoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdutoPesquisar.Location = new System.Drawing.Point(745, 23);
            this.btnProdutoPesquisar.Name = "btnProdutoPesquisar";
            this.btnProdutoPesquisar.Size = new System.Drawing.Size(51, 48);
            this.btnProdutoPesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProdutoPesquisar.StateCommon.Border.Rounding = 20;
            this.btnProdutoPesquisar.TabIndex = 15;
            this.btnProdutoPesquisar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.pesquisar__2_;
            this.btnProdutoPesquisar.Values.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(19, 389);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(147, 16);
            this.label26.TabIndex = 18;
            this.label26.Text = "Resultado da consulta";
            // 
            // tpVenda
            // 
            this.tpVenda.Controls.Add(this.groupBox4);
            this.tpVenda.Controls.Add(this.kryptonGroupBox1);
            this.tpVenda.Controls.Add(this.dgvPedidoProdutos);
            this.tpVenda.Controls.Add(this.label27);
            this.tpVenda.Controls.Add(this.groupBox3);
            this.tpVenda.Controls.Add(this.groupBox2);
            this.tpVenda.Location = new System.Drawing.Point(4, 25);
            this.tpVenda.Name = "tpVenda";
            this.tpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenda.Size = new System.Drawing.Size(1197, 565);
            this.tpVenda.TabIndex = 3;
            this.tpVenda.Text = "Vendas";
            this.tpVenda.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.kryptonTextBox5);
            this.groupBox4.Controls.Add(this.kryptonTextBox4);
            this.groupBox4.Controls.Add(this.txtPedidoValorTotal);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(895, 375);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 178);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resumo Pedido";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(27, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(48, 16);
            this.label34.TabIndex = 2;
            this.label34.Text = "Saldo:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(27, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 16);
            this.label29.TabIndex = 2;
            this.label29.Text = "Valor Pago:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(27, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 16);
            this.label31.TabIndex = 2;
            this.label31.Text = "Valor Total:";
            // 
            // kryptonTextBox5
            // 
            this.kryptonTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonTextBox5.Location = new System.Drawing.Point(19, 142);
            this.kryptonTextBox5.Name = "kryptonTextBox5";
            this.kryptonTextBox5.Size = new System.Drawing.Size(245, 28);
            this.kryptonTextBox5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox5.StateCommon.Border.Rounding = 18;
            this.kryptonTextBox5.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.kryptonTextBox5.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox5.TabIndex = 0;
            // 
            // kryptonTextBox4
            // 
            this.kryptonTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonTextBox4.Location = new System.Drawing.Point(19, 90);
            this.kryptonTextBox4.Name = "kryptonTextBox4";
            this.kryptonTextBox4.Size = new System.Drawing.Size(245, 28);
            this.kryptonTextBox4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox4.StateCommon.Border.Rounding = 18;
            this.kryptonTextBox4.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.kryptonTextBox4.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox4.TabIndex = 0;
            // 
            // txtPedidoValorTotal
            // 
            this.txtPedidoValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoValorTotal.Location = new System.Drawing.Point(19, 40);
            this.txtPedidoValorTotal.Name = "txtPedidoValorTotal";
            this.txtPedidoValorTotal.Size = new System.Drawing.Size(245, 28);
            this.txtPedidoValorTotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoValorTotal.StateCommon.Border.Rounding = 18;
            this.txtPedidoValorTotal.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtPedidoValorTotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoValorTotal.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox1.CaptionOverlap = 0D;
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(895, 16);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.label28);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtPedidoPesquisa);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton7);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton9);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton6);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(283, 353);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox1.TabIndex = 26;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(57, 6);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 16);
            this.label28.TabIndex = 29;
            this.label28.Text = "Pesquisar Pedido";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(15, 177);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(245, 48);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton1.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 16;
            this.kryptonButton1.Values.Image = global::TestePraticoDeMaria.Properties.Resources.dinheiro__1_;
            this.kryptonButton1.Values.Text = "  Caixa";
            // 
            // txtPedidoPesquisa
            // 
            this.txtPedidoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoPesquisa.Location = new System.Drawing.Point(30, 25);
            this.txtPedidoPesquisa.Name = "txtPedidoPesquisa";
            this.txtPedidoPesquisa.Size = new System.Drawing.Size(173, 33);
            this.txtPedidoPesquisa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoPesquisa.StateCommon.Border.Rounding = 18;
            this.txtPedidoPesquisa.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoPesquisa.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoPesquisa.TabIndex = 27;
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton7.Location = new System.Drawing.Point(209, 16);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.Size = new System.Drawing.Size(51, 48);
            this.kryptonButton7.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateCommon.Border.Rounding = 20;
            this.kryptonButton7.TabIndex = 28;
            this.kryptonButton7.Values.Image = global::TestePraticoDeMaria.Properties.Resources.pesquisar__2_;
            this.kryptonButton7.Values.Text = "";
            // 
            // kryptonButton9
            // 
            this.kryptonButton9.Location = new System.Drawing.Point(15, 283);
            this.kryptonButton9.Name = "kryptonButton9";
            this.kryptonButton9.Size = new System.Drawing.Size(245, 48);
            this.kryptonButton9.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9.StateCommon.Border.Rounding = 20;
            this.kryptonButton9.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton9.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton9.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton9.TabIndex = 17;
            this.kryptonButton9.Values.Image = global::TestePraticoDeMaria.Properties.Resources.remover__2_;
            this.kryptonButton9.Values.Text = " Cancelar";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(15, 230);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(245, 48);
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 20;
            this.kryptonButton2.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton2.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 17;
            this.kryptonButton2.Values.Image = global::TestePraticoDeMaria.Properties.Resources.pacote;
            this.kryptonButton2.Values.Text = "Finalizar";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(15, 124);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(245, 48);
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton3.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 15;
            this.kryptonButton3.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Salvar;
            this.kryptonButton3.Values.Text = "\tSalvar";
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Location = new System.Drawing.Point(15, 71);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.Size = new System.Drawing.Size(245, 48);
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Border.Rounding = 20;
            this.kryptonButton6.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton6.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.TabIndex = 14;
            this.kryptonButton6.Values.Image = global::TestePraticoDeMaria.Properties.Resources.arquivo__1_;
            this.kryptonButton6.Values.Text = "\tNovo";
            // 
            // dgvPedidoProdutos
            // 
            this.dgvPedidoProdutos.AllowUserToAddRows = false;
            this.dgvPedidoProdutos.AllowUserToDeleteRows = false;
            this.dgvPedidoProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidoProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdutoVenda,
            this.colQuantiade,
            this.colValorUnitario,
            this.colValorTotal});
            this.dgvPedidoProdutos.Location = new System.Drawing.Point(19, 394);
            this.dgvPedidoProdutos.Name = "dgvPedidoProdutos";
            this.dgvPedidoProdutos.ReadOnly = true;
            this.dgvPedidoProdutos.Size = new System.Drawing.Size(870, 155);
            this.dgvPedidoProdutos.TabIndex = 25;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(18, 375);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(189, 16);
            this.label27.TabIndex = 24;
            this.label27.Text = "Lista de Produtos no pedido:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.kryptonButton5);
            this.groupBox3.Controls.Add(this.cmbPedidoProdutos);
            this.groupBox3.Controls.Add(this.kryptonButton4);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtPedidoProdutoValorTotal);
            this.groupBox3.Controls.Add(this.txtPedidoProdutoValorUnitario);
            this.groupBox3.Controls.Add(this.nudPedidoProdutoQuantidade);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 170);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Produto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(36, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Produto:";
            // 
            // kryptonButton5
            // 
            this.kryptonButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton5.Location = new System.Drawing.Point(665, 98);
            this.kryptonButton5.Name = "kryptonButton5";
            this.kryptonButton5.Size = new System.Drawing.Size(184, 48);
            this.kryptonButton5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton5.StateCommon.Border.Rounding = 20;
            this.kryptonButton5.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton5.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton5.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton5.TabIndex = 17;
            this.kryptonButton5.Values.Image = global::TestePraticoDeMaria.Properties.Resources.remover__2_;
            this.kryptonButton5.Values.Text = " Remover";
            // 
            // cmbPedidoProdutos
            // 
            this.cmbPedidoProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPedidoProdutos.DropDownWidth = 210;
            this.cmbPedidoProdutos.Location = new System.Drawing.Point(22, 38);
            this.cmbPedidoProdutos.Name = "cmbPedidoProdutos";
            this.cmbPedidoProdutos.Size = new System.Drawing.Size(624, 36);
            this.cmbPedidoProdutos.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbPedidoProdutos.StateCommon.ComboBox.Border.Rounding = 18;
            this.cmbPedidoProdutos.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedidoProdutos.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbPedidoProdutos.TabIndex = 5;
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton4.Location = new System.Drawing.Point(462, 98);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(184, 48);
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Border.Rounding = 20;
            this.kryptonButton4.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton4.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.TabIndex = 17;
            this.kryptonButton4.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Adicionar;
            this.kryptonButton4.Values.Text = " Adicionar";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(214, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "Valor Total:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "Valor Unitário:";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(676, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 16);
            this.label22.TabIndex = 6;
            this.label22.Text = "Quantidade:";
            // 
            // txtPedidoProdutoValorTotal
            // 
            this.txtPedidoProdutoValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoProdutoValorTotal.Location = new System.Drawing.Point(200, 113);
            this.txtPedidoProdutoValorTotal.Name = "txtPedidoProdutoValorTotal";
            this.txtPedidoProdutoValorTotal.Size = new System.Drawing.Size(239, 33);
            this.txtPedidoProdutoValorTotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoProdutoValorTotal.StateCommon.Border.Rounding = 18;
            this.txtPedidoProdutoValorTotal.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoProdutoValorTotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoProdutoValorTotal.TabIndex = 0;
            // 
            // txtPedidoProdutoValorUnitario
            // 
            this.txtPedidoProdutoValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoProdutoValorUnitario.Location = new System.Drawing.Point(22, 113);
            this.txtPedidoProdutoValorUnitario.Name = "txtPedidoProdutoValorUnitario";
            this.txtPedidoProdutoValorUnitario.Size = new System.Drawing.Size(154, 33);
            this.txtPedidoProdutoValorUnitario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoProdutoValorUnitario.StateCommon.Border.Rounding = 18;
            this.txtPedidoProdutoValorUnitario.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoProdutoValorUnitario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoProdutoValorUnitario.TabIndex = 0;
            // 
            // nudPedidoProdutoQuantidade
            // 
            this.nudPedidoProdutoQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPedidoProdutoQuantidade.Location = new System.Drawing.Point(665, 37);
            this.nudPedidoProdutoQuantidade.Name = "nudPedidoProdutoQuantidade";
            this.nudPedidoProdutoQuantidade.Size = new System.Drawing.Size(184, 37);
            this.nudPedidoProdutoQuantidade.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nudPedidoProdutoQuantidade.StateCommon.Border.Rounding = 18;
            this.nudPedidoProdutoQuantidade.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.nudPedidoProdutoQuantidade.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.nudPedidoProdutoQuantidade.TabIndex = 7;
            this.nudPedidoProdutoQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtPedidoObservacao);
            this.groupBox2.Controls.Add(this.cmbPedidoClientes);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.kryptonTextBox3);
            this.groupBox2.Controls.Add(this.kryptonTextBox2);
            this.groupBox2.Controls.Add(this.kryptonTextBox1);
            this.groupBox2.Controls.Add(this.txtPedidoNumero);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 179);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Pedido";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Observação:";
            // 
            // txtPedidoObservacao
            // 
            this.txtPedidoObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoObservacao.Location = new System.Drawing.Point(19, 122);
            this.txtPedidoObservacao.Multiline = true;
            this.txtPedidoObservacao.Name = "txtPedidoObservacao";
            this.txtPedidoObservacao.Size = new System.Drawing.Size(822, 42);
            this.txtPedidoObservacao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoObservacao.StateCommon.Border.Rounding = 18;
            this.txtPedidoObservacao.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoObservacao.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoObservacao.TabIndex = 7;
            // 
            // cmbPedidoClientes
            // 
            this.cmbPedidoClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPedidoClientes.DropDownWidth = 210;
            this.cmbPedidoClientes.Location = new System.Drawing.Point(533, 52);
            this.cmbPedidoClientes.Name = "cmbPedidoClientes";
            this.cmbPedidoClientes.Size = new System.Drawing.Size(326, 36);
            this.cmbPedidoClientes.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbPedidoClientes.StateCommon.ComboBox.Border.Rounding = 18;
            this.cmbPedidoClientes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedidoClientes.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbPedidoClientes.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(551, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "Cliente:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(416, 36);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(112, 16);
            this.label37.TabIndex = 2;
            this.label37.Text = "Data Cancelado:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(306, 36);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(108, 16);
            this.label36.TabIndex = 2;
            this.label36.Text = "Data Concluido:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(197, 36);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 16);
            this.label35.TabIndex = 2;
            this.label35.Text = "Data Pedido:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Número do Pedido:";
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.Enabled = false;
            this.kryptonTextBox3.Location = new System.Drawing.Point(416, 55);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(111, 33);
            this.kryptonTextBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox3.StateCommon.Border.Rounding = 18;
            this.kryptonTextBox3.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox3.TabIndex = 0;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Enabled = false;
            this.kryptonTextBox2.Location = new System.Drawing.Point(299, 55);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(111, 33);
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateCommon.Border.Rounding = 18;
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox2.TabIndex = 0;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Enabled = false;
            this.kryptonTextBox1.Location = new System.Drawing.Point(182, 55);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(111, 33);
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 18;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.TabIndex = 0;
            // 
            // txtPedidoNumero
            // 
            this.txtPedidoNumero.Enabled = false;
            this.txtPedidoNumero.Location = new System.Drawing.Point(22, 55);
            this.txtPedidoNumero.Name = "txtPedidoNumero";
            this.txtPedidoNumero.Size = new System.Drawing.Size(154, 33);
            this.txtPedidoNumero.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoNumero.StateCommon.Border.Rounding = 18;
            this.txtPedidoNumero.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoNumero.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoNumero.TabIndex = 0;
            // 
            // tpRelatorios
            // 
            this.tpRelatorios.Controls.Add(this.kryptonGroupBox2);
            this.tpRelatorios.Controls.Add(this.reportViewer1);
            this.tpRelatorios.Location = new System.Drawing.Point(4, 25);
            this.tpRelatorios.Name = "tpRelatorios";
            this.tpRelatorios.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatorios.Size = new System.Drawing.Size(1197, 565);
            this.tpRelatorios.TabIndex = 4;
            this.tpRelatorios.Text = "Relatórios";
            this.tpRelatorios.UseVisualStyleBackColor = true;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionOverlap = 0D;
            this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(3, 3);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.label32);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label33);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label30);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dateTimePicker2);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dateTimePicker1);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonButton8);
            this.kryptonGroupBox2.Panel.Controls.Add(this.listBox1);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(269, 559);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox2.TabIndex = 21;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(129, 387);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 16);
            this.label32.TabIndex = 19;
            this.label32.Text = "Data Final";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(17, 14);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 16);
            this.label33.TabIndex = 19;
            this.label33.Text = "Relatórios";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(17, 387);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 16);
            this.label30.TabIndex = 19;
            this.label30.Text = "Data Inicial";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(132, 406);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(103, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 406);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // kryptonButton8
            // 
            this.kryptonButton8.Location = new System.Drawing.Point(20, 451);
            this.kryptonButton8.Name = "kryptonButton8";
            this.kryptonButton8.Size = new System.Drawing.Size(215, 48);
            this.kryptonButton8.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton8.StateCommon.Border.Rounding = 20;
            this.kryptonButton8.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonButton8.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonButton8.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton8.TabIndex = 17;
            this.kryptonButton8.Values.Image = global::TestePraticoDeMaria.Properties.Resources.grafico__1_;
            this.kryptonButton8.Values.Text = " Gerar Relatório";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 340);
            this.listBox1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.Location = new System.Drawing.Point(278, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(916, 556);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 8);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(155, 38);
            this.btnClientes.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClientes.StateCommon.Border.Rounding = 20;
            this.btnClientes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Values.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(176, 8);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(155, 38);
            this.btnProdutos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProdutos.StateCommon.Border.Rounding = 20;
            this.btnProdutos.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Values.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(340, 8);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(155, 38);
            this.btnVendas.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnVendas.StateCommon.Border.Rounding = 20;
            this.btnVendas.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Values.Text = "Vendas";
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(504, 8);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(155, 38);
            this.btnRelatorios.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRelatorios.StateCommon.Border.Rounding = 20;
            this.btnRelatorios.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.TabIndex = 4;
            this.btnRelatorios.Values.Text = "Relatórios";
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // grpNavMenu
            // 
            this.grpNavMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNavMenu.CaptionOverlap = 0D;
            this.grpNavMenu.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.grpNavMenu.Location = new System.Drawing.Point(23, 12);
            this.grpNavMenu.Name = "grpNavMenu";
            // 
            // grpNavMenu.Panel
            // 
            this.grpNavMenu.Panel.Controls.Add(this.btnRelatorios);
            this.grpNavMenu.Panel.Controls.Add(this.btnClientes);
            this.grpNavMenu.Panel.Controls.Add(this.btnVendas);
            this.grpNavMenu.Panel.Controls.Add(this.btnProdutos);
            this.grpNavMenu.Panel.Controls.Add(this.btnConfiguracao);
            this.grpNavMenu.Size = new System.Drawing.Size(1225, 64);
            this.grpNavMenu.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.grpNavMenu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpNavMenu.StateCommon.Border.Rounding = 20;
            this.grpNavMenu.TabIndex = 2;
            this.grpNavMenu.Values.Heading = "";
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracao.Location = new System.Drawing.Point(1153, 1);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(51, 48);
            this.btnConfiguracao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConfiguracao.StateCommon.Border.Rounding = 20;
            this.btnConfiguracao.TabIndex = 1;
            this.btnConfiguracao.Values.Image = global::TestePraticoDeMaria.Properties.Resources.configuracao;
            this.btnConfiguracao.Values.Text = "";
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // colProdutoVenda
            // 
            this.colProdutoVenda.HeaderText = "Produto";
            this.colProdutoVenda.Name = "colProdutoVenda";
            this.colProdutoVenda.ReadOnly = true;
            // 
            // colQuantiade
            // 
            this.colQuantiade.HeaderText = "Quantidade";
            this.colQuantiade.Name = "colQuantiade";
            this.colQuantiade.ReadOnly = true;
            // 
            // colValorUnitario
            // 
            this.colValorUnitario.HeaderText = "Valor Unitário";
            this.colValorUnitario.Name = "colValorUnitario";
            this.colValorUnitario.ReadOnly = true;
            this.colValorUnitario.Width = 150;
            // 
            // colValorTotal
            // 
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduto.DataPropertyName = "produto";
            this.colProduto.HeaderText = "Produto";
            this.colProduto.MinimumWidth = 150;
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colPrecoUnitario
            // 
            this.colPrecoUnitario.DataPropertyName = "precounitario";
            this.colPrecoUnitario.HeaderText = "Preço";
            this.colPrecoUnitario.Name = "colPrecoUnitario";
            this.colPrecoUnitario.ReadOnly = true;
            // 
            // colEstoque
            // 
            this.colEstoque.DataPropertyName = "quantidadeestoque";
            this.colEstoque.HeaderText = "Quantidade em Estoque";
            this.colEstoque.Name = "colEstoque";
            this.colEstoque.ReadOnly = true;
            this.colEstoque.Width = 180;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.DataPropertyName = "descricao";
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 100;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpNavMenu);
            this.Controls.Add(this.tabInterface);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenuPrincipal";
            this.Palette = this.krPallet;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Text = "Gestor Empresa X";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.tabInterface.ResumeLayout(false);
            this.tpCliente.ResumeLayout(false);
            this.tpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientePesquisa)).EndInit();
            this.grpDadosCliente.ResumeLayout(false);
            this.grpDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClienteEnderecoUf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles.Panel)).EndInit();
            this.grpClienteControles.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpClienteControles)).EndInit();
            this.grpClienteControles.ResumeLayout(false);
            this.tpProdutos.ResumeLayout(false);
            this.tpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutoPesquisa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles.Panel)).EndInit();
            this.grpProdutoControles.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles)).EndInit();
            this.grpProdutoControles.ResumeLayout(false);
            this.tpVenda.ResumeLayout(false);
            this.tpVenda.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPedidoProdutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPedidoClientes)).EndInit();
            this.tpRelatorios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpNavMenu.Panel)).EndInit();
            this.grpNavMenu.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpNavMenu)).EndInit();
            this.grpNavMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette krPallet;
        private System.Windows.Forms.TabControl tabInterface;
        private System.Windows.Forms.TabPage tpMenu;
        private System.Windows.Forms.TabPage tpCliente;
        private System.Windows.Forms.TabPage tpProdutos;
        private System.Windows.Forms.TabPage tpVenda;
        private System.Windows.Forms.TabPage tpRelatorios;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClientes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnVendas;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProdutos;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRelatorios;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClientePesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClientePesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpClienteControles;
        private System.Windows.Forms.GroupBox grpDadosCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteCpfCnpj;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteNome;
        private System.Windows.Forms.CheckBox chkPessoaJuridica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClientePesquisarCEP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteTelefoneCelular;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoCEP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoComplemento;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoLogradouro;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbClienteEnderecoUf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoLocalidade;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoBairro;
        private System.Windows.Forms.DataGridView dgvClientePesquisa;
        private System.Windows.Forms.Label label13;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpNavMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClienteNovo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClienteRemover;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClienteSalvar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClienteAbrirNovoPedido;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpProdutoControles;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProdutoRemover;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProdutoSalvar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProdutoNovo;
        private System.Windows.Forms.DataGridView dgvProdutoPesquisa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoDescricao;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoPesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProdutoPesquisar;
        private System.Windows.Forms.Label label26;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nudProdutoQuantidadeEstoque;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoPreco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbPedidoProdutos;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbPedidoClientes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private System.Windows.Forms.Label label17;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoObservacao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nudPedidoProdutoQuantidade;
        private System.Windows.Forms.DataGridView dgvPedidoProdutos;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoProdutoValorTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoProdutoValorUnitario;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label28;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoPesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label31;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoValorTotal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ListBox listBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton8;
        private System.Windows.Forms.Label label33;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfiguracao;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label29;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfCnpj;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPessoaJuridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefoneCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClienteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantiade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    }
}