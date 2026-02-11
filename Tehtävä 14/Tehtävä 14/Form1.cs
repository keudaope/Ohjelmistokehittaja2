namespace Tehtävä_14
{
    public partial class PaivakirjaFM : Form
    {
        public PaivakirjaFM()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("c:/Temp/paivakirja.txt");
            paivakirjaTB.Text = teksti;
        }

        private void lisaaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += paivakirjaTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yy HH.mm") + "\n";
            TextWriter text = new StreamWriter("c:/Temp/paivakirja.txt");
            text.WriteLine(teksti);
            text.Close();
            Application.Exit();
        }
    }
}