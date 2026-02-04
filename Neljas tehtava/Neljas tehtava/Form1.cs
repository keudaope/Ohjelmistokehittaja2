namespace Neljas_tehtava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttarit = synttariDT.Value;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            vuosissaLB.Text = Math.Floor(erotus / 365.25).ToString();
            kuukausissaLB.Text = Math.Floor(erotus / 12).ToString();
            paivissaLB.Text = erotus.ToString();
            tunneissaLB.Text = (erotus * 24).ToString();
            minuuteissaLB.Text = (erotus * 24 * 60).ToString();
            sekunneissaLB.Text = (erotus * 24 * 60 * 60).ToString();
            vuosissaLB.Visible= true;
            kuukausissaLB.Visible= true;
            paivissaLB.Visible = true;
            tunneissaLB.Visible= true;
            minuuteissaLB.Visible = true;
            sekunneissaLB.Visible = true;
        }
    }
}