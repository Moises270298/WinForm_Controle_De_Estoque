using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class SplashScreen : Form
    {

        //SoundPlayer meuPlayer = new SoundPlayer(@"G:\ETEC\DS II\ZELDA.wav");
        public SplashScreen()
        {
            InitializeComponent();
            //meuPlayer.Play();
            EfectTime();
        }

        private bool Efect = true;
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if (Efect)
            {
                this.Opacity -= 0.03D;
            }

            if (this.Opacity == 0)
            {
                Efect = false;

                SplashTimer.Enabled = false;
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();                
                this.Hide();
            }
        }

        private void EfectTime()
        {
            SplashTimer.Interval = 200;
            SplashTimer.Tick += new EventHandler(SplashTimer_Tick);
            SplashTimer.Enabled = true;
            this.Opacity = 1;
        }

    }
}
