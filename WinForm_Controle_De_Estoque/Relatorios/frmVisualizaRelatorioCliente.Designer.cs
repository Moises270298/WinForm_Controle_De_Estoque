namespace WinForm_Controle_De_Estoque.Relatorios
{
    partial class frmVisualizaRelatorioCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDadosDoBanco1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dados_Do_Banco1 = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.rp_clientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBanco1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco1)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dataSetDadosDoBanco1BindingSource;
            // 
            // dataSetDadosDoBanco1BindingSource
            // 
            this.dataSetDadosDoBanco1BindingSource.DataSource = this.dataSet_Dados_Do_Banco1;
            this.dataSetDadosDoBanco1BindingSource.Position = 0;
            // 
            // dataSet_Dados_Do_Banco1
            // 
            this.dataSet_Dados_Do_Banco1.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rp_clientes
            // 
            this.rp_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clienteBindingSource;
            this.rp_clientes.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_clientes.LocalReport.ReportEmbeddedResource = "WinForm_Controle_De_Estoque.Relatorios.Relatorio_Cliente.rdlc";
            this.rp_clientes.Location = new System.Drawing.Point(0, 0);
            this.rp_clientes.Name = "rp_clientes";
            this.rp_clientes.Size = new System.Drawing.Size(631, 609);
            this.rp_clientes.TabIndex = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 609);
            this.Controls.Add(this.rp_clientes);
            this.Name = "frmVisualizaRelatorio";
            this.Text = "frmVisualizaRelatorio";
            this.Load += new System.EventHandler(this.frmVisualizaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBanco1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_clientes;
        private System.Windows.Forms.BindingSource dataSetDadosDoBanco1BindingSource;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}