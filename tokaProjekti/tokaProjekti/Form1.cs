namespace tokaProjekti
{
    public partial class harjoitus2FM : Form
    {
        public harjoitus2FM()
        {
            InitializeComponent();
        }

        private void tulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = viestiTB.Text;
            tulostaLB.Visible= true;
            if(teksti.Length > 0)
            {
                tulostaLB.Text = teksti;
            }
            else
            {
                tulostaLB.Text = "Et syöttänyt mitään tekstiä";
                viestiTB.Focus();
                
            }
        }
    }
}