namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    partial class frmUsuario
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label nivelLabel;
            this.dataSet_Dados_Do_Banco = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_Banco();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TableAdapterManager();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_nv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCadastro = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            nivelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGenerico)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.TabPage_Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dados_Do_Banco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModo
            // 
            this.lblModo.Size = new System.Drawing.Size(52, 13);
            this.lblModo.Text = "Alterando";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpCadastro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(senhaLabel);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(nivelLabel);
            this.groupBox1.Controls.Add(this.txt_nv);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(6, 16);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 42);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(6, 68);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 4;
            senhaLabel.Text = "Senha:";
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new System.Drawing.Point(6, 94);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new System.Drawing.Size(36, 13);
            nivelLabel.TabIndex = 6;
            nivelLabel.Text = "Nível:";
            // 
            // dataSet_Dados_Do_Banco
            // 
            this.dataSet_Dados_Do_Banco.DataSetName = "dataSet_Dados_Do_Banco";
            this.dataSet_Dados_Do_Banco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dataSet_Dados_Do_Banco;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Item_TempTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // txt_id
            // 
            this.txt_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "ID", true));
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(53, 13);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(22, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.txt_nome.Location = new System.Drawing.Point(53, 39);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(263, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.txt_senha.Location = new System.Drawing.Point(53, 65);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(211, 20);
            this.txt_senha.TabIndex = 5;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_nv
            // 
            this.txt_nv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nivel", true));
            this.txt_nv.Location = new System.Drawing.Point(53, 91);
            this.txt_nv.Name = "txt_nv";
            this.txt_nv.Size = new System.Drawing.Size(22, 20);
            this.txt_nv.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nível 0 = Usuário\r\nNível 1 = Administrador";
            // 
            // dtpCadastro
            // 
            this.dtpCadastro.Location = new System.Drawing.Point(53, 140);
            this.dtpCadastro.Name = "dtpCadastro";
            this.dtpCadastro.Size = new System.Drawing.Size(200, 20);
            this.dtpCadastro.TabIndex = 9;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(691, 383);
            this.Name = "frmUsuario";
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.dataSet_Dados_Do_Banco dataSet_Dados_Do_Banco;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private Dados.dataSet_Dados_Do_BancoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_nv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCadastro;
    }
}
