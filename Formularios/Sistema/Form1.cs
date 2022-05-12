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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick_1(object sender, EventArgs e)
        {
            SplashTimer.Start();
            progressBar1.Increment(5);
            if (progressBar1.Value == 100)
            {
                SplashTimer.Stop();
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
    }
}
