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
    public partial class frmUsuario : WinForm_Controle_De_Estoque.Formularios.Modelos.frmBase
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.usuarioTableAdapter.Fill(this.dataSet_Dados_Do_Banco.Usuario);
        }
            public override void Atualiza_Grid()
            {

                try
                {
                    this.Text = lblTitulo.Text = "Cadastro de Usuários";
                    UsuarioTableAdapter ta = new UsuarioTableAdapter();
                    Dados.dataSet_Dados_Do_Banco.UsuarioDataTable dt = new Dados.dataSet_Dados_Do_Banco.UsuarioDataTable();
                    dt = ta.GetData();
                    Dados.dataSet_Dados_Do_Banco ds = new Dados.dataSet_Dados_Do_Banco();
                    ta.Fill(ds.Usuario);
                    dataSetDadosDoBancoBindingSource.DataSource = ds.Usuario;
                    dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;
                    BindingNavigator.BindingSource = dataSetDadosDoBancoBindingSource;

                    dgvGrid.Columns["ID"].HeaderText = "ID";
                    dgvGrid.Columns["ID"].Width = 50;

                    dgvGrid.Columns["Nome"].HeaderText = "Nome do Usuário";
                    dgvGrid.Columns["Nome"].Width = 200;
                    dgvGrid.Columns["Nome"].DisplayIndex = 1;

                    dgvGrid.Columns["Senha"].HeaderText = "Senha";
                    dgvGrid.Columns["Senha"].Width = 200;

                    dgvGrid.Columns["Nivel"].HeaderText = "Nível";
                    dgvGrid.Columns["Nivel"].Width = 50;

                dgvGrid.Columns["Data"].HeaderText = "Data de Cadastro";
                dgvGrid.Columns["Data"].Width = 50;

                dgvGrid.Width = TabControl.Width - 20;



                    if (cmbColuna.Items.Count == 0)
                    {
                        foreach (DataColumn coluna in ds.Usuario.Columns)
                        {
                            cmbColuna.Items.Add(coluna.ColumnName);
                        }
                    }
                    dtGenerico = ds.Usuario;
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
                    txt_nome.Text = dgvGrid.CurrentRow.Cells["Nome"].Value.ToString();
                    txt_senha.Text = dgvGrid.CurrentRow.Cells["Senha"].Value.ToString();
                    txt_nv.Text = dgvGrid.CurrentRow.Cells["Nivel"].Value.ToString();
                dtpCadastro.Text = dgvGrid.CurrentRow.Cells["Data"].Value.ToString();
            }

            catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            public override bool Salvar()
            {
                bool bSalvar = false;

                try
                {
                    UsuarioTableAdapter ta = new UsuarioTableAdapter();
                    if (sStatus == StatusCadastro.scIncluindo)
                    {
                        bSalvar = ta.Insert(txt_nome.Text,txt_senha.Text,int.Parse(txt_nv.Text))>0;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Deu erro!" + e);
                }
                return bSalvar = true;
            }

            public override bool Alterar()
            {
                bool bAterar = false;

                try
                {
                    UsuarioTableAdapter ta = new UsuarioTableAdapter();
                    if (sStatus == StatusCadastro.scAlterando)
                    {
                        bAterar = ta.Update(txt_nome.Text,txt_senha.Text,int.Parse(txt_nv.Text),nCodGenerico)>0;
                    }
            }
                catch (Exception e)
                {
                    MessageBox.Show("Deu erro!" + e);
                }
                return bAterar;
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

        }
    }

