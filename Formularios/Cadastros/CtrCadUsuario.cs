using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class CtrCadUsuario : WinForm_Controle_De_Estoque.Formularios.Modelos.CtrTelaBase
    {
        public CtrCadUsuario()
        {
            InitializeComponent();
            dgvGrid.BringToFront();
        }

        private void CtrCadUsuario_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter1.Fill(this.dataSet_Dados_Do_Banco.Usuario);
        }
        public override void Atualiza_Grid()
        {

            try
            {
                this.Text = lblTitulo.Text = "Usuários";
                UsuarioTableAdapter ta = new UsuarioTableAdapter();
                Dados.dataSet_Dados_Do_Banco.UsuarioDataTable dt = new Dados.dataSet_Dados_Do_Banco.UsuarioDataTable();
                dt = ta.GetData();
                Dados.dataSet_Dados_Do_Banco ds = new Dados.dataSet_Dados_Do_Banco();
                ta.Fill(ds.Usuario);
                dataSetDadosDoBancoBindingSource.DataSource = ds.Usuario;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;

                dgvGrid.Columns["ID"].HeaderText = "ID";
                dgvGrid.Columns["ID"].Width = 50;

                dgvGrid.Columns["Nome"].HeaderText = "Nome do Usuário";
                dgvGrid.Columns["Nome"].Width = 400;
                dgvGrid.Columns["Nome"].DisplayIndex = 1;

                dgvGrid.Columns["Senha"].HeaderText = "Senha";
                dgvGrid.Columns["Senha"].Width = 350;

                dgvGrid.Columns["Nivel"].HeaderText = "Nível";
                dgvGrid.Columns["Nivel"].Width = 50;


                dgvGrid.Columns["Data"].HeaderText = "Data de Cadastro";
                dgvGrid.Columns["Data"].Width = 125;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public override void CarregaValores()
        {
            try
            {
                txt_Nome.Text = dgvGrid.CurrentRow.Cells["Nome"].Value.ToString();
                txt_Senha.Text = dgvGrid.CurrentRow.Cells["Senha"].Value.ToString();
                txt_Senha2.Text = dgvGrid.CurrentRow.Cells["Senha"].Value.ToString();
                cmb_Nivel.Text = dgvGrid.CurrentRow.Cells["Nivel"].Value.ToString();
                dtpDataCadastro.Text = dgvGrid.CurrentRow.Cells["Data"].Value.ToString();
            }

            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message);
            }
        }

        public override bool Salvar()
        {
            bool bSalvar = false;
            if (ChecarCaixas())
            {
                return bSalvar = false;
            }
            else
            {
                UsuarioTableAdapter ta = new UsuarioTableAdapter();
                if (sStatus == StatusCadastro.scIncluindo)
                {
                    bSalvar = ta.Insert(txt_Nome.Text, txt_Senha.Text, int.Parse(cmb_Nivel.Text), DateTime.Parse(dtpDataCadastro.Text)) > 0;
                }
                return bSalvar = true;
            }

        }

        public override bool Alterar()
        {
            bool bAterar = false;


                if (ChecarCaixas())
                {
                    return bAterar = false;
                }
                else
                {
                    UsuarioTableAdapter ta = new UsuarioTableAdapter();
                    if (sStatus == StatusCadastro.scAlterando)
                    {
                       bAterar = ta.Update(txt_Nome.Text, txt_Senha.Text, int.Parse(cmb_Nivel.Text), DateTime.Parse(dtpDataCadastro.Text), nCodGenerico) > 0;

                    }
                return bAterar;

                }


        }

        public override bool Excluir()
        {
            bool bExcluir = false;

            try
            {
                UsuarioTableAdapter ta = new UsuarioTableAdapter();
                bExcluir = ta.Delete(nCodGenerico) > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Deu erro!" + e);
            }

            return bExcluir = true;
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string vfiltro = cmbColuna.Text;

            switch (vfiltro)
            {
                case "Código/Id":
                    vfiltro = "ID";
                    break;
                case "Nome":
                    vfiltro = "Nome";
                    break;
                case "Senha":
                    vfiltro = "Senha";
                    break;
                default:
                    break;
            }
            try
            {
                if (txt_Pesquisa.Text == "")
                {
                    usuarioBindingSource.Filter = "";
                }

                else if (cmbColuna.Text == "")
                {
                    usuarioBindingSource.Filter = "";
                }

                else if (vfiltro == "ID")
                {
                    usuarioBindingSource.RemoveFilter();
                    usuarioBindingSource.Filter = vfiltro + " = " + txt_Pesquisa.Text;
                }

                else
                {
                    usuarioBindingSource.RemoveFilter();
                    usuarioBindingSource.Filter = vfiltro + " like '" + txt_Pesquisa.Text + "%'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu erro!  " + ex, "Erro!", MessageBoxButtons.OK);
            }
        }

        private bool ChecarCaixas()
        {
            bool bCheck = false;
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_Senha.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_Senha2.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (cmb_Nivel.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            return bCheck = false;
        }
    }
}


