namespace Kolmas_tehtava
{
    partial class nelilaskinFM
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
            this.lukuYksiTB = new System.Windows.Forms.TextBox();
            this.lukuKaksiTB = new System.Windows.Forms.TextBox();
            this.laskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lukuYksiTB
            // 
            this.lukuYksiTB.Location = new System.Drawing.Point(27, 22);
            this.lukuYksiTB.Name = "lukuYksiTB";
            this.lukuYksiTB.Size = new System.Drawing.Size(100, 35);
            this.lukuYksiTB.TabIndex = 0;
            // 
            // lukuKaksiTB
            // 
            this.lukuKaksiTB.Location = new System.Drawing.Point(256, 22);
            this.lukuKaksiTB.Name = "lukuKaksiTB";
            this.lukuKaksiTB.Size = new System.Drawing.Size(100, 35);
            this.lukuKaksiTB.TabIndex = 1;
            // 
            // laskutoimitusCB
            // 
            this.laskutoimitusCB.FormattingEnabled = true;
            this.laskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.laskutoimitusCB.Location = new System.Drawing.Point(129, 22);
            this.laskutoimitusCB.Name = "laskutoimitusCB";
            this.laskutoimitusCB.Size = new System.Drawing.Size(121, 38);
            this.laskutoimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(395, 25);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(25, 30);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "X";
            this.vastausLB.Visible = false;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(448, 19);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(121, 43);
            this.laskeBT.TabIndex = 5;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // nelilaskinFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 75);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskutoimitusCB);
            this.Controls.Add(this.lukuKaksiTB);
            this.Controls.Add(this.lukuYksiTB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "nelilaskinFM";
            this.Text = "Yksinkertainen nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox lukuYksiTB;
        private TextBox lukuKaksiTB;
        private ComboBox laskutoimitusCB;
        private Label label1;
        private Label vastausLB;
        private Button laskeBT;
    }
}