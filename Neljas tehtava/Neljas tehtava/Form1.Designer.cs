namespace Neljas_tehtava
{
    partial class Form1
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
            this.synttariDT = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vuosissaLB = new System.Windows.Forms.Label();
            this.kuukausissaLB = new System.Windows.Forms.Label();
            this.paivissaLB = new System.Windows.Forms.Label();
            this.tunneissaLB = new System.Windows.Forms.Label();
            this.minuuteissaLB = new System.Windows.Forms.Label();
            this.sekunneissaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // synttariDT
            // 
            this.synttariDT.Location = new System.Drawing.Point(45, 44);
            this.synttariDT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.synttariDT.Name = "synttariDT";
            this.synttariDT.Size = new System.Drawing.Size(340, 35);
            this.synttariDT.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(409, 40);
            this.laskeBT.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(129, 46);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vuosissaLB
            // 
            this.vuosissaLB.AutoSize = true;
            this.vuosissaLB.Location = new System.Drawing.Point(51, 138);
            this.vuosissaLB.Name = "vuosissaLB";
            this.vuosissaLB.Size = new System.Drawing.Size(68, 30);
            this.vuosissaLB.TabIndex = 2;
            this.vuosissaLB.Text = "label1";
            this.vuosissaLB.Visible = false;
            // 
            // kuukausissaLB
            // 
            this.kuukausissaLB.AutoSize = true;
            this.kuukausissaLB.Location = new System.Drawing.Point(51, 178);
            this.kuukausissaLB.Name = "kuukausissaLB";
            this.kuukausissaLB.Size = new System.Drawing.Size(68, 30);
            this.kuukausissaLB.TabIndex = 3;
            this.kuukausissaLB.Text = "label1";
            this.kuukausissaLB.Visible = false;
            this.kuukausissaLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // paivissaLB
            // 
            this.paivissaLB.AutoSize = true;
            this.paivissaLB.Location = new System.Drawing.Point(51, 223);
            this.paivissaLB.Name = "paivissaLB";
            this.paivissaLB.Size = new System.Drawing.Size(68, 30);
            this.paivissaLB.TabIndex = 4;
            this.paivissaLB.Text = "label1";
            this.paivissaLB.Visible = false;
            // 
            // tunneissaLB
            // 
            this.tunneissaLB.AutoSize = true;
            this.tunneissaLB.Location = new System.Drawing.Point(317, 138);
            this.tunneissaLB.Name = "tunneissaLB";
            this.tunneissaLB.Size = new System.Drawing.Size(68, 30);
            this.tunneissaLB.TabIndex = 5;
            this.tunneissaLB.Text = "label1";
            this.tunneissaLB.Visible = false;
            // 
            // minuuteissaLB
            // 
            this.minuuteissaLB.AutoSize = true;
            this.minuuteissaLB.Location = new System.Drawing.Point(317, 178);
            this.minuuteissaLB.Name = "minuuteissaLB";
            this.minuuteissaLB.Size = new System.Drawing.Size(68, 30);
            this.minuuteissaLB.TabIndex = 6;
            this.minuuteissaLB.Text = "label1";
            this.minuuteissaLB.Visible = false;
            // 
            // sekunneissaLB
            // 
            this.sekunneissaLB.AutoSize = true;
            this.sekunneissaLB.Location = new System.Drawing.Point(317, 223);
            this.sekunneissaLB.Name = "sekunneissaLB";
            this.sekunneissaLB.Size = new System.Drawing.Size(68, 30);
            this.sekunneissaLB.TabIndex = 7;
            this.sekunneissaLB.Text = "label1";
            this.sekunneissaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 288);
            this.Controls.Add(this.sekunneissaLB);
            this.Controls.Add(this.minuuteissaLB);
            this.Controls.Add(this.tunneissaLB);
            this.Controls.Add(this.paivissaLB);
            this.Controls.Add(this.kuukausissaLB);
            this.Controls.Add(this.vuosissaLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.synttariDT);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker synttariDT;
        private Button laskeBT;
        private Label vuosissaLB;
        private Label kuukausissaLB;
        private Label paivissaLB;
        private Label tunneissaLB;
        private Label minuuteissaLB;
        private Label sekunneissaLB;
    }
}