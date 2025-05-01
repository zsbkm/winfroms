using Microsoft.EntityFrameworkCore;
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
    public partial class FormDNNUsers : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();
        public Models.Users KivalasztottFelhasznalo = new();
        public FormDNNUsers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FormDNNUsers_Load(object sender, EventArgs e)
        {
            _context.Users.Load();
            usersBindingSource.DataSource = _context.Users.Local.ToBindingList();
        }
        private void AdatBetoltes()
        {
            var query = _context.Users
                .Where(x => x.Username.ToLower().Contains(textBoxEdzoSzuro.Text.ToLower()));

            usersBindingSource.DataSource = query.ToList();
        }

        private void textBoxEdzoSzuro_TextChanged(object sender, EventArgs e)
        {
            AdatBetoltes();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            KivalasztottFelhasznalo = usersBindingSource.Current as Models.Users;

            /* var cb = usersBindingSource.Current as Models.Users;
            Clipboard.SetText(cb.UserId.ToString()); */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
