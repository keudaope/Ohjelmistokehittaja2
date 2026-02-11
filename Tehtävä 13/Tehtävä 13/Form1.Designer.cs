namespace Tehtävä_13
{
    partial class suosikitFM
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
            this.kysymysLB = new System.Windows.Forms.Label();
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Location = new System.Drawing.Point(23, 39);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(602, 30);
            this.kysymysLB.TabIndex = 0;
            this.kysymysLB.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // nimiTB
            // 
            this.nimiTB.Location = new System.Drawing.Point(631, 39);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(179, 35);
            this.nimiTB.TabIndex = 1;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(23, 102);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(68, 30);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "label1";
            this.vastausLB.Visible = false;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.Location = new System.Drawing.Point(685, 95);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(125, 45);
            this.tarkastaBT.TabIndex = 3;
            this.tarkastaBT.Text = "Tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = true;
            this.tarkastaBT.Click += new System.EventHandler(this.tarkastaBT_Click);
            // 
            // suosikitFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 153);
            this.Controls.Add(this.tarkastaBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.nimiTB);
            this.Controls.Add(this.kysymysLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "suosikitFM";
            this.Text = "Onko nimesi suosittujen joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kysymysLB;
        private TextBox nimiTB;
        private Label vastausLB;
        private Button tarkastaBT;
    }
}