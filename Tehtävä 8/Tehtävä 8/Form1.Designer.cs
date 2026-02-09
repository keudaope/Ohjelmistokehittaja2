namespace Tehtävä_8
{
    partial class RoomalaisetNumerotFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomalaisetNumerotFM));
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.muutaBT = new System.Windows.Forms.Button();
            this.pyyntoLB = new System.Windows.Forms.Label();
            this.lukuTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Pristina", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(144, 9);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(478, 85);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Roomalaiset numerot";
            // 
            // muutaBT
            // 
            this.muutaBT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.muutaBT.Location = new System.Drawing.Point(512, 177);
            this.muutaBT.Name = "muutaBT";
            this.muutaBT.Size = new System.Drawing.Size(168, 52);
            this.muutaBT.TabIndex = 1;
            this.muutaBT.Text = "Muuta";
            this.muutaBT.UseVisualStyleBackColor = false;
            this.muutaBT.Click += new System.EventHandler(this.muutaBT_Click_1);
            // 
            // pyyntoLB
            // 
            this.pyyntoLB.AutoSize = true;
            this.pyyntoLB.Location = new System.Drawing.Point(12, 122);
            this.pyyntoLB.Name = "pyyntoLB";
            this.pyyntoLB.Size = new System.Drawing.Size(605, 42);
            this.pyyntoLB.TabIndex = 2;
            this.pyyntoLB.Text = "Anna luku  väliltä 1-3999, niin muutan sen roomalaisiksi:";
            // 
            // lukuTB
            // 
            this.lukuTB.BackColor = System.Drawing.SystemColors.WindowText;
            this.lukuTB.ForeColor = System.Drawing.SystemColors.Window;
            this.lukuTB.Location = new System.Drawing.Point(623, 122);
            this.lukuTB.Name = "lukuTB";
            this.lukuTB.Size = new System.Drawing.Size(100, 49);
            this.lukuTB.TabIndex = 3;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(13, 194);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(73, 42);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "label1";
            // 
            // RoomalaisetNumerotFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 438);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.lukuTB);
            this.Controls.Add(this.pyyntoLB);
            this.Controls.Add(this.muutaBT);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "RoomalaisetNumerotFM";
            this.Text = "Numeroiden muunto latinalaisista roomalaisiksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion;

        private Label otsikkoLB;
        private Button muutaBT;
        private Label pyyntoLB;
        private TextBox lukuTB;
        private Label vastausLB;
    }
}