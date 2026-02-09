namespace Tehtävä_6
{
    public partial class salasanaFM : Form
    {
        public salasanaFM()
        {
            InitializeComponent();
        }



        private void salasanaBT_Click(object sender, EventArgs e)
        {
            
        }

        private void salasanaPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tarkastaBT_Click(object sender, EventArgs e)
        {
            if (kayttajaTB.Text == "Jyri")
            {
                salasanaPL.Visible = false;
                salasanaOikeinPL.Visible = true;
            }
            else
            {
                virheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                virheViestiLB.Visible = true;
            }
        }

        private void tarkastaBT_Click_1(object sender, EventArgs e)
        {
            if(kayttajaTB.Text == "Jyri" && salasanaTB.Text == "J@akk0ku1ta")
            {
                salasanaPL.Visible = false;
                salasanaOikeinPL.Visible= true;
            }
            else
            {
                virheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                virheViestiLB.Visible = true;
            }
        }
    }
}