using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Formularios;
using System.Threading;
using WinForm_Controle_De_Estoque.Formularios.Sistema;
using System.Diagnostics;
using WinForm_Controle_De_Estoque.Relatorios;
using WinForm_Controle_De_Estoque.Formularios.Modelos;
using WinForm_Controle_De_Estoque.Formularios.Cadastros;
using System.Media;


namespace WinForm_Controle_De_Estoque
{
    public partial class MenuPrincipal : Form
    {
        //SoundPlayer meuPlayer = new SoundPlayer(@"G:\ETEC\DS II\ZELDA.wav");
        public MenuPrincipal()
        {
            //meuPlayer.Stop();
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            staUsuario.Text = "Usuário Atual: " + Properties.Settings.Default.NomeUsuarioLogado;
            Checa_Teclas();
        }

        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                staCaps.Text = staCaps.Text == "CAP" ? "" : "CAP";
                Checa_Teclas();
            }

            if (e.KeyCode == Keys.NumLock)
            {
                staNum.Text = staNum.Text == "NUM" ? "" : "NUM";
                Checa_Teclas();
            }
        }
            private void Checa_Teclas()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                staCaps.Text = "CAP";
                staCaps.BorderStyle=Border3DStyle.Raised;
            }

            else
            {
                staCaps.Text = "";
                staCaps.BorderStyle=Border3DStyle.Sunken;

            }

            if (Control.IsKeyLocked(Keys.NumLock))
            {
                staNum.Text = "NUM";
                staNum.BorderStyle=Border3DStyle.Raised;

            }
            else
            {
                staNum.Text = "";
                staNum.BorderStyle=Border3DStyle.Sunken;

            }
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            staHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Confirma", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                Application.ExitThread();
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadClientes clientes = new frmCadClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCategoria categoria = new frmCadCategoria();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProdutos p = new frmCadProdutos();
            p.MdiParent = this;
            p.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadVendas v = new frmCadVendas();
            v.MdiParent = this;
            v.Show();
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(startInfo);
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe", "www.Google.com.br");
        }

        private void relatórioDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioCliente vrpt = new frmVisualizaRelatorioCliente();
            vrpt.MdiParent = this;
            vrpt.Show();   
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.NivelUsuarioLogado != 1)
            {
                MessageBox.Show("Você não tem acesso a este Cadastro!");
            }
            else
            {
                frmUsuario frmUsuario = new frmUsuario();
                frmUsuario.MdiParent = this;
                frmUsuario.Show();
            }
        }

        private void pesquisarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioProduto frm = new frmVisualizaRelatorioProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relatórioDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioCategoria frm = new frmVisualizaRelatorioCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioVenda frm = new frmVisualizaRelatorioVenda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadClientes clientes = new frmCadClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadProdutos clientes = new frmCadProdutos();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCategoria clientes = new frmCadCategoria();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadVendas clientes = new frmCadVendas();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioCliente vrpt = new frmVisualizaRelatorioCliente();
            vrpt.MdiParent = this;
            vrpt.Show();
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioProduto frm = new frmVisualizaRelatorioProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioCategoria frm = new frmVisualizaRelatorioCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVisualizaRelatorioVenda frm = new frmVisualizaRelatorioVenda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void notePadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(startInfo);
        }
    }
}
