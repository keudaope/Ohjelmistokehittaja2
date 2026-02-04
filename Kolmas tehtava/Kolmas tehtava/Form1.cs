namespace Kolmas_tehtava
{
    public partial class nelilaskinFM : Form
    {
        public nelilaskinFM()
        {
            InitializeComponent();
        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(lukuYksiTB.Text);
            float luku2 = float.Parse(lukuKaksiTB.Text);
            float vastaus = 0;
            string merkki = laskutoimitusCB.Text;
            switch(merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus= luku1 - luku2;
                    break;
                case "*":
                    vastaus= luku1 * luku2;
                    break;
                case "/":
                    vastaus= luku1 / luku2;
                    break;
            }
            vastausLB.Text = vastaus.ToString();
            vastausLB.Visible= true;
        }
    }
}