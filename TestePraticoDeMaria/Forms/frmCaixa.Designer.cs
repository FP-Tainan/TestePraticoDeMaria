namespace TestePraticoDeMaria.Forms
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.krPallet = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dgvPedidoProdutos = new System.Windows.Forms.DataGridView();
            this.colProdutoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantiade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValorTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtQuantidadeTotal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPedidoNumero = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cmbFormaPagamento = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCaixaMovimentacoes = new System.Windows.Forms.DataGridView();
            this.colFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorMovimentado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSaida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPagamentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorMovimentacao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbCaixaControles = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.grbTipoMovimentacao = new System.Windows.Forms.GroupBox();
            this.rbtnEntrada = new System.Windows.Forms.RadioButton();
            this.rbtnSaida = new System.Windows.Forms.RadioButton();
            this.btnSalvarMovimentacao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNovaMovimentacao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixaMovimentacoes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbCaixaControles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbCaixaControles.Panel)).BeginInit();
            this.grbCaixaControles.Panel.SuspendLayout();
            this.grbCaixaControles.SuspendLayout();
            this.grbTipoMovimentacao.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.dgvPedidoProdutos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.txtQuantidadeTotal);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtPedidoNumero);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1240, 393);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(19, 89);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(189, 16);
            this.label27.TabIndex = 26;
            this.label27.Text = "Lista de Produtos no pedido:";
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
            this.dgvPedidoProdutos.Location = new System.Drawing.Point(22, 110);
            this.dgvPedidoProdutos.Name = "dgvPedidoProdutos";
            this.dgvPedidoProdutos.ReadOnly = true;
            this.dgvPedidoProdutos.Size = new System.Drawing.Size(1210, 266);
            this.dgvPedidoProdutos.TabIndex = 27;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor Total do Pedido";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(212, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 16);
            this.label19.TabIndex = 7;
            this.label19.Text = "Quantidade de Produtos";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Location = new System.Drawing.Point(635, 44);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(597, 33);
            this.txtValorTotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValorTotal.StateCommon.Border.Rounding = 18;
            this.txtValorTotal.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtValorTotal.TabIndex = 6;
            // 
            // txtQuantidadeTotal
            // 
            this.txtQuantidadeTotal.Location = new System.Drawing.Point(193, 44);
            this.txtQuantidadeTotal.Name = "txtQuantidadeTotal";
            this.txtQuantidadeTotal.ReadOnly = true;
            this.txtQuantidadeTotal.Size = new System.Drawing.Size(437, 33);
            this.txtQuantidadeTotal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtQuantidadeTotal.StateCommon.Border.Rounding = 18;
            this.txtQuantidadeTotal.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeTotal.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtQuantidadeTotal.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 16);
            this.label20.TabIndex = 5;
            this.label20.Text = "Número do Pedido:";
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
            this.txtPedidoNumero.TabIndex = 4;
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.DropDownWidth = 210;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(22, 44);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(254, 36);
            this.cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 18;
            this.cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbFormaPagamento.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Forma Pagamento:";
            // 
            // dgvCaixaMovimentacoes
            // 
            this.dgvCaixaMovimentacoes.AllowUserToAddRows = false;
            this.dgvCaixaMovimentacoes.AllowUserToDeleteRows = false;
            this.dgvCaixaMovimentacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaixaMovimentacoes.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvCaixaMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixaMovimentacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFormaPagamento,
            this.colValorMovimentado,
            this.colEntrada,
            this.colSaida,
            this.colPagamentoID});
            this.dgvCaixaMovimentacoes.Location = new System.Drawing.Point(22, 115);
            this.dgvCaixaMovimentacoes.Name = "dgvCaixaMovimentacoes";
            this.dgvCaixaMovimentacoes.ReadOnly = true;
            this.dgvCaixaMovimentacoes.Size = new System.Drawing.Size(945, 125);
            this.dgvCaixaMovimentacoes.TabIndex = 27;
            // 
            // colFormaPagamento
            // 
            this.colFormaPagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFormaPagamento.DataPropertyName = "formapagamento";
            this.colFormaPagamento.HeaderText = "Forma Pagamento";
            this.colFormaPagamento.MinimumWidth = 150;
            this.colFormaPagamento.Name = "colFormaPagamento";
            this.colFormaPagamento.ReadOnly = true;
            // 
            // colValorMovimentado
            // 
            this.colValorMovimentado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValorMovimentado.DataPropertyName = "valormovimentacao";
            this.colValorMovimentado.HeaderText = "Valor";
            this.colValorMovimentado.MinimumWidth = 100;
            this.colValorMovimentado.Name = "colValorMovimentado";
            this.colValorMovimentado.ReadOnly = true;
            // 
            // colEntrada
            // 
            this.colEntrada.DataPropertyName = "entrada";
            this.colEntrada.HeaderText = "Entrada";
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.ReadOnly = true;
            // 
            // colSaida
            // 
            this.colSaida.DataPropertyName = "saida";
            this.colSaida.HeaderText = "Saida";
            this.colSaida.Name = "colSaida";
            this.colSaida.ReadOnly = true;
            // 
            // colPagamentoID
            // 
            this.colPagamentoID.DataPropertyName = "id";
            this.colPagamentoID.HeaderText = "id";
            this.colPagamentoID.Name = "colPagamentoID";
            this.colPagamentoID.ReadOnly = true;
            this.colPagamentoID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Movimentações Realizas nesse Pedido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvCaixaMovimentacoes);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbFormaPagamento);
            this.groupBox2.Controls.Add(this.txtValorMovimentacao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 257);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Pagamento";
            // 
            // txtValorMovimentacao
            // 
            this.txtValorMovimentacao.AccessibleName = "Valor da Movimentação";
            this.txtValorMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorMovimentacao.Location = new System.Drawing.Point(296, 44);
            this.txtValorMovimentacao.Name = "txtValorMovimentacao";
            this.txtValorMovimentacao.Size = new System.Drawing.Size(671, 33);
            this.txtValorMovimentacao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtValorMovimentacao.StateCommon.Border.Rounding = 18;
            this.txtValorMovimentacao.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMovimentacao.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtValorMovimentacao.TabIndex = 4;
            this.txtValorMovimentacao.TextChanged += new System.EventHandler(this.txtValorMovimentacao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor da Movimentação";
            // 
            // grbCaixaControles
            // 
            this.grbCaixaControles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCaixaControles.CaptionOverlap = 0D;
            this.grbCaixaControles.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.grbCaixaControles.Location = new System.Drawing.Point(993, 24);
            this.grbCaixaControles.Name = "grbCaixaControles";
            // 
            // grbCaixaControles.Panel
            // 
            this.grbCaixaControles.Panel.Controls.Add(this.grbTipoMovimentacao);
            this.grbCaixaControles.Panel.Controls.Add(this.btnSalvarMovimentacao);
            this.grbCaixaControles.Panel.Controls.Add(this.btnNovaMovimentacao);
            this.grbCaixaControles.Size = new System.Drawing.Size(259, 257);
            this.grbCaixaControles.StateCommon.Back.Color1 = System.Drawing.Color.Linen;
            this.grbCaixaControles.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grbCaixaControles.StateCommon.Border.Rounding = 10;
            this.grbCaixaControles.TabIndex = 24;
            this.grbCaixaControles.Values.Heading = "";
            // 
            // grbTipoMovimentacao
            // 
            this.grbTipoMovimentacao.Controls.Add(this.rbtnEntrada);
            this.grbTipoMovimentacao.Controls.Add(this.rbtnSaida);
            this.grbTipoMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipoMovimentacao.Location = new System.Drawing.Point(5, 159);
            this.grbTipoMovimentacao.Name = "grbTipoMovimentacao";
            this.grbTipoMovimentacao.Size = new System.Drawing.Size(242, 77);
            this.grbTipoMovimentacao.TabIndex = 16;
            this.grbTipoMovimentacao.TabStop = false;
            this.grbTipoMovimentacao.Text = "Tipo de Movimentação";
            // 
            // rbtnEntrada
            // 
            this.rbtnEntrada.AutoSize = true;
            this.rbtnEntrada.BackColor = System.Drawing.Color.Transparent;
            this.rbtnEntrada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEntrada.Location = new System.Drawing.Point(39, 25);
            this.rbtnEntrada.Name = "rbtnEntrada";
            this.rbtnEntrada.Size = new System.Drawing.Size(131, 20);
            this.rbtnEntrada.TabIndex = 15;
            this.rbtnEntrada.TabStop = true;
            this.rbtnEntrada.Text = "Entrada de Valor";
            this.rbtnEntrada.UseVisualStyleBackColor = false;
            // 
            // rbtnSaida
            // 
            this.rbtnSaida.AutoSize = true;
            this.rbtnSaida.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSaida.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSaida.Location = new System.Drawing.Point(39, 51);
            this.rbtnSaida.Name = "rbtnSaida";
            this.rbtnSaida.Size = new System.Drawing.Size(119, 20);
            this.rbtnSaida.TabIndex = 15;
            this.rbtnSaida.TabStop = true;
            this.rbtnSaida.Text = "Saida de Valor";
            this.rbtnSaida.UseVisualStyleBackColor = false;
            // 
            // btnSalvarMovimentacao
            // 
            this.btnSalvarMovimentacao.Location = new System.Drawing.Point(8, 82);
            this.btnSalvarMovimentacao.Name = "btnSalvarMovimentacao";
            this.btnSalvarMovimentacao.Size = new System.Drawing.Size(239, 64);
            this.btnSalvarMovimentacao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSalvarMovimentacao.StateCommon.Border.Rounding = 20;
            this.btnSalvarMovimentacao.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnSalvarMovimentacao.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnSalvarMovimentacao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarMovimentacao.TabIndex = 14;
            this.btnSalvarMovimentacao.Values.Image = global::TestePraticoDeMaria.Properties.Resources.Salvar;
            this.btnSalvarMovimentacao.Values.Text = "\tSalvar";
            this.btnSalvarMovimentacao.Click += new System.EventHandler(this.btnSalvarMovimentacao_Click);
            // 
            // btnNovaMovimentacao
            // 
            this.btnNovaMovimentacao.Location = new System.Drawing.Point(8, 12);
            this.btnNovaMovimentacao.Name = "btnNovaMovimentacao";
            this.btnNovaMovimentacao.Size = new System.Drawing.Size(239, 64);
            this.btnNovaMovimentacao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNovaMovimentacao.StateCommon.Border.Rounding = 20;
            this.btnNovaMovimentacao.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.btnNovaMovimentacao.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnNovaMovimentacao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaMovimentacao.TabIndex = 14;
            this.btnNovaMovimentacao.Values.Image = global::TestePraticoDeMaria.Properties.Resources.arquivo__1_;
            this.btnNovaMovimentacao.Values.Text = "\tNovo";
            this.btnNovaMovimentacao.Click += new System.EventHandler(this.btnNovaMovimentacao_Click);
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grbCaixaControles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmCaixa";
            this.Palette = this.krPallet;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixaMovimentacoes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbCaixaControles.Panel)).EndInit();
            this.grbCaixaControles.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbCaixaControles)).EndInit();
            this.grbCaixaControles.ResumeLayout(false);
            this.grbTipoMovimentacao.ResumeLayout(false);
            this.grbTipoMovimentacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette krPallet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPedidoNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValorTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtQuantidadeTotal;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dgvPedidoProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantiade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutoId;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCaixaMovimentacoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtValorMovimentacao;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grbCaixaControles;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNovaMovimentacao;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSalvarMovimentacao;
        private System.Windows.Forms.GroupBox grbTipoMovimentacao;
        private System.Windows.Forms.RadioButton rbtnEntrada;
        private System.Windows.Forms.RadioButton rbtnSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorMovimentado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEntrada;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPagamentoID;
    }
}