using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DRE: "+this.dreBox.Text+ "\n Senha: " + this.pwsdBox.Text);
        }

        private void singupButton_Click_1(object sender, EventArgs e)
        {
            CadastroForm cadForm = new CadastroForm();
            cadForm.Show();
            Hide();
        }
    }
}
