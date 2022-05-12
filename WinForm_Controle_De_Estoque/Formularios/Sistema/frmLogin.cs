using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WinForm_Controle_De_Estoque.Dados;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{

    public partial class frmLogin : Form
    {
        //SoundPlayer meuPlayer = new SoundPlayer(@"G:\ETEC\DS II\ZELDA.wav");
        public frmLogin()
        {
            InitializeComponent();
        }

        int vErros = 0;

        private bool CaixasOK()
        {
            if (txtNomeUsuario.Text == "")
            {
                errorProvider.SetError(txtNomeUsuario, "Informar o usuário");
                return false;
            }

            else
            {
                errorProvider.SetError(txtNomeUsuario, "");
            }

            if (txtSenha.Text == "")
            {
                errorProvider.SetError(txtSenha, "Informar a Senha");
                return false;
            }

            else
            {
                errorProvider.SetError(txtSenha, "");
                return true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
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
                }


            }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

        }

        private void lbn_Music_Click(object sender, EventArgs e)
        {
            if (lbn_Music.Text == "Play Music")
            {
                //meuPlayer.Play();
                lbn_Music.Text = "Stop Music";
            }
            else
            {
                lbn_Music.Text = "Play Music";
                //m//euPlayer.Stop();
            }

        }

        private void lbn_Music_MouseLeave(object sender, EventArgs e)
        {
            lbn_Music.ForeColor = Color.DarkGray;
        }

        private void lbn_Music_MouseHover(object sender, EventArgs e)
        {
            lbn_Music.ForeColor = Color.White;
        }
    }

}

