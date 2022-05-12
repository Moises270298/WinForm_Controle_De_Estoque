namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    partial class CtrCadCliente
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.msk_CEP = new System.Windows.Forms.MaskedTextBox();
            this.msk_Fone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.clienteBindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDadosDoBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.TCC_ClienteTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_CLIENTETableAdapter();
            this.txt_UF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColuna
            // 
            this.cmbColuna.Items.AddRange(new object[] {
            "Código/Id",
            "Nome",
            "Endereço",
            "Número da Casa",
            "Bairro",
            "Cidade",
            "Estado",
            "CEP",
            "CPF",
            "Telefone"});
            this.cmbColuna.SelectedIndexChanged += new System.EventHandler(this.cmbColuna_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_UF);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.msk_Fone);
            this.panel1.Controls.Add(this.msk_CEP);
            this.panel1.Controls.Add(this.msk_CPF);
            this.panel1.Controls.Add(this.txt_Cidade);
            this.panel1.Controls.Add(this.txt_Bairro);
            this.panel1.Controls.Add(this.txt_Endereco);
            this.panel1.Controls.Add(this.txt_Numero);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.panel1.Controls.SetChildIndex(this.dtpDataCadastro, 0);
            this.panel1.Controls.SetChildIndex(this.label20, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Nome, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Numero, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Endereco, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Bairro, 0);
            this.panel1.Controls.SetChildIndex(this.txt_Cidade, 0);
            this.panel1.Controls.SetChildIndex(this.msk_CPF, 0);
            this.panel1.Controls.SetChildIndex(this.msk_CEP, 0);
            this.panel1.Controls.SetChildIndex(this.msk_Fone, 0);
            this.panel1.Controls.SetChildIndex(this.label12, 0);
            this.panel1.Controls.SetChildIndex(this.label22, 0);
            this.panel1.Controls.SetChildIndex(this.label21, 0);
            this.panel1.Controls.SetChildIndex(this.label11, 0);
            this.panel1.Controls.SetChildIndex(this.label14, 0);
            this.panel1.Controls.SetChildIndex(this.label15, 0);
            this.panel1.Controls.SetChildIndex(this.label17, 0);
            this.panel1.Controls.SetChildIndex(this.label18, 0);
            this.panel1.Controls.SetChildIndex(this.label19, 0);
            this.panel1.Controls.SetChildIndex(this.txt_UF, 0);
            // 
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.TextChanged += new System.EventHandler(this.txt_Pesquisa_TextChanged);
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Data de Cadastro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "RG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bairro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Endereço:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(72, 17);
            this.txt_Nome.MaxLength = 80;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(349, 25);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Endereco.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(520, 17);
            this.txt_Endereco.MaxLength = 50;
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(309, 25);
            this.txt_Endereco.TabIndex = 1;
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Bairro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bairro.Location = new System.Drawing.Point(72, 76);
            this.txt_Bairro.MaxLength = 50;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(240, 25);
            this.txt_Bairro.TabIndex = 3;
            // 
            // msk_CPF
            // 
            this.msk_CPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_CPF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_CPF.Location = new System.Drawing.Point(72, 137);
            this.msk_CPF.Mask = "000000000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(107, 25);
            this.msk_CPF.TabIndex = 7;
            // 
            // msk_CEP
            // 
            this.msk_CEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_CEP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_CEP.Location = new System.Drawing.Point(842, 74);
            this.msk_CEP.Mask = "00000-000";
            this.msk_CEP.Name = "msk_CEP";
            this.msk_CEP.Size = new System.Drawing.Size(77, 25);
            this.msk_CEP.TabIndex = 6;
            // 
            // msk_Fone
            // 
            this.msk_Fone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_Fone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Fone.Location = new System.Drawing.Point(347, 137);
            this.msk_Fone.Mask = "(00) 00000-0000";
            this.msk_Fone.Name = "msk_Fone";
            this.msk_Fone.Size = new System.Drawing.Size(117, 25);
            this.msk_Fone.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label12.Location = new System.Drawing.Point(12, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Nome:";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cidade.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cidade.Location = new System.Drawing.Point(441, 76);
            this.txt_Cidade.MaxLength = 50;
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(137, 25);
            this.txt_Cidade.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label11.Location = new System.Drawing.Point(437, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Endereço:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label14.Location = new System.Drawing.Point(360, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Cidade:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label15.Location = new System.Drawing.Point(616, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 19);
            this.label15.TabIndex = 6;
            this.label15.Text = "UF:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label17.Location = new System.Drawing.Point(12, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "CPF:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label18.Location = new System.Drawing.Point(762, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 19);
            this.label18.TabIndex = 6;
            this.label18.Text = "CEP:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label19.Location = new System.Drawing.Point(269, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 19);
            this.label19.TabIndex = 6;
            this.label19.Text = "Telefone:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label21.Location = new System.Drawing.Point(852, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 19);
            this.label21.TabIndex = 6;
            this.label21.Text = "N°:";
            // 
            // txt_Numero
            // 
            this.txt_Numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Numero.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(883, 17);
            this.txt_Numero.MaxLength = 7;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(62, 25);
            this.txt_Numero.TabIndex = 2;
            this.txt_Numero.Enter += new System.EventHandler(this.txt_Numero_Enter);
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.label22.Location = new System.Drawing.Point(12, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 19);
            this.label22.TabIndex = 6;
            this.label22.Text = "Bairro:";
            // 
            // clienteBindingsource
            // 
            this.clienteBindingsource.DataMember = "TCC_CLIENTE";
            this.clienteBindingsource.DataSource = this.dataSetDadosDoBancoBindingSource;
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
            // TCC_ClienteTableAdapter
            // 
            this.TCC_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // txt_UF
            // 
            this.txt_UF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UF.Location = new System.Drawing.Point(671, 76);
            this.txt_UF.MaxLength = 2;
            this.txt_UF.Name = "txt_UF";
            this.txt_UF.Size = new System.Drawing.Size(42, 25);
            this.txt_UF.TabIndex = 5;
            // 
            // CtrCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.Name = "CtrCadCliente";
            this.Load += new System.EventHandler(this.CtrCadCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingsource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.dataSet_Dados_Do_BancoTableAdapters.TCC_CLIENTETableAdapter TCC_ClienteTableAdapter;
        private System.Windows.Forms.BindingSource dataSetDadosDoBancoBindingSource;
        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox msk_Fone;
        private System.Windows.Forms.MaskedTextBox msk_CEP;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.BindingSource clienteBindingsource;
        private System.Windows.Forms.TextBox txt_UF;
    }
}
