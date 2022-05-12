using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;
using WinForm_Controle_De_Estoque.Formularios.Sistema;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class CtrCadOrcamentos : UserControl
    {
        public CtrCadOrcamentos()
        {
            InitializeComponent();
            dgv_orc.BringToFront();
        }

        int vld_VendaAtual, vSaldoAtual;
        double vValorTotalProduto, vTotalPedido, vValorUnitDigitado, vLargura, vComprimento, vQuantidadeDigitada;
        string vUsuario;

        private void CtrCadOrcamentos_Load(object sender, EventArgs e)
        {
            TCC_ITEM_TEMPTableAdapter ta = new TCC_ITEM_TEMPTableAdapter();
            this.tcC_CLIENTETableAdapter1.Fill(this.dataSet_Dados_Do_Banco.TCC_CLIENTE);
            this.tCC_ORCAMENTOTableAdapter.Fill(this.dataSet_Dados_Do_Banco.TCC_ORCAMENTO);
            vUsuario = Properties.Settings.Default.NomeUsuarioLogado.ToString();
            gbPedido.Enabled = false;
            gbItens.Enabled = false;
            btn_Gravar.Enabled = false;
            ta.DeletarTemp();
            grbPesquisaPedido.Visible = false;
        }
        private void CarregaGridItens()
        {
            TCC_ITEM_TEMPTableAdapter taItemTemp = new TCC_ITEM_TEMPTableAdapter();
            DataTable db;
            db = taItemTemp.Selecionar_Item_Temp();
            dgvItem.DataSource = db;
            this.tCC_ORCAMENTOTableAdapter.Fill(this.dataSet_Dados_Do_Banco.TCC_ORCAMENTO);
        }

        private void Limpa_Campos_Item()
        {
            txtCodigo.Text = "";
            txtDescricaoProduto.Text = "";
            txtValorUnit.Text = "";
            txtTotalProduto.Text = "";
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpa_Campos_Pedido();
            TCC_ITEM_TEMPTableAdapter taItem_Temp = new TCC_ITEM_TEMPTableAdapter();
            taItem_Temp.LimparItens(vUsuario, vld_VendaAtual);
            CarregaGridItens();
            TCC_ORCAMENTOTableAdapter taPedido = new TCC_ORCAMENTOTableAdapter();
            vld_VendaAtual = (int)taPedido.UltimoPedido() + 1;
            lblnumero.Text = "Nº " + vld_VendaAtual.ToString();
            gbPedido.Enabled = true;
            gbItens.Enabled = true;
            btn_Gravar.Enabled = true;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = false;
            cmbCliente.Focus();
        }
        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCodigo.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCodigo.Focus();
            txtComprimento.Focus();

        }
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            TCC_ITEM_TEMPTableAdapter taItemtemp = new TCC_ITEM_TEMPTableAdapter();
            int vCodigoProduto = (int)dgvItem.CurrentRow.Cells["Codigo"].Value;
            vValorTotalProduto = double.Parse(dgvItem.CurrentRow.Cells["Total_Item"].Value.ToString());
            vld_VendaAtual = int.Parse(lblNumeroPedido.Text);

            taItemtemp.Delete(vld_VendaAtual, vCodigoProduto, vUsuario);
            CarregaGridItens();

            if (vTotalPedido <= 0)
            {
                txtTotalDoPedido.Text = "0";
            }
            else
            {
                vTotalPedido = vTotalPedido - vValorTotalProduto;
                txtTotalDoPedido.Text = vTotalPedido.ToString("R$ ###,##0.00");
            }
            if (dgvItem.RowCount == 0)
            {
                txtTotalDoPedido.Text = vTotalPedido.ToString("R$ ###,##0.00");
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedIndex == -1)
                {
                    ErrErro.SetError(cmbCliente, "Selecione um Cliente");
                    return;
                }
                else
                {
                    ErrErro.SetError(cmbCliente, "");
                }
                //Gravar Pedido 
                string data = DateTime.Now.ToShortTimeString();
                TCC_ORCAMENTOTableAdapter taPedido = new TCC_ORCAMENTOTableAdapter();
                DateTime d = dtpDataVenda.Value;
                decimal v = Convert.ToDecimal(vTotalPedido.ToString());
                int c = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                if (chk_status.Checked)
                {
                    taPedido.Insert(c, d, v, "Ativo", txtObservacao.Text);
                }

                else
                {
                    taPedido.Insert(c, d, v, "Cancelado", txtObservacao.Text);
                }

                vld_VendaAtual = (int)taPedido.UltimoPedido();

                //-------------------------------------------------------------

                //Gravando os itens
                TCC_ITEMTableAdapter taItem = new TCC_ITEMTableAdapter();
                TCC_PRODUTOTableAdapter taProduto = new TCC_PRODUTOTableAdapter();
                int vCodigoProduto, vQtdVendida;
                decimal vValorUnit;

                for (int i = 0; i <= dgvItem.RowCount - 1; i++)
                {
                    vCodigoProduto = (int)dgvItem.Rows[i].Cells["Codigo"].Value;
                    vLargura = Convert.ToDouble(dgvItem.Rows[i].Cells["Largura"].Value);
                    vComprimento = Convert.ToDouble(dgvItem.Rows[i].Cells["Comprimento"].Value);
                    vValorUnit = (decimal)dgvItem.Rows[i].Cells["Valor_Unit"].Value;
                    vQtdVendida = int.Parse((vLargura * vComprimento).ToString());

                    taItem.Insert(vld_VendaAtual, vCodigoProduto, decimal.Parse(vLargura.ToString()), decimal.Parse(vComprimento.ToString()), vValorUnit);
                    taProduto.Acerta_Saldo_Saida(vCodigoProduto, vQtdVendida);
                }



                MessageBox.Show("Venda gravada com Sucesso");
                Limpa_Campos_Pedido();
                //Limpa os tiens da tabela temporária
                TCC_ITEM_TEMPTableAdapter taItem_Temp = new TCC_ITEM_TEMPTableAdapter();
                taItem_Temp.LimparItens(vUsuario, vld_VendaAtual);
                CarregaGridItens();
                //desabilita controles
                gbPedido.Enabled = false;
                gbItens.Enabled = false;
                btn_Gravar.Enabled = false;
                btnNovo.Enabled = true;
                dgv_orc.BringToFront();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu Erro" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpa_Campos_Pedido()
        {
            lblnumero.Text = "";
            cmbCliente.SelectedIndex = -1;
            txtObservacao.Text = "";
            txtTotalDoPedido.Text = "";
            txtNumPedidoPesq.Text = "";
            lblnumero.Text = "";
            Limpa_Campos_Item();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgv_orc.BringToFront();
            Limpa_Campos_Pedido();
            gbPedido.Enabled = false;
            gbItens.Enabled = false;
            btn_Gravar.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;

            TCC_ITEM_TEMPTableAdapter taItem_Temp = new TCC_ITEM_TEMPTableAdapter();
            taItem_Temp.LimparItens(vUsuario, vld_VendaAtual);
        }

        private void txtNumPedidoPesq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnLocalizarPedido_Click(object sender, EventArgs e)
        {
            TCC_ORCAMENTOTableAdapter taPedido = new TCC_ORCAMENTOTableAdapter();
            Dados.dataSet_Dados_Do_Banco.TCC_ORCAMENTODataTable dt = new Dados.dataSet_Dados_Do_Banco.TCC_ORCAMENTODataTable();
            dt = taPedido.ProcuraPedido(int.Parse(txtNumPedidoPesq.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Pedido Inexistente");
                txtNumPedidoPesq.Focus();
                txtNumPedidoPesq.SelectAll();
            }

            else
            {
                lblnumero.Text = dt.Rows[0]["orc_Id"].ToString();
                cmbCliente.SelectedValue = dt.Rows[0]["cli_Id"];
                dtpDataVenda.Value = DateTime.Parse(dt.Rows[0]["ped_DtEncomenda"].ToString());
                vTotalPedido = Convert.ToDouble(dt.Rows[0]["ped_Valor"].ToString());
                txtObservacao.Text = dt.Rows[0]["ped_Observacao"].ToString();
                txtTotalDoPedido.Text = vTotalPedido.ToString("C");
                if (dt.Rows[0]["ped_Status"].ToString() == "C")
                {
                    lblStatus.Text = "Cancelado";
                }

            }

            TCC_ITEMTableAdapter taItem = new TCC_ITEMTableAdapter();
            Dados.dataSet_Dados_Do_Banco.TCC_ITEMDataTable dtItem = new Dados.dataSet_Dados_Do_Banco.TCC_ITEMDataTable();
            dtItem = taItem.Pesquisa_Itens_Pedido(int.Parse(txtNumPedidoPesq.Text));
            dgvItem.DataSource = dtItem;

            dgvItem.Columns["Codigo"].DisplayIndex = 0;
            dgvItem.Columns["Descricao"].DisplayIndex = 1;
            dgvItem.Columns["Largura"].DisplayIndex = 2;
            dgvItem.Columns["Comprimento"].DisplayIndex = 2;
            dgvItem.Columns["Valor_Unit"].DisplayIndex = 3;
            dgvItem.Columns["Total_Item"].DisplayIndex = 4;
        }

        private void btnAdicionarItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalProduto.Text == "")
                {
                    MessageBox.Show("Escolha um produto!");
                }
                else
                {
                    //Grava item na table temporária
                    TCC_ITEM_TEMPTableAdapter taItemTemp = new TCC_ITEM_TEMPTableAdapter();
                    taItemTemp.Insert(vld_VendaAtual, int.Parse(txtCodigo.Text), txtDescricaoProduto.Text, decimal.Parse(txtLargura.Text), decimal.Parse(txtComprimento.Text), decimal.Parse(txtValorUnit.Text), vUsuario);
                    //------------------------------------------------------------------
                    vTotalPedido = vTotalPedido + vValorTotalProduto;
                    txtTotalDoPedido.Text = (vTotalPedido).ToString("C");
                    Limpa_Campos_Item();
                    CarregaGridItens();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Deu Erro" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
        }


        private void txtMedidas_TextCanged(object sender, EventArgs e)
        {
            try
            {
                if (txtComprimento.Text == "")
                {
                    txtComprimento.Text = "1";

                    if (txtLargura.Text != "")
                    {
                        vQuantidadeDigitada = Convert.ToDouble(txtComprimento.Text) * Convert.ToDouble(txtLargura.Text);
                    }

                    else
                    {
                        return;
                    }
                }

                else if (txtLargura.Text == "")
                {
                    txtLargura.Text = "1";

                    if (txtComprimento.Text != "")
                    {
                        vQuantidadeDigitada = Convert.ToDouble(txtComprimento.Text) * Convert.ToDouble(txtLargura.Text);
                    }

                    else
                    {
                        return;
                    }
                }

                else if (vQuantidadeDigitada > vSaldoAtual)
                {
                    MessageBox.Show("Saldo insuficiente, só existem " + vSaldoAtual.ToString() + " disponivel");
                    txtComprimento.Focus();
                    txtComprimento.SelectAll();//Seleciona todo o texto da textbox
                }
                else if (txtComprimento.Text != "" && txtLargura.Text != "")
                {
                    vQuantidadeDigitada = Convert.ToDouble(txtComprimento.Text) * Convert.ToDouble(txtLargura.Text);
                    vValorUnitDigitado = Convert.ToDouble(txtValorUnit.Text);
                    vValorTotalProduto = vQuantidadeDigitada * vValorUnitDigitado;
                    txtTotalProduto.Text = (vValorTotalProduto).ToString("###,##0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu Erro" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            string vfiltro = cmbColuna.Text;

            switch (vfiltro)
            {
                case "Código/Id":
                    vfiltro = "orc_Id";
                    break;
                case "Valor":
                    vfiltro = "ped_Valor";
                    break;
                case "Status":
                    vfiltro = "ped_Status";
                    break;
                case "Observação":
                    vfiltro = "ped_Observacao";
                    break;
                default:
                    break;
            }
            try
            {
                if (txt_Pesquisa.Text == "")
                {
                    tCCORCAMENTOBindingSource.Filter = "";
                }

                else if (cmbColuna.Text == "")
                {
                    tCCORCAMENTOBindingSource.Filter = "";
                }

                else if (vfiltro == "orc_Id" || vfiltro == "ped_Valor")
                {
                    tCCORCAMENTOBindingSource.RemoveFilter();
                    tCCORCAMENTOBindingSource.Filter = vfiltro + " = " + txt_Pesquisa.Text;
                }

                else
                {
                    tCCORCAMENTOBindingSource.RemoveFilter();
                    tCCORCAMENTOBindingSource.Filter = vfiltro + " like '" + txt_Pesquisa.Text + "%'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira os Parâmetros Corretos de Acordo com o Filtro!  ", "Erro!", MessageBoxButtons.OK);
            }
        }

        private void txtValorUnit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValorUnit.Text == "")
                {
                    return;
                }

                else
                {
                    txtValorUnit.Text = Convert.ToDouble(txtValorUnit.Text).ToString("F");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex, "Erro!", MessageBoxButtons.OK);
            }
        }
        private void btn_incluir_Click(object sender, EventArgs e)
        {
            panel_orc.BringToFront();
            txt_Pesquisa.Text = "";
            cmbColuna.SelectedIndex = -1;
            btnNovo.Focus();

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if(dgv_orc.Rows.Count != 0)
            {
                txt_Pesquisa.Text = "";
                cmbColuna.SelectedIndex = -1;
                txtNumPedidoPesq.Text = dgv_orc.CurrentRow.Cells["orc_Id"].Value.ToString();
                btnLocalizarPedido_Click(sender, e);
                panel_orc.BringToFront();
            }

            else
            {
                MessageBox.Show("Não há registros!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CtrCadOrcamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtCodigo_Leave(object sende, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                TCC_PRODUTOTableAdapter taProduto = new TCC_PRODUTOTableAdapter();
                Dados.dataSet_Dados_Do_Banco.TCC_PRODUTODataTable dtProduto = new Dados.dataSet_Dados_Do_Banco.TCC_PRODUTODataTable();
                dtProduto = taProduto.Procura_Produto(int.Parse(txtCodigo.Text));

                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Código Não cadastrado");
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                }

                else
                {
                    txtDescricaoProduto.Text = dtProduto.Rows[0]["pro_Descricao"].ToString();
                    txtValorUnit.Text = dtProduto.Rows[0]["pro_Valor"].ToString();
                    vSaldoAtual = (int)dtProduto.Rows[0]["pro_QtdeEstoque"];
                    txtComprimento.Focus();
                }
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (grbPesquisaPedido.Visible == true)
            {
                grbPesquisaPedido.Visible = false;
            }

            else
            {
                grbPesquisaPedido.Visible = true;
                txtNumPedidoPesq.Focus();
            }
            //btnCancelar_Click(sender, e);
            CarregaGridItens();
        }

    }
}
