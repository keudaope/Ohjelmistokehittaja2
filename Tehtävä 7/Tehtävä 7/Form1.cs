namespace Tehtävä_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, energia, kustannukset;
            laina = double.Parse(lainaTB.Text);
            nesteet = double.Parse(nesteetTB.Text);
            pesut = double.Parse(pesutTB.Text);
            huollot = double.Parse(huollotTB.Text);
            renkaat = double.Parse(renkaatTB.Text);
            muut = double.Parse(muutTB.Text);
            energia = double.Parse(polttonesteTB.Text);
            vakuutus = double.Parse(vakuutusTB.Text);
            int kilometrit = int.Parse(kilometritCB.Text);
            kustannukset = (laina + nesteet + pesut + huollot + renkaat + muut + energia + vakuutus) / (kilometrit / 12);
            vastausLB.Text = ("Kustannukset kilometriä kohden ovat " + Math.Round(kustannukset, 2) + " euroa"); ;
            vastausLB.Visible = true;
        }
    }
}