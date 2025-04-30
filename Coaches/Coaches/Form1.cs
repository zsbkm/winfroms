using Coaches.Models;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Coaches
{
    public partial class Form1 : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();

        public Form1()
        {
            InitializeComponent();
            szemelyiEdzokBindingSource.DataSource = _context.SzemelyiEdzok.ToList();
            //label1.Text = "Edzõk szûrése:";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Id");
            comboBox1.Items.Add("Nev");
            comboBox1.Items.Add("Szulhely");
            comboBox1.Items.Add("Szulido");
            comboBox1.Items.Add("Sportok");
            comboBox1.Items.Add("Napszak");
            comboBox1.Items.Add("Aktiv");
            comboBox1.Items.Add("Oraber");

            comboBox1.SelectedIndex = 0;

            //buttonDelete.BackColor = ColorTranslator.FromHtml("#ffc9bd");
            //this.BackColor = ColorTranslator.FromHtml("#bbd5bc"); 

        }

        private void EdzokBetoltese()
        {
            var szuro = comboBox1.Text;

            var query = _context.SzemelyiEdzok
                .Where(x => x.Nev.ToLower().Contains(textBoxEdzoSzuro.Text.ToLower()));

            switch (szuro)
            {
                case "Id":
                    query = query.OrderBy(x => x.Id);
                    break;
                case "Nev":
                    query = query.OrderBy(x => x.Nev);
                    break;
                case "Szulhely":
                    query = query.OrderBy(x => x.SzulHely);
                    break;
                case "Szulido":
                    query = query.OrderBy(x => x.Nev);
                    break;
                case "Sportok":
                    query = query.OrderBy(x => x.Sportok);
                    break;
                case "Napszak":
                    query = query.OrderBy(x => x.Napszak);
                    break;
                case "Aktiv":
                    query = query.OrderBy(x => x.Aktiv);
                    break;
                case "Oraber":
                    query = query.OrderBy(x => x.Oraber);
                    break;
                default:
                    query = query.OrderBy(x => x.Nev); // Fallback
                    break;
            }

            szemelyiEdzokBindingSource.DataSource = query.ToList();



        }



        private void textBoxEdzoSzuro_TextChanged(object sender, EventArgs e)
        {
            EdzokBetoltese();
        }
        private void Mentes()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddNewCoach_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                       $"Elõször regisztrálni kell az edzõt a weboldalon, ezt megtette már?",
                       "Érvénytelen mûvelet",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                this.Hide();
                FormAdd fan = new FormAdd();
                if (fan.ShowDialog() == DialogResult.OK)
                {

                    _context.SzemelyiEdzok.Add(fan.ujEdzo);
                    Mentes();
                    EdzokBetoltese();
                }
            }
            if (confirmResult == DialogResult.No)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "http://rendfejl1000.northeurope.cloudapp.azure.com:8080/Regisztracio?returnurl=http%3a%2f%2frendfejl1000.northeurope.cloudapp.azure.com%3a8080%2f",
                    UseShellExecute = true
                });
            }



            this.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdit formEdit = new FormEdit();
            if (szemelyiEdzokBindingSource.Current == null)
            {
                MessageBox.Show("Nincs kiválasztv sor");
            }
            formEdit.szemelyiEdzok = szemelyiEdzokBindingSource.Current as SzemelyiEdzok;
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                Mentes();
            }
            EdzokBetoltese();

            this.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var kivalasztott = szemelyiEdzokBindingSource.Current as SzemelyiEdzok;

            if (kivalasztott != null)
            {
                bool szerepel = _context.Foglalasok.Any(f => f.SzemelyiEdzoId == kivalasztott.Id);

                if (szerepel)
                {
                    var confirmResult = MessageBox.Show(
                       $"{kivalasztott.Nev} nem törölhetõ, mert már szerepel a Foglalások táblában!\nEl szeretnéd rejteni a weboldalról?",
                       "Érvénytelen mûvelet",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        kivalasztott.Aktiv = false;
                    }


                }
                else
                {
                    if (kivalasztott == null)
                    {
                        MessageBox.Show("Ninc kiválasztva sor");
                    }

                    var confirmResult = MessageBox.Show(
                        $"Biztosan törölni szeretnéd {kivalasztott.Nev} rekordját?",
                        "Megerõsítés",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        var del = (from x in _context.SzemelyiEdzok
                                   where x.Id == kivalasztott.Id
                                   select x).FirstOrDefault();

                        if (del != null)
                        {
                            _context.Remove(del);
                            Mentes();
                            EdzokBetoltese();
                        }
                    }
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EdzokBetoltese();
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            this.Close();
           Application.Exit();  
        }

        private void buttonBerszamfejtes_Click(object sender, EventArgs e)
        {
            FormBerszamfejtes bsz = new();
            if(bsz.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
