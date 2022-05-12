using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Relatorios
{
    public partial class frmVisualizaRelatorioCliente : Form
    {
        public frmVisualizaRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmVisualizaRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Dados_Do_Banco1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.dataSet_Dados_Do_Banco1.Cliente);

            this.rp_clientes.RefreshReport();
        }
    }
}
