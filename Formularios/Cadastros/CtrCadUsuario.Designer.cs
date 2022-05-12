namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    partial class CtrCadUsuario
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
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Senha2 = new System.Windows.Forms.TextBox();
            this.cmb_Nivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataSetDadosDoBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.usuarioTableAdapter1 = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.UsuarioTableAdapter();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColuna
            // 
            this.cmbColuna.Items.AddRange(new object[] {
            "Código/Id",
            "Nome",
            "Senha"});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_Nivel);
            this.panel1.Controls.Add(this.txt_Senha2);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.SetChildIndex(this.dtpDataCadastro, 0);
            this.panel1.Controls.SetChildIndex(this.label20, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Nome, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Senha, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Senha2, 0);
            this.panel1.Controls.SetChildIndex(this.cmb_Nivel, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label12, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.txt_Pesquisa_TextChanged);
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.TabIndex = 4;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(140, 21);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(298, 25);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Senha
            // 
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(140, 82);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(298, 25);
            this.txt_Senha.TabIndex = 2;
            // 
            // txt_Senha2
            // 
            this.txt_Senha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha2.Location = new System.Drawing.Point(140, 137);
            this.txt_Senha2.Name = "txt_Senha2";
            this.txt_Senha2.Size = new System.Drawing.Size(298, 25);
            this.txt_Senha2.TabIndex = 3;
            // 
            // cmb_Nivel
            // 
            this.cmb_Nivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nivel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Nivel.FormattingEnabled = true;
            this.cmb_Nivel.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmb_Nivel.Location = new System.Drawing.Point(513, 21);
            this.cmb_Nivel.MaxLength = 2;
            this.cmb_Nivel.Name = "cmb_Nivel";
            this.cmb_Nivel.Size = new System.Drawing.Size(50, 25);
            this.cmb_Nivel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(694, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 48);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nível 0 = Usuário Comum\r\nNível 1 = Usuário Administrador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label12.Location = new System.Drawing.Point(18, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(18, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Repita a senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label5.Location = new System.Drawing.Point(457, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nível:";
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
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dataSetDadosDoBancoBindingSource;
            // 
            // CtrCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CtrCadUsuario";
            this.Load += new System.EventHandler(this.CtrCadUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataSetDadosDoBancoBindingSource;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.TextBox txt_Senha2;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ComboBox cmb_Nivel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
    }
}
