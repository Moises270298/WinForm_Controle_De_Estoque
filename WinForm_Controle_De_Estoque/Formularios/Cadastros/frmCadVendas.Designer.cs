namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{ 
    partial class frmCadVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDadosDoBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReemoverItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtTotalDoPedido = new System.Windows.Forms.TextBox();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalDoPedido = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grbPesquisaPedido = new System.Windows.Forms.GroupBox();
            this.txtNumPedidoPesq = new System.Windows.Forms.TextBox();
            this.btnLocalizarPedido = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ErrErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.ClienteTableAdapter();
            this.itemTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.ItemTableAdapter();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            this.gbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            this.grbPesquisaPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.lblStatus);
            this.gbPedido.Controls.Add(this.btnCancelar);
            this.gbPedido.Controls.Add(this.dtpDataVenda);
            this.gbPedido.Controls.Add(this.label3);
            this.gbPedido.Controls.Add(this.txtObservacao);
            this.gbPedido.Controls.Add(this.cmbCliente);
            this.gbPedido.Controls.Add(this.txtNumeroPedido);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.lblNumeroPedido);
            this.gbPedido.Location = new System.Drawing.Point(2, 3);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(738, 130);
            this.gbPedido.TabIndex = 0;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedido";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(622, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(622, 17);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(95, 20);
            this.dtpDataVenda.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(268, 44);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(270, 80);
            this.txtObservacao.TabIndex = 3;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "cli_NomeRazao";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(268, 17);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(270, 21);
            this.cmbCliente.TabIndex = 2;
            this.cmbCliente.ValueMember = "cli_Id";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dataSet_Dados_Do_Banco;
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Enabled = false;
            this.txtNumeroPedido.Location = new System.Drawing.Point(100, 17);
            this.txtNumeroPedido.Multiline = true;
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(65, 33);
            this.txtNumeroPedido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observação:";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumeroPedido.Location = new System.Drawing.Point(46, 14);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(33, 25);
            this.lblNumeroPedido.TabIndex = 0;
            this.lblNumeroPedido.Text = "Nº";
            // 
            // gbItens
            // 
            this.gbItens.Controls.Add(this.txtValorUnit);
            this.gbItens.Controls.Add(this.dgvItem);
            this.gbItens.Controls.Add(this.btnReemoverItem);
            this.gbItens.Controls.Add(this.btnAdicionarItem);
            this.gbItens.Controls.Add(this.btnBuscarProduto);
            this.gbItens.Controls.Add(this.txtTotalDoPedido);
            this.gbItens.Controls.Add(this.txtTotalProduto);
            this.gbItens.Controls.Add(this.label9);
            this.gbItens.Controls.Add(this.label8);
            this.gbItens.Controls.Add(this.lblTotalDoPedido);
            this.gbItens.Controls.Add(this.label7);
            this.gbItens.Controls.Add(this.label6);
            this.gbItens.Controls.Add(this.label5);
            this.gbItens.Controls.Add(this.lblTotalProduto);
            this.gbItens.Controls.Add(this.txtQtd);
            this.gbItens.Controls.Add(this.txtDescricaoProduto);
            this.gbItens.Controls.Add(this.txtCodigo);
            this.gbItens.Location = new System.Drawing.Point(2, 140);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(738, 255);
            this.gbItens.TabIndex = 1;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens";
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Enabled = false;
            this.txtValorUnit.Location = new System.Drawing.Point(487, 44);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(75, 20);
            this.txtValorUnit.TabIndex = 8;
            this.txtValorUnit.Leave += new System.EventHandler(this.txtValorUnit_Leave);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AutoGenerateColumns = false;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.Valor_Unit,
            this.Total_Item});
            this.dgvItem.DataSource = this.itemBindingSource1;
            this.dgvItem.Location = new System.Drawing.Point(6, 71);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(652, 150);
            this.dgvItem.TabIndex = 7;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "Item";
            this.itemBindingSource1.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // dataSetDadosDoBancoBindingSource
            // 
            this.dataSetDadosDoBancoBindingSource.DataSource = this.dataSet_Dados_Do_Banco;
            this.dataSetDadosDoBancoBindingSource.Position = 0;
            // 
            // btnReemoverItem
            // 
            this.btnReemoverItem.Location = new System.Drawing.Point(664, 114);
            this.btnReemoverItem.Name = "btnReemoverItem";
            this.btnReemoverItem.Size = new System.Drawing.Size(53, 37);
            this.btnReemoverItem.TabIndex = 6;
            this.btnReemoverItem.Text = "Remove";
            this.btnReemoverItem.UseVisualStyleBackColor = true;
            this.btnReemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(664, 71);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(53, 37);
            this.btnAdicionarItem.TabIndex = 6;
            this.btnAdicionarItem.Text = "ADD";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click_1);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(65, 44);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(42, 20);
            this.btnBuscarProduto.TabIndex = 2;
            this.btnBuscarProduto.Text = "...";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // txtTotalDoPedido
            // 
            this.txtTotalDoPedido.Enabled = false;
            this.txtTotalDoPedido.Location = new System.Drawing.Point(537, 227);
            this.txtTotalDoPedido.Name = "txtTotalDoPedido";
            this.txtTotalDoPedido.Size = new System.Drawing.Size(121, 20);
            this.txtTotalDoPedido.TabIndex = 1;
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Enabled = false;
            this.txtTotalProduto.Location = new System.Drawing.Point(584, 44);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.Size = new System.Drawing.Size(74, 20);
            this.txtTotalProduto.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Descrição";
            // 
            // lblTotalDoPedido
            // 
            this.lblTotalDoPedido.AutoSize = true;
            this.lblTotalDoPedido.Location = new System.Drawing.Point(440, 230);
            this.lblTotalDoPedido.Name = "lblTotalDoPedido";
            this.lblTotalDoPedido.Size = new System.Drawing.Size(91, 13);
            this.lblTotalDoPedido.TabIndex = 4;
            this.lblTotalDoPedido.Text = "$Total do Pedido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "$Unitário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "$Unitário";
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Location = new System.Drawing.Point(581, 29);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(54, 13);
            this.lblTotalProduto.TabIndex = 4;
            this.lblTotalProduto.Text = "Total Item";
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(424, 44);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(51, 20);
            this.txtQtd.TabIndex = 1;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Enabled = false;
            this.txtDescricaoProduto.Location = new System.Drawing.Point(113, 45);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(297, 20);
            this.txtDescricaoProduto.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(52, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 418);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 20);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(126, 418);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 20);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // grbPesquisaPedido
            // 
            this.grbPesquisaPedido.Controls.Add(this.txtNumPedidoPesq);
            this.grbPesquisaPedido.Controls.Add(this.btnLocalizarPedido);
            this.grbPesquisaPedido.Location = new System.Drawing.Point(248, 401);
            this.grbPesquisaPedido.Name = "grbPesquisaPedido";
            this.grbPesquisaPedido.Size = new System.Drawing.Size(198, 48);
            this.grbPesquisaPedido.TabIndex = 3;
            this.grbPesquisaPedido.TabStop = false;
            this.grbPesquisaPedido.Text = "Informe o Número da Venda";
            // 
            // txtNumPedidoPesq
            // 
            this.txtNumPedidoPesq.Location = new System.Drawing.Point(6, 19);
            this.txtNumPedidoPesq.Name = "txtNumPedidoPesq";
            this.txtNumPedidoPesq.Size = new System.Drawing.Size(51, 20);
            this.txtNumPedidoPesq.TabIndex = 1;
            this.txtNumPedidoPesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPedidoPesq_KeyPress);
            // 
            // btnLocalizarPedido
            // 
            this.btnLocalizarPedido.Location = new System.Drawing.Point(82, 19);
            this.btnLocalizarPedido.Name = "btnLocalizarPedido";
            this.btnLocalizarPedido.Size = new System.Drawing.Size(97, 20);
            this.btnLocalizarPedido.TabIndex = 2;
            this.btnLocalizarPedido.Text = "&Localizar";
            this.btnLocalizarPedido.UseVisualStyleBackColor = true;
            this.btnLocalizarPedido.Click += new System.EventHandler(this.btnLocalizarPedido_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(462, 412);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(137, 32);
            this.btn_Gravar.TabIndex = 2;
            this.btn_Gravar.Text = "&Gravar Venda";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(605, 412);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(132, 32);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ErrErro
            // 
            this.ErrErro.ContainerControl = this;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "pro_Id";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 45;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "pro_Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 270;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "ite_Qtde";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Valor_Unit
            // 
            this.Valor_Unit.DataPropertyName = "Ite_Valor";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor_Unit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor_Unit.HeaderText = "$Unitário";
            this.Valor_Unit.Name = "Valor_Unit";
            this.Valor_Unit.ReadOnly = true;
            // 
            // Total_Item
            // 
            this.Total_Item.DataPropertyName = "TotalItem";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Total_Item.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total_Item.HeaderText = "Total Item";
            this.Total_Item.Name = "Total_Item";
            this.Total_Item.ReadOnly = true;
            // 
            // frmCadVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 462);
            this.Controls.Add(this.grbPesquisaPedido);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.gbPedido);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Vendas";
            this.Load += new System.EventHandler(this.frmCadVendas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadVendas_KeyDown);
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            this.gbItens.ResumeLayout(false);
            this.gbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).EndInit();
            this.grbPesquisaPedido.ResumeLayout(false);
            this.grbPesquisaPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Button btnReemoverItem;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTotalDoPedido;
        private System.Windows.Forms.Label lblTotalDoPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox grbPesquisaPedido;
        private System.Windows.Forms.TextBox txtNumPedidoPesq;
        private System.Windows.Forms.Button btnLocalizarPedido;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btnFechar;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.ErrorProvider ErrErro;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource dataSetDadosDoBancoBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Item;
    }
}