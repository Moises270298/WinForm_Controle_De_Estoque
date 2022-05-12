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
    public partial class frmVisualizaRelatorioCategoria : Form
    {
        public frmVisualizaRelatorioCategoria()
        {
            InitializeComponent();
        }

        private void frmVisualizaRelatorioCategoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Dados_Do_Banco.Categoria' table. You can move, or remove it, as needed.
            this.categoriaTableAdapter.Fill(this.dataSet_Dados_Do_Banco.Categoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
