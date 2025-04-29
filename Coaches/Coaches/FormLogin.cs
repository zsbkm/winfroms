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
            textBox2.PasswordChar = '●';


            int xPosition = (this.ClientSize.Width - label3.Width) / 2;

            // A Label3 pozíciójának beállítása (az Y koordináta változatlan marad)
            label3.Location = new Point(xPosition, label3.Location.Y);
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
        }
    }
}
