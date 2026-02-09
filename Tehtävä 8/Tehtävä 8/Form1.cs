namespace Tehtävä_8
{
    public partial class RoomalaisetNumerotFM : Form
    {
        public RoomalaisetNumerotFM()
        {
            InitializeComponent();
        }

        private void muutaBT_Click(object sender, EventArgs e)
        {
            
            
        }

        private void muutaBT_Click_1(object sender, EventArgs e)
        {
            int luku1=0, luku2=0, luku3 = 0, luku4 = 0;
            string vastaus = "";
            if(lukuTB.MaxLength > 3)
            {
                luku1 = Convert.ToInt32(lukuTB.Text.Substring(0, 1));
                luku2 = Convert.ToInt32(lukuTB.Text.Substring(1, 1));
                luku3 = Convert.ToInt32(lukuTB.Text.Substring(2, 1));
                luku4 = Convert.ToInt32(lukuTB.Text.Substring(3, 1));
                if(luku1 % 3== 0)
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if(luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus+= "";
                }
                vastaus += Sataset(luku2, vastaus);
                vastaus += Kympit(luku3, vastaus);
                vastaus += Ykkoset(luku4, vastaus);
            }
            else if(lukuTB.Text.Length > 2)
            {
                luku2 = int.Parse(lukuTB.Text.Substring(0, 1));
                luku3 = int.Parse(lukuTB.Text.Substring(1, 1));
                luku4 = int.Parse(lukuTB.Text.Substring(2, 1));
                vastaus += Sataset(luku2, vastaus);
                vastaus += Kympit(luku3, vastaus);
                vastaus += Ykkoset(luku4, vastaus);
            }
            else if(lukuTB.Text.Length > 1)
            {
                luku3 = int.Parse(lukuTB.Text.Substring(0, 1));
                luku4 = int.Parse(lukuTB.Text.Substring(1, 1));
                vastaus += Kympit(luku3, vastaus);
                vastaus += Ykkoset(luku4, vastaus);
            }
            else if(lukuTB.Text.Length > 0)
            {
                luku4 = int.Parse(lukuTB.Text.Substring(0, 1));
                vastaus += Ykkoset(luku4, vastaus);
            }
            else
            {
                vastaus = "Et antanut mitään lukua";
            }
            vastausLB.Text = vastaus;
            vastausLB.Visible = true;
            
        }
        private string Sataset(int luku, string vastaus)
        {
            if(luku % 9 == 0 && luku != 0)
            {
                return "CM";
            }
            else if(luku % 8 == 0 && luku != 0)
            {
                return "DCCC";
            }
            else if (luku % 7 == 0 && luku != 0)
            {
                return "DCC";
            }
            else if (luku % 6 == 0 && luku != 0)
            {
                return "DC";
            }
            else if (luku % 5 == 0 && luku != 0)
            {
                return "D";
            }
            else if (luku % 4 == 0 && luku != 0)
            {
                return "CD";
            }
            else if (luku % 3 == 0 && luku != 0)
            {
                return "CCC";
            }
            else if (luku % 2 == 0 && luku != 0)
            {
                return "CC";
            }
            else if (luku % 1 == 0 && luku != 0)
            {
                return "C";
            }
            else
            {
                return "";
            }
        }
        private string Kympit(int luku, string vastaus)
        {
            if (luku % 9 == 0 && luku != 0)
            {
                return "XC";
            }
            else if (luku % 8 == 0 && luku != 0)
            {
                return "LXXX";
            }
            else if (luku % 7 == 0 && luku != 0)
            {
                return "LXX";
            }
            else if (luku % 6 == 0 && luku != 0)
            {
                return "LX";
            }
            else if (luku % 5 == 0 && luku != 0)
            {
                return "L";
            }
            else if (luku % 4 == 0 && luku != 0)
            {
                return "XL";
            }
            else if (luku % 3 == 0 && luku != 0)
            {
                return "XXX";
            }
            else if (luku % 2 == 0 && luku != 0)
            {
                return "XX";
            }
            else if (luku % 1 == 0 && luku != 0)
            {
                return "X";
            }
            else
            {
                return "";
            }
        }
        private string Ykkoset(int luku, string vastaus)
        {
            if (luku % 9 == 0 && luku != 0)
            {
                return "IX";
            }
            else if (luku % 8 == 0 && luku != 0)
            {
                return "VIII";
            }
            else if (luku % 7 == 0 && luku != 0)
            {
                return "VII";
            }
            else if (luku % 6 == 0 && luku != 0)
            {
                return "VI";
            }
            else if (luku % 5 == 0 && luku != 0)
            {
                return "V";
            }
            else if (luku % 4 == 0 && luku != 0)
            {
                return "IV";
            }
            else if (luku % 3 == 0 && luku != 0)
            {
                return "III";
            }
            else if (luku % 2 == 0 && luku != 0)
            {
                return "II";
            }
            else if (luku % 1 == 0 && luku != 0)
            {
                return "I";
            }
            else
            {
                return "";
            }
        }
    }
}