namespace Tehtävä_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            double asteet = double.Parse(asteetTB.Text);
            double vastaus;
            if(celsiusRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                vastausLB.Text = asteet + " fahrenheit astetta on " + Math.Round(vastaus, 2) + " celsius astetta.";
                vastausLB.Visible = true;
            }
            else if (fahrenheitRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                vastausLB.Text = asteet + " celsius astetta on " + Math.Round(vastaus, 2) + " fahrenheit astetta";
                vastausLB.Visible = true;
            }
            else
            {
                vastausLB.Text = "Et valinnut, kuinka muutetaan";
                vastausLB.Visible = true;
            }
        }
    }
}