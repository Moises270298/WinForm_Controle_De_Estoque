namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    partial class frmCadProdutos
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
            System.Windows.Forms.Label txt_id;
            System.Windows.Forms.Label cmbCategoria;
            System.Windows.Forms.Label pro_DescricaoLabel;
            System.Windows.Forms.Label txt_QtdEstoque;
            System.Windows.Forms.Label pro_ValorLabel;
            System.Windows.Forms.Label pro_AtivoLabel;
            System.Windows.Forms.Label pro_DataLabel;
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.tableAdapterManager = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TableAdapterManager();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_QtdeEstoque = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.CategoriaTableAdapter();
            this.produtoTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.ProdutoTableAdapter();
            txt_id = new System.Windows.Forms.Label();
            cmbCategoria = new System.Windows.Forms.Label();
            pro_DescricaoLabel = new System.Windows.Forms.Label();
            txt_QtdEstoque = new System.Windows.Forms.Label();
            pro_ValorLabel = new System.Windows.Forms.Label();
            pro_AtivoLabel = new System.Windows.Forms.Label();
            pro_DataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.TabPage_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModo
            // 
            this.lblModo.Size = new System.Drawing.Size(52, 13);
            this.lblModo.Text = "Alterando";
            // 
            // TabPage_Cadastro
            // 
            this.TabPage_Cadastro.AutoScroll = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCat);
            this.groupBox1.Controls.Add(this.chkAtivo);
            this.groupBox1.Controls.Add(txt_id);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(cmbCategoria);
            this.groupBox1.Controls.Add(pro_DescricaoLabel);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(txt_QtdEstoque);
            this.groupBox1.Controls.Add(this.txt_QtdeEstoque);
            this.groupBox1.Controls.Add(pro_ValorLabel);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(pro_AtivoLabel);
            this.groupBox1.Controls.Add(pro_DataLabel);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Size = new System.Drawing.Size(700, 357);
            // 
            // txt_id
            // 
            txt_id.AutoSize = true;
            txt_id.Location = new System.Drawing.Point(26, 27);
            txt_id.Name = "txt_id";
            txt_id.Size = new System.Drawing.Size(19, 13);
            txt_id.TabIndex = 0;
            txt_id.Text = "Id:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoSize = true;
            cmbCategoria.Location = new System.Drawing.Point(26, 53);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new System.Drawing.Size(55, 13);
            cmbCategoria.TabIndex = 2;
            cmbCategoria.Text = "Categoria:";
            // 
            // pro_DescricaoLabel
            // 
            pro_DescricaoLabel.AutoSize = true;
            pro_DescricaoLabel.Location = new System.Drawing.Point(26, 79);
            pro_DescricaoLabel.Name = "pro_DescricaoLabel";
            pro_DescricaoLabel.Size = new System.Drawing.Size(58, 13);
            pro_DescricaoLabel.TabIndex = 4;
            pro_DescricaoLabel.Text = "Descrição:";
            // 
            // txt_QtdEstoque
            // 
            txt_QtdEstoque.AutoSize = true;
            txt_QtdEstoque.Location = new System.Drawing.Point(26, 105);
            txt_QtdEstoque.Name = "txt_QtdEstoque";
            txt_QtdEstoque.Size = new System.Drawing.Size(72, 13);
            txt_QtdEstoque.TabIndex = 6;
            txt_QtdEstoque.Text = "Qtd. Estoque:";
            // 
            // pro_ValorLabel
            // 
            pro_ValorLabel.AutoSize = true;
            pro_ValorLabel.Location = new System.Drawing.Point(26, 131);
            pro_ValorLabel.Name = "pro_ValorLabel";
            pro_ValorLabel.Size = new System.Drawing.Size(34, 13);
            pro_ValorLabel.TabIndex = 8;
            pro_ValorLabel.Text = "Valor:";
            // 
            // pro_AtivoLabel
            // 
            pro_AtivoLabel.AutoSize = true;
            pro_AtivoLabel.Location = new System.Drawing.Point(26, 157);
            pro_AtivoLabel.Name = "pro_AtivoLabel";
            pro_AtivoLabel.Size = new System.Drawing.Size(34, 13);
            pro_AtivoLabel.TabIndex = 10;
            pro_AtivoLabel.Text = "Ativo:";
            // 
            // pro_DataLabel
            // 
            pro_DataLabel.AutoSize = true;
            pro_DataLabel.Location = new System.Drawing.Point(26, 184);
            pro_DataLabel.Name = "pro_DataLabel";
            pro_DataLabel.Size = new System.Drawing.Size(33, 13);
            pro_DataLabel.TabIndex = 12;
            pro_DataLabel.Text = "Data:";
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Item_TempTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(125, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(38, 20);
            this.txtId.TabIndex = 1;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(125, 76);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(255, 20);
            this.txt_desc.TabIndex = 5;
            // 
            // txt_QtdeEstoque
            // 
            this.txt_QtdeEstoque.Location = new System.Drawing.Point(125, 102);
            this.txt_QtdeEstoque.Name = "txt_QtdeEstoque";
            this.txt_QtdeEstoque.Size = new System.Drawing.Size(38, 20);
            this.txt_QtdeEstoque.TabIndex = 7;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(125, 128);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(86, 20);
            this.txt_valor.TabIndex = 9;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(125, 180);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(97, 20);
            this.dtpData.TabIndex = 13;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(125, 156);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(15, 14);
            this.chkAtivo.TabIndex = 14;
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbCat
            // 
            this.cmbCat.DataSource = this.categoriaBindingSource;
            this.cmbCat.DisplayMember = "cat_Descricao";
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(125, 49);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(121, 21);
            this.cmbCat.TabIndex = 15;
            this.cmbCat.ValueMember = "cat_Id";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dataSet_Dados_Do_Banco;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 388);
            this.Name = "frmCadProdutos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.TabPage_Cadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_QtdeEstoque;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.ProdutoTableAdapter produtoTableAdapter;
    }
}
