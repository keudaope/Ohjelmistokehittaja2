namespace Tehtävä_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double paino = double.Parse(painoTB.Text);
            double pituus = double.Parse(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus),2);
            if(bmi < 18.5)
            {
                bmiLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.Text = "Alipaino";
                bmiLB.Visible = true; 
                vastausLB.Visible = true;
                bmiLB.ForeColor = Color.Cyan;
                vastausLB.ForeColor = Color.Cyan;
            }
            else if (bmi <= 24.9)
            {
                bmiLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.Text = "Normaalipaino";
                bmiLB.Visible = true;
                vastausLB.Visible = true;
                bmiLB.ForeColor = Color.Green;
                vastausLB.ForeColor = Color.Green;
            }
            else if(bmi <= 39.9)
            {
                bmiLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.Text = "Ylipaino";
                bmiLB.Visible = true;
                vastausLB.Visible = true;
                bmiLB.ForeColor = Color.Orange;
                vastausLB.ForeColor = Color.Orange;
            }
            else
            {
                bmiLB.Text = "Painoindeksisi on " + bmi;
                vastausLB.Text = "Merkittävä lihavuus";
                bmiLB.Visible = true;
                vastausLB.Visible = true;
                bmiLB.ForeColor = Color.Red;
                vastausLB.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}