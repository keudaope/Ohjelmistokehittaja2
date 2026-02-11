using System.Diagnostics;
namespace Tehtävä_15
{
    public partial class Form1 : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void startBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void ajastinTR_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}