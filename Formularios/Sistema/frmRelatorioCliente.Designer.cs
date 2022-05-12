namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    partial class frmRelatorioCliente
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.tCCCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCC_CLIENTETableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCCLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelatorioCliente";
            reportDataSource1.Value = this.tCCCLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinForm_Controle_De_Estoque.Formularios.Sistema.RelatorioCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCCCLIENTEBindingSource
            // 
            this.tCCCLIENTEBindingSource.DataMember = "TCC_CLIENTE";
            this.tCCCLIENTEBindingSource.DataSource = this.dataSet_Dados_Do_Banco;
            // 
            // tCC_CLIENTETableAdapter
            // 
            this.tCC_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioCliente";
            this.Text = "frmRelatorioCliente";
            this.Load += new System.EventHandler(this.frmRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCCCLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.BindingSource tCCCLIENTEBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_CLIENTETableAdapter tCC_CLIENTETableAdapter;
    }
}