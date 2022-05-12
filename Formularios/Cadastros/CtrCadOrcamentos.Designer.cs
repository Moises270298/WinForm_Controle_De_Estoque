namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    partial class CtrCadOrcamentos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrCadOrcamentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_orc = new System.Windows.Forms.Panel();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.chk_status = new System.Windows.Forms.CheckBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.tCCCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDadosDoBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grbPesquisaPedido = new System.Windows.Forms.GroupBox();
            this.txtNumPedidoPesq = new System.Windows.Forms.TextBox();
            this.btnLocalizarPedido = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReemoverItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtTotalDoPedido = new System.Windows.Forms.TextBox();
            this.txtTotalProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalDoPedido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalProduto = new System.Windows.Forms.Label();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCCITEMTEMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tcC_PRODUTOTableAdapter1 = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_PRODUTOTableAdapter();
            this.ErrErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.tCCITEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcC_CLIENTETableAdapter1 = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_CLIENTETableAdapter();
            this.tCC_ITEMTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_ITEMTableAdapter();
            this.tCC_ITEM_TEMPTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_ITEM_TEMPTableAdapter();
            this.dgv_orc = new System.Windows.Forms.DataGridView();
            this.orc_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedDtEncomendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedObservacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCCORCAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_incluir = new System.Windows.Forms.ToolStripButton();
            this.btn_editar = new System.Windows.Forms.ToolStripButton();
            this.btn_cancelarup = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tCC_ORCAMENTOTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_ORCAMENTOTableAdapter();
            this.txt_Pesquisa = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_orc.SuspendLayout();
            this.gbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCCCLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            this.grbPesquisaPedido.SuspendLayout();
            this.gbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCITEMTEMPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCITEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCORCAMENTOBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_orc
            // 
            this.panel_orc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(96)))));
            this.panel_orc.Controls.Add(this.gbPedido);
            this.panel_orc.Controls.Add(this.grbPesquisaPedido);
            this.panel_orc.Controls.Add(this.btnPesquisar);
            this.panel_orc.Controls.Add(this.btnNovo);
            this.panel_orc.Controls.Add(this.gbItens);
            this.panel_orc.Location = new System.Drawing.Point(14, 106);
            this.panel_orc.Name = "panel_orc";
            this.panel_orc.Size = new System.Drawing.Size(1004, 362);
            this.panel_orc.TabIndex = 0;
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.lblnumero);
            this.gbPedido.Controls.Add(this.lblNumeroPedido);
            this.gbPedido.Controls.Add(this.chk_status);
            this.gbPedido.Controls.Add(this.dtpDataVenda);
            this.gbPedido.Controls.Add(this.label3);
            this.gbPedido.Controls.Add(this.txtObservacao);
            this.gbPedido.Controls.Add(this.cmbCliente);
            this.gbPedido.Controls.Add(this.label2);
            this.gbPedido.Controls.Add(this.label4);
            this.gbPedido.Controls.Add(this.lblStatus);
            this.gbPedido.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.ForeColor = System.Drawing.Color.Black;
            this.gbPedido.Location = new System.Drawing.Point(3, 3);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(607, 83);
            this.gbPedido.TabIndex = 22;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedido";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblnumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.lblnumero.Location = new System.Drawing.Point(7, 26);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(37, 26);
            this.lblnumero.TabIndex = 10;
            this.lblnumero.Text = "Nº";
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroPedido.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumeroPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.lblNumeroPedido.Location = new System.Drawing.Point(40, 26);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(24, 26);
            this.lblNumeroPedido.TabIndex = 16;
            this.lblNumeroPedido.Text = "1";
            // 
            // chk_status
            // 
            this.chk_status.AutoSize = true;
            this.chk_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.chk_status.Location = new System.Drawing.Point(458, 24);
            this.chk_status.Name = "chk_status";
            this.chk_status.Size = new System.Drawing.Size(63, 21);
            this.chk_status.TabIndex = 15;
            this.chk_status.Text = "Ativo";
            this.chk_status.UseVisualStyleBackColor = true;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(507, 52);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(95, 25);
            this.dtpDataVenda.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(454, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtObservacao.Location = new System.Drawing.Point(170, 50);
            this.txtObservacao.MaxLength = 50;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(270, 27);
            this.txtObservacao.TabIndex = 12;
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataSource = this.tCCCLIENTEBindingSource;
            this.cmbCliente.DisplayMember = "cli_Nome";
            this.cmbCliente.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(170, 20);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(270, 25);
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.ValueMember = "cli_Id";
            // 
            // tCCCLIENTEBindingSource
            // 
            this.tCCCLIENTEBindingSource.DataMember = "TCC_CLIENTE";
            this.tCCCLIENTEBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // dataSetDadosDoBancoBindingSource
            // 
            this.dataSetDadosDoBancoBindingSource.DataSource = this.dataSet_Dados_Do_Banco;
            this.dataSetDadosDoBancoBindingSource.Position = 0;
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(102, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(70, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Observação:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 7;
            // 
            // grbPesquisaPedido
            // 
            this.grbPesquisaPedido.Controls.Add(this.txtNumPedidoPesq);
            this.grbPesquisaPedido.Controls.Add(this.btnLocalizarPedido);
            this.grbPesquisaPedido.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPesquisaPedido.ForeColor = System.Drawing.Color.Black;
            this.grbPesquisaPedido.Location = new System.Drawing.Point(787, 12);
            this.grbPesquisaPedido.Name = "grbPesquisaPedido";
            this.grbPesquisaPedido.Size = new System.Drawing.Size(203, 64);
            this.grbPesquisaPedido.TabIndex = 21;
            this.grbPesquisaPedido.TabStop = false;
            this.grbPesquisaPedido.Text = "Informe o Número da Venda";
            // 
            // txtNumPedidoPesq
            // 
            this.txtNumPedidoPesq.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtNumPedidoPesq.Location = new System.Drawing.Point(6, 26);
            this.txtNumPedidoPesq.Name = "txtNumPedidoPesq";
            this.txtNumPedidoPesq.Size = new System.Drawing.Size(51, 25);
            this.txtNumPedidoPesq.TabIndex = 1;
            this.txtNumPedidoPesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPedidoPesq_KeyPress);
            // 
            // btnLocalizarPedido
            // 
            this.btnLocalizarPedido.FlatAppearance.BorderSize = 0;
            this.btnLocalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizarPedido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLocalizarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.btnLocalizarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnLocalizarPedido.Image")));
            this.btnLocalizarPedido.Location = new System.Drawing.Point(63, 17);
            this.btnLocalizarPedido.Name = "btnLocalizarPedido";
            this.btnLocalizarPedido.Size = new System.Drawing.Size(134, 39);
            this.btnLocalizarPedido.TabIndex = 2;
            this.btnLocalizarPedido.Text = "&Localizar";
            this.btnLocalizarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocalizarPedido.UseVisualStyleBackColor = true;
            this.btnLocalizarPedido.Click += new System.EventHandler(this.btnLocalizarPedido_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(634, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(138, 46);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(635, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 49);
            this.btnNovo.TabIndex = 19;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gbItens
            // 
            this.gbItens.Controls.Add(this.label1);
            this.gbItens.Controls.Add(this.txtLargura);
            this.gbItens.Controls.Add(this.txtValorUnit);
            this.gbItens.Controls.Add(this.label7);
            this.gbItens.Controls.Add(this.btnCancelar);
            this.gbItens.Controls.Add(this.btnReemoverItem);
            this.gbItens.Controls.Add(this.btnAdicionarItem);
            this.gbItens.Controls.Add(this.btn_Gravar);
            this.gbItens.Controls.Add(this.btnBuscarProduto);
            this.gbItens.Controls.Add(this.txtTotalDoPedido);
            this.gbItens.Controls.Add(this.txtTotalProduto);
            this.gbItens.Controls.Add(this.label9);
            this.gbItens.Controls.Add(this.label8);
            this.gbItens.Controls.Add(this.lblTotalDoPedido);
            this.gbItens.Controls.Add(this.label5);
            this.gbItens.Controls.Add(this.lblTotalProduto);
            this.gbItens.Controls.Add(this.txtComprimento);
            this.gbItens.Controls.Add(this.txtDescricaoProduto);
            this.gbItens.Controls.Add(this.txtCodigo);
            this.gbItens.Controls.Add(this.dgvItem);
            this.gbItens.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbItens.ForeColor = System.Drawing.Color.Black;
            this.gbItens.Location = new System.Drawing.Point(3, 82);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(987, 278);
            this.gbItens.TabIndex = 23;
            this.gbItens.TabStop = false;
            this.gbItens.Text = "Itens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(470, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Comprimento";
            // 
            // txtLargura
            // 
            this.txtLargura.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtLargura.Location = new System.Drawing.Point(579, 39);
            this.txtLargura.MaxLength = 18;
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(67, 25);
            this.txtLargura.TabIndex = 15;
            this.txtLargura.TextChanged += new System.EventHandler(this.txtMedidas_TextCanged);
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtValorUnit.Location = new System.Drawing.Point(393, 39);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.ReadOnly = true;
            this.txtValorUnit.Size = new System.Drawing.Size(75, 25);
            this.txtValorUnit.TabIndex = 7;
            this.txtValorUnit.TextChanged += new System.EventHandler(this.txtValorUnit_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label7.Location = new System.Drawing.Point(575, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Largura";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(933, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(49, 47);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReemoverItem
            // 
            this.btnReemoverItem.AutoSize = true;
            this.btnReemoverItem.FlatAppearance.BorderSize = 0;
            this.btnReemoverItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReemoverItem.Image = ((System.Drawing.Image)(resources.GetObject("btnReemoverItem.Image")));
            this.btnReemoverItem.Location = new System.Drawing.Point(865, 127);
            this.btnReemoverItem.Name = "btnReemoverItem";
            this.btnReemoverItem.Size = new System.Drawing.Size(54, 54);
            this.btnReemoverItem.TabIndex = 12;
            this.btnReemoverItem.UseVisualStyleBackColor = true;
            this.btnReemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarItem.Image")));
            this.btnAdicionarItem.Location = new System.Drawing.Point(866, 67);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(53, 54);
            this.btnAdicionarItem.TabIndex = 11;
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click_1);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Gravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Gravar.FlatAppearance.BorderSize = 0;
            this.btn_Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Gravar.Image")));
            this.btn_Gravar.Location = new System.Drawing.Point(867, 225);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(52, 47);
            this.btn_Gravar.TabIndex = 13;
            this.btn_Gravar.UseVisualStyleBackColor = false;
            this.btn_Gravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProduto.Image")));
            this.btnBuscarProduto.Location = new System.Drawing.Point(66, 26);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(42, 38);
            this.btnBuscarProduto.TabIndex = 2;
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // txtTotalDoPedido
            // 
            this.txtTotalDoPedido.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtTotalDoPedido.Location = new System.Drawing.Point(740, 39);
            this.txtTotalDoPedido.Name = "txtTotalDoPedido";
            this.txtTotalDoPedido.ReadOnly = true;
            this.txtTotalDoPedido.Size = new System.Drawing.Size(121, 25);
            this.txtTotalDoPedido.TabIndex = 10;
            // 
            // txtTotalProduto
            // 
            this.txtTotalProduto.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtTotalProduto.Location = new System.Drawing.Point(660, 39);
            this.txtTotalProduto.Name = "txtTotalProduto";
            this.txtTotalProduto.ReadOnly = true;
            this.txtTotalProduto.Size = new System.Drawing.Size(74, 25);
            this.txtTotalProduto.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label9.Location = new System.Drawing.Point(4, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label8.Location = new System.Drawing.Point(111, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Descrição";
            // 
            // lblTotalDoPedido
            // 
            this.lblTotalDoPedido.AutoSize = true;
            this.lblTotalDoPedido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalDoPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.lblTotalDoPedido.Location = new System.Drawing.Point(736, 17);
            this.lblTotalDoPedido.Name = "lblTotalDoPedido";
            this.lblTotalDoPedido.Size = new System.Drawing.Size(112, 19);
            this.lblTotalDoPedido.TabIndex = 4;
            this.lblTotalDoPedido.Text = "Total do Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label5.Location = new System.Drawing.Point(389, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unitário";
            // 
            // lblTotalProduto
            // 
            this.lblTotalProduto.AutoSize = true;
            this.lblTotalProduto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.lblTotalProduto.Location = new System.Drawing.Point(656, 17);
            this.lblTotalProduto.Name = "lblTotalProduto";
            this.lblTotalProduto.Size = new System.Drawing.Size(78, 19);
            this.lblTotalProduto.TabIndex = 4;
            this.lblTotalProduto.Text = "Total Item";
            // 
            // txtComprimento
            // 
            this.txtComprimento.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtComprimento.Location = new System.Drawing.Point(474, 39);
            this.txtComprimento.MaxLength = 18;
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(87, 25);
            this.txtComprimento.TabIndex = 8;
            this.txtComprimento.TextChanged += new System.EventHandler(this.txtMedidas_TextCanged);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtDescricaoProduto.Location = new System.Drawing.Point(115, 39);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.ReadOnly = true;
            this.txtDescricaoProduto.Size = new System.Drawing.Size(272, 25);
            this.txtDescricaoProduto.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtCodigo.Location = new System.Drawing.Point(8, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(52, 25);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AutoGenerateColumns = false;
            this.dgvItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Largura,
            this.Comprimento,
            this.Valor_Unit,
            this.Total_Item,
            this.usuarioDataGridViewTextBoxColumn});
            this.dgvItem.DataSource = this.tCCITEMTEMPBindingSource;
            this.dgvItem.Location = new System.Drawing.Point(7, 67);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(854, 205);
            this.dgvItem.TabIndex = 7;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "pro_Id";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "pro_Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Largura
            // 
            this.Largura.DataPropertyName = "Ite_Largura";
            this.Largura.HeaderText = "Largura";
            this.Largura.Name = "Largura";
            this.Largura.ReadOnly = true;
            // 
            // Comprimento
            // 
            this.Comprimento.DataPropertyName = "Ite_Comprimento";
            this.Comprimento.HeaderText = "Comprimento";
            this.Comprimento.Name = "Comprimento";
            this.Comprimento.ReadOnly = true;
            // 
            // Valor_Unit
            // 
            this.Valor_Unit.DataPropertyName = "Ite_Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Valor_Unit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Valor_Unit.HeaderText = "Unitário";
            this.Valor_Unit.Name = "Valor_Unit";
            this.Valor_Unit.ReadOnly = true;
            // 
            // Total_Item
            // 
            this.Total_Item.DataPropertyName = "TotalItem";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Total_Item.DefaultCellStyle = dataGridViewCellStyle2;
            this.Total_Item.HeaderText = "Total Item";
            this.Total_Item.Name = "Total_Item";
            this.Total_Item.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCCITEMTEMPBindingSource
            // 
            this.tCCITEMTEMPBindingSource.DataMember = "TCC_ITEM_TEMP";
            this.tCCITEMTEMPBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(96)))));
            this.lblTitulo.Location = new System.Drawing.Point(9, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(137, 26);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Orçamentos";
            // 
            // tcC_PRODUTOTableAdapter1
            // 
            this.tcC_PRODUTOTableAdapter1.ClearBeforeFill = true;
            // 
            // ErrErro
            // 
            this.ErrErro.ContainerControl = this;
            // 
            // tCCITEMBindingSource
            // 
            this.tCCITEMBindingSource.DataMember = "TCC_ITEM";
            this.tCCITEMBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // tcC_CLIENTETableAdapter1
            // 
            this.tcC_CLIENTETableAdapter1.ClearBeforeFill = true;
            // 
            // tCC_ITEMTableAdapter
            // 
            this.tCC_ITEMTableAdapter.ClearBeforeFill = true;
            // 
            // tCC_ITEM_TEMPTableAdapter
            // 
            this.tCC_ITEM_TEMPTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_orc
            // 
            this.dgv_orc.AllowUserToAddRows = false;
            this.dgv_orc.AutoGenerateColumns = false;
            this.dgv_orc.BackgroundColor = System.Drawing.Color.White;
            this.dgv_orc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orc_Id,
            this.pedDtEncomendaDataGridViewTextBoxColumn,
            this.pedValorDataGridViewTextBoxColumn,
            this.pedStatusDataGridViewTextBoxColumn,
            this.pedObservacaoDataGridViewTextBoxColumn});
            this.dgv_orc.DataSource = this.tCCORCAMENTOBindingSource;
            this.dgv_orc.Location = new System.Drawing.Point(14, 106);
            this.dgv_orc.Name = "dgv_orc";
            this.dgv_orc.ReadOnly = true;
            this.dgv_orc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_orc.Size = new System.Drawing.Size(1004, 362);
            this.dgv_orc.TabIndex = 15;
            // 
            // orc_Id
            // 
            this.orc_Id.DataPropertyName = "orc_Id";
            this.orc_Id.HeaderText = "Código do Pedido";
            this.orc_Id.Name = "orc_Id";
            this.orc_Id.ReadOnly = true;
            // 
            // pedDtEncomendaDataGridViewTextBoxColumn
            // 
            this.pedDtEncomendaDataGridViewTextBoxColumn.DataPropertyName = "ped_DtEncomenda";
            this.pedDtEncomendaDataGridViewTextBoxColumn.HeaderText = "Data da Encomenda";
            this.pedDtEncomendaDataGridViewTextBoxColumn.Name = "pedDtEncomendaDataGridViewTextBoxColumn";
            this.pedDtEncomendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedDtEncomendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pedValorDataGridViewTextBoxColumn
            // 
            this.pedValorDataGridViewTextBoxColumn.DataPropertyName = "ped_Valor";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.pedValorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pedValorDataGridViewTextBoxColumn.HeaderText = "Valor do Pedido";
            this.pedValorDataGridViewTextBoxColumn.Name = "pedValorDataGridViewTextBoxColumn";
            this.pedValorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedValorDataGridViewTextBoxColumn.Width = 125;
            // 
            // pedStatusDataGridViewTextBoxColumn
            // 
            this.pedStatusDataGridViewTextBoxColumn.DataPropertyName = "ped_Status";
            this.pedStatusDataGridViewTextBoxColumn.HeaderText = "Status do Pedido";
            this.pedStatusDataGridViewTextBoxColumn.Name = "pedStatusDataGridViewTextBoxColumn";
            this.pedStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedObservacaoDataGridViewTextBoxColumn
            // 
            this.pedObservacaoDataGridViewTextBoxColumn.DataPropertyName = "ped_Observacao";
            this.pedObservacaoDataGridViewTextBoxColumn.HeaderText = "Observação do Pedido";
            this.pedObservacaoDataGridViewTextBoxColumn.Name = "pedObservacaoDataGridViewTextBoxColumn";
            this.pedObservacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedObservacaoDataGridViewTextBoxColumn.Width = 510;
            // 
            // tCCORCAMENTOBindingSource
            // 
            this.tCCORCAMENTOBindingSource.DataMember = "TCC_ORCAMENTO";
            this.tCCORCAMENTOBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_incluir,
            this.btn_editar,
            this.btn_cancelarup,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(909, 61);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(109, 39);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_incluir
            // 
            this.btn_incluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_incluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluir.Image")));
            this.btn_incluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_incluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(36, 36);
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(36, 36);
            this.btn_editar.Text = "Editar";
            this.btn_editar.ToolTipText = "Pesquisar";
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelarup
            // 
            this.btn_cancelarup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cancelarup.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelarup.Image")));
            this.btn_cancelarup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_cancelarup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cancelarup.Name = "btn_cancelarup";
            this.btn_cancelarup.Size = new System.Drawing.Size(36, 36);
            this.btn_cancelarup.Text = "Exlcuir";
            this.btn_cancelarup.ToolTipText = "Cancelar";
            this.btn_cancelarup.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Transparent;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 4);
            // 
            // tCC_ORCAMENTOTableAdapter
            // 
            this.tCC_ORCAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_Pesquisa.Location = new System.Drawing.Point(57, 75);
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(381, 25);
            this.txt_Pesquisa.TabIndex = 20;
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.txt_Pesquisa_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // cmbColuna
            // 
            this.cmbColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColuna.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "Código/Id",
            "Valor",
            "Status",
            "Observação"});
            this.cmbColuna.Location = new System.Drawing.Point(519, 75);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(154, 25);
            this.cmbColuna.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(456, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filtros:";
            // 
            // CtrCadOrcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.Controls.Add(this.txt_Pesquisa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbColuna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel_orc);
            this.Controls.Add(this.dgv_orc);
            this.Name = "CtrCadOrcamentos";
            this.Size = new System.Drawing.Size(1033, 480);
            this.Load += new System.EventHandler(this.CtrCadOrcamentos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CtrCadOrcamentos_KeyDown);
            this.panel_orc.ResumeLayout(false);
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tCCCLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            this.grbPesquisaPedido.ResumeLayout(false);
            this.grbPesquisaPedido.PerformLayout();
            this.gbItens.ResumeLayout(false);
            this.gbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCITEMTEMPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCITEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCORCAMENTOBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_orc;
        public System.Windows.Forms.Label lblTitulo;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_CLIENTETableAdapter tcC_CLIENTETableAdapter1;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_PRODUTOTableAdapter tcC_PRODUTOTableAdapter1;
        private System.Windows.Forms.BindingSource dataSetDadosDoBancoBindingSource;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.ErrorProvider ErrErro;
        private System.Windows.Forms.BindingSource tCCCLIENTEBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_ITEMTableAdapter tCC_ITEMTableAdapter;
        private System.Windows.Forms.BindingSource tCCITEMTEMPBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_ITEM_TEMPTableAdapter tCC_ITEM_TEMPTableAdapter;
        private System.Windows.Forms.BindingSource tCCITEMBindingSource;
        private System.Windows.Forms.DataGridView dgv_orc;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btn_incluir;
        public System.Windows.Forms.ToolStripButton btn_editar;
        public System.Windows.Forms.ToolStripButton btn_cancelarup;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource tCCORCAMENTOBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_ORCAMENTOTableAdapter tCC_ORCAMENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orc_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedDtEncomendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedObservacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grbPesquisaPedido;
        private System.Windows.Forms.TextBox txtNumPedidoPesq;
        private System.Windows.Forms.Button btnLocalizarPedido;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtValorUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReemoverItem;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.TextBox txtTotalDoPedido;
        private System.Windows.Forms.TextBox txtTotalProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalDoPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalProduto;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        public System.Windows.Forms.MaskedTextBox txt_Pesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cmbColuna;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_status;
        private System.Windows.Forms.Label lblNumeroPedido;
    }
}
