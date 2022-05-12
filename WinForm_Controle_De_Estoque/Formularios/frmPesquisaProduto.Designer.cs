namespace WinForm_Controle_De_Estoque.Formularios
{
    partial class frmPesquisaProduto
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
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.produtoTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.ProdutoTableAdapter();
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.PedidoTableAdapter();
            this.itemTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.ItemTableAdapter();
            this.lstProduto = new System.Windows.Forms.ListBox();
            this.item_TempTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.Item_TempTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(12, 37);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(260, 20);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dataSet_Dados_Do_Banco;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // lstProduto
            // 
            this.lstProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "pro_Id", true));
            this.lstProduto.DataSource = this.produtoBindingSource;
            this.lstProduto.DisplayMember = "pro_Descricao";
            this.lstProduto.FormattingEnabled = true;
            this.lstProduto.Location = new System.Drawing.Point(12, 83);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(260, 368);
            this.lstProduto.TabIndex = 2;
            this.lstProduto.ValueMember = "pro_Id";
            this.lstProduto.DoubleClick += new System.EventHandler(this.lstProduto_DoubleClick);
            // 
            // item_TempTableAdapter
            // 
            this.item_TempTableAdapter.ClearBeforeFill = true;
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 467);
            this.Controls.Add(this.lstProduto);
            this.Controls.Add(this.txtProduto);
            this.Name = "frmPesquisaProduto";
            this.Text = "frmPesquisaProduto";
            this.Load += new System.EventHandler(this.frmPesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.ListBox lstProduto;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.Item_TempTableAdapter item_TempTableAdapter;
    }
}