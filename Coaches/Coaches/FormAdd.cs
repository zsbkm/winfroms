using Coaches.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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




        //REGEXEK és VALIDÁLÁSOK

        private bool CheckEmpty(string név)
        {
            return !string.IsNullOrEmpty(név);
        }
        private bool CheckEmail(string email)
        {
            Regex r = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w+$");
            return r.IsMatch(email);
        }

        /*
        private bool CheckDate(string date)
        {
            Regex r = new Regex(@"^\d{4}\.\d{2}\.\d{2}\.$");
            return r.IsMatch(date);
        } */

        private bool CheckDate(string date)
        {
            Regex r = new Regex(@"^\d{4}\.\s?\d{2}\.\s?\d{2}\.\s?$");
            return r.IsMatch(date);
        }

        private bool CheckPhoneNumber(string phoneNumber)
        {
            Regex r = new Regex(@"^\+36\d{9}$");
            return r.IsMatch(phoneNumber);
        }

        private bool CheckSport(string input)
        {
            Regex r = new Regex(@"^[\p{L};]+$");
            return r.IsMatch(input);
        }

        private bool CheckNapszak(string input)
        {
            Regex r = new Regex(@"^(de|du|egesznap)$");
            return r.IsMatch(input);
        }
        private bool CheckSzamla(string input)
        {
            Regex r = new Regex(@"^\d{8}-\d{4}-\d{4}$");
            return r.IsMatch(input);
        }

        private bool CheckAdo(string input)
        {
            Regex r = new Regex(@"^\d{10}$");
            return r.IsMatch(input);
        }




        //Nev
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "A név nem lehet üres!");
            }
            else { errorProvider1.SetError(textBox1, string.Empty); }
        }

        //Szulhely
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "A születési hely megadása kötelező!");
            }
            else { errorProvider1.SetError(textBox2, string.Empty); }

        }

        //Szulido
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox4.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox4, "A születési hely megadása kötelező!");
            }
            if (!CheckDate(textBox4.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox4, "A formátum nem megfelelő!");
            }

            else { errorProvider1.SetError(textBox4, string.Empty); }
        }

        //Telefon
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Telefonszám megadása kötelező!");
            }
            if (!CheckPhoneNumber(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "A formátum nem megfelelő");
            }

            else { errorProvider1.SetError(textBox3, string.Empty); }
        }

        //Facebookra nincs, nem biztos, hogy van az illetőnek

        //Sportok


        //Email
        private void textBox5_Validating(object sender, CancelEventArgs e)
        {

            if (!CheckEmpty(textBox5.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox5, "Az email cím megadása kötelező!");
            }
            if (!CheckEmail(textBox5.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox5, "Az email cím formátuma nem megfelelő!");
            }
            else { errorProvider1.SetError(textBox5, string.Empty); }

        }

        //Sportok
        private void textBox9_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox9.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox9, "Sport(ok) megadása kötelező!");
            }
            if (!CheckSport(textBox9.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox9, "A sport(ok) formátuma nem megfelelő!");
            }
            else { errorProvider1.SetError(textBox9, string.Empty); }
        }

        //Napszak
        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox10.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox10, "A napszak megadása kötelező!");
            }
            if (!CheckNapszak(textBox10.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox10, "A napszak nem megfelelő!");
            }
            else { errorProvider1.SetError(textBox10, string.Empty); }
        }

        //Oraber
        private void textBox12_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox12.Text))
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

        //DNN
        private void textBoxDNN_Validating(object sender, CancelEventArgs e)
        {

            if (!CheckEmpty(textBoxDNN.Text))
            {
                //e.Cancel = true;

                errorProvider1.SetError(textBoxDNN, "Az azonosító nem lehet üres");

            }
            else { errorProvider1.SetError(textBoxDNN, string.Empty); }
        }

        //Bszla
        private void textBox13_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox13.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox13, "Számlaszám megadása kötelező!");
            }
            if (!CheckSzamla(textBox13.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox13, "A számla formátuma nem megfelelő!");
            }
            else { errorProvider1.SetError(textBox13, string.Empty); }
        }

        //Ado
        private void textBox14_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox14.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox14, "Adójel megadása kötelező!");
            }
            if (!CheckAdo(textBox14.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox14, "Az adójel formátuma nem megfelelő!");
            }
            else { errorProvider1.SetError(textBox14, string.Empty); }
        }

        //Lakcim
        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox11.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox11, "Lakcím megadása kötelező!");
            }
            else { errorProvider1.SetError(textBox11, string.Empty); }
        }

        //Bio
        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmpty(textBox7.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox7, "Bio megadása kötelező!");
            }
            else { errorProvider1.SetError(textBox7, string.Empty); }
        }

        //Mentes
        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren() && string.IsNullOrWhiteSpace(textBoxDNN.Text) == false)
            {

                this.DialogResult = DialogResult.OK;
                ujEdzo.DnnAzonosito = int.Parse(textBoxDNN.Text);



            }

        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

        }

        private void buttonPic_Click(object sender, EventArgs e)
        {
            var maxID = (from x in _context.SzemelyiEdzok
                            select x.Id).Max() +1;

            try
            {
                // Hálózati útvonal a fájlkezelőhöz
                string networkPath = @"\\rendfejl1000.northeurope.cloudapp.azure.com\edzokepek";

                // Windows Fájlkezelő megnyitása
                Process.Start("explorer.exe", networkPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt a fájlkezelő megnyitásakor: {ex.Message}\nStackTrace: {ex.StackTrace}",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("A kép neve legyen: " + maxID + ".png");
        }
    }
}
