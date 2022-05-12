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
    public partial class frmMenuRelatorio : Form
    {
        public frmMenuRelatorio()
        {
            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocation;

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente cli = new frmRelatorioCliente();
            cli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto pro = new frmRelatorioProduto();
            pro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRelatorioVenda vend = new frmRelatorioVenda();
            vend.ShowDialog();
        }
    }
}
