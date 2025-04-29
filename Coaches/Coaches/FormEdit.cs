using Coaches.Models;
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
    public partial class FormEdit : Form
    {
        public SzemelyiEdzok szemelyiEdzok;
        public FormEdit()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = szemelyiEdzok;
            szemelyiEdzok.Aktiv = true;

            //this.BackColor = ColorTranslator.FromHtml("#bbd5bc");


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                szemelyiEdzok.Aktiv = true;
            }
            if (checkBox1.Checked == false)
            {
                szemelyiEdzok.Aktiv = false;
            }
        }
    }
}
