using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class frmCadProdutos : WinForm_Controle_De_Estoque.Formularios.Modelos.frmBase
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        public override void Atualiza_Grid()
        {
            try
            {
                this.Text = lblTitulo.Text = "Produtos";
                Dados.dataSet_Dados_Do_Banco.ProdutoDataTable dt = new Dados.dataSet_Dados_Do_Banco.ProdutoDataTable();
                ProdutoTableAdapter ta = new ProdutoTableAdapter();
                dt = ta.GetData();
                Dados.dataSet_Dados_Do_Banco ds = new Dados.dataSet_Dados_Do_Banco();
                ta.Fill(ds.Produto);
                //ta.Fill(dt);
                dataSetDadosDoBancoBindingSource.DataSource = ds.Produto;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;
                BindingNavigator.BindingSource = dataSetDadosDoBancoBindingSource;

                dgvGrid.Columns[0].HeaderText = "ID";
                dgvGrid.Columns[0].Width = 50;

                DataGridViewComboBoxColumn dgvcolcombo = new DataGridViewComboBoxColumn();
                dgvcolcombo.HeaderText = "Categoria";
                dgvcolcombo.DataSource = categoriaBindingSource;
                dgvcolcombo.DataPropertyName = "cat_Id";
                dgvcolcombo.Name = "cat_Id";
                dgvcolcombo.DisplayMember = "cat_Descricao";
                dgvcolcombo.ValueMember = "cat_Id";

                /*cmbCat.DisplayMember = "cat_Descricao";
                cmbCat.ValueMember = "cat_Id"; 
                cmbCat.DataSource = ds.Tables["Categoria"];*/

                /*cmbCat.DataSource = dt;
                cmbCat.DisplayMember = "cat_Descricao";
                cmbCat.ValueMember = "cat_Id";*/


                dgvGrid.Columns.Remove(dgvGrid.Columns["cat_Id"]);
                dgvGrid.Columns.Add(dgvcolcombo);

                DataGridViewCheckBoxColumn dgvcolcheck = new DataGridViewCheckBoxColumn();
                dgvcolcheck.HeaderText = "Ativo";
                dgvcolcheck.DataPropertyName = "pro_Ativo";
                dgvcolcheck.Name = "pro_Ativo";

                dgvGrid.Columns.Remove(dgvGrid.Columns["pro_Ativo"]);
                dgvGrid.Columns.Add(dgvcolcheck);

                /*dgvGrid.Columns["cat_Id"];
                dgvGrid.Columns["cat_Id"].HeaderText = "Categoria";
                dgvGrid.Columns["cat_Id"].Width = 200;*/

                dgvGrid.Columns["pro_Descricao"].HeaderText = "Descrição";
                dgvGrid.Columns["pro_Descricao"].Width = 300;
                dgvGrid.Columns["pro_Descricao"].DisplayIndex = 1;

                dgvGrid.Columns["pro_QtdeEstoque"].HeaderText = "Qtd";
                dgvGrid.Columns["pro_QtdeEstoque"].Width = 50;

                dgvGrid.Columns["pro_Valor"].HeaderText = "Valor";
                dgvGrid.Columns["pro_Valor"].Width = 100;
                dgvGrid.Columns["pro_Valor"].DefaultCellStyle.Format = "R$ ###,##0.00";

                dgvGrid.Columns["pro_Ativo"].HeaderText = "Ativo";
                dgvGrid.Columns["pro_Ativo"].Width = 45;

                dgvGrid.Columns["pro_Data"].HeaderText = "Data";
                dgvGrid.Columns["pro_Data"].Width = 100; ;

                dgvGrid.Columns["cat_Id"].Width = 200;

                dgvGrid.Width = TabControl.Width - 20;


                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Produto.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }

                }
                dtGenerico = ds.Produto;
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
                txtId.Text = dgvGrid.CurrentRow.Cells["pro_Id"].Value.ToString();
                cmbCat.SelectedValue = dgvGrid.CurrentRow.Cells["cat_Id"].Value;
                txt_desc.Text = dgvGrid.CurrentRow.Cells["pro_Descricao"].Value.ToString();
                txt_QtdeEstoque.Text = dgvGrid.CurrentRow.Cells["pro_QtdeEstoque"].Value.ToString();
                txt_valor.Text = dgvGrid.CurrentRow.Cells["pro_Valor"].Value.ToString();
                chkAtivo.Checked = bool.Parse(dgvGrid.CurrentRow.Cells["pro_Ativo"].Value.ToString());
                dtpData.Text = dgvGrid.CurrentRow.Cells["pro_Data"].Value.ToString();
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public override bool Salvar()
        {
            bool bSalvar = false;
            ProdutoTableAdapter ta = new ProdutoTableAdapter();
            if (sStatus == StatusCadastro.scIncluindo)
            {
                bSalvar = ta.Insert(int.Parse(cmbCat.SelectedValue.ToString()),
                    txt_desc.Text,
                    int.Parse(txt_QtdeEstoque.Text),
                    decimal.Parse(txt_valor.Text),
                    chkAtivo.Checked.ToString(),
                    DateTime.Parse(dtpData.Text)) > 0;
            }

            return bSalvar;
        }

        public override bool Alterar()
        {
            bool bSalvar = false;
            ProdutoTableAdapter ta = new ProdutoTableAdapter();
            if (sStatus == StatusCadastro.scAlterando)
            {
                bSalvar = ta.Update(int.Parse(cmbCat.SelectedValue.ToString()),
                                    txt_desc.Text,
                                    int.Parse(txt_QtdeEstoque.Text),
                                    decimal.Parse(txt_valor.Text),
                                    chkAtivo.Checked.ToString(),
                                    DateTime.Parse(dtpData.Text), nCodGenerico) > 0;
            }
            return bSalvar;
        }

        public override bool Excluir()
        {
            bool bExcluir = false;
            ProdutoTableAdapter ta = new ProdutoTableAdapter();
            bExcluir = (ta.Delete(nCodGenerico) > 0);
            return bExcluir;
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            this.categoriaTableAdapter.Fill(this.dataSet_Dados_Do_Banco.Categoria);
            this.produtoTableAdapter.Fill(this.dataSet_Dados_Do_Banco.Produto);
        }
    }
}



