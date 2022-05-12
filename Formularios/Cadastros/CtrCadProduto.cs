using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class CtrCadProduto : WinForm_Controle_De_Estoque.Formularios.Modelos.CtrTelaBase
    {
        public CtrCadProduto()
        {
            InitializeComponent();
            dgvGrid.BringToFront();
            txt_Valor.Text = string.Format("C");
        }

        public override void Atualiza_Grid()
        {
            try
            {
                this.Text = lblTitulo.Text = "Produtos";
                Dados.dataSet_Dados_Do_Banco.TCC_PRODUTODataTable dt = new Dados.dataSet_Dados_Do_Banco.TCC_PRODUTODataTable();
                TCC_PRODUTOTableAdapter ta = new TCC_PRODUTOTableAdapter();
                dt = ta.GetData();
                Dados.dataSet_Dados_Do_Banco ds = new Dados.dataSet_Dados_Do_Banco();
                ta.Fill(ds.TCC_PRODUTO);
                dataSetDadosDoBancoBindingSource.DataSource = ds.TCC_PRODUTO;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;

                dgvGrid.Columns[0].HeaderText = "ID";
                dgvGrid.Columns[0].Width = 48;


                DataGridViewCheckBoxColumn dgvcolcheck = new DataGridViewCheckBoxColumn();
                dgvcolcheck.HeaderText = "Ativo";
                dgvcolcheck.DataPropertyName = "pro_Ativo";
                dgvcolcheck.Name = "pro_Ativo";

                dgvGrid.Columns.Remove(dgvGrid.Columns["pro_Ativo"]);
                dgvGrid.Columns.Add(dgvcolcheck);

                //dgvGrid.Columns["tipo_Id"].HeaderText = "Tipo";
                //dgvGrid.Columns["tipo_Id"].Width = 200;

                dgvGrid.Columns["pro_Descricao"].HeaderText = "Descrição";
                dgvGrid.Columns["pro_Descricao"].Width = 400;
                dgvGrid.Columns["pro_Descricao"].DisplayIndex = 1;

                dgvGrid.Columns["pro_tipo"].HeaderText = "Tipo";
                dgvGrid.Columns["pro_tipo"].Width = 225;
                dgvGrid.Columns["pro_tipo"].DisplayIndex = 2;

                //dgvGrid.Columns["tipo_Id"].HeaderText = "Tipo";
                //dgvGrid.Columns["tipo_Id"].Width = 150;

                dgvGrid.Columns["pro_QtdeEstoque"].HeaderText = "Qtd";
                dgvGrid.Columns["pro_QtdeEstoque"].Width = 50;

                dgvGrid.Columns["pro_Valor"].HeaderText = "Valor";
                dgvGrid.Columns["pro_Valor"].Width = 100;
                dgvGrid.Columns["pro_Valor"].DefaultCellStyle.Format = "C";

                dgvGrid.Columns["pro_Ativo"].HeaderText = "Ativo";
                dgvGrid.Columns["pro_Ativo"].Width = 40;

                dgvGrid.Columns["pro_Data"].HeaderText = "Data";
                dgvGrid.Columns["pro_Data"].Width = 100;


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
                txt_Desc.Text = dgvGrid.CurrentRow.Cells["pro_Descricao"].Value.ToString();
                txt_tipo.Text = dgvGrid.CurrentRow.Cells["pro_tipo"].Value.ToString();
                txt_quantidade.Text = dgvGrid.CurrentRow.Cells["pro_QtdeEstoque"].Value.ToString();
                txt_Valor.Text = dgvGrid.CurrentRow.Cells["pro_Valor"].Value.ToString();
                chk_Ativo.Checked = bool.Parse(dgvGrid.CurrentRow.Cells["pro_Ativo"].Value.ToString());
                dtpDataCadastro.Text = dgvGrid.CurrentRow.Cells["pro_Data"].Value.ToString();
                txt_Valor.Text = Convert.ToDouble(txt_Valor.Text).ToString("F");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                TCC_PRODUTOTableAdapter ta = new TCC_PRODUTOTableAdapter();
                if (sStatus == StatusCadastro.scIncluindo)
                {
                    bSalvar = ta.Insert(txt_Desc.Text, txt_tipo.Text, int.Parse(txt_quantidade.Text), decimal.Parse(txt_Valor.Text), chk_Ativo.Checked.ToString(), DateTime.Parse(dtpDataCadastro.Text)) > 0;
                }

                return bSalvar;
            }

        }

        public override bool Alterar()
        {
            bool bSalvar = false;

            if (ChecarCaixas())
            {
                return bSalvar = false;
            }
            else
            {
                TCC_PRODUTOTableAdapter ta = new TCC_PRODUTOTableAdapter();
                if (sStatus == StatusCadastro.scAlterando)
                {
                    bSalvar = ta.Update(txt_Desc.Text, txt_tipo.Text, int.Parse(txt_quantidade.Text), decimal.Parse(txt_Valor.Text), chk_Ativo.Checked.ToString(), DateTime.Parse(dtpDataCadastro.Text), nCodGenerico) > 0;
                }
                return bSalvar;
            }
            
        }

        public override bool Excluir()
        {
            bool bExcluir = false;
            TCC_PRODUTOTableAdapter ta = new TCC_PRODUTOTableAdapter();
            bExcluir = (ta.Delete(nCodGenerico) > 0);
            return bExcluir;
        }

        private void CtrCadProduto_Load(object sender, EventArgs e)
        {
            this.tCC_PRODUTOTableAdapter.Fill(this.dataSet_Dados_Do_Banco.TCC_PRODUTO);
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string vfiltro = cmbColuna.Text;

            switch (vfiltro)
            {
                case "Código/Id":
                    vfiltro = "pro_Id";
                    break;
                case "Descrição":
                    vfiltro = "pro_descricao";
                    break;
                case "Tipo":
                    vfiltro = "pro_tipo";
                    break;
                case "Quantidade":
                    vfiltro = "pro_QtdeEstoque";
                    break;
                case "Valor":
                    vfiltro = "pro_Valor";
                    break;
                case "Disponível":
                    vfiltro = "pro_Ativo";
                    break;
                default:
                    break;
            }
            try
            {
                if (txt_Pesquisa.Text == "")
                {
                    tCCPRODUTOBindingSource.Filter = "";
                }

                else if (cmbColuna.Text == "")
                {
                    tCCPRODUTOBindingSource.Filter = "";
                }

                else if (vfiltro == "pro_Id" || vfiltro == "pro_QtdeEstoque" || vfiltro == "pro_Valor")
                {
                    tCCPRODUTOBindingSource.RemoveFilter();
                    tCCPRODUTOBindingSource.Filter = vfiltro + " = " + txt_Pesquisa.Text;
                }

                else
                {
                    tCCPRODUTOBindingSource.RemoveFilter();
                    tCCPRODUTOBindingSource.Filter = vfiltro + " like '" + txt_Pesquisa.Text + "%'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira os Parâmetros Corretos de Acordo com o Filtro!  ", "Erro!", MessageBoxButtons.OK);
            }
        }

        private void txt_Valor_Leave(object sender, EventArgs e)
        {
            try
            {
                if(txt_Valor.Text == "")
                {
                    return;
                }

                else
                {
                    txt_Valor.Text = Convert.ToDouble(txt_Valor.Text).ToString("F");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex, "Erro!", MessageBoxButtons.OK);
            }
        }

        private void txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt_Valor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_Valor_Enter(object sender, EventArgs e)
        {
            string x = "";
            for (int i = 0; i <= txt_Valor.Text.Length - 1; i++)
            {
                if ((txt_Valor.Text[i] >= '0' &&
                    txt_Valor.Text[i] <= '9') ||
                    txt_Valor.Text[i] == ',')
                {
                    x += txt_Valor.Text[i];
                }
            }
            txt_Valor.Text = x;
            txt_Valor.SelectAll();
        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbColuna.Text == "Disponível")
            {
                MessageBox.Show("Para a pesquisa, digite: 'true' para ver os produtos disponíveis, e 'false' para ver ver os produtos indisponíveis!", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ChecarCaixas()
        {
            bool bCheck = false;
            if (txt_Desc.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return bCheck= true;
            }

            else if (txt_tipo.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_quantidade.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_Valor.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            return bCheck = false;
        }

        private void txt_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txt_Valor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txt_quantidade_Enter(object sender, EventArgs e)
        {
            string x = "";
            for (int i = 0; i <= txt_Valor.Text.Length - 1; i++)
            {
                if ((txt_Valor.Text[i] >= '0' &&
                    txt_Valor.Text[i] <= '9') ||
                    txt_Valor.Text[i] == ',')
                {
                    x += txt_Valor.Text[i];
                }
            }
            txt_Valor.Text = x;
            txt_Valor.SelectAll();
        }
    }
}