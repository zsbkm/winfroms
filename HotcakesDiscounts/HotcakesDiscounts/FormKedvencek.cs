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
            var responseProducts = proxy.ProductsFindAll();




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
            tabla.Columns.Add("TermékId", typeof(string));
            tabla.Columns.Add("Termék neve", typeof(string));
            tabla.Columns.Add("Összesen ennyiszer", typeof(int));
            tabla.Columns.Add("Aktív kedvezmény", typeof(string));

            // DataTable feltöltése az összegzett adatokkal
            foreach (var prod in groupedProducts)
            {
                var row = tabla.NewRow();
                row["TermékId"] = prod.ProductId;

                //Itt lekérdezem hogy az adott id melyik terméknévhez tartozik
                foreach(var elem in responseProducts.Content)
                {
                    if(elem.Bvin == prod.ProductId)
                    {
                        row["Termék neve"] = elem.ProductName;
                        break;
                    }
                }

                row["Összesen ennyiszer"] = prod.Count;               

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
