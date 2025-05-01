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

namespace Coaches
{
    public partial class FormAdd : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();

        public SzemelyiEdzok ujEdzo = new();
        int ell = 0;


        public FormAdd()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {


            bindingSource1.DataSource = ujEdzo;

            var maxDnnId = (from x in _context.SzemelyiEdzok
                            select x.DnnAzonosito).Max();


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

            if (formDNNUsers.ShowDialog() == DialogResult.OK)
            {
                textBoxDNN.Text = formDNNUsers.KivalasztottFelhasznalo.UserId.ToString();
                formDNNUsers.Close();
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
            else { errorProvider1.SetError(textBox5, string.Empty); }

        }

        private void textBoxDNN_Validating(object sender, CancelEventArgs e)
        {

            if (!CheckName(textBoxDNN.Text))
            {
                //e.Cancel = true;
                
                errorProvider1.SetError(textBoxDNN, "Az azonosító nem lehet üres");

            }
            else { errorProvider1.SetError(textBoxDNN, string.Empty);}
        }

        private void textBox12_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBox12.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox12, "Órabér megadása kötelező!");
            }
            else if (!decimal.TryParse(textBox12.Text, out decimal oraber) || oraber <= 0)
            {
                
                textBox12.Focus();
                errorProvider1.SetError(textBox12, "Az órabér pozitív szám legyen!");
            }
            else { errorProvider1.SetError(textBox12, string.Empty); }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren() && string.IsNullOrWhiteSpace(textBoxDNN.Text) == false)
            {

                this.DialogResult = DialogResult.OK;
                ujEdzo.DnnAzonosito = int.Parse(textBoxDNN.Text);



            }

        }

 
    }
}
