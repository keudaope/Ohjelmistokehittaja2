namespace Tehtävä_12
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
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.vastausGB = new System.Windows.Forms.GroupBox();
            this.nakymatonRB = new System.Windows.Forms.RadioButton();
            this.aRB = new System.Windows.Forms.RadioButton();
            this.bRB = new System.Windows.Forms.RadioButton();
            this.cRB = new System.Windows.Forms.RadioButton();
            this.dRB = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.vastausGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Location = new System.Drawing.Point(44, 49);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(236, 30);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // vastausGB
            // 
            this.vastausGB.Controls.Add(this.dRB);
            this.vastausGB.Controls.Add(this.cRB);
            this.vastausGB.Controls.Add(this.bRB);
            this.vastausGB.Controls.Add(this.aRB);
            this.vastausGB.Controls.Add(this.nakymatonRB);
            this.vastausGB.Location = new System.Drawing.Point(306, 49);
            this.vastausGB.Name = "vastausGB";
            this.vastausGB.Size = new System.Drawing.Size(105, 207);
            this.vastausGB.TabIndex = 1;
            this.vastausGB.TabStop = false;
            this.vastausGB.Text = "Vastaus";
            // 
            // nakymatonRB
            // 
            this.nakymatonRB.AutoCheck = false;
            this.nakymatonRB.AutoSize = true;
            this.nakymatonRB.Location = new System.Drawing.Point(24, 50);
            this.nakymatonRB.Name = "nakymatonRB";
            this.nakymatonRB.Size = new System.Drawing.Size(14, 13);
            this.nakymatonRB.TabIndex = 0;
            this.nakymatonRB.TabStop = true;
            this.nakymatonRB.UseVisualStyleBackColor = true;
            this.nakymatonRB.Visible = false;
            // 
            // aRB
            // 
            this.aRB.AutoSize = true;
            this.aRB.Location = new System.Drawing.Point(24, 39);
            this.aRB.Name = "aRB";
            this.aRB.Size = new System.Drawing.Size(45, 34);
            this.aRB.TabIndex = 1;
            this.aRB.TabStop = true;
            this.aRB.Text = "A";
            this.aRB.UseVisualStyleBackColor = true;
            // 
            // bRB
            // 
            this.bRB.AutoSize = true;
            this.bRB.Location = new System.Drawing.Point(24, 79);
            this.bRB.Name = "bRB";
            this.bRB.Size = new System.Drawing.Size(43, 34);
            this.bRB.TabIndex = 2;
            this.bRB.TabStop = true;
            this.bRB.Text = "B";
            this.bRB.UseVisualStyleBackColor = true;
            // 
            // cRB
            // 
            this.cRB.AutoSize = true;
            this.cRB.Location = new System.Drawing.Point(24, 119);
            this.cRB.Name = "cRB";
            this.cRB.Size = new System.Drawing.Size(44, 34);
            this.cRB.TabIndex = 3;
            this.cRB.TabStop = true;
            this.cRB.Text = "C";
            this.cRB.UseVisualStyleBackColor = true;
            // 
            // dRB
            // 
            this.dRB.AutoSize = true;
            this.dRB.Location = new System.Drawing.Point(24, 159);
            this.dRB.Name = "dRB";
            this.dRB.Size = new System.Drawing.Size(46, 34);
            this.dRB.TabIndex = 4;
            this.dRB.TabStop = true;
            this.dRB.Text = "D";
            this.dRB.UseVisualStyleBackColor = true;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(44, 212);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(68, 30);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "label1";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.vastausGB);
            this.Controls.Add(this.otsikkoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "10 Kysymystä";
            this.vastausGB.ResumeLayout(false);
            this.vastausGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label otsikkoLB;
        private GroupBox vastausGB;
        private RadioButton dRB;
        private RadioButton cRB;
        private RadioButton bRB;
        private RadioButton aRB;
        private RadioButton nakymatonRB;
        private Label vastausLB;
    }
}