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
    public partial class FormBerszamfejtes : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();
        public FormBerszamfejtes()
        {
            InitializeComponent();

            


            var honapok = _context.Foglalasok
            .Where(f => f.Idopont != null)
            .Select(f => new { f.Idopont.Value.Year, f.Idopont.Value.Month })
            .AsEnumerable()
            .Select(x => $"{x.Year}-{x.Month:D2}")
            .Distinct()
            .OrderBy(h => h)
            .ToList();

            //comboBoxHonap.Items.Add("Összes"); // Opcionális: összes adat megjelenítése
            comboBoxHonap.Items.AddRange(honapok.ToArray());
            comboBoxHonap.SelectedIndex = 0;

            LoadData(null);


            /*
            var query = (from f in _context.Foglalasok
                         join e in _context.SzemelyiEdzok on f.SzemelyiEdzoId equals e.Id
                         where f.Idopont != null
                         group f by new { e.Id, e.Nev, e.Oraber } into g
                         select new
                         {
                             Id = g.Key.Id,
                             Edző = g.Key.Nev,
                             Órabér = g.Key.Oraber + " Ft",
                             Foglalások = g.Count(),
                             Összesen = g.Count() * g.Key.Oraber + " Ft"
                         }).ToList();


            dataGridView1.DataSource = query; */
        }

        private void FormBerszamfejtes_Load(object sender, EventArgs e)
        {

        }


        private void LoadData(string honapFilter)
        {
            try
            {
                // Alap lekérdezés
                var query = from f in _context.Foglalasok
                            join e in _context.SzemelyiEdzok on f.SzemelyiEdzoId equals e.Id
                            where f.Idopont != null // Csak nem null Idopont értékek
                            select new { f, e };

                // Szűrés a hónapra, ha van kiválasztva
                if (honapFilter != null && honapFilter != "Összes")
                {
                    var parts = honapFilter.Split('-');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int year) && int.TryParse(parts[1], out int month))
                    {
                        query = query.Where(x => x.f.Idopont.Value.Year == year && x.f.Idopont.Value.Month == month);
                    }
                    else
                    {
                        // Ha a honapFilter formátuma hibás, üres eredményt adunk
                        dataGridView1.DataSource = new List<object>();
                        return;
                    }
                }

                // Csoportosítás és végső eredmény
                var result = query
                    .GroupBy(x => new { x.e.Id, x.e.Nev, x.e.Oraber })
                    .Select(g => new
                    {
                        Id = g.Key.Id,
                        Edző = g.Key.Nev,
                        Órabér = g.Key.Oraber + " Ft",
                        Foglalások = g.Count(),
                        Összesen = g.Count() * g.Key.Oraber + " Ft"
                    })
                    .ToList();

                dataGridView1.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}\nStackTrace: {ex.StackTrace}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxHonap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHonap = comboBoxHonap.SelectedItem?.ToString();
            LoadData(selectedHonap);
        }
    }
}
