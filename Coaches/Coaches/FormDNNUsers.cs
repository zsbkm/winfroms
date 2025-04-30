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
        public FormDNNUsers()
        {
            InitializeComponent();

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

        private void button2_Click(object sender, EventArgs e)
        {
            var cb = usersBindingSource.Current as Models.Users;
            Clipboard.SetText(cb.UserId.ToString());
        }
    }
}
