using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coaches
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox2.PasswordChar = '●';
            this.AcceptButton = button1;

            
        }
        

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "zsbkm" && textBox2.Text == "zsbkmjelszo")
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                

            }
            else
            {
                label5.Visible = true;
                label5.Text = ("Érvénytelen felhasználónév vagy jelszó!");
            }
        }
    }
}
