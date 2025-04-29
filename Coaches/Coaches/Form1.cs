using Coaches.Models;

namespace Coaches
{
    public partial class Form1 : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();

        public Form1()
        {
            InitializeComponent();
            szemelyiEdzokBindingSource.DataSource = _context.SzemelyiEdzok.ToList();
            label1.Text = "Edzõk szûrése:";
        }

        private void EdzokBetoltese()
        {
            var edzok = from x in _context.SzemelyiEdzok
                        where x.Nev.ToLower().Contains(textBoxEdzoSzuro.Text.ToLower())
                        orderby x.Nev
                        select x;

            szemelyiEdzokBindingSource.DataSource = edzok.ToList();
            //szemelyiEdzokBindingSource.ResetCurrentItem();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            FormAddNew formAddNew = new FormAddNew();
            formAddNew.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit();
            formEdit.szemelyiEdzok = szemelyiEdzokBindingSource.Current as SzemelyiEdzok;
            if (formEdit.ShowDialog() == DialogResult.OK) 
            {
                Mentes();
            }

            
        }
    }
}
