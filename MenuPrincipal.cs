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
using WinForm_Controle_De_Estoque.Formularios.Modelos;


namespace WinForm_Controle_De_Estoque
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            ctrHome1.BringToFront();
        }

        bool mouseDown;
        Point lastLocation;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            staUsuario.Text = "Usuário Atual: " + Properties.Settings.Default.NomeUsuarioLogado;
            if(Properties.Settings.Default.NivelUsuarioLogado != 1)
            {
                btn_config.Visible = false;
                btn_Usu.Visible = false;
            }

            else
            {
                btn_config.Visible = false;
                btn_Usu.Visible = true;
            }
            staCaps.Visible = false;
            staNum.Visible = false;
            Checa_Teclas();
        }

        private void MenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                //staCaps.Text = staCaps.Text == "CAP" ? "" : "CAP";
                Checa_Teclas();
            }

            else if (e.KeyCode == Keys.NumLock)
            {
                //staNum.Text = staNum.Text == "NUM" ? "" : "NUM";
                Checa_Teclas();
            }
        }
        private void Checa_Teclas()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                staCaps.Text = " CapsLock Ativado ";
                staCaps.Visible = true;
                staCaps.BorderStyle = Border3DStyle.Raised;
            }

            else
            {
                staCaps.Text = "";
                staCaps.Visible = false;
                staCaps.BorderStyle = Border3DStyle.Sunken;

            }

             if (Control.IsKeyLocked(Keys.NumLock))
            {
                if(staNum.Text == " NumLock Ativado ")
                {
                    staNum.Text = "";
                    staNum.Visible = false;
                    staNum.BorderStyle = Border3DStyle.Sunken;
                }
                else
                {
                    staNum.Text = " NumLock Ativado ";
                    staNum.Visible = true;
                    staNum.BorderStyle = Border3DStyle.Raised;
                }

            }
            else
            {
                staNum.Text = "";
                staNum.Visible = false;
                staNum.BorderStyle = Border3DStyle.Sunken;

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            staHora.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;

            }
            else
            {
                Application.ExitThread();
            }
        }
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ctrHome1.BringToFront();
        }

        private void btn_cliente_Click_1(object sender, EventArgs e)
        {
            ctrCadCliente1.BringToFront();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            ctrCadProduto1.BringToFront();
        }

        private void btn_informacao_Click(object sender, EventArgs e)
        {
            ctrInfo1.BringToFront();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
        }

        private void btn_trocaUsu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin log = new frmLogin();
            log.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ctrCadOrcamentos1.BringToFront();
        }

        private void btn_Usu_Click(object sender, EventArgs e)
        {
            ctrCadUsuario1.BringToFront();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            ctrAjuda1.BringToFront();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmMenuRelatorio menu = new frmMenuRelatorio();
            menu.Show();
        }
    }
}
