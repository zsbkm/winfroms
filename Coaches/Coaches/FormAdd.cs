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



        }
    }
}
