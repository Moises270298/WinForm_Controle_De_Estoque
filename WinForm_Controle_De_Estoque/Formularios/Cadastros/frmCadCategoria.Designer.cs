namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    partial class frmCadCategoria
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.CategoriaTableAdapter();
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
            this.lblModo.Size = new System.Drawing.Size(66, 13);
            this.lblModo.Text = "Consultando";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCodigo);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(64, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(34, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 388);
            this.Name = "frmCadCategoria";
            this.Text = "Cadastro de Categorias";
            this.Load += new System.EventHandler(this.frmCadCategoria_Load);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
    }
}
