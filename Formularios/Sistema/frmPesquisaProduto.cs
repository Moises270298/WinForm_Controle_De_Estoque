using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados.dataSet_Dados_Do_BancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class frmPesquisaProduto : Form
    {
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

            private int _CodigoRetorno;

            public int CodigoRetorno
            {
                get { return _CodigoRetorno; }
                set { _CodigoRetorno = value; }
            }

            private void frmPesquisaProduto_Load(object sender, EventArgs e)
            {
                this.tcC_PRODUTOTableAdapter1.Fill(this.dataSet_Dados_Do_Banco.TCC_PRODUTO);
            }

            private void txtProduto_TextChanged(object sender, EventArgs e)
            {
                if (txtProduto.Text == "")
                {
                    tCCPRODUTOBindingSource.Filter = "";
                }

                else
                {
                tCCPRODUTOBindingSource.Filter = "pro_Descricao like '" + txtProduto.Text + "%'";
                }
            }

            private void lstProduto_DoubleClick(object sender, EventArgs e)
            {
                _CodigoRetorno = (int)lstProduto.SelectedValue;
                Close();
            }
        }
    }
