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
    public partial class CtrCadCliente : WinForm_Controle_De_Estoque.Formularios.Modelos.CtrTelaBase
    {
        public CtrCadCliente()
        {
            InitializeComponent();
            dgvGrid.BringToFront();
        }

        public override void Atualiza_Grid()
        {

            try
            {
                this.Text = lblTitulo.Text = "Clientes";
                TCC_CLIENTETableAdapter ta = new TCC_CLIENTETableAdapter();
                Dados.dataSet_Dados_Do_Banco.TCC_CLIENTEDataTable dt = new Dados.dataSet_Dados_Do_Banco.TCC_CLIENTEDataTable();
                dt = ta.GetData();
                Dados.dataSet_Dados_Do_Banco ds = new Dados.dataSet_Dados_Do_Banco();
                ta.Fill(ds.TCC_CLIENTE);
                dataSetDadosDoBancoBindingSource.DataSource = ds.TCC_CLIENTE;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;


                dgvGrid.Columns["cli_Id"].HeaderText = "ID";
                dgvGrid.Columns["cli_Id"].Width = 50;

                dgvGrid.Columns["cli_Nome"].HeaderText = "Nome";
                dgvGrid.Columns["cli_Nome"].Width = 250;
                dgvGrid.Columns["cli_Nome"].DisplayIndex = 1;

                dgvGrid.Columns["cli_CPF"].HeaderText = "CPF";
                dgvGrid.Columns["cli_CPF"].Width = 110;

                dgvGrid.Columns["cli_Endereco"].HeaderText = "Endereço";
                dgvGrid.Columns["cli_Endereco"].Width = 250;

                dgvGrid.Columns["cli_Numero"].HeaderText = "Número";
                dgvGrid.Columns["cli_Numero"].Width = 60;

                dgvGrid.Columns["cli_Bairro"].HeaderText = "Bairro";
                dgvGrid.Columns["cli_Bairro"].Width = 175;

                dgvGrid.Columns["cli_Cidade"].HeaderText = "Cidade";
                dgvGrid.Columns["cli_Cidade"].Width = 100;

                dgvGrid.Columns["cli_UF"].HeaderText = "UF";
                dgvGrid.Columns["cli_UF"].Width = 35;

                dgvGrid.Columns["cli_CEP"].HeaderText = "CEP";
                dgvGrid.Columns["cli_CEP"].Width = 95;
                //dgvGrid.Columns["cli_CEP"].DefaultCellStyle.Format = "00000-000";


                dgvGrid.Columns["cli_Fones"].HeaderText = "Telefone";
                dgvGrid.Columns["cli_Fones"].Width = 110;
                //dgvGrid.Columns["cli_Fones"].DefaultCellStyle.Format = "(00) #0000-0000";

                dgvGrid.Columns["cli_DtCadastro"].HeaderText = "Data de Cadastro";
                dgvGrid.Columns["cli_DtCadastro"].Width = 75;
                //dgvGrid.Columns["cli_DtCadastro"].DefaultCellStyle.Format = "00/00/0000";                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public override void CarregaValores()
        {

            txt_Nome.Text = dgvGrid.CurrentRow.Cells["cli_Nome"].Value.ToString();
            msk_Fone.Text = dgvGrid.CurrentRow.Cells["cli_Fones"].Value.ToString();
            txt_Bairro.Text = dgvGrid.CurrentRow.Cells["cli_Bairro"].Value.ToString();
            txt_Endereco.Text = dgvGrid.CurrentRow.Cells["cli_Endereco"].Value.ToString();
            txt_Numero.Text = dgvGrid.CurrentRow.Cells["cli_Numero"].Value.ToString();
            txt_Cidade.Text = dgvGrid.CurrentRow.Cells["cli_Cidade"].Value.ToString();
            txt_UF.Text = dgvGrid.CurrentRow.Cells["cli_UF"].Value.ToString();
            msk_CPF.Text = dgvGrid.CurrentRow.Cells["cli_CPF"].Value.ToString();
            msk_CEP.Text = dgvGrid.CurrentRow.Cells["cli_CEP"].Value.ToString();
            dtpDataCadastro.Text = dgvGrid.CurrentRow.Cells["cli_DtCadastro"].Value.ToString();
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
                TCC_CLIENTETableAdapter ta = new TCC_CLIENTETableAdapter();
                if (sStatus == StatusCadastro.scIncluindo)
                {
                    bSalvar = (ta.Insert(txt_Nome.Text, msk_CPF.Text, txt_Bairro.Text, txt_Endereco.Text, txt_Numero.Text, txt_Cidade.Text, txt_UF.Text.ToUpper(), msk_CEP.Text, msk_Fone.Text, DateTime.Parse(dtpDataCadastro.Text)) > 0);
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
                TCC_CLIENTETableAdapter ta = new TCC_CLIENTETableAdapter();
                if (sStatus == StatusCadastro.scAlterando)
                {
                    bAterar = (ta.Update(txt_Nome.Text, msk_CPF.Text, txt_Bairro.Text, txt_Endereco.Text, txt_Numero.Text, txt_Cidade.Text, txt_UF.Text.ToUpper(), msk_CEP.Text, msk_Fone.Text, DateTime.Parse(dtpDataCadastro.Text), nCodGenerico) > 0);
                }

                return bAterar;
            }
        }

        public override bool Excluir()
        {
            bool bExcluir = false;

            try
            {
                TCC_CLIENTETableAdapter ta = new TCC_CLIENTETableAdapter();
                bExcluir = (ta.Delete(nCodGenerico) > 0);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Deu erro!" + e);
            }

            return bExcluir = true;
        }

        private void CtrCadCliente_Load(object sender, EventArgs e)
        {
            this.TCC_ClienteTableAdapter.Fill(this.dataSet_Dados_Do_Banco.TCC_CLIENTE);
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string vfiltro = cmbColuna.Text;

            switch (vfiltro)
            {
                case "Código/Id":
                    vfiltro = "cli_Id";
                    break;
                case "Nome":
                    vfiltro = "cli_Nome";
                    break;
                case "Endereço":
                    vfiltro = "cli_Endereco";
                    break;
                case "Número da Casa":
                    vfiltro = "cli_Numero";
                    break;
                case "Bairro":
                    vfiltro = "cli_Bairro";
                    break;
                case "Cidade":
                    vfiltro = "cli_Cidade";
                    break;
                case "Estado":
                    vfiltro = "cli_UF";
                    break;
                case "CEP":
                    vfiltro = "cli_CEP";
                    break;
                case "CPF":
                    vfiltro = "cli_CPF";
                    break;
                case "Telefone":
                    vfiltro = "cli_Fones";
                    break;
                case "Data de Cadastro":
                    vfiltro = "cli_DtCadastro";
                    break;
                default:
                    break;
            }
            try
            {
                if (txt_Pesquisa.Text == "")
                {
                    clienteBindingsource.Filter = "";
                }

                else if (cmbColuna.Text == "")
                {
                    clienteBindingsource.Filter = "";
                }

                else if (vfiltro == "cli_Id")
                {
                    clienteBindingsource.RemoveFilter();
                    clienteBindingsource.Filter = vfiltro + " = " + txt_Pesquisa.Text;
                }

                else
                {
                    clienteBindingsource.RemoveFilter();
                    clienteBindingsource.Filter = vfiltro + " like '" + txt_Pesquisa.Text + "%'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira os Parâmetros Corretos de Acordo com o Filtro!  ", "Erro!", MessageBoxButtons.OK);
            }
        }

        private void cmbColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColuna.Text == "Telefone")
            {
                txt_Pesquisa.Mask = "(00) ##########";
                Atualiza_Grid();
            }

            else
            {
                txt_Pesquisa.Mask = "";
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

            else if (txt_Endereco.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_Numero.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_Bairro.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_Cidade.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (txt_UF.Text == "")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (msk_CEP.Text == "     -")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (msk_CPF.Text == "         -")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            else if (msk_Fone.Text == "(  )      -")
            {
                MessageBox.Show("Digite todas as informações necessárias!  ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return bCheck = true;
            }

            return bCheck = false;
        }

        private void txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txt_Numero.Text.Contains(','))
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

        private void txt_Numero_Enter(object sender, EventArgs e)
        {
            string x = "";
            for (int i = 0; i <= txt_Numero.Text.Length - 1; i++)
            {
                if ((txt_Numero.Text[i] >= '0' &&
                    txt_Numero.Text[i] <= '9') ||
                    txt_Numero.Text[i] == ',')
                {
                    x += txt_Numero.Text[i];
                }
            }
            txt_Numero.Text = x;
            txt_Numero.SelectAll();
        }
    }
}

