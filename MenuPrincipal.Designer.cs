using System;

namespace WinForm_Controle_De_Estoque
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ts_btns = new System.Windows.Forms.ToolStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_home = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_cliente = new System.Windows.Forms.ToolStripButton();
            this.btn_produto = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Usu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.btn_informacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.s = new System.Windows.Forms.ToolStripButton();
            this.btn_config = new System.Windows.Forms.ToolStripButton();
            this.t = new System.Windows.Forms.ToolStripButton();
            this.btn_trocaUsu = new System.Windows.Forms.ToolStripButton();
            this.staHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.staNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.staCaps = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.ctrAjuda1 = new WinForm_Controle_De_Estoque.Formularios.Sistema.CtrAjuda();
            this.ctrCadOrcamentos1 = new WinForm_Controle_De_Estoque.Formularios.Cadastros.CtrCadOrcamentos();
            this.ctrCadUsuario1 = new WinForm_Controle_De_Estoque.Formularios.Sistema.CtrCadUsuario();
            this.ctrInfo1 = new WinForm_Controle_De_Estoque.Formularios.Sistema.CtrInfo();
            this.ctrCadProduto1 = new WinForm_Controle_De_Estoque.Formularios.Cadastros.CtrCadProduto();
            this.ctrCadCliente1 = new WinForm_Controle_De_Estoque.Formularios.Cadastros.CtrCadCliente();
            this.ctrHome1 = new WinForm_Controle_De_Estoque.Formularios.Sistema.CtrHome();
            this.ts_btns.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 20);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ts_btns
            // 
            this.ts_btns.AutoSize = false;
            this.ts_btns.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_btns.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_btns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.ts_btns.Location = new System.Drawing.Point(0, 0);
            this.ts_btns.Name = "ts_btns";
            this.ts_btns.Size = new System.Drawing.Size(90, 488);
            this.ts_btns.Stretch = true;
            this.ts_btns.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_home,
            this.toolStripSeparator3,
            this.btn_cliente,
            this.btn_produto,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.btn_Usu,
            this.toolStripButton5,
            this.btn_informacao,
            this.toolStripSeparator2,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.s,
            this.btn_config,
            this.t,
            this.btn_trocaUsu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1033, 47);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            this.toolStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseUp);
            // 
            // btn_home
            // 
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(113, 44);
            this.btn_home.Text = "Página Inicial";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 47);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(85, 44);
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click_1);
            // 
            // btn_produto
            // 
            this.btn_produto.Image = ((System.Drawing.Image)(resources.GetObject("btn_produto.Image")));
            this.btn_produto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_produto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(91, 44);
            this.btn_produto.Text = "Produtos";
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(108, 44);
            this.toolStripButton4.Text = "Orçamentos";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btn_Usu
            // 
            this.btn_Usu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Usu.Image")));
            this.btn_Usu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Usu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Usu.Name = "btn_Usu";
            this.btn_Usu.Size = new System.Drawing.Size(88, 44);
            this.btn_Usu.Text = "Usuários";
            this.btn_Usu.Click += new System.EventHandler(this.btn_Usu_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(95, 44);
            this.toolStripButton5.Text = "Relatórios";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // btn_informacao
            // 
            this.btn_informacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_informacao.Image")));
            this.btn_informacao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_informacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_informacao.Name = "btn_informacao";
            this.btn_informacao.Size = new System.Drawing.Size(109, 44);
            this.btn_informacao.Text = "Informações";
            this.btn_informacao.Click += new System.EventHandler(this.btn_informacao_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(74, 44);
            this.toolStripButton9.Text = "Ajuda";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(36, 44);
            this.toolStripButton10.Text = "Fechar";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(36, 44);
            this.toolStripButton11.Text = "Minimizar";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // s
            // 
            this.s.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.s.Enabled = false;
            this.s.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(23, 44);
            // 
            // btn_config
            // 
            this.btn_config.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_config.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_config.Image = ((System.Drawing.Image)(resources.GetObject("btn_config.Image")));
            this.btn_config.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_config.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(36, 44);
            this.btn_config.Text = "Administração";
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // t
            // 
            this.t.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.t.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t.Enabled = false;
            this.t.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(23, 44);
            // 
            // btn_trocaUsu
            // 
            this.btn_trocaUsu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_trocaUsu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_trocaUsu.Image = ((System.Drawing.Image)(resources.GetObject("btn_trocaUsu.Image")));
            this.btn_trocaUsu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_trocaUsu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_trocaUsu.Name = "btn_trocaUsu";
            this.btn_trocaUsu.Size = new System.Drawing.Size(52, 44);
            this.btn_trocaUsu.Text = "Trocar Usuário";
            this.btn_trocaUsu.Click += new System.EventHandler(this.btn_trocaUsu_Click);
            // 
            // staHora
            // 
            this.staHora.Image = ((System.Drawing.Image)(resources.GetObject("staHora.Image")));
            this.staHora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.staHora.Name = "staHora";
            this.staHora.Size = new System.Drawing.Size(49, 17);
            this.staHora.Text = "Hora";
            // 
            // staNum
            // 
            this.staNum.Image = ((System.Drawing.Image)(resources.GetObject("staNum.Image")));
            this.staNum.Name = "staNum";
            this.staNum.Size = new System.Drawing.Size(16, 17);
            // 
            // staCaps
            // 
            this.staCaps.Image = ((System.Drawing.Image)(resources.GetObject("staCaps.Image")));
            this.staCaps.Name = "staCaps";
            this.staCaps.Size = new System.Drawing.Size(16, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(840, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // staUsuario
            // 
            this.staUsuario.Image = ((System.Drawing.Image)(resources.GetObject("staUsuario.Image")));
            this.staUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.staUsuario.Name = "staUsuario";
            this.staUsuario.Size = new System.Drawing.Size(97, 17);
            this.staUsuario.Text = "Usuario Atual:";
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staUsuario,
            this.toolStripStatusLabel1,
            this.staCaps,
            this.staNum,
            this.staHora});
            this.statusbar.Location = new System.Drawing.Point(0, 528);
            this.statusbar.Name = "statusbar";
            this.statusbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusbar.Size = new System.Drawing.Size(1033, 22);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 23;
            this.statusbar.Text = "statusStrip1";
            // 
            // ctrAjuda1
            // 
            this.ctrAjuda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ctrAjuda1.Location = new System.Drawing.Point(0, 47);
            this.ctrAjuda1.Name = "ctrAjuda1";
            this.ctrAjuda1.Size = new System.Drawing.Size(1033, 478);
            this.ctrAjuda1.TabIndex = 31;
            // 
            // ctrCadOrcamentos1
            // 
            this.ctrCadOrcamentos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ctrCadOrcamentos1.Location = new System.Drawing.Point(0, 47);
            this.ctrCadOrcamentos1.Name = "ctrCadOrcamentos1";
            this.ctrCadOrcamentos1.Size = new System.Drawing.Size(1033, 480);
            this.ctrCadOrcamentos1.TabIndex = 30;
            // 
            // ctrCadUsuario1
            // 
            this.ctrCadUsuario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ctrCadUsuario1.Location = new System.Drawing.Point(0, 47);
            this.ctrCadUsuario1.Name = "ctrCadUsuario1";
            this.ctrCadUsuario1.Size = new System.Drawing.Size(1033, 480);
            this.ctrCadUsuario1.TabIndex = 29;
            // 
            // ctrInfo1
            // 
            this.ctrInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ctrInfo1.Location = new System.Drawing.Point(0, 47);
            this.ctrInfo1.Name = "ctrInfo1";
            this.ctrInfo1.Size = new System.Drawing.Size(1033, 478);
            this.ctrInfo1.TabIndex = 28;
            // 
            // ctrCadProduto1
            // 
            this.ctrCadProduto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ctrCadProduto1.Location = new System.Drawing.Point(0, 47);
            this.ctrCadProduto1.Name = "ctrCadProduto1";
            this.ctrCadProduto1.Size = new System.Drawing.Size(1033, 480);
            this.ctrCadProduto1.TabIndex = 27;
            // 
            // ctrCadCliente1
            // 
            this.ctrCadCliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ctrCadCliente1.Location = new System.Drawing.Point(0, 47);
            this.ctrCadCliente1.Name = "ctrCadCliente1";
            this.ctrCadCliente1.Size = new System.Drawing.Size(1033, 478);
            this.ctrCadCliente1.TabIndex = 26;
            // 
            // ctrHome1
            // 
            this.ctrHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(92)))));
            this.ctrHome1.Location = new System.Drawing.Point(0, 47);
            this.ctrHome1.Name = "ctrHome1";
            this.ctrHome1.Size = new System.Drawing.Size(1033, 480);
            this.ctrHome1.TabIndex = 25;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 550);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.ctrHome1);
            this.Controls.Add(this.ctrAjuda1);
            this.Controls.Add(this.ctrCadOrcamentos1);
            this.Controls.Add(this.ctrCadUsuario1);
            this.Controls.Add(this.ctrInfo1);
            this.Controls.Add(this.ctrCadProduto1);
            this.Controls.Add(this.ctrCadCliente1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuPrincipal_KeyDown);
            this.ts_btns.ResumeLayout(false);
            this.ts_btns.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip ts_btns;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_home;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_cliente;
        private System.Windows.Forms.ToolStripButton btn_produto;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton btn_informacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton s;
        private System.Windows.Forms.ToolStripButton btn_config;
        public System.Windows.Forms.ToolStripStatusLabel staHora;
        private System.Windows.Forms.ToolStripStatusLabel staNum;
        private System.Windows.Forms.ToolStripStatusLabel staCaps;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel staUsuario;
        private System.Windows.Forms.StatusStrip statusbar;
        private Formularios.Sistema.CtrHome ctrHome1;
        private Formularios.Cadastros.CtrCadCliente ctrCadCliente1;
        private Formularios.Cadastros.CtrCadProduto ctrCadProduto1;
        private Formularios.Sistema.CtrInfo ctrInfo1;
        private Formularios.Sistema.CtrCadUsuario ctrCadUsuario1;
        private System.Windows.Forms.ToolStripButton btn_trocaUsu;
        private System.Windows.Forms.ToolStripButton t;
        private Formularios.Cadastros.CtrCadOrcamentos ctrCadOrcamentos1;
        private System.Windows.Forms.ToolStripButton btn_Usu;
        private Formularios.Sistema.CtrAjuda ctrAjuda1;
    }
}