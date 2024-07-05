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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
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
            this.lbPesquisaCliente = new System.Windows.Forms.Label();
            this.grpDadosCliente = new System.Windows.Forms.GroupBox();
            this.cmbClienteEnderecoUf = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lbComplementoEnderecoCliente = new System.Windows.Forms.Label();
            this.lbCepCliente = new System.Windows.Forms.Label();
            this.lbCpfCnpjCliente = new System.Windows.Forms.Label();
            this.lbEstadoCliente = new System.Windows.Forms.Label();
            this.lbNumeroCasaCliente = new System.Windows.Forms.Label();
            this.lbTelefoneCliente = new System.Windows.Forms.Label();
            this.lbLocalidadeEnderecoCliente = new System.Windows.Forms.Label();
            this.lbBairroEnderecoCliente = new System.Windows.Forms.Label();
            this.lbLogradouroCLiente = new System.Windows.Forms.Label();
            this.lbEmailCliente = new System.Windows.Forms.Label();
            this.btnClientePesquisarCEP = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbNomeCliente = new System.Windows.Forms.Label();
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
            this.lbResultadoConsultaCliente = new System.Windows.Forms.Label();
            this.tpProdutos = new System.Windows.Forms.TabPage();
            this.dgvProdutoPesquisa = new System.Windows.Forms.DataGridView();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPesquisaProduto = new System.Windows.Forms.Label();
            this.grpDadosProduto = new System.Windows.Forms.GroupBox();
            this.nudProdutoQuantidadeEstoque = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lbDescricaoProduto = new System.Windows.Forms.Label();
            this.lbQuantidadeEstoqueProduto = new System.Windows.Forms.Label();
            this.lbPrecoProduto = new System.Windows.Forms.Label();
            this.lbNomeProduto = new System.Windows.Forms.Label();
            this.txtProdutoDescricao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProdutoPreco = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProdutoNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grpProdutoControles = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnProdutoRemover = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProdutoSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProdutoNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtProdutoPesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnProdutoPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbResultadoPesquisaProduto = new System.Windows.Forms.Label();
            this.tpVenda = new System.Windows.Forms.TabPage();
            this.grpResumoPedido = new System.Windows.Forms.GroupBox();
            this.lbResumoValorSaldo = new System.Windows.Forms.Label();
            this.lbResumoValorPago = new System.Windows.Forms.Label();
            this.lbResumoValorTotal = new System.Windows.Forms.Label();
            this.txtPedidoSaldo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoValorPago = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoValorTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnPedidoCaixa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtPedidoPesquisa = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnPedidoPesquisar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPedidoCancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPedidoFinalizar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPedidoSalvar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPedidoNovo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgvPedidoProdutos = new System.Windows.Forms.DataGridView();
            this.colProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantiade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label27 = new System.Windows.Forms.Label();
            this.grpDadosProdutoPedido = new System.Windows.Forms.GroupBox();
            this.lbProdutoNomePedido = new System.Windows.Forms.Label();
            this.btnPedidoRemoverProduto = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbPedidoProdutos = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnPedidoSalvarProduto = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbProdutoValorTotalitemPedido = new System.Windows.Forms.Label();
            this.lbProdutoValorUnidadePedido = new System.Windows.Forms.Label();
            this.lbProdutoQuantidadePedido = new System.Windows.Forms.Label();
            this.txtPedidoProdutoValorTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoProdutoValorUnitario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nudPedidoProdutoQuantidade = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.grpDadosPedido = new System.Windows.Forms.GroupBox();
            this.lbObservacaoPedido = new System.Windows.Forms.Label();
            this.txtPedidoObservacao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbPedidoClientes = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnPedidoVoltar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPedidoAvancar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbClientePedido = new System.Windows.Forms.Label();
            this.lbDataCancelamentoPedido = new System.Windows.Forms.Label();
            this.lbDataConclusaoPedido = new System.Windows.Forms.Label();
            this.lbDataPedido = new System.Windows.Forms.Label();
            this.lbNumeroPedido = new System.Windows.Forms.Label();
            this.txtPedidoDataCancelado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoDataFinalizado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoDataInclusao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoNumero = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tpRelatorios = new System.Windows.Forms.TabPage();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.btnGerarRelatorio = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lstRelatorios = new System.Windows.Forms.ListBox();
            this.rvwRelatorios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClientes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnProdutos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnVendas = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRelatorios = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpNavMenu = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnConfiguracao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.grpDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles.Panel)).BeginInit();
            this.grpProdutoControles.Panel.SuspendLayout();
            this.grpProdutoControles.SuspendLayout();
            this.tpVenda.SuspendLayout();
            this.grpResumoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProdutos)).BeginInit();
            this.grpDadosProdutoPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPedidoProdutos)).BeginInit();
            this.grpDadosPedido.SuspendLayout();
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
            this.tabInterface.Location = new System.Drawing.Point(33, 52);
            this.tabInterface.Name = "tabInterface";
            this.tabInterface.SelectedIndex = 0;
            this.tabInterface.Size = new System.Drawing.Size(1205, 600);
            this.tabInterface.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.Location = new System.Drawing.Point(4, 25);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(1197, 571);
            this.tpMenu.TabIndex = 0;
            this.tpMenu.Text = "Menu";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.dgvClientePesquisa);
            this.tpCliente.Controls.Add(this.lbPesquisaCliente);
            this.tpCliente.Controls.Add(this.grpDadosCliente);
            this.tpCliente.Controls.Add(this.grpClienteControles);
            this.tpCliente.Controls.Add(this.txtClientePesquisa);
            this.tpCliente.Controls.Add(this.btnClientePesquisar);
            this.tpCliente.Controls.Add(this.lbResultadoConsultaCliente);
            this.tpCliente.Location = new System.Drawing.Point(4, 25);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(1197, 571);
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
            this.dgvClientePesquisa.Name = "dgvClientePesquisa";
            this.dgvClientePesquisa.ReadOnly = true;
            this.dgvClientePesquisa.Size = new System.Drawing.Size(1157, 148);
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
            // lbPesquisaCliente
            // 
            this.lbPesquisaCliente.AutoSize = true;
            this.lbPesquisaCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisaCliente.Location = new System.Drawing.Point(353, 10);
            this.lbPesquisaCliente.Name = "lbPesquisaCliente";
            this.lbPesquisaCliente.Size = new System.Drawing.Size(259, 16);
            this.lbPesquisaCliente.TabIndex = 2;
            this.lbPesquisaCliente.Text = "Pesquisar Cliente (Nome, CPF ou CNPJ)";
            // 
            // grpDadosCliente
            // 
            this.grpDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosCliente.Controls.Add(this.cmbClienteEnderecoUf);
            this.grpDadosCliente.Controls.Add(this.lbComplementoEnderecoCliente);
            this.grpDadosCliente.Controls.Add(this.lbCepCliente);
            this.grpDadosCliente.Controls.Add(this.lbCpfCnpjCliente);
            this.grpDadosCliente.Controls.Add(this.lbEstadoCliente);
            this.grpDadosCliente.Controls.Add(this.lbNumeroCasaCliente);
            this.grpDadosCliente.Controls.Add(this.lbTelefoneCliente);
            this.grpDadosCliente.Controls.Add(this.lbLocalidadeEnderecoCliente);
            this.grpDadosCliente.Controls.Add(this.lbBairroEnderecoCliente);
            this.grpDadosCliente.Controls.Add(this.lbLogradouroCLiente);
            this.grpDadosCliente.Controls.Add(this.lbEmailCliente);
            this.grpDadosCliente.Controls.Add(this.btnClientePesquisarCEP);
            this.grpDadosCliente.Controls.Add(this.lbNomeCliente);
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
            // lbComplementoEnderecoCliente
            // 
            this.lbComplementoEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbComplementoEnderecoCliente.AutoSize = true;
            this.lbComplementoEnderecoCliente.Location = new System.Drawing.Point(450, 166);
            this.lbComplementoEnderecoCliente.Name = "lbComplementoEnderecoCliente";
            this.lbComplementoEnderecoCliente.Size = new System.Drawing.Size(100, 16);
            this.lbComplementoEnderecoCliente.TabIndex = 2;
            this.lbComplementoEnderecoCliente.Text = "Complemento:";
            // 
            // lbCepCliente
            // 
            this.lbCepCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCepCliente.AutoSize = true;
            this.lbCepCliente.Location = new System.Drawing.Point(610, 105);
            this.lbCepCliente.Name = "lbCepCliente";
            this.lbCepCliente.Size = new System.Drawing.Size(37, 16);
            this.lbCepCliente.TabIndex = 2;
            this.lbCepCliente.Text = "CEP:";
            // 
            // lbCpfCnpjCliente
            // 
            this.lbCpfCnpjCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCpfCnpjCliente.AutoSize = true;
            this.lbCpfCnpjCliente.Location = new System.Drawing.Point(510, 35);
            this.lbCpfCnpjCliente.Name = "lbCpfCnpjCliente";
            this.lbCpfCnpjCliente.Size = new System.Drawing.Size(83, 16);
            this.lbCpfCnpjCliente.TabIndex = 2;
            this.lbCpfCnpjCliente.Text = "CPF / CNPJ:";
            // 
            // lbEstadoCliente
            // 
            this.lbEstadoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEstadoCliente.AutoSize = true;
            this.lbEstadoCliente.Location = new System.Drawing.Point(755, 232);
            this.lbEstadoCliente.Name = "lbEstadoCliente";
            this.lbEstadoCliente.Size = new System.Drawing.Size(28, 16);
            this.lbEstadoCliente.TabIndex = 2;
            this.lbEstadoCliente.Text = "UF:";
            // 
            // lbNumeroCasaCliente
            // 
            this.lbNumeroCasaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumeroCasaCliente.AutoSize = true;
            this.lbNumeroCasaCliente.Location = new System.Drawing.Point(336, 166);
            this.lbNumeroCasaCliente.Name = "lbNumeroCasaCliente";
            this.lbNumeroCasaCliente.Size = new System.Drawing.Size(61, 16);
            this.lbNumeroCasaCliente.TabIndex = 2;
            this.lbNumeroCasaCliente.Text = "Número:";
            // 
            // lbTelefoneCliente
            // 
            this.lbTelefoneCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTelefoneCliente.AutoSize = true;
            this.lbTelefoneCliente.Location = new System.Drawing.Point(441, 105);
            this.lbTelefoneCliente.Name = "lbTelefoneCliente";
            this.lbTelefoneCliente.Size = new System.Drawing.Size(124, 16);
            this.lbTelefoneCliente.TabIndex = 2;
            this.lbTelefoneCliente.Text = "Telefone / Celular:";
            // 
            // lbLocalidadeEnderecoCliente
            // 
            this.lbLocalidadeEnderecoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLocalidadeEnderecoCliente.AutoSize = true;
            this.lbLocalidadeEnderecoCliente.Location = new System.Drawing.Point(361, 229);
            this.lbLocalidadeEnderecoCliente.Name = "lbLocalidadeEnderecoCliente";
            this.lbLocalidadeEnderecoCliente.Size = new System.Drawing.Size(82, 16);
            this.lbLocalidadeEnderecoCliente.TabIndex = 2;
            this.lbLocalidadeEnderecoCliente.Text = "Localidade:";
            // 
            // lbBairroEnderecoCliente
            // 
            this.lbBairroEnderecoCliente.AutoSize = true;
            this.lbBairroEnderecoCliente.Location = new System.Drawing.Point(39, 229);
            this.lbBairroEnderecoCliente.Name = "lbBairroEnderecoCliente";
            this.lbBairroEnderecoCliente.Size = new System.Drawing.Size(50, 16);
            this.lbBairroEnderecoCliente.TabIndex = 2;
            this.lbBairroEnderecoCliente.Text = "Bairro:";
            // 
            // lbLogradouroCLiente
            // 
            this.lbLogradouroCLiente.AutoSize = true;
            this.lbLogradouroCLiente.Location = new System.Drawing.Point(39, 166);
            this.lbLogradouroCLiente.Name = "lbLogradouroCLiente";
            this.lbLogradouroCLiente.Size = new System.Drawing.Size(85, 16);
            this.lbLogradouroCLiente.TabIndex = 2;
            this.lbLogradouroCLiente.Text = "Logradouro:";
            // 
            // lbEmailCliente
            // 
            this.lbEmailCliente.AutoSize = true;
            this.lbEmailCliente.Location = new System.Drawing.Point(39, 101);
            this.lbEmailCliente.Name = "lbEmailCliente";
            this.lbEmailCliente.Size = new System.Drawing.Size(51, 16);
            this.lbEmailCliente.TabIndex = 2;
            this.lbEmailCliente.Text = "E-mail:";
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
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(39, 36);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(111, 16);
            this.lbNomeCliente.TabIndex = 2;
            this.lbNomeCliente.Text = "Nome completo:";
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
            // lbResultadoConsultaCliente
            // 
            this.lbResultadoConsultaCliente.AutoSize = true;
            this.lbResultadoConsultaCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoConsultaCliente.Location = new System.Drawing.Point(18, 387);
            this.lbResultadoConsultaCliente.Name = "lbResultadoConsultaCliente";
            this.lbResultadoConsultaCliente.Size = new System.Drawing.Size(147, 16);
            this.lbResultadoConsultaCliente.TabIndex = 2;
            this.lbResultadoConsultaCliente.Text = "Resultado da consulta";
            // 
            // tpProdutos
            // 
            this.tpProdutos.Controls.Add(this.dgvProdutoPesquisa);
            this.tpProdutos.Controls.Add(this.lbPesquisaProduto);
            this.tpProdutos.Controls.Add(this.grpDadosProduto);
            this.tpProdutos.Controls.Add(this.grpProdutoControles);
            this.tpProdutos.Controls.Add(this.txtProdutoPesquisa);
            this.tpProdutos.Controls.Add(this.btnProdutoPesquisar);
            this.tpProdutos.Controls.Add(this.lbResultadoPesquisaProduto);
            this.tpProdutos.Location = new System.Drawing.Point(4, 25);
            this.tpProdutos.Name = "tpProdutos";
            this.tpProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProdutos.Size = new System.Drawing.Size(1197, 571);
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
            this.dgvProdutoPesquisa.Size = new System.Drawing.Size(1157, 142);
            this.dgvProdutoPesquisa.TabIndex = 19;
            this.dgvProdutoPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutoPesquisa_CellClick);
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
            // lbPesquisaProduto
            // 
            this.lbPesquisaProduto.AutoSize = true;
            this.lbPesquisaProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesquisaProduto.Location = new System.Drawing.Point(354, 12);
            this.lbPesquisaProduto.Name = "lbPesquisaProduto";
            this.lbPesquisaProduto.Size = new System.Drawing.Size(172, 16);
            this.lbPesquisaProduto.TabIndex = 16;
            this.lbPesquisaProduto.Text = "Pesquisar Produto (Nome)";
            // 
            // grpDadosProduto
            // 
            this.grpDadosProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosProduto.Controls.Add(this.nudProdutoQuantidadeEstoque);
            this.grpDadosProduto.Controls.Add(this.lbDescricaoProduto);
            this.grpDadosProduto.Controls.Add(this.lbQuantidadeEstoqueProduto);
            this.grpDadosProduto.Controls.Add(this.lbPrecoProduto);
            this.grpDadosProduto.Controls.Add(this.lbNomeProduto);
            this.grpDadosProduto.Controls.Add(this.txtProdutoDescricao);
            this.grpDadosProduto.Controls.Add(this.txtProdutoPreco);
            this.grpDadosProduto.Controls.Add(this.txtProdutoNome);
            this.grpDadosProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosProduto.Location = new System.Drawing.Point(20, 77);
            this.grpDadosProduto.Name = "grpDadosProduto";
            this.grpDadosProduto.Size = new System.Drawing.Size(868, 295);
            this.grpDadosProduto.TabIndex = 17;
            this.grpDadosProduto.TabStop = false;
            this.grpDadosProduto.Text = "Dados do Produto";
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
            this.nudProdutoQuantidadeEstoque.TabIndex = 18;
            // 
            // lbDescricaoProduto
            // 
            this.lbDescricaoProduto.AutoSize = true;
            this.lbDescricaoProduto.Location = new System.Drawing.Point(39, 155);
            this.lbDescricaoProduto.Name = "lbDescricaoProduto";
            this.lbDescricaoProduto.Size = new System.Drawing.Size(73, 16);
            this.lbDescricaoProduto.TabIndex = 2;
            this.lbDescricaoProduto.Text = "Descrição:";
            // 
            // lbQuantidadeEstoqueProduto
            // 
            this.lbQuantidadeEstoqueProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantidadeEstoqueProduto.AutoSize = true;
            this.lbQuantidadeEstoqueProduto.Location = new System.Drawing.Point(639, 93);
            this.lbQuantidadeEstoqueProduto.Name = "lbQuantidadeEstoqueProduto";
            this.lbQuantidadeEstoqueProduto.Size = new System.Drawing.Size(163, 16);
            this.lbQuantidadeEstoqueProduto.TabIndex = 2;
            this.lbQuantidadeEstoqueProduto.Text = "Quantidade em Estoque:";
            // 
            // lbPrecoProduto
            // 
            this.lbPrecoProduto.AutoSize = true;
            this.lbPrecoProduto.Location = new System.Drawing.Point(39, 93);
            this.lbPrecoProduto.Name = "lbPrecoProduto";
            this.lbPrecoProduto.Size = new System.Drawing.Size(48, 16);
            this.lbPrecoProduto.TabIndex = 2;
            this.lbPrecoProduto.Text = "Preço:";
            // 
            // lbNomeProduto
            // 
            this.lbNomeProduto.AutoSize = true;
            this.lbNomeProduto.Location = new System.Drawing.Point(39, 36);
            this.lbNomeProduto.Name = "lbNomeProduto";
            this.lbNomeProduto.Size = new System.Drawing.Size(48, 16);
            this.lbNomeProduto.TabIndex = 2;
            this.lbNomeProduto.Text = "Nome:";
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
            this.txtProdutoDescricao.TabIndex = 19;
            // 
            // txtProdutoPreco
            // 
            this.txtProdutoPreco.AccessibleName = "Preço";
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
            this.txtProdutoPreco.TabIndex = 17;
            this.txtProdutoPreco.TextChanged += new System.EventHandler(this.txtProdutoPreco_TextChanged);
            // 
            // txtProdutoNome
            // 
            this.txtProdutoNome.AccessibleName = "Nome";
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
            this.txtProdutoNome.TabIndex = 16;
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
            this.btnProdutoRemover.TabIndex = 23;
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
            this.btnProdutoSalvar.TabIndex = 22;
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
            this.btnProdutoNovo.TabIndex = 21;
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
            this.btnProdutoPesquisar.Click += new System.EventHandler(this.btnProdutoPesquisar_Click);
            // 
            // lbResultadoPesquisaProduto
            // 
            this.lbResultadoPesquisaProduto.AutoSize = true;
            this.lbResultadoPesquisaProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultadoPesquisaProduto.Location = new System.Drawing.Point(19, 389);
            this.lbResultadoPesquisaProduto.Name = "lbResultadoPesquisaProduto";
            this.lbResultadoPesquisaProduto.Size = new System.Drawing.Size(147, 16);
            this.lbResultadoPesquisaProduto.TabIndex = 18;
            this.lbResultadoPesquisaProduto.Text = "Resultado da consulta";
            // 
            // tpVenda
            // 
            this.tpVenda.Controls.Add(this.grpResumoPedido);
            this.tpVenda.Controls.Add(this.kryptonGroupBox1);
            this.tpVenda.Controls.Add(this.dgvPedidoProdutos);
            this.tpVenda.Controls.Add(this.label27);
            this.tpVenda.Controls.Add(this.grpDadosProdutoPedido);
            this.tpVenda.Controls.Add(this.grpDadosPedido);
            this.tpVenda.Location = new System.Drawing.Point(4, 25);
            this.tpVenda.Name = "tpVenda";
            this.tpVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenda.Size = new System.Drawing.Size(1197, 571);
            this.tpVenda.TabIndex = 3;
            this.tpVenda.Text = "Vendas";
            this.tpVenda.UseVisualStyleBackColor = true;
            // 
            // grpResumoPedido
            // 
            this.grpResumoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResumoPedido.Controls.Add(this.lbResumoValorSaldo);
            this.grpResumoPedido.Controls.Add(this.lbResumoValorPago);
            this.grpResumoPedido.Controls.Add(this.lbResumoValorTotal);
            this.grpResumoPedido.Controls.Add(this.txtPedidoSaldo);
            this.grpResumoPedido.Controls.Add(this.txtPedidoValorPago);
            this.grpResumoPedido.Controls.Add(this.txtPedidoValorTotal);
            this.grpResumoPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResumoPedido.Location = new System.Drawing.Point(895, 379);
            this.grpResumoPedido.Name = "grpResumoPedido";
            this.grpResumoPedido.Size = new System.Drawing.Size(283, 181);
            this.grpResumoPedido.TabIndex = 27;
            this.grpResumoPedido.TabStop = false;
            this.grpResumoPedido.Text = "Resumo Pedido";
            // 
            // lbResumoValorSaldo
            // 
            this.lbResumoValorSaldo.AutoSize = true;
            this.lbResumoValorSaldo.Location = new System.Drawing.Point(27, 123);
            this.lbResumoValorSaldo.Name = "lbResumoValorSaldo";
            this.lbResumoValorSaldo.Size = new System.Drawing.Size(48, 16);
            this.lbResumoValorSaldo.TabIndex = 2;
            this.lbResumoValorSaldo.Text = "Saldo:";
            // 
            // lbResumoValorPago
            // 
            this.lbResumoValorPago.AutoSize = true;
            this.lbResumoValorPago.Location = new System.Drawing.Point(27, 71);
            this.lbResumoValorPago.Name = "lbResumoValorPago";
            this.lbResumoValorPago.Size = new System.Drawing.Size(81, 16);
            this.lbResumoValorPago.TabIndex = 2;
            this.lbResumoValorPago.Text = "Valor Pago:";
            // 
            // lbResumoValorTotal
            // 
            this.lbResumoValorTotal.AutoSize = true;
            this.lbResumoValorTotal.Location = new System.Drawing.Point(27, 21);
            this.lbResumoValorTotal.Name = "lbResumoValorTotal";
            this.lbResumoValorTotal.Size = new System.Drawing.Size(79, 16);
            this.lbResumoValorTotal.TabIndex = 2;
            this.lbResumoValorTotal.Text = "Valor Total:";
            // 
            // txtPedidoSaldo
            // 
            this.txtPedidoSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoSaldo.Location = new System.Drawing.Point(19, 142);
            this.txtPedidoSaldo.Name = "txtPedidoSaldo";
            this.txtPedidoSaldo.ReadOnly = true;
            this.txtPedidoSaldo.Size = new System.Drawing.Size(245, 28);
            this.txtPedidoSaldo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoSaldo.StateCommon.Border.Rounding = 18;
            this.txtPedidoSaldo.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtPedidoSaldo.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoSaldo.TabIndex = 0;
            // 
            // txtPedidoValorPago
            // 
            this.txtPedidoValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoValorPago.Location = new System.Drawing.Point(19, 90);
            this.txtPedidoValorPago.Name = "txtPedidoValorPago";
            this.txtPedidoValorPago.ReadOnly = true;
            this.txtPedidoValorPago.Size = new System.Drawing.Size(245, 28);
            this.txtPedidoValorPago.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoValorPago.StateCommon.Border.Rounding = 18;
            this.txtPedidoValorPago.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.txtPedidoValorPago.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoValorPago.TabIndex = 0;
            // 
            // txtPedidoValorTotal
            // 
            this.txtPedidoValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoValorTotal.Location = new System.Drawing.Point(19, 40);
            this.txtPedidoValorTotal.Name = "txtPedidoValorTotal";
            this.txtPedidoValorTotal.ReadOnly = true;
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
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnPedidoCaixa);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtPedidoPesquisa);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnPedidoPesquisar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnPedidoCancelar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnPedidoFinalizar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnPedidoSalvar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnPedidoNovo);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(283, 353);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox1.TabIndex = 1;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(27, 6);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(180, 16);
            this.label28.TabIndex = 29;
            this.label28.Text = "Pesquisar Pedido (Número)";
            // 
            // btnPedidoCaixa
            // 
            this.btnPedidoCaixa.Location = new System.Drawing.Point(15, 177);
            this.btnPedidoCaixa.Name = "btnPedidoCaixa";
            this.btnPedidoCaixa.Size = new System.Drawing.Size(245, 48);
            this.btnPedidoCaixa.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoCaixa.StateCommon.Border.Rounding = 20;
            this.btnPedidoCaixa.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoCaixa.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoCaixa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoCaixa.TabIndex = 5;
            this.btnPedidoCaixa.Values.Image = global::TestePraticoDeMaria.Properties.Resources.dinheiro__1_;
            this.btnPedidoCaixa.Values.Text = "  Caixa";
            this.btnPedidoCaixa.Click += new System.EventHandler(this.btnPedidoCaixa_Click);
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
            this.txtPedidoPesquisa.TabIndex = 1;
            // 
            // btnPedidoPesquisar
            // 
            this.btnPedidoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidoPesquisar.Location = new System.Drawing.Point(209, 16);
            this.btnPedidoPesquisar.Name = "btnPedidoPesquisar";
            this.btnPedidoPesquisar.Size = new System.Drawing.Size(51, 48);
            this.btnPedidoPesquisar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoPesquisar.StateCommon.Border.Rounding = 20;
            this.btnPedidoPesquisar.TabIndex = 2;
            this.btnPedidoPesquisar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.pesquisar__2_;
            this.btnPedidoPesquisar.Values.Text = "";
            this.btnPedidoPesquisar.Click += new System.EventHandler(this.btnPedidoPesquisar_Click);
            // 
            // btnPedidoCancelar
            // 
            this.btnPedidoCancelar.Location = new System.Drawing.Point(15, 283);
            this.btnPedidoCancelar.Name = "btnPedidoCancelar";
            this.btnPedidoCancelar.Size = new System.Drawing.Size(245, 48);
            this.btnPedidoCancelar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoCancelar.StateCommon.Border.Rounding = 20;
            this.btnPedidoCancelar.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoCancelar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoCancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoCancelar.TabIndex = 7;
            this.btnPedidoCancelar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.remover__2_;
            this.btnPedidoCancelar.Values.Text = " Cancelar";
            this.btnPedidoCancelar.Click += new System.EventHandler(this.btnPedidoCancelar_Click);
            // 
            // btnPedidoFinalizar
            // 
            this.btnPedidoFinalizar.Location = new System.Drawing.Point(15, 230);
            this.btnPedidoFinalizar.Name = "btnPedidoFinalizar";
            this.btnPedidoFinalizar.Size = new System.Drawing.Size(245, 48);
            this.btnPedidoFinalizar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoFinalizar.StateCommon.Border.Rounding = 20;
            this.btnPedidoFinalizar.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoFinalizar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoFinalizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoFinalizar.TabIndex = 6;
            this.btnPedidoFinalizar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.pacote;
            this.btnPedidoFinalizar.Values.Text = "Finalizar";
            this.btnPedidoFinalizar.Click += new System.EventHandler(this.btnPedidoFinalizar_Click);
            // 
            // btnPedidoSalvar
            // 
            this.btnPedidoSalvar.Location = new System.Drawing.Point(15, 124);
            this.btnPedidoSalvar.Name = "btnPedidoSalvar";
            this.btnPedidoSalvar.Size = new System.Drawing.Size(245, 48);
            this.btnPedidoSalvar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoSalvar.StateCommon.Border.Rounding = 20;
            this.btnPedidoSalvar.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoSalvar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoSalvar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoSalvar.TabIndex = 5;
            this.btnPedidoSalvar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Salvar;
            this.btnPedidoSalvar.Values.Text = "\tSalvar";
            this.btnPedidoSalvar.Click += new System.EventHandler(this.btnPedidoSalvar_Click);
            // 
            // btnPedidoNovo
            // 
            this.btnPedidoNovo.Location = new System.Drawing.Point(15, 70);
            this.btnPedidoNovo.Name = "btnPedidoNovo";
            this.btnPedidoNovo.Size = new System.Drawing.Size(245, 49);
            this.btnPedidoNovo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoNovo.StateCommon.Border.Rounding = 20;
            this.btnPedidoNovo.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoNovo.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoNovo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoNovo.TabIndex = 3;
            this.btnPedidoNovo.Values.Image = global::TestePraticoDeMaria.Properties.Resources.arquivo__1_;
            this.btnPedidoNovo.Values.Text = "\tNovo";
            this.btnPedidoNovo.Click += new System.EventHandler(this.btnPedidoNovo_Click);
            // 
            // dgvPedidoProdutos
            // 
            this.dgvPedidoProdutos.AllowUserToAddRows = false;
            this.dgvPedidoProdutos.AllowUserToDeleteRows = false;
            this.dgvPedidoProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidoProdutos.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvPedidoProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdutoVenda,
            this.colQuantiade,
            this.colValorUnitario,
            this.colValorTotal,
            this.colProdutoId});
            this.dgvPedidoProdutos.Location = new System.Drawing.Point(19, 394);
            this.dgvPedidoProdutos.Name = "dgvPedidoProdutos";
            this.dgvPedidoProdutos.ReadOnly = true;
            this.dgvPedidoProdutos.Size = new System.Drawing.Size(870, 166);
            this.dgvPedidoProdutos.TabIndex = 12;
            this.dgvPedidoProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidoProdutos_CellClick);
            // 
            // colProdutoVenda
            // 
            this.colProdutoVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProdutoVenda.DataPropertyName = "Produto";
            this.colProdutoVenda.HeaderText = "Produto";
            this.colProdutoVenda.MinimumWidth = 150;
            this.colProdutoVenda.Name = "colProdutoVenda";
            this.colProdutoVenda.ReadOnly = true;
            // 
            // colQuantiade
            // 
            this.colQuantiade.DataPropertyName = "quantidade";
            this.colQuantiade.HeaderText = "Quantidade";
            this.colQuantiade.MinimumWidth = 100;
            this.colQuantiade.Name = "colQuantiade";
            this.colQuantiade.ReadOnly = true;
            // 
            // colValorUnitario
            // 
            this.colValorUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValorUnitario.DataPropertyName = "valorunitario";
            this.colValorUnitario.HeaderText = "Valor Unitário";
            this.colValorUnitario.MinimumWidth = 150;
            this.colValorUnitario.Name = "colValorUnitario";
            this.colValorUnitario.ReadOnly = true;
            // 
            // colValorTotal
            // 
            this.colValorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValorTotal.DataPropertyName = "valortotal";
            this.colValorTotal.HeaderText = "Valor Total";
            this.colValorTotal.MinimumWidth = 100;
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.ReadOnly = true;
            // 
            // colProdutoId
            // 
            this.colProdutoId.DataPropertyName = "produtos_id";
            this.colProdutoId.HeaderText = "ProdutoID";
            this.colProdutoId.Name = "colProdutoId";
            this.colProdutoId.ReadOnly = true;
            this.colProdutoId.Visible = false;
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
            // grpDadosProdutoPedido
            // 
            this.grpDadosProdutoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosProdutoPedido.Controls.Add(this.lbProdutoNomePedido);
            this.grpDadosProdutoPedido.Controls.Add(this.btnPedidoRemoverProduto);
            this.grpDadosProdutoPedido.Controls.Add(this.cmbPedidoProdutos);
            this.grpDadosProdutoPedido.Controls.Add(this.btnPedidoSalvarProduto);
            this.grpDadosProdutoPedido.Controls.Add(this.lbProdutoValorTotalitemPedido);
            this.grpDadosProdutoPedido.Controls.Add(this.lbProdutoValorUnidadePedido);
            this.grpDadosProdutoPedido.Controls.Add(this.lbProdutoQuantidadePedido);
            this.grpDadosProdutoPedido.Controls.Add(this.txtPedidoProdutoValorTotal);
            this.grpDadosProdutoPedido.Controls.Add(this.txtPedidoProdutoValorUnitario);
            this.grpDadosProdutoPedido.Controls.Add(this.nudPedidoProdutoQuantidade);
            this.grpDadosProdutoPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosProdutoPedido.Location = new System.Drawing.Point(21, 201);
            this.grpDadosProdutoPedido.Name = "grpDadosProdutoPedido";
            this.grpDadosProdutoPedido.Size = new System.Drawing.Size(868, 170);
            this.grpDadosProdutoPedido.TabIndex = 23;
            this.grpDadosProdutoPedido.TabStop = false;
            this.grpDadosProdutoPedido.Text = "Dados do Produto";
            // 
            // lbProdutoNomePedido
            // 
            this.lbProdutoNomePedido.AutoSize = true;
            this.lbProdutoNomePedido.Location = new System.Drawing.Point(36, 18);
            this.lbProdutoNomePedido.Name = "lbProdutoNomePedido";
            this.lbProdutoNomePedido.Size = new System.Drawing.Size(61, 16);
            this.lbProdutoNomePedido.TabIndex = 2;
            this.lbProdutoNomePedido.Text = "Produto:";
            // 
            // btnPedidoRemoverProduto
            // 
            this.btnPedidoRemoverProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidoRemoverProduto.Location = new System.Drawing.Point(665, 98);
            this.btnPedidoRemoverProduto.Name = "btnPedidoRemoverProduto";
            this.btnPedidoRemoverProduto.Size = new System.Drawing.Size(184, 48);
            this.btnPedidoRemoverProduto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoRemoverProduto.StateCommon.Border.Rounding = 20;
            this.btnPedidoRemoverProduto.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoRemoverProduto.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoRemoverProduto.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoRemoverProduto.TabIndex = 11;
            this.btnPedidoRemoverProduto.Values.Image = global::TestePraticoDeMaria.Properties.Resources.remover__2_;
            this.btnPedidoRemoverProduto.Values.Text = " Remover";
            this.btnPedidoRemoverProduto.Click += new System.EventHandler(this.btnPedidoRemoverProduto_Click);
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
            this.cmbPedidoProdutos.TabIndex = 6;
            this.cmbPedidoProdutos.SelectedValueChanged += new System.EventHandler(this.cmbPedidoProdutos_SelectedValueChanged);
            // 
            // btnPedidoSalvarProduto
            // 
            this.btnPedidoSalvarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidoSalvarProduto.Location = new System.Drawing.Point(462, 98);
            this.btnPedidoSalvarProduto.Name = "btnPedidoSalvarProduto";
            this.btnPedidoSalvarProduto.Size = new System.Drawing.Size(184, 48);
            this.btnPedidoSalvarProduto.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoSalvarProduto.StateCommon.Border.Rounding = 20;
            this.btnPedidoSalvarProduto.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoSalvarProduto.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoSalvarProduto.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoSalvarProduto.TabIndex = 10;
            this.btnPedidoSalvarProduto.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Adicionar;
            this.btnPedidoSalvarProduto.Values.Text = " Adicionar";
            this.btnPedidoSalvarProduto.Click += new System.EventHandler(this.btnPedidoSalvarProduto_Click);
            // 
            // lbProdutoValorTotalitemPedido
            // 
            this.lbProdutoValorTotalitemPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProdutoValorTotalitemPedido.AutoSize = true;
            this.lbProdutoValorTotalitemPedido.Location = new System.Drawing.Point(214, 94);
            this.lbProdutoValorTotalitemPedido.Name = "lbProdutoValorTotalitemPedido";
            this.lbProdutoValorTotalitemPedido.Size = new System.Drawing.Size(79, 16);
            this.lbProdutoValorTotalitemPedido.TabIndex = 2;
            this.lbProdutoValorTotalitemPedido.Text = "Valor Total:";
            // 
            // lbProdutoValorUnidadePedido
            // 
            this.lbProdutoValorUnidadePedido.AutoSize = true;
            this.lbProdutoValorUnidadePedido.Location = new System.Drawing.Point(36, 94);
            this.lbProdutoValorUnidadePedido.Name = "lbProdutoValorUnidadePedido";
            this.lbProdutoValorUnidadePedido.Size = new System.Drawing.Size(98, 16);
            this.lbProdutoValorUnidadePedido.TabIndex = 2;
            this.lbProdutoValorUnidadePedido.Text = "Valor Unitário:";
            // 
            // lbProdutoQuantidadePedido
            // 
            this.lbProdutoQuantidadePedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProdutoQuantidadePedido.AutoSize = true;
            this.lbProdutoQuantidadePedido.Location = new System.Drawing.Point(676, 18);
            this.lbProdutoQuantidadePedido.Name = "lbProdutoQuantidadePedido";
            this.lbProdutoQuantidadePedido.Size = new System.Drawing.Size(85, 16);
            this.lbProdutoQuantidadePedido.TabIndex = 6;
            this.lbProdutoQuantidadePedido.Text = "Quantidade:";
            // 
            // txtPedidoProdutoValorTotal
            // 
            this.txtPedidoProdutoValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoProdutoValorTotal.Location = new System.Drawing.Point(200, 113);
            this.txtPedidoProdutoValorTotal.Name = "txtPedidoProdutoValorTotal";
            this.txtPedidoProdutoValorTotal.ReadOnly = true;
            this.txtPedidoProdutoValorTotal.Size = new System.Drawing.Size(239, 33);
            this.txtPedidoProdutoValorTotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoProdutoValorTotal.StateCommon.Border.Rounding = 18;
            this.txtPedidoProdutoValorTotal.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoProdutoValorTotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoProdutoValorTotal.TabIndex = 9;
            // 
            // txtPedidoProdutoValorUnitario
            // 
            this.txtPedidoProdutoValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPedidoProdutoValorUnitario.Location = new System.Drawing.Point(22, 113);
            this.txtPedidoProdutoValorUnitario.Name = "txtPedidoProdutoValorUnitario";
            this.txtPedidoProdutoValorUnitario.ReadOnly = true;
            this.txtPedidoProdutoValorUnitario.Size = new System.Drawing.Size(154, 33);
            this.txtPedidoProdutoValorUnitario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoProdutoValorUnitario.StateCommon.Border.Rounding = 18;
            this.txtPedidoProdutoValorUnitario.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoProdutoValorUnitario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoProdutoValorUnitario.TabIndex = 8;
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
            this.nudPedidoProdutoQuantidade.ValueChanged += new System.EventHandler(this.nudPedidoProdutoQuantidade_ValueChanged);
            // 
            // grpDadosPedido
            // 
            this.grpDadosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosPedido.Controls.Add(this.lbObservacaoPedido);
            this.grpDadosPedido.Controls.Add(this.txtPedidoObservacao);
            this.grpDadosPedido.Controls.Add(this.cmbPedidoClientes);
            this.grpDadosPedido.Controls.Add(this.btnPedidoVoltar);
            this.grpDadosPedido.Controls.Add(this.btnPedidoAvancar);
            this.grpDadosPedido.Controls.Add(this.lbClientePedido);
            this.grpDadosPedido.Controls.Add(this.lbDataCancelamentoPedido);
            this.grpDadosPedido.Controls.Add(this.lbDataConclusaoPedido);
            this.grpDadosPedido.Controls.Add(this.lbDataPedido);
            this.grpDadosPedido.Controls.Add(this.lbNumeroPedido);
            this.grpDadosPedido.Controls.Add(this.txtPedidoDataCancelado);
            this.grpDadosPedido.Controls.Add(this.txtPedidoDataFinalizado);
            this.grpDadosPedido.Controls.Add(this.txtPedidoDataInclusao);
            this.grpDadosPedido.Controls.Add(this.txtPedidoNumero);
            this.grpDadosPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDadosPedido.Location = new System.Drawing.Point(21, 16);
            this.grpDadosPedido.Name = "grpDadosPedido";
            this.grpDadosPedido.Size = new System.Drawing.Size(868, 179);
            this.grpDadosPedido.TabIndex = 21;
            this.grpDadosPedido.TabStop = false;
            this.grpDadosPedido.Text = "Dados do Pedido";
            // 
            // lbObservacaoPedido
            // 
            this.lbObservacaoPedido.AutoSize = true;
            this.lbObservacaoPedido.Location = new System.Drawing.Point(36, 84);
            this.lbObservacaoPedido.Name = "lbObservacaoPedido";
            this.lbObservacaoPedido.Size = new System.Drawing.Size(86, 16);
            this.lbObservacaoPedido.TabIndex = 6;
            this.lbObservacaoPedido.Text = "Observação:";
            // 
            // txtPedidoObservacao
            // 
            this.txtPedidoObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPedidoObservacao.Location = new System.Drawing.Point(19, 103);
            this.txtPedidoObservacao.Multiline = true;
            this.txtPedidoObservacao.Name = "txtPedidoObservacao";
            this.txtPedidoObservacao.Size = new System.Drawing.Size(508, 61);
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
            this.cmbPedidoClientes.Location = new System.Drawing.Point(536, 103);
            this.cmbPedidoClientes.Name = "cmbPedidoClientes";
            this.cmbPedidoClientes.Size = new System.Drawing.Size(326, 36);
            this.cmbPedidoClientes.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbPedidoClientes.StateCommon.ComboBox.Border.Rounding = 18;
            this.cmbPedidoClientes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPedidoClientes.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbPedidoClientes.TabIndex = 4;
            this.cmbPedidoClientes.SelectedValueChanged += new System.EventHandler(this.cmbPedidoClientes_SelectedValueChanged);
            // 
            // btnPedidoVoltar
            // 
            this.btnPedidoVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidoVoltar.Location = new System.Drawing.Point(639, 20);
            this.btnPedidoVoltar.Name = "btnPedidoVoltar";
            this.btnPedidoVoltar.Size = new System.Drawing.Size(110, 48);
            this.btnPedidoVoltar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoVoltar.StateCommon.Border.Rounding = 20;
            this.btnPedidoVoltar.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoVoltar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnPedidoVoltar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoVoltar.TabIndex = 17;
            this.btnPedidoVoltar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.seta__4_;
            this.btnPedidoVoltar.Values.Text = "Anterior";
            this.btnPedidoVoltar.Click += new System.EventHandler(this.btnPedidoVoltar_Click);
            // 
            // btnPedidoAvancar
            // 
            this.btnPedidoAvancar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedidoAvancar.Location = new System.Drawing.Point(755, 20);
            this.btnPedidoAvancar.Name = "btnPedidoAvancar";
            this.btnPedidoAvancar.Size = new System.Drawing.Size(107, 48);
            this.btnPedidoAvancar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPedidoAvancar.StateCommon.Border.Rounding = 20;
            this.btnPedidoAvancar.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnPedidoAvancar.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnPedidoAvancar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAvancar.TabIndex = 17;
            this.btnPedidoAvancar.Values.Image = global::TestePraticoDeMaria.Properties.Resources.seta__3_;
            this.btnPedidoAvancar.Values.Text = "Próximo";
            this.btnPedidoAvancar.Click += new System.EventHandler(this.btnPedidoAvancar_Click);
            // 
            // lbClientePedido
            // 
            this.lbClientePedido.AutoSize = true;
            this.lbClientePedido.Location = new System.Drawing.Point(554, 85);
            this.lbClientePedido.Name = "lbClientePedido";
            this.lbClientePedido.Size = new System.Drawing.Size(56, 16);
            this.lbClientePedido.TabIndex = 2;
            this.lbClientePedido.Text = "Cliente:";
            // 
            // lbDataCancelamentoPedido
            // 
            this.lbDataCancelamentoPedido.AutoSize = true;
            this.lbDataCancelamentoPedido.Location = new System.Drawing.Point(416, 25);
            this.lbDataCancelamentoPedido.Name = "lbDataCancelamentoPedido";
            this.lbDataCancelamentoPedido.Size = new System.Drawing.Size(112, 16);
            this.lbDataCancelamentoPedido.TabIndex = 2;
            this.lbDataCancelamentoPedido.Text = "Data Cancelado:";
            // 
            // lbDataConclusaoPedido
            // 
            this.lbDataConclusaoPedido.AutoSize = true;
            this.lbDataConclusaoPedido.Location = new System.Drawing.Point(306, 25);
            this.lbDataConclusaoPedido.Name = "lbDataConclusaoPedido";
            this.lbDataConclusaoPedido.Size = new System.Drawing.Size(108, 16);
            this.lbDataConclusaoPedido.TabIndex = 2;
            this.lbDataConclusaoPedido.Text = "Data Concluido:";
            // 
            // lbDataPedido
            // 
            this.lbDataPedido.AutoSize = true;
            this.lbDataPedido.Location = new System.Drawing.Point(197, 25);
            this.lbDataPedido.Name = "lbDataPedido";
            this.lbDataPedido.Size = new System.Drawing.Size(89, 16);
            this.lbDataPedido.TabIndex = 2;
            this.lbDataPedido.Text = "Data Pedido:";
            // 
            // lbNumeroPedido
            // 
            this.lbNumeroPedido.AutoSize = true;
            this.lbNumeroPedido.Location = new System.Drawing.Point(36, 25);
            this.lbNumeroPedido.Name = "lbNumeroPedido";
            this.lbNumeroPedido.Size = new System.Drawing.Size(130, 16);
            this.lbNumeroPedido.TabIndex = 2;
            this.lbNumeroPedido.Text = "Número do Pedido:";
            // 
            // txtPedidoDataCancelado
            // 
            this.txtPedidoDataCancelado.Location = new System.Drawing.Point(416, 44);
            this.txtPedidoDataCancelado.Name = "txtPedidoDataCancelado";
            this.txtPedidoDataCancelado.ReadOnly = true;
            this.txtPedidoDataCancelado.Size = new System.Drawing.Size(111, 33);
            this.txtPedidoDataCancelado.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoDataCancelado.StateCommon.Border.Rounding = 18;
            this.txtPedidoDataCancelado.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoDataCancelado.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoDataCancelado.TabIndex = 99;
            // 
            // txtPedidoDataFinalizado
            // 
            this.txtPedidoDataFinalizado.Location = new System.Drawing.Point(299, 44);
            this.txtPedidoDataFinalizado.Name = "txtPedidoDataFinalizado";
            this.txtPedidoDataFinalizado.ReadOnly = true;
            this.txtPedidoDataFinalizado.Size = new System.Drawing.Size(111, 33);
            this.txtPedidoDataFinalizado.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoDataFinalizado.StateCommon.Border.Rounding = 18;
            this.txtPedidoDataFinalizado.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoDataFinalizado.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoDataFinalizado.TabIndex = 99;
            // 
            // txtPedidoDataInclusao
            // 
            this.txtPedidoDataInclusao.Location = new System.Drawing.Point(182, 44);
            this.txtPedidoDataInclusao.Name = "txtPedidoDataInclusao";
            this.txtPedidoDataInclusao.ReadOnly = true;
            this.txtPedidoDataInclusao.Size = new System.Drawing.Size(111, 33);
            this.txtPedidoDataInclusao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoDataInclusao.StateCommon.Border.Rounding = 18;
            this.txtPedidoDataInclusao.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoDataInclusao.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoDataInclusao.TabIndex = 99;
            // 
            // txtPedidoNumero
            // 
            this.txtPedidoNumero.Location = new System.Drawing.Point(22, 44);
            this.txtPedidoNumero.Name = "txtPedidoNumero";
            this.txtPedidoNumero.ReadOnly = true;
            this.txtPedidoNumero.Size = new System.Drawing.Size(154, 33);
            this.txtPedidoNumero.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPedidoNumero.StateCommon.Border.Rounding = 18;
            this.txtPedidoNumero.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedidoNumero.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPedidoNumero.TabIndex = 99;
            // 
            // tpRelatorios
            // 
            this.tpRelatorios.Controls.Add(this.kryptonGroupBox2);
            this.tpRelatorios.Controls.Add(this.rvwRelatorios);
            this.tpRelatorios.Location = new System.Drawing.Point(4, 25);
            this.tpRelatorios.Name = "tpRelatorios";
            this.tpRelatorios.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatorios.Size = new System.Drawing.Size(1197, 571);
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
            this.kryptonGroupBox2.Panel.Controls.Add(this.dtpDataFinal);
            this.kryptonGroupBox2.Panel.Controls.Add(this.dtpDataInicial);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnGerarRelatorio);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lstRelatorios);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(269, 565);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(129, 432);
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
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(17, 432);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 16);
            this.label30.TabIndex = 19;
            this.label30.Text = "Data Inicial";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataFinal.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.Enabled = false;
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(132, 451);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(103, 22);
            this.dtpDataFinal.TabIndex = 4;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataInicial.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.Enabled = false;
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(20, 451);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(103, 22);
            this.dtpDataInicial.TabIndex = 3;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(20, 484);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(215, 48);
            this.btnGerarRelatorio.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGerarRelatorio.StateCommon.Border.Rounding = 20;
            this.btnGerarRelatorio.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnGerarRelatorio.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnGerarRelatorio.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.TabIndex = 5;
            this.btnGerarRelatorio.Values.Image = global::TestePraticoDeMaria.Properties.Resources.grafico__1_;
            this.btnGerarRelatorio.Values.Text = " Gerar Relatório";
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // lstRelatorios
            // 
            this.lstRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRelatorios.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRelatorios.FormattingEnabled = true;
            this.lstRelatorios.ItemHeight = 17;
            this.lstRelatorios.Items.AddRange(new object[] {
            "Produtos Estoque",
            "Clientes",
            "Vendas Finalizadas"});
            this.lstRelatorios.Location = new System.Drawing.Point(20, 30);
            this.lstRelatorios.Name = "lstRelatorios";
            this.lstRelatorios.Size = new System.Drawing.Size(226, 395);
            this.lstRelatorios.TabIndex = 2;
            this.lstRelatorios.SelectedValueChanged += new System.EventHandler(this.lstRelatorios_SelectedValueChanged);
            // 
            // rvwRelatorios
            // 
            this.rvwRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvwRelatorios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rvwRelatorios.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rvwRelatorios.DocumentMapCollapsed = true;
            this.rvwRelatorios.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rvwRelatorios.LocalReport.ReportEmbeddedResource = "TestePraticoDeMaria.Relatorios.rptProdutosEstoque.rdlc";
            this.rvwRelatorios.Location = new System.Drawing.Point(278, 6);
            this.rvwRelatorios.Name = "rvwRelatorios";
            this.rvwRelatorios.ServerReport.BearerToken = null;
            this.rvwRelatorios.ShowBackButton = false;
            this.rvwRelatorios.ShowContextMenu = false;
            this.rvwRelatorios.ShowCredentialPrompts = false;
            this.rvwRelatorios.ShowDocumentMapButton = false;
            this.rvwRelatorios.ShowFindControls = false;
            this.rvwRelatorios.ShowParameterPrompts = false;
            this.rvwRelatorios.ShowProgress = false;
            this.rvwRelatorios.ShowPromptAreaButton = false;
            this.rvwRelatorios.ShowRefreshButton = false;
            this.rvwRelatorios.ShowStopButton = false;
            this.rvwRelatorios.Size = new System.Drawing.Size(916, 562);
            this.rvwRelatorios.TabIndex = 1;
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
            this.btnConfiguracao.TabIndex = 5;
            this.btnConfiguracao.Values.Image = global::TestePraticoDeMaria.Properties.Resources.configuracao;
            this.btnConfiguracao.Values.Text = "";
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.grpDadosProduto.ResumeLayout(false);
            this.grpDadosProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles.Panel)).EndInit();
            this.grpProdutoControles.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpProdutoControles)).EndInit();
            this.grpProdutoControles.ResumeLayout(false);
            this.tpVenda.ResumeLayout(false);
            this.tpVenda.PerformLayout();
            this.grpResumoPedido.ResumeLayout(false);
            this.grpResumoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProdutos)).EndInit();
            this.grpDadosProdutoPedido.ResumeLayout(false);
            this.grpDadosProdutoPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPedidoProdutos)).EndInit();
            this.grpDadosPedido.ResumeLayout(false);
            this.grpDadosPedido.PerformLayout();
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
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbPesquisaCliente;
        private System.Windows.Forms.Label lbCpfCnpjCliente;
        private System.Windows.Forms.Label lbCepCliente;
        private System.Windows.Forms.Label lbTelefoneCliente;
        private System.Windows.Forms.Label lbEmailCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClientePesquisarCEP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteTelefoneCelular;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoCEP;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEmail;
        private System.Windows.Forms.Label lbComplementoEnderecoCliente;
        private System.Windows.Forms.Label lbNumeroCasaCliente;
        private System.Windows.Forms.Label lbLogradouroCLiente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoComplemento;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoLogradouro;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbClienteEnderecoUf;
        private System.Windows.Forms.Label lbEstadoCliente;
        private System.Windows.Forms.Label lbLocalidadeEnderecoCliente;
        private System.Windows.Forms.Label lbBairroEnderecoCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoLocalidade;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtClienteEnderecoBairro;
        private System.Windows.Forms.DataGridView dgvClientePesquisa;
        private System.Windows.Forms.Label lbResultadoConsultaCliente;
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
        private System.Windows.Forms.Label lbPesquisaProduto;
        private System.Windows.Forms.GroupBox grpDadosProduto;
        private System.Windows.Forms.Label lbDescricaoProduto;
        private System.Windows.Forms.Label lbNomeProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoDescricao;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoPesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProdutoPesquisar;
        private System.Windows.Forms.Label lbResultadoPesquisaProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nudProdutoQuantidadeEstoque;
        private System.Windows.Forms.Label lbQuantidadeEstoqueProduto;
        private System.Windows.Forms.Label lbPrecoProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdutoPreco;
        private System.Windows.Forms.GroupBox grpDadosPedido;
        private System.Windows.Forms.Label lbNumeroPedido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbPedidoProdutos;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbPedidoClientes;
        private System.Windows.Forms.Label lbProdutoNomePedido;
        private System.Windows.Forms.Label lbClientePedido;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoRemoverProduto;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoSalvarProduto;
        private System.Windows.Forms.Label lbObservacaoPedido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoObservacao;
        private System.Windows.Forms.GroupBox grpDadosProdutoPedido;
        private System.Windows.Forms.Label lbProdutoQuantidadePedido;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nudPedidoProdutoQuantidade;
        private System.Windows.Forms.DataGridView dgvPedidoProdutos;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbProdutoValorTotalitemPedido;
        private System.Windows.Forms.Label lbProdutoValorUnidadePedido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoProdutoValorTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoProdutoValorUnitario;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label28;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoCaixa;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoPesquisa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoPesquisar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoFinalizar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoSalvar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoNovo;
        private System.Windows.Forms.GroupBox grpResumoPedido;
        private System.Windows.Forms.Label lbResumoValorTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoValorTotal;
        private Microsoft.Reporting.WinForms.ReportViewer rvwRelatorios;
        private System.Windows.Forms.ListBox lstRelatorios;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGerarRelatorio;
        private System.Windows.Forms.Label label33;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConfiguracao;
        private System.Windows.Forms.Label lbDataCancelamentoPedido;
        private System.Windows.Forms.Label lbDataConclusaoPedido;
        private System.Windows.Forms.Label lbDataPedido;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoDataCancelado;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoDataFinalizado;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoDataInclusao;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoCancelar;
        private System.Windows.Forms.Label lbResumoValorSaldo;
        private System.Windows.Forms.Label lbResumoValorPago;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoSaldo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoValorPago;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoVoltar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPedidoAvancar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantiade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoId;
    }
}