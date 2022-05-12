namespace WinForm_Controle_De_Estoque.Formularios.Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaProduto));
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lstProduto = new System.Windows.Forms.ListBox();
            this.tCCPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDadosDoBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.tCCPRODUTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tcC_PRODUTOTableAdapter1 = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_PRODUTOTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tCCPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCPRODUTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.ForeColor = System.Drawing.Color.Black;
            this.txtProduto.Location = new System.Drawing.Point(12, 64);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(260, 26);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // lstProduto
            // 
            this.lstProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tCCPRODUTOBindingSource, "pro_Id", true));
            this.lstProduto.DataSource = this.tCCPRODUTOBindingSource1;
            this.lstProduto.DisplayMember = "pro_Descricao";
            this.lstProduto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduto.ForeColor = System.Drawing.Color.Black;
            this.lstProduto.FormattingEnabled = true;
            this.lstProduto.ItemHeight = 19;
            this.lstProduto.Location = new System.Drawing.Point(12, 96);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(260, 365);
            this.lstProduto.TabIndex = 2;
            this.lstProduto.ValueMember = "pro_Id";
            this.lstProduto.DoubleClick += new System.EventHandler(this.lstProduto_DoubleClick);
            // 
            // tCCPRODUTOBindingSource
            // 
            this.tCCPRODUTOBindingSource.DataMember = "TCC_PRODUTO";
            this.tCCPRODUTOBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
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
            // tCCPRODUTOBindingSource1
            // 
            this.tCCPRODUTOBindingSource1.DataMember = "TCC_PRODUTO";
            this.tCCPRODUTOBindingSource1.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // tcC_PRODUTOTableAdapter1
            // 
            this.tcC_PRODUTOTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(138)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(66, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecionar Produto";
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(286, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstProduto);
            this.Controls.Add(this.txtProduto);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPesquisaProduto";
            this.Text = "frmPesquisaProduto";
            this.Load += new System.EventHandler(this.frmPesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCCPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCPRODUTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ListBox lstProduto;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_PRODUTOTableAdapter tcC_PRODUTOTableAdapter1;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.BindingSource dataSetDadosDoBancoBindingSource;
        private System.Windows.Forms.BindingSource tCCPRODUTOBindingSource;
        private System.Windows.Forms.BindingSource tCCPRODUTOBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}