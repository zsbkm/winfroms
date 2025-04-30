using Coaches.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        //REGEXEK
        private bool CheckName(string név)
        {
            return !string.IsNullOrEmpty(név);
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "A név nem lehet üres");
            }
            else { errorProvider1.SetError(textBox1, string.Empty); }
        }

        private bool CheckEmail(string email)
        {
            Regex r = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
            return r.IsMatch(email);
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox5.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox5, "Az email cím megadása kötelező");
            }
            if (!CheckEmail(textBox5.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox5, "Az email cím formátuma nem megfelelő");
            }
            else { errorProvider1.SetError(textBox1, string.Empty); }
        }

        private void textBox12_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox12.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox12, "Órabér megadása kötelező!");
            }
            else { errorProvider1.SetError(textBox12, string.Empty); }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
