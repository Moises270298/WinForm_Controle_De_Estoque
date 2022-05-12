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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Cadastro_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorios_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Janelas_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navegadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sistemas_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.staUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staCaps = new System.Windows.Forms.ToolStripStatusLabel();
            this.staNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.staHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastro_Menu,
            this.Relatorios_Menu,
            this.Janelas_Menu,
            this.Sistemas_Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Cadastro_Menu
            // 
            this.Cadastro_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.Cadastro_Menu.Name = "Cadastro_Menu";
            this.Cadastro_Menu.Size = new System.Drawing.Size(71, 20);
            this.Cadastro_Menu.Text = "&Cadastros";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cToolStripMenuItem.Text = "&Cliente";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.categoriaToolStripMenuItem.Text = "&Categoria dos Produtos";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.produtosToolStripMenuItem.Text = "&Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.vendasToolStripMenuItem.Text = "&Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // Relatorios_Menu
            // 
            this.Relatorios_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeClienteToolStripMenuItem,
            this.relatórioDeProdutosToolStripMenuItem,
            this.relatórioDeCategoriasToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem});
            this.Relatorios_Menu.Name = "Relatorios_Menu";
            this.Relatorios_Menu.Size = new System.Drawing.Size(71, 20);
            this.Relatorios_Menu.Text = "&Relatórios";
            // 
            // relatórioDeClienteToolStripMenuItem
            // 
            this.relatórioDeClienteToolStripMenuItem.Name = "relatórioDeClienteToolStripMenuItem";
            this.relatórioDeClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relatórioDeClienteToolStripMenuItem.Text = "Relatório de Cliente";
            this.relatórioDeClienteToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeClienteToolStripMenuItem_Click);
            // 
            // relatórioDeProdutosToolStripMenuItem
            // 
            this.relatórioDeProdutosToolStripMenuItem.Name = "relatórioDeProdutosToolStripMenuItem";
            this.relatórioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relatórioDeProdutosToolStripMenuItem.Text = "Relatório de Produtos";
            this.relatórioDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeProdutosToolStripMenuItem_Click);
            // 
            // relatórioDeCategoriasToolStripMenuItem
            // 
            this.relatórioDeCategoriasToolStripMenuItem.Name = "relatórioDeCategoriasToolStripMenuItem";
            this.relatórioDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relatórioDeCategoriasToolStripMenuItem.Text = "Relatório de Categorias";
            this.relatórioDeCategoriasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeCategoriasToolStripMenuItem_Click);
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
            this.relatórioDeVendasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendasToolStripMenuItem_Click);
            // 
            // Janelas_Menu
            // 
            this.Janelas_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notePadToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.navegadorToolStripMenuItem});
            this.Janelas_Menu.Name = "Janelas_Menu";
            this.Janelas_Menu.Size = new System.Drawing.Size(56, 20);
            this.Janelas_Menu.Text = "&Janelas";
            // 
            // notePadToolStripMenuItem
            // 
            this.notePadToolStripMenuItem.Name = "notePadToolStripMenuItem";
            this.notePadToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.notePadToolStripMenuItem.Text = "NotePad";
            this.notePadToolStripMenuItem.Click += new System.EventHandler(this.notePadToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // navegadorToolStripMenuItem
            // 
            this.navegadorToolStripMenuItem.Name = "navegadorToolStripMenuItem";
            this.navegadorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.navegadorToolStripMenuItem.Text = "Navegador";
            this.navegadorToolStripMenuItem.Click += new System.EventHandler(this.navegadorToolStripMenuItem_Click);
            // 
            // Sistemas_Menu
            // 
            this.Sistemas_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem});
            this.Sistemas_Menu.Name = "Sistemas_Menu";
            this.Sistemas_Menu.Size = new System.Drawing.Size(65, 20);
            this.Sistemas_Menu.Text = "&Sistemas";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staUsuario,
            this.toolStripStatusLabel1,
            this.staCaps,
            this.staNum,
            this.staHora});
            this.statusbar.Location = new System.Drawing.Point(0, 555);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(895, 22);
            this.statusbar.TabIndex = 12;
            this.statusbar.Text = "statusStrip1";
            // 
            // staUsuario
            // 
            this.staUsuario.Name = "staUsuario";
            this.staUsuario.Size = new System.Drawing.Size(47, 17);
            this.staUsuario.Text = "Usuario";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(800, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // staCaps
            // 
            this.staCaps.Name = "staCaps";
            this.staCaps.Size = new System.Drawing.Size(0, 17);
            // 
            // staNum
            // 
            this.staNum.Name = "staNum";
            this.staNum.Size = new System.Drawing.Size(0, 17);
            // 
            // staHora
            // 
            this.staHora.Name = "staHora";
            this.staHora.Size = new System.Drawing.Size(33, 17);
            this.staHora.Text = "Hora";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem1,
            this.categoriasToolStripMenuItem,
            this.vendasToolStripMenuItem1});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.produtosToolStripMenuItem2,
            this.categoriasToolStripMenuItem1,
            this.vendasToolStripMenuItem2});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem2
            // 
            this.produtosToolStripMenuItem2.Name = "produtosToolStripMenuItem2";
            this.produtosToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem2.Text = "Produtos";
            this.produtosToolStripMenuItem2.Click += new System.EventHandler(this.produtosToolStripMenuItem2_Click);
            // 
            // categoriasToolStripMenuItem1
            // 
            this.categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            this.categoriasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem1.Text = "Categorias";
            this.categoriasToolStripMenuItem1.Click += new System.EventHandler(this.categoriasToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem2
            // 
            this.vendasToolStripMenuItem2.Name = "vendasToolStripMenuItem2";
            this.vendasToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.vendasToolStripMenuItem2.Text = "Vendas";
            this.vendasToolStripMenuItem2.Click += new System.EventHandler(this.vendasToolStripMenuItem2_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem1,
            this.notePadToolStripMenuItem1});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // calculadoraToolStripMenuItem1
            // 
            this.calculadoraToolStripMenuItem1.Name = "calculadoraToolStripMenuItem1";
            this.calculadoraToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.calculadoraToolStripMenuItem1.Text = "Calculadora";
            this.calculadoraToolStripMenuItem1.Click += new System.EventHandler(this.calculadoraToolStripMenuItem1_Click);
            // 
            // notePadToolStripMenuItem1
            // 
            this.notePadToolStripMenuItem1.Name = "notePadToolStripMenuItem1";
            this.notePadToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.notePadToolStripMenuItem1.Text = "NotePad";
            this.notePadToolStripMenuItem1.Click += new System.EventHandler(this.notePadToolStripMenuItem1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 577);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--- Menu Principal ---";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void toolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cadastro_Menu;
        private System.Windows.Forms.ToolStripMenuItem Relatorios_Menu;
        private System.Windows.Forms.ToolStripMenuItem Janelas_Menu;
        private System.Windows.Forms.ToolStripMenuItem Sistemas_Menu;
        private System.Windows.Forms.Timer timer1;
        private EventHandler toolStripDropDownButton1_Click;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel staNum;
        private System.Windows.Forms.ToolStripStatusLabel staCaps;
        public System.Windows.Forms.ToolStripStatusLabel staHora;
        private System.Windows.Forms.ToolStripStatusLabel staUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem notePadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navegadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notePadToolStripMenuItem1;
    }
}