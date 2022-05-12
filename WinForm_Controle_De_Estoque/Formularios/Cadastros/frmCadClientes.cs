using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WinForm_Controle_De_Estoque.Dados;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class frmCadClientes : WinForm_Controle_De_Estoque.Formularios.Modelos.frmBase
    {
        public frmCadClientes()
        {
            InitializeComponent();
        }

        public override void Atualiza_Grid()
        {

            try
            {
                this.Text = lblTitulo.Text = "Cadastro de Clientes";
                ClienteTableAdapter ta = new ClienteTableAdapter();
                Dados.dataSet_Dados_Do_Banco.ClienteDataTable dt = new Dados.dataSet_Dados_Do_Banco.ClienteDataTable();
                dt = ta.GetData();
                Dados.dataSet_Dados_Do_Banco ds = new Dados.dataSet_Dados_Do_Banco();
                ta.Fill(ds.Cliente);
                dataSetDadosDoBancoBindingSource.DataSource = ds.Cliente;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;
                BindingNavigator.BindingSource = dataSetDadosDoBancoBindingSource;

                dgvGrid.Columns["cli_Id"].HeaderText = "ID";
                dgvGrid.Columns["cli_Id"].Width = 50;

                dgvGrid.Columns["cli_NomeRazao"].HeaderText = "Nome/Razão";
                dgvGrid.Columns["cli_NomeRazao"].Width = 250;
                dgvGrid.Columns["cli_NomeRazao"].DisplayIndex = 1;

                dgvGrid.Columns["cli_CNPJCPF"].HeaderText = "CNPJ/CPF";
                dgvGrid.Columns["cli_CNPJCPF"].Width = 125;

                dgvGrid.Columns["cli_Logradouro"].HeaderText = "Logradouro";
                dgvGrid.Columns["cli_Logradouro"].Width = 80;

                dgvGrid.Columns["cli_Bairro"].HeaderText = "Bairro";
                dgvGrid.Columns["cli_Bairro"].Width = 100;

                dgvGrid.Columns["cli_Cidade"].HeaderText = "Cidade";
                dgvGrid.Columns["cli_Cidade"].Width = 100;

                dgvGrid.Columns["cli_UF"].HeaderText = "UF";
                dgvGrid.Columns["cli_UF"].Width = 35;

                dgvGrid.Columns["cli_CEP"].HeaderText = "CEP";
                dgvGrid.Columns["cli_CEP"].Width = 70;
                dgvGrid.Columns["cli_CEP"].DefaultCellStyle.Format = "00000-000";

                dgvGrid.Columns["cli_Email"].HeaderText = "Email";
                dgvGrid.Columns["cli_Email"].Width = 175;

                dgvGrid.Columns["cli_Fones"].HeaderText = "Telefone";
                dgvGrid.Columns["cli_Fones"].Width = 100;
                //dgvGrid.Columns["cli_Fones"].DefaultCellStyle.Format = "(00) #0000-0000";

                dgvGrid.Columns["cli_DtCadastro"].HeaderText = "Data de Cadastro";
                dgvGrid.Columns["cli_DtCadastro"].Width = 75;
                //dgvGrid.Columns["cli_DtCadastro"].DefaultCellStyle.Format = "00/00/0000";

                dgvGrid.Width = TabControl.Width - 20;
                

            
                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Cliente.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }
                }
                dtGenerico = ds.Cliente;
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
                txt_NomeRazao.Text = dgvGrid.CurrentRow.Cells["cli_NomeRazao"].Value.ToString();
                msk_CPF.Text = dgvGrid.CurrentRow.Cells["cli_CNPJCPF"].Value.ToString();
                txt_Logradouro.Text = dgvGrid.CurrentRow.Cells["cli_Logradouro"].Value.ToString();
                txt_Bairro.Text = dgvGrid.CurrentRow.Cells["cli_bairro"].Value.ToString();
                txt_Cidade.Text = dgvGrid.CurrentRow.Cells["cli_Cidade"].Value.ToString();
                cmb_UF.Text = dgvGrid.CurrentRow.Cells["cli_UF"].Value.ToString();
                msk_CEP.Text = dgvGrid.CurrentRow.Cells["cli_CEP"].Value.ToString();
                txt_Email.Text = dgvGrid.CurrentRow.Cells["cli_Email"].Value.ToString();
                msk_Fone.Text = dgvGrid.CurrentRow.Cells["cli_Fones"].Value.ToString();
                dtpData.Text = dgvGrid.CurrentRow.Cells["cli_DtCadastro"].Value.ToString();
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
                ClienteTableAdapter ta = new ClienteTableAdapter();              
                if (sStatus == StatusCadastro.scIncluindo)
                {
                    bSalvar = ta.Insert(txt_NomeRazao.Text, msk_CPF.Text, txt_Logradouro.Text,
                        txt_Bairro.Text, txt_Cidade.Text, cmb_UF.Text, msk_CEP.Text,
                        txt_Email.Text, msk_Fone.Text,DateTime.Parse(dtpData.Text))>0;
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
                ClienteTableAdapter ta = new ClienteTableAdapter();
                if (sStatus == StatusCadastro.scAlterando)
                {
                    bAterar = ta.Update(txt_NomeRazao.Text, msk_CPF.Text, txt_Logradouro.Text,
                        txt_Bairro.Text, txt_Cidade.Text, cmb_UF.Text, msk_CEP.Text,
                        txt_Email.Text, msk_Fone.Text, DateTime.Parse(dtpData.Text), nCodGenerico) > 0;
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
                ClienteTableAdapter ta = new ClienteTableAdapter();
                bExcluir = (ta.Delete(nCodGenerico) > 0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Deu erro!" + e);
            }

            return bExcluir = true;
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter1.Fill(this.dataSet_Dados_Do_Banco.Cliente);
        }
    }
}

