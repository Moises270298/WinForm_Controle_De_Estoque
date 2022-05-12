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
    public partial class frmRelatorioCliente : Form
    {
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Dados_Do_Banco.TCC_CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.tCC_CLIENTETableAdapter.Fill(this.dataSet_Dados_Do_Banco.TCC_CLIENTE);

            this.reportViewer1.RefreshReport();
        }
    }
}
