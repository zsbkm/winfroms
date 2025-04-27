using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotcakesOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetOrders();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public static Api ApiCall()
        {
            string url = "http://rendfejl1000.northeurope.cloudapp.azure.com:8080";
            string kulcs = "1-6bd2514f-f48c-4480-b474-647f35d27979";
            Api proxy = new Api(url, kulcs);
            return proxy;
        }
        private void GetOrders()
        {
            Api proxy = ApiCall();
            var responseOrder = proxy.OrdersFindAll();


            if (responseOrder == null || responseOrder.Content == null || responseOrder.Content.Count == 0)
            {
                MessageBox.Show("Nem sikerült lekérni a rendeléseket vagy nincs adat.");
                return;
            }


            DataTable tabla = new DataTable();

            tabla.Columns.Add("OrderNumber");
            tabla.Columns.Add("OrderBvin");
            tabla.Columns.Add("OrderDate");
            tabla.Columns.Add("TotalGrand");
            tabla.Columns.Add("UserEmail");            
            tabla.Columns.Add("BillingName");
            tabla.Columns.Add("BillingCountry");
            tabla.Columns.Add("BillingCity");
            tabla.Columns.Add("BillingStreet");
            tabla.Columns.Add("ShippingName");
            tabla.Columns.Add("ShippingCountry");
            tabla.Columns.Add("ShippingCity");
            tabla.Columns.Add("ShippingStreet");


            int szamlalo = 0;

            foreach (var order in responseOrder.Content)
            {
                var row = tabla.NewRow();
                if (order.OrderNumber != "")
                {
                    szamlalo++;

                    row["OrderNumber"] = order.OrderNumber;
                    row["OrderBvin"] = order.bvin;
                    row["OrderDate"] = order.TimeOfOrderUtc.ToLocalTime().ToString("yyyy.MM.dd HH:mm");
                    row["TotalGrand"] = order.TotalGrand;
                    row["UserEmail"] = order.UserEmail;

                    if (order.BillingAddress != null)
                    {
                        row["BillingName"] = $"{order.BillingAddress.FirstName} {order.BillingAddress.LastName}";
                        row["BillingStreet"] = order.BillingAddress.Line1;
                        row["BillingCity"] = order.BillingAddress.City;
                        row["BillingCountry"] = order.BillingAddress.CountryName;
                    }


                    if (order.ShippingAddress != null)
                    {
                        row["ShippingName"] = $"{order.ShippingAddress.FirstName} {order.ShippingAddress.LastName}";
                        row["ShippingStreet"] = order.ShippingAddress.Line1;
                        row["ShippingCity"] = order.ShippingAddress.City;
                        row["ShippingCountry"] = order.ShippingAddress.CountryName;
                    }

                    tabla.Rows.Add(row);
                }
            }
            dataGridViewOrders.DataSource = tabla;
            label1.Text = "Összes rendelés: " + szamlalo.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
