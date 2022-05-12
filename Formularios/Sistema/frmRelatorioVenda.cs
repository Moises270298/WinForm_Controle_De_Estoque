using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class frmRelatorioVenda : Form
    {
        public frmRelatorioVenda()
        {
            InitializeComponent();
        }

        private void frmRelatorioVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Dados_Do_Banco.TCC_ORCAMENTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tCC_ORCAMENTOTableAdapter.Fill(this.dataSet_Dados_Do_Banco.TCC_ORCAMENTO);

            this.reportViewer1.RefreshReport();
        }
    }
}
