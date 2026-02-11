namespace Tehtävä_16
{
    public partial class Form1 : Form
    {
        private int kokonaisaika;
        public Form1()
        {
            InitializeComponent();
            stopBT.Enabled = false;
            for(int i = 0;i <=59; i++)
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 0;
            sekunnitCB.SelectedIndex = 7;
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            stopBT.Enabled = true;
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTR.Enabled = true;
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            stopBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTR.Enabled = true;
            aikaLB.Text = "00:00";
        }

        private void ajastinTR_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                ajastinTR.Stop();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("c:/temp/alarm.wav");
                player.Play();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}