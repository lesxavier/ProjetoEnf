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
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Close();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void CadastroForm_Load(object sender, EventArgs e)
        {

        }

        private void CadastroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.Equals((sender as Button).Name, @"CloseButton"))
                Application.Exit();
        }
    }
}
