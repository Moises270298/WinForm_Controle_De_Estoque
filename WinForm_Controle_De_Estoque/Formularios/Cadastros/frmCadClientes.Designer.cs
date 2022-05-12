namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    partial class frmCadClientes
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
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.txt_NomeRazao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.cmb_UF = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msk_CEP = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.msk_Fone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pedidoTableAdapter1 = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.PedidoTableAdapter();
            this.clienteTableAdapter1 = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.ClienteTableAdapter();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.TabPage_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(19, 368);
            // 
            // lblModo
            // 
            this.lblModo.Size = new System.Drawing.Size(52, 13);
            this.lblModo.Text = "Alterando";
            // 
            // TabControl
            // 
            this.TabControl.Size = new System.Drawing.Size(667, 267);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(597, 368);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Location = new System.Drawing.Point(22, 397);
            // 
            // TabPage_Cadastro
            // 
            this.TabPage_Cadastro.Size = new System.Drawing.Size(659, 241);
            // 
            // TabPage_Lista
            // 
            this.TabPage_Lista.Size = new System.Drawing.Size(659, 241);
            // 
            // dataSetDadosDoBancoBindingSource
            // 
            this.dataSetDadosDoBancoBindingSource.DataSource = null;
            this.dataSetDadosDoBancoBindingSource.Position = -1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.cmb_UF);
            this.groupBox1.Controls.Add(this.msk_Fone);
            this.groupBox1.Controls.Add(this.msk_CEP);
            this.groupBox1.Controls.Add(this.msk_CPF);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Cidade);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_Bairro);
            this.groupBox1.Controls.Add(this.txt_Logradouro);
            this.groupBox1.Controls.Add(this.txt_NomeRazao);
            this.groupBox1.Size = new System.Drawing.Size(642, 299);
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_NomeRazao
            // 
            this.txt_NomeRazao.Location = new System.Drawing.Point(107, 19);
            this.txt_NomeRazao.Name = "txt_NomeRazao";
            this.txt_NomeRazao.Size = new System.Drawing.Size(290, 20);
            this.txt_NomeRazao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome/Razão:";
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(107, 45);
            this.msk_CPF.Mask = "000.000.000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(81, 20);
            this.msk_CPF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNPJ/CPF:";
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(107, 71);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(165, 20);
            this.txt_Logradouro.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Logradouro:";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(107, 97);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(290, 20);
            this.txt_Bairro.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bairro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cidade:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(107, 123);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(134, 20);
            this.txt_Cidade.TabIndex = 4;
            // 
            // cmb_UF
            // 
            this.cmb_UF.FormattingEnabled = true;
            this.cmb_UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA ",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmb_UF.Location = new System.Drawing.Point(107, 149);
            this.cmb_UF.Name = "cmb_UF";
            this.cmb_UF.Size = new System.Drawing.Size(44, 21);
            this.cmb_UF.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "UF:";
            // 
            // msk_CEP
            // 
            this.msk_CEP.Location = new System.Drawing.Point(107, 176);
            this.msk_CEP.Mask = "00000-000";
            this.msk_CEP.Name = "msk_CEP";
            this.msk_CEP.Size = new System.Drawing.Size(60, 20);
            this.msk_CEP.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "CEP:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(107, 202);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(290, 20);
            this.txt_Email.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Email:";
            // 
            // msk_Fone
            // 
            this.msk_Fone.Location = new System.Drawing.Point(515, 19);
            this.msk_Fone.Mask = "(00) 00000-0000";
            this.msk_Fone.Name = "msk_Fone";
            this.msk_Fone.Size = new System.Drawing.Size(96, 20);
            this.msk_Fone.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Telefone:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Data do Cadastro:";
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(515, 46);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(96, 20);
            this.dtpData.TabIndex = 9;
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 400);
            this.Name = "frmCadClientes";
            this.Text = "Cadastro de Clientes";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NomeRazao;
        private System.Windows.Forms.ComboBox cmb_UF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.MaskedTextBox msk_Fone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        public Dados.dataSet_Dados_Do_BancoTableAdapters.PedidoTableAdapter pedidoTableAdapter1;
        public Dados.dataSet_Dados_Do_BancoTableAdapters.ClienteTableAdapter clienteTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtpData;
        public System.Windows.Forms.MaskedTextBox msk_CEP;
    }
}
