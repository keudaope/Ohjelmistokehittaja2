namespace Tehtävä_13
{
    public partial class suosikitFM : Form
    {
        public suosikitFM()
        {
            InitializeComponent();
        }

        private void tarkastaBT_Click(object sender, EventArgs e)
        {
            vastausLB.Text = "";
            vastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Temp/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Temp/tytot.txt");
            string nimi = nimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach(string poika in pojat)
            {
                if(nimi == poika)
                {
                    vastausLB.Text = "Nimesi on " + laskurip + ". suosituin pojan nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach(string tytto in tytot)
            {
                if(nimi == tytto)
                {
                    vastausLB.Text = "Nimesi on " + laskurit + ". suosituin tytön nimi vuonna 2020";
                    vastausLB.Visible = true;
                }
                laskurit++;
            }
            if(vastausLB.Visible == false) 
            {
                vastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta";
                vastausLB.Visible = true;
            }
        }
    }
}