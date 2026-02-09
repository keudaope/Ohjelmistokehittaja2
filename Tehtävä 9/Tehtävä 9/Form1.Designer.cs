namespace Tehtävä_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.muuntoGB = new System.Windows.Forms.GroupBox();
            this.celsiusRB = new System.Windows.Forms.RadioButton();
            this.fahrenheitRB = new System.Windows.Forms.RadioButton();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.muuntoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna asteet:";
            // 
            // asteetTB
            // 
            this.asteetTB.Location = new System.Drawing.Point(172, 36);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(100, 35);
            this.asteetTB.TabIndex = 1;
            // 
            // muuntoGB
            // 
            this.muuntoGB.Controls.Add(this.fahrenheitRB);
            this.muuntoGB.Controls.Add(this.celsiusRB);
            this.muuntoGB.Location = new System.Drawing.Point(303, 13);
            this.muuntoGB.Name = "muuntoGB";
            this.muuntoGB.Size = new System.Drawing.Size(200, 100);
            this.muuntoGB.TabIndex = 2;
            this.muuntoGB.TabStop = false;
            this.muuntoGB.Text = "Miten muunnat?";
            // 
            // celsiusRB
            // 
            this.celsiusRB.AutoSize = true;
            this.celsiusRB.Location = new System.Drawing.Point(14, 30);
            this.celsiusRB.Name = "celsiusRB";
            this.celsiusRB.Size = new System.Drawing.Size(95, 34);
            this.celsiusRB.TabIndex = 0;
            this.celsiusRB.TabStop = true;
            this.celsiusRB.Text = "Celsius";
            this.celsiusRB.UseVisualStyleBackColor = true;
            // 
            // fahrenheitRB
            // 
            this.fahrenheitRB.AutoSize = true;
            this.fahrenheitRB.Location = new System.Drawing.Point(14, 61);
            this.fahrenheitRB.Name = "fahrenheitRB";
            this.fahrenheitRB.Size = new System.Drawing.Size(128, 34);
            this.fahrenheitRB.TabIndex = 1;
            this.fahrenheitRB.TabStop = true;
            this.fahrenheitRB.Text = "Fahrenheit";
            this.fahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // muunnaBT
            // 
            this.muunnaBT.Location = new System.Drawing.Point(519, 39);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(107, 42);
            this.muunnaBT.TabIndex = 3;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(35, 114);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(68, 30);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "label2";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 153);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.muuntoGB);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Astemuunnin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.muuntoGB.ResumeLayout(false);
            this.muuntoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox asteetTB;
        private GroupBox muuntoGB;
        private RadioButton fahrenheitRB;
        private RadioButton celsiusRB;
        private Button muunnaBT;
        private Label vastausLB;
    }
}