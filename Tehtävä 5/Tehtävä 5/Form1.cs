namespace Tehtävä_5
{
    public partial class Form1 : Form
    {
        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void luvutTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter)
            {
                if(luvutTB.Text == "-999")
                {
                    vastausLB.Text = "";
                    luvutTB.Text = "";
                    int[] taulu = jono.ToArray();
                    Array.Sort(taulu);
                    foreach(int luku in taulu)
                    {
                        vastausLB.Text += luku.ToString() + " ";
                    }
                    vastausLB.Visible= true;
                }
                else
                {
                    jono.Add(int.Parse(luvutTB.Text));
                    luvutTB.Text = "";
                }
            }
            else if(e.KeyChar== (char)Keys.Escape) 
            {
                TyhjaaLomake();
            }
        }
        private void TyhjaaLomake()
        {
            luvutTB.Text = "";
        }
    }
}