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
    public partial class FormAdd : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();

        public SzemelyiEdzok ujEdzo = new();
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

            bindingSource1.DataSource = ujEdzo;

            var maxDnnId = (from x in _context.SzemelyiEdzok
                            select x.DnnAzonosito).Max();

            ujEdzo.DnnAzonosito = maxDnnId + 1;
            ujEdzo.Aktiv = true;

            //this.BackColor = ColorTranslator.FromHtml("#bbd5bc");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ujEdzo.Aktiv = true;
            }
            if (checkBox1.Checked == false)
            {
                ujEdzo.Aktiv = false;
            }

        }

        private void buttonDNN_Click(object sender, EventArgs e)
        {
            FormDNNUsers formDNNUsers = new FormDNNUsers();
            
            if(formDNNUsers.ShowDialog() == DialogResult.OK)
            {
                formDNNUsers.Close();
            }
        }
    }
}
