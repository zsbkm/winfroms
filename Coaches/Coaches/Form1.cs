namespace Coaches
{
    public partial class Form1 : Form
    {
        Models.MyDnndatabaseContext _context = new Models.MyDnndatabaseContext();

        public Form1()
        {
            InitializeComponent();
            szemelyiEdzokBindingSource.DataSource = _context.SzemelyiEdzok.ToList();
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
        private void Mentés()
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
    }
}
