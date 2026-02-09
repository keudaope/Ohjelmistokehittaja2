namespace Tehtävä_12
{
    public partial class Form1 : Form
    {
        string[] vastaukset = new string[11];
        string[] oikeat = { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            aRB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
            bRB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
            cRB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
            dRB.CheckedChanged += new EventHandler(radiobutton_CheckChanged);
        }
        private void radiobutton_CheckChanged(object sender, System.EventArgs e)
        {
            if(sender is RadioButton && laskuri <= 10) 
            { 
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                otsikkoLB.Text = "Vastaus " + laskuri + ". kysymykseen:";
                laskuri++;
            }
            else
            {
                vastausLB.Text = "";
                aRB.Enabled= false;
                bRB.Enabled= false;
                cRB.Enabled= false;
                dRB.Enabled= false;
                for(int j = 1; j<= 10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                vastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                vastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if (aRB.Checked)
            {
                aRB.Checked = false;
                laskuri--;
            }
            else if (bRB.Checked)
            {
                bRB.Checked = false;
                laskuri--;
            }
            else if (cRB.Checked)
            {
                cRB.Checked = false;
                laskuri--;
            }
            else if (dRB.Checked)
            {
                dRB.Checked = false;
                laskuri--;
            }
        }
    }
}