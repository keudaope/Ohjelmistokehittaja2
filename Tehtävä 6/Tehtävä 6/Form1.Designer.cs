namespace Tehtävä_6
{
    partial class salasanaFM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salasanaPL = new System.Windows.Forms.Panel();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.virheViestiLB = new System.Windows.Forms.Label();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salasanaOikeinPL = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.salasanaPL.SuspendLayout();
            this.salasanaOikeinPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPL
            // 
            this.salasanaPL.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanaPL.Controls.Add(this.tarkastaBT);
            this.salasanaPL.Controls.Add(this.salasanaTB);
            this.salasanaPL.Controls.Add(this.virheViestiLB);
            this.salasanaPL.Controls.Add(this.kayttajaTB);
            this.salasanaPL.Controls.Add(this.label2);
            this.salasanaPL.Controls.Add(this.label1);
            this.salasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salasanaPL.ForeColor = System.Drawing.Color.Gold;
            this.salasanaPL.Location = new System.Drawing.Point(0, 0);
            this.salasanaPL.Name = "salasanaPL";
            this.salasanaPL.Size = new System.Drawing.Size(596, 171);
            this.salasanaPL.TabIndex = 0;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tarkastaBT.Location = new System.Drawing.Point(456, 118);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(122, 50);
            this.tarkastaBT.TabIndex = 7;
            this.tarkastaBT.Text = "Tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = true;
            this.tarkastaBT.Click += new System.EventHandler(this.tarkastaBT_Click_1);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(237, 72);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(341, 39);
            this.salasanaTB.TabIndex = 6;
            // 
            // virheViestiLB
            // 
            this.virheViestiLB.AutoSize = true;
            this.virheViestiLB.Location = new System.Drawing.Point(22, 127);
            this.virheViestiLB.Name = "virheViestiLB";
            this.virheViestiLB.Size = new System.Drawing.Size(78, 32);
            this.virheViestiLB.TabIndex = 5;
            this.virheViestiLB.Text = "label3";
            this.virheViestiLB.Visible = false;
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(237, 24);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(341, 39);
            this.kayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // salasanaOikeinPL
            // 
            this.salasanaOikeinPL.BackColor = System.Drawing.Color.DarkRed;
            this.salasanaOikeinPL.Controls.Add(this.label3);
            this.salasanaOikeinPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaOikeinPL.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.salasanaOikeinPL.ForeColor = System.Drawing.Color.Snow;
            this.salasanaOikeinPL.Location = new System.Drawing.Point(0, 0);
            this.salasanaOikeinPL.Name = "salasanaOikeinPL";
            this.salasanaOikeinPL.Size = new System.Drawing.Size(596, 171);
            this.salasanaOikeinPL.TabIndex = 1;
            this.salasanaOikeinPL.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivuilleni";
            // 
            // salasanaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 171);
            this.Controls.Add(this.salasanaPL);
            this.Controls.Add(this.salasanaOikeinPL);
            this.Name = "salasanaFM";
            this.Text = "Salasanan tarkastus";
            this.salasanaPL.ResumeLayout(false);
            this.salasanaPL.PerformLayout();
            this.salasanaOikeinPL.ResumeLayout(false);
            this.salasanaOikeinPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel salasanaPL;
        private Label virheViestiLB;
        private TextBox kayttajaTB;
        private Label label2;
        private Label label1;
        private Panel salasanaOikeinPL;
        private Label label3;
        private TextBox salasanaTB;
        private Button tarkastaBT;
    }
}