using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
    public partial class CtrAjuda : WinForm_Controle_De_Estoque.Formularios.Sistema.CtrHome
    {
        public CtrAjuda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"C:\Users\Thiago\Desktop\SISTEMA DO TCC\Manual.pdf");
        }
    }
}

