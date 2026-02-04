namespace tokaProjekti
{
    partial class harjoitus2FM
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.tulostaLB = new System.Windows.Forms.Label();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.tulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(41, 54);
            this.otsikkoLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(288, 33);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // tulostaLB
            // 
            this.tulostaLB.AutoSize = true;
            this.tulostaLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tulostaLB.Location = new System.Drawing.Point(41, 117);
            this.tulostaLB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tulostaLB.Name = "tulostaLB";
            this.tulostaLB.Size = new System.Drawing.Size(72, 33);
            this.tulostaLB.TabIndex = 1;
            this.tulostaLB.Text = "xxxx";
            this.tulostaLB.Visible = false;
            // 
            // viestiTB
            // 
            this.viestiTB.Location = new System.Drawing.Point(355, 54);
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(520, 35);
            this.viestiTB.TabIndex = 2;
            // 
            // tulostaBT
            // 
            this.tulostaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tulostaBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tulostaBT.Location = new System.Drawing.Point(46, 180);
            this.tulostaBT.Name = "tulostaBT";
            this.tulostaBT.Size = new System.Drawing.Size(140, 61);
            this.tulostaBT.TabIndex = 3;
            this.tulostaBT.Text = "Tulosta";
            this.tulostaBT.UseVisualStyleBackColor = true;
            this.tulostaBT.Click += new System.EventHandler(this.tulostaBT_Click);
            // 
            // harjoitus2FM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1033, 538);
            this.Controls.Add(this.tulostaBT);
            this.Controls.Add(this.viestiTB);
            this.Controls.Add(this.tulostaLB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "harjoitus2FM";
            this.Text = "Harjoitus 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private Label tulostaLB;
        private TextBox viestiTB;
        private Button tulostaBT;
    }
}