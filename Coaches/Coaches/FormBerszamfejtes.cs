using Coaches.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = OfficeOpenXml;


namespace Coaches
{
    public partial class FormBerszamfejtes : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();
        public FormBerszamfejtes()
        {
            InitializeComponent();

            Excel.ExcelPackage.LicenseContext = Excel.LicenseContext.NonCommercial;



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
                        BruttóBér = g.Count() * g.Key.Oraber + " Ft"
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

        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel fájlok (*.xlsx)|*.xlsx|Összes fájl (*.*)|*.*";
                    saveFileDialog.Title = "Excel fájl mentése";
                    saveFileDialog.DefaultExt = "xlsx";
                    saveFileDialog.FileName = $"Berszamfejtes_{comboBoxHonap.SelectedItem}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var package = new ExcelPackage(new FileInfo(saveFileDialog.FileName)))
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Bérszámfejtés");

                            // Oszlopfejlécek exportálása
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                                worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            }

                            // Adatok exportálása
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // Automatikus oszlopszélesség
                            worksheet.Cells.AutoFitColumns();

                            // Fájl mentése
                            package.Save();
                        }

                        MessageBox.Show("Az adatok sikeresen exportálva az Excel fájlba!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hiba történt az exportálás során: {ex.Message}\nStackTrace: {ex.StackTrace}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBezaras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
