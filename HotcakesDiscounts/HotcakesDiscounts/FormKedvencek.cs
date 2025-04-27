using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1.Catalog;
using Hotcakes.CommerceDTO.v1.Contacts;

namespace HotcakesDiscounts
{
    public partial class FormKedvencek : Form
    {
        public FormKedvencek()
        {
            InitializeComponent();
            WishList();
        }

        public static Api ApiCall()
        {
            string url = "http://rendfejl1000.northeurope.cloudapp.azure.com:8080";
            string kulcs = "1-6bd2514f-f48c-4480-b474-647f35d27979";
            Api proxy = new Api(url, kulcs);
            return proxy;
        }


        private void WishList()
        {
            dataGridViewKedvencek.Columns.Clear();

            Api proxy = ApiCall();

            var response = proxy.WishListItemsFindAll();

            if (response == null || response.Content == null || response.Content.Count == 0)
            {
                MessageBox.Show("Nem sikerült lekérni a rendeléseket vagy nincs adat.");
                return;
            }

            // Termékek csoportosítása ProductId alapján és darabszám számítása
            var groupedProducts = response.Content
                .GroupBy(prod => prod.ProductId)
                .Select(group => new
                {
                    ProductId = group.Key,
                    Count = group.Count()
                })
                .ToList();

            // DataTable létrehozása
            DataTable tabla = new DataTable();
            tabla.Columns.Add("ProductId", typeof(string));
            tabla.Columns.Add("Count", typeof(int));

            // DataTable feltöltése az összegzett adatokkal
            foreach (var prod in groupedProducts)
            {
                var row = tabla.NewRow();
                row["ProductId"] = prod.ProductId;
                row["Count"] = prod.Count;
                tabla.Rows.Add(row);
            }

            dataGridViewKedvencek.DataSource = tabla;
        }



        private void buttonKedvencekBezaras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
