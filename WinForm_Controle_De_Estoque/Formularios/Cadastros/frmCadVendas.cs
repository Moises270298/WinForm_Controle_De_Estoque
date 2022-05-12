using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros

{
    public partial class frmCadVendas : Form
    {
        public frmCadVendas()
        {
            InitializeComponent();
        }
        int vld_VendaAtual, vQuantidadeDigitada, vSaldoAtual;
        double vValorTotalProduto, vTotalPedido, vValorUnitDigitado;
        string vUsuario;

        private void frmCadVendas_Load(object sender, EventArgs e)
        {
            Item_TempTableAdapter ta = new Item_TempTableAdapter();
            this.clienteTableAdapter.Fill(this.dataSet_Dados_Do_Banco.Cliente);
            vUsuario = Properties.Settings.Default.NomeUsuarioLogado.ToString();
            gbPedido.Enabled = false;
            gbItens.Enabled = false;
            btn_Gravar.Enabled = false;
            btnCancelar.Visible = false;
            ta.DeletarTemp();
            grbPesquisaPedido.Visible = false;
        }
        private void CarregaGridItens()
        {
            Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
            //dgvItem.DataSource = taItemTemp.ItensPedido();
            DataTable db;
            db = taItemTemp.Selecionar_Item_Temp();
            dgvItem.DataSource = db;
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
            btnCancelar_Click(sender, e);
            CarregaGridItens();
            PedidoTableAdapter taPedido = new PedidoTableAdapter();
            vld_VendaAtual = (int)taPedido.UltimoPedido() + 1;
            txtNumeroPedido.Text = vld_VendaAtual.ToString();
            gbPedido.Enabled = true;
            gbItens.Enabled = true;
            btn_Gravar.Enabled = true;
            btnNovo.Enabled = true;
            btnCancelar.Visible = true;
            btnPesquisar.Enabled = false;
            cmbCliente.Focus();
        }
        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCodigo.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCodigo.Focus();
            txtQtd.Focus();

        }
        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            Item_TempTableAdapter taItemtemp = new Item_TempTableAdapter();
            int vCodigoProduto = (int)dgvItem.CurrentRow.Cells["Codigo"].Value;
            vValorTotalProduto = double.Parse(dgvItem.CurrentRow.Cells["Total_Item"].Value.ToString());
            vld_VendaAtual = int.Parse(txtNumeroPedido.Text);

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
                PedidoTableAdapter taPedido = new PedidoTableAdapter();
                DateTime d = dtpDataVenda.Value;
                decimal v = Convert.ToDecimal(vTotalPedido.ToString());
                int c = Convert.ToInt32(cmbCliente.SelectedValue.ToString());
                taPedido.Insert(c, d, v, "V", txtObservacao.Text);
                vld_VendaAtual = (int)taPedido.UltimoPedido();

                //-------------------------------------------------------------

                //Gravando os itens
                ItemTableAdapter taItem = new ItemTableAdapter();
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                int vCodigoProduto, vQtdVendida;
                decimal vValorUnit;

                    for (int i = 0; i <= dgvItem.RowCount - 1; i++)
                    {
                        vCodigoProduto = (int)dgvItem.Rows[i].Cells["Codigo"].Value;
                        vQtdVendida = (int)dgvItem.Rows[i].Cells["Quantidade"].Value;
                        vValorUnit = (decimal)dgvItem.Rows[i].Cells["Valor_Unit"].Value;

                        taItem.Insert(vld_VendaAtual, vCodigoProduto, vQtdVendida, vValorUnit);
                        taProduto.Acerta_Saldo_Saida(vCodigoProduto, vQtdVendida);
                    }
                

                
                MessageBox.Show("Venda gravada com Sucesso");
                Limpa_Campos_Pedido();
                //Limpa os tiens da tabela temporária
                Item_TempTableAdapter taItem_Temp = new Item_TempTableAdapter();
                taItem_Temp.LimpaItens(vld_VendaAtual, vUsuario);
                CarregaGridItens();
                //desabilita controles
                gbPedido.Enabled = false;
                gbItens.Enabled = false;
                btn_Gravar.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu Erro" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpa_Campos_Pedido()
        {
            lblNumeroPedido.Text = "";
            cmbCliente.SelectedIndex = -1;
            txtObservacao.Text = "";
            txtTotalDoPedido.Text = "";
            txtNumPedidoPesq.Text = "";
            lblNumeroPedido.Text = "";
            Limpa_Campos_Item();
        }

        private void txtValorUnit_Leave(object sender, EventArgs e)
        {
            vValorUnitDigitado = Convert.ToDouble(txtValorUnit.Text);
            vValorTotalProduto = vQuantidadeDigitada * vValorUnitDigitado;
            txtTotalProduto.Text = (vValorTotalProduto).ToString("###,##0.00");
            btnAdicionarItem.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpa_Campos_Pedido();
            gbPedido.Enabled = false;
            gbItens.Enabled = false;
            btn_Gravar.Enabled = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;

            Item_TempTableAdapter taItem_Temp = new Item_TempTableAdapter();
            taItem_Temp.LimpaItens(vld_VendaAtual, vUsuario);
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
            PedidoTableAdapter taPedido = new PedidoTableAdapter();
            Dados.dataSet_Dados_Do_Banco.PedidoDataTable dt = new Dados.dataSet_Dados_Do_Banco.PedidoDataTable();
            dt = taPedido.ProcuraPedido(int.Parse(txtNumPedidoPesq.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Pedido Inexistente");
                txtNumPedidoPesq.Focus();
                txtNumPedidoPesq.SelectAll();
            }

            else
            {
                txtNumeroPedido.Text = dt.Rows[0]["ped_Id"].ToString();
                cmbCliente.SelectedValue = dt.Rows[0]["cli_Id"];
                dtpDataVenda.Value = DateTime.Parse(dt.Rows[0]["ped_DtEncomenda"].ToString());
                txtTotalDoPedido.Text = String.Format(dt.Rows[0]["ped_Valor"].ToString(), "###,##0.00");
                txtObservacao.Text = dt.Rows[0]["ped_Observacao"].ToString();
                if (dt.Rows[0]["ped_Status"].ToString() == "C")
                {
                    lblStatus.Text = "Cancelado";
                }

            }

            ItemTableAdapter taItem = new ItemTableAdapter();
            Dados.dataSet_Dados_Do_Banco.ItemDataTable dtItem = new Dados.dataSet_Dados_Do_Banco.ItemDataTable();
            dtItem = taItem.Pesquisa_Itens_Pedido(int.Parse(txtNumPedidoPesq.Text));
            dgvItem.DataSource = dtItem;

            dgvItem.Columns["Codigo"].DisplayIndex = 0;
            dgvItem.Columns["Descricao"].DisplayIndex = 1;
            dgvItem.Columns["Quantidade"].DisplayIndex = 2;
            dgvItem.Columns["Valor_Unit"].DisplayIndex = 3;
            dgvItem.Columns["Total_Item"].DisplayIndex = 4;
        }

        private void btnAdicionarItem_Click_1(object sender, EventArgs e)
        {
            if (txtTotalProduto.Text == "")
            {
                MessageBox.Show("Escolha um produto!");
            }
            else
            {
                //Grava item na table temporária
                Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
                taItemTemp.Insert(vld_VendaAtual, int.Parse(txtCodigo.Text), txtDescricaoProduto.Text, int.Parse(txtQtd.Text), decimal.Parse(txtValorUnit.Text), vUsuario);
                //------------------------------------------------------------------
                vTotalPedido = vTotalPedido + vValorTotalProduto;
                txtTotalDoPedido.Text = (vTotalPedido).ToString("R$ ###,##0.00");
                Limpa_Campos_Item();
                CarregaGridItens();
            }

            /* //Grava item na tabela temporária
             Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
             taItemTemp.Insert(vld_VendaAtual, int.Parse(txtCodigo.Text), txtNumeroPedido.Text,
                 int.Parse(txtQtd.Text), decimal.Parse(txtValorUnit.Text), vUsuario);

             Limpa_Campos_Item();
             CarregaGridItens();//Carrega o grid com os dados atualizados
             vTotalPedido = vTotalPedido = vValorTotalProduto;
             txtTotalDoPedido.Text = (vTotalPedido).ToString("###,##0.00");*/
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQtd.Text == "")
                {
                    txtQtd.Text = "1";
                    vQuantidadeDigitada = Convert.ToInt16(txtQtd.Text);
                }
                if (vQuantidadeDigitada > vSaldoAtual)
                {
                    MessageBox.Show("Saldo insuficiente, só existem " + vSaldoAtual.ToString() + " disponivel");
                    txtQtd.Focus();
                    txtQtd.SelectAll();//Seleciona todo o texto da textbox
                }
                if (txtQtd.Text != "")
                {
                    vQuantidadeDigitada = Convert.ToInt32(txtQtd.Text);
                    vValorUnitDigitado = Convert.ToDouble(txtValorUnit.Text);
                    vValorTotalProduto = vQuantidadeDigitada * vValorUnitDigitado;
                    txtTotalProduto.Text = vValorTotalProduto.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu Erro" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_Leave(object sende, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                Dados.dataSet_Dados_Do_Banco.ProdutoDataTable dtProduto = new Dados.dataSet_Dados_Do_Banco.ProdutoDataTable();
                dtProduto = taProduto.Procura_Produto(int.Parse(txtCodigo.Text));

                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Código Não cadastrado");
                    txtCodigo.Focus();
                }

                else
                {
                    //Dados.dataSet_Dados_Do_Banco.ProdutoDataTable dtProduto = new Dados.dataSet_Dados_Do_Banco.ProdutoDataTable();
                    txtDescricaoProduto.Text = dtProduto.Rows[0]["pro_Descricao"].ToString();
                    txtValorUnit.Text = dtProduto.Rows[0]["pro_Valor"].ToString();
                    vSaldoAtual = (int)dtProduto.Rows[0]["pro_QtdeEstoque"];
                    txtQtd.Focus();
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
            btnCancelar_Click(sender, e);
            CarregaGridItens();
        }

        private void frmCadVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}