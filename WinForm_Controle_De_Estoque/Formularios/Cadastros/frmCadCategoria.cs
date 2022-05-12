using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class frmCadCategoria : WinForm_Controle_De_Estoque.Formularios.Modelos.frmBase
    {
        public frmCadCategoria()
        {
            InitializeComponent();
        }

        public override void Atualiza_Grid()
        {
            try
            {
                this.Text = lblTitulo.Text = "Categoria de Produtos";
                Dados.dataSet_Dados_Do_Banco.CategoriaDataTable dt = new Dados.dataSet_Dados_Do_Banco.CategoriaDataTable();
                CategoriaTableAdapter ta = new CategoriaTableAdapter();
                dt = ta.GetData();
                Dados.dataSet_Dados_Do_Banco ds = new Dados.dataSet_Dados_Do_Banco();
                ta.Fill(ds.Categoria);
                dataSetDadosDoBancoBindingSource.DataSource = ds.Categoria;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;
                BindingNavigator.BindingSource = dataSetDadosDoBancoBindingSource;

                dgvGrid.Columns[0].HeaderText = "ID";
                dgvGrid.Columns[0].Width = 50;
                dgvGrid.Columns[1].HeaderText = "Nome da Categoria";
                dgvGrid.Columns[1].Width = 600;
           
                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Categoria.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }
                }
                dtGenerico = ds.Categoria;
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
                txtCodigo.Text = dgvGrid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvGrid.CurrentRow.Cells["cat_Descricao"].Value.ToString();
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public override bool Salvar()
        {
            bool bSalvar = false;
            CategoriaTableAdapter ta = new CategoriaTableAdapter();
            if (sStatus == StatusCadastro.scIncluindo)
            {
                bSalvar = (ta.Insert(txtNome.Text) > 0);
            }

            return bSalvar;
        }

        public override bool Alterar()
        {
            bool bSalvar = false;
            CategoriaTableAdapter ta = new CategoriaTableAdapter();

            if (sStatus == StatusCadastro.scAlterando)
            {
                bSalvar = (ta.Update(txtNome.Text, nCodGenerico) > 0);
            }
            return bSalvar;
        }

        public override bool Excluir()
        {
            bool bExcluir = false;
            CategoriaTableAdapter ta = new CategoriaTableAdapter();
            bExcluir = (ta.Delete(nCodGenerico) > 0);
            return bExcluir;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                errErro.SetError(txtNome, "O campo nome precisa ser preenchido");
                e.Cancel = true;
            }

            else
            {
                errErro.SetError(txtNome, "");
            }
        }

        private void frmCadCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
