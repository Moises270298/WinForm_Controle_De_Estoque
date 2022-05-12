using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Formularios.Cadastros;

namespace WinForm_Controle_De_Estoque.Formularios.Modelos
{
    public partial class CtrTelaBase : UserControl
    {
        public CtrTelaBase()
        {
            InitializeComponent();
            btn_cancelar.Enabled = false;
            btn_gravar.Enabled = false;
        }

        public int nCodGenerico;
        public DataTable dtGenerico = new DataTable();

        public enum StatusCadastro
        {
            scIncluindo,
            scConsultando,
            scAlterando
        }
        public StatusCadastro sStatus;
        private void LimpaControles()
        {
            foreach (Control ctr in this.panel1.Controls)
            {
                if (ctr is TextBox )
                {
                    (ctr as TextBox).Text = "";
                }

                if (ctr is MaskedTextBox)
                {
                    (ctr as MaskedTextBox).Text = "";
                }

                if (ctr is DateTimePicker)
                {
                    (ctr as DateTimePicker).Text = "";
                }

                if (ctr is ComboBox)
                {
                    (ctr as ComboBox).SelectedIndex = -1;
                }

                if (ctr is ListBox)
                {
                    (ctr as ListBox).SelectedIndex = -1;
                }

                if (ctr is RadioButton)
                {
                    (ctr as RadioButton).Checked = false;
                }

                if (ctr is CheckBox)
                {
                    (ctr as CheckBox).Checked = false;
                }
                if(ctr is NumericUpDown)
                {
                    (ctr as NumericUpDown).Value = 0;
                }
            }
        }

        private void HabilitaDesabilitaControles(bool bValue)
        {
            btn_incluir.Enabled = (sStatus == StatusCadastro.scConsultando);
            btn_gravar.Enabled = (sStatus == StatusCadastro.scIncluindo || sStatus == StatusCadastro.scAlterando);
            btn_excluir.Enabled = (sStatus == StatusCadastro.scConsultando);
            btn_editar.Enabled = (sStatus == StatusCadastro.scConsultando);
            btn_cancelar.Enabled = (sStatus == StatusCadastro.scAlterando || sStatus == StatusCadastro.scIncluindo);
            dtpDataCadastro.Enabled = (sStatus == StatusCadastro.scIncluindo || sStatus == StatusCadastro.scConsultando);
            txt_Pesquisa.Enabled = (sStatus == StatusCadastro.scConsultando);
            cmbColuna.Enabled = (sStatus == StatusCadastro.scConsultando);
        }

        public virtual void CarregaValores()
        {

        }
        public virtual void Atualiza_Grid()
        {

        }
        public virtual bool Salvar()
        {
            return false;
        }

        public virtual bool Alterar()
        {
            return false;
        }
        public virtual bool Excluir()
        {
            return false;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            LimpaControles();
            sStatus = StatusCadastro.scIncluindo;
            HabilitaDesabilitaControles(true);
            btn_editar.Enabled = false;
            panel1.BringToFront();
            LimpaControles();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scAlterando;
            try
            {
                if (dgvGrid.Rows.Count != 0)
                {
                    CarregaValores();
                    nCodGenerico = (int)dgvGrid.CurrentRow.Cells[0].Value;
                    panel1.BringToFront();
                    HabilitaDesabilitaControles(true);
                }

                else
                {
                    MessageBox.Show("Não há registros para alterar!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    sStatus = StatusCadastro.scConsultando;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro);
            }
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scConsultando;
            HabilitaDesabilitaControles(true);
            dgvGrid.BringToFront();
            btn_editar.Enabled = true;
        }

        private void dgvGrid_DoubleClick(object sender, EventArgs e)
        {
            CarregaValores();
            if (dgvGrid.Rows.Count != 0)
            {
                nCodGenerico = (int)dgvGrid.CurrentRow.Cells[0].Value;
            }

        }

        private void dgvGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvGrid.Rows.Count != 0)
                {
                    nCodGenerico = (int)dgvGrid.CurrentRow.Cells[0].Value;
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro: " + erro);
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (sStatus == StatusCadastro.scIncluindo)
            {
                if (Salvar())
                {
                    Atualiza_Grid();
                    if (sStatus == StatusCadastro.scIncluindo)
                    {
                        dataSetDadosDoBancoBindingSource.Position = dataSetDadosDoBancoBindingSource.Count - 1;
                        dgvGrid.BringToFront();
                    }
                    sStatus = StatusCadastro.scConsultando;
                    HabilitaDesabilitaControles(false);
                    MessageBox.Show("Registro salvo com sucesso", "Aviso do Sistema", MessageBoxButtons.OK);
                }
            }

            else if (sStatus == StatusCadastro.scAlterando)
            {
                if (Alterar())
                {
                    Atualiza_Grid();
                    if (sStatus == StatusCadastro.scAlterando)
                    {
                        dataSetDadosDoBancoBindingSource.Position = dataSetDadosDoBancoBindingSource.Count - 1;
                        sStatus = StatusCadastro.scConsultando;
                        HabilitaDesabilitaControles(false);
                        MessageBox.Show("Registro alterado com sucesso", "Aviso do Sistema", MessageBoxButtons.OK);
                        dgvGrid.BringToFront();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("O registro não foi alterado, por favor verifique os erros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                HabilitaDesabilitaControles(true);
            }


            else
            {
                MessageBox.Show("O registro não foi salvo/alterado, por favor verifique os erros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btn_editar.Enabled = true;
        }

        private void CtrTelaBase_load(object sender, EventArgs e)
        {
            sStatus = StatusCadastro.scConsultando;
            Atualiza_Grid();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma Exclusão?", "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (Excluir())
                {
                    sStatus = StatusCadastro.scConsultando;
                    MessageBox.Show("Registro excluído com sucesso", "Aviso do Sitema");
                    Atualiza_Grid();
                }

                else
                {
                    MessageBox.Show("O registro não foi excluído, por favor verifique os erros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}