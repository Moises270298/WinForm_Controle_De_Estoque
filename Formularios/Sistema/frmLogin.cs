using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocation;

        int vErros = 0;

        private bool CaixasOK()
        {
            if (txtSenha.Text == "")
            {
                errorProvider.SetError(txtSenha, "Informar o usuário");
                return false;
            }

            else
            {
                errorProvider.SetError(txtSenha, "");
            }

            if (txtNomeUsuario.Text == "")
            {
                errorProvider.SetError(txtNomeUsuario, "Informar a Senha");
                return false;
            }

            else
            {
                errorProvider.SetError(txtNomeUsuario, "");
                return true;
            }
        }
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                Dados.dataSet_Dados_Do_Banco.UsuarioDataTable dtUsuario;
                UsuarioTableAdapter taUsuario = new UsuarioTableAdapter();
                dtUsuario = taUsuario.VerificaNivel(txtNomeUsuario.Text, txtSenha.Text);
                if (dtUsuario.Rows.Count == 0) 
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    vErros++;
                    if (vErros == 3)
                    {
                        MessageBox.Show("Número de tentativas esgotados");
                        taUsuario.Dispose();
                        this.Close();
                    }
                }
                else
                {
                    Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["Nivel"];
                    Properties.Settings.Default.NomeUsuarioLogado = txtNomeUsuario.Text;
                    MenuPrincipal frmMenuPrincipal = new MenuPrincipal();
                    frmMenuPrincipal.Show();
                    this.Close();
                }
                /*MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Close();*/
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Se o código ASCII da tecla guardada no "e" for igual ao da tecla Enter, faça isso:
            {
                if (CaixasOK())
                {
                    Dados.dataSet_Dados_Do_Banco.UsuarioDataTable dtUsuario;
                    UsuarioTableAdapter taUsuario = new UsuarioTableAdapter();
                    dtUsuario = taUsuario.VerificaNivel(txtNomeUsuario.Text, txtSenha.Text);
                    if (dtUsuario.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");
                        vErros++;
                        if (vErros == 3)
                        {
                            MessageBox.Show("Número de tentativas esgotados");
                            taUsuario.Dispose();
                            Application.ExitThread();
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["Nivel"];
                        Properties.Settings.Default.NomeUsuarioLogado = txtNomeUsuario.Text;
                        MenuPrincipal frmMenuPrincipal = new MenuPrincipal();
                        frmMenuPrincipal.Show();
                        this.Close();
                    }

                    /*MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Close();*/
                }
            }

            else if (e.KeyCode == Keys.Escape)
            {
                Application.ExitThread();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }      

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
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
    }

}

