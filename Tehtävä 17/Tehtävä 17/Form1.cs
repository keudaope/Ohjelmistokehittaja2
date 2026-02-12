using System.IO;
namespace Tehtävä_17
{
    public partial class muistioFM : Form
    {
        string tiedostopolku = "";
        public muistioFM()
        {
            InitializeComponent();
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(rikasTB.Rtf != "")
            {
                tallennaNimelläToolStripMenuItem_Click(sender, e);
                rikasTB.Rtf = "";
            }
            else
            {
                rikasTB.Rtf = "";
            }
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog()
            {
                Filter = "Rikastekstiformaatti|*.rtf",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        rikasTB.Rtf = teksti.Result;
                    }
                        
                }
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tiedostopolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "Rikastekstiformaatti|*.rtf",
                    ValidateNames = true,
                })
                {
                    if(ttk.ShowDialog() == DialogResult.OK )
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLineAsync(this.rikasTB.Rtf);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostopolku))
                {
                    vk.WriteLineAsync(rikasTB.Rtf);
                }
            }
        }

        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog()
            {
                Filter = "Rikastekstiformaatti|*.rtf",
                ValidateNames = true,
            })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                    tiedosto.WriteLineAsync(this.rikasTB.Rtf);
                    tiedosto.Close();
                }
            }
        }

        private void tulostuksenEsikatseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Copy();
        }

        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectedText = "";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectAll();
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rikasTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasTB.SelectionBackColor = Color.Yellow;
        }

        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinKorostusToolStripMenuItem.Checked == true)
            {
                tekstinKorostusToolStripMenuItem.Checked = false;
                rikasTB.WordWrap = false;
            }
            else
            {
                tekstinKorostusToolStripMenuItem.Checked = true;
                rikasTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tietoa tietoa = new Tietoa();
            tietoa.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rikasTB.Rtf, rikasTB.Font, Brushes.Black, 12, 10);
        }

        private void rikasTB_TextChanged(object sender, EventArgs e)
        {
            if(rikasTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled= true;
                leikkaaToolStripMenuItem.Enabled= true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled=false;
            }
        }
    }
}