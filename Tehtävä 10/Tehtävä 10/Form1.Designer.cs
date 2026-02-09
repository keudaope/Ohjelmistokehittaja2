namespace Tehtävä_10
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
            this.painoLB = new System.Windows.Forms.Label();
            this.pituusLB = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.laskeBT = new System.Windows.Forms.Button();
            this.bmiLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painoLB
            // 
            this.painoLB.AutoSize = true;
            this.painoLB.Location = new System.Drawing.Point(32, 41);
            this.painoLB.Name = "painoLB";
            this.painoLB.Size = new System.Drawing.Size(125, 30);
            this.painoLB.TabIndex = 0;
            this.painoLB.Text = "Anna paino:";
            // 
            // pituusLB
            // 
            this.pituusLB.AutoSize = true;
            this.pituusLB.Location = new System.Drawing.Point(32, 94);
            this.pituusLB.Name = "pituusLB";
            this.pituusLB.Size = new System.Drawing.Size(130, 30);
            this.pituusLB.TabIndex = 1;
            this.pituusLB.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            this.painoTB.Location = new System.Drawing.Point(176, 40);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 35);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Location = new System.Drawing.Point(176, 91);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 35);
            this.pituusTB.TabIndex = 3;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(32, 145);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(244, 41);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske BMI";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // bmiLB
            // 
            this.bmiLB.AutoSize = true;
            this.bmiLB.Location = new System.Drawing.Point(32, 205);
            this.bmiLB.Name = "bmiLB";
            this.bmiLB.Size = new System.Drawing.Size(68, 30);
            this.bmiLB.TabIndex = 5;
            this.bmiLB.Text = "label1";
            this.bmiLB.Visible = false;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(32, 245);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(68, 30);
            this.vastausLB.TabIndex = 6;
            this.vastausLB.Text = "label1";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 290);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.bmiLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.pituusLB);
            this.Controls.Add(this.painoLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "BMI laskuri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label painoLB;
        private Label pituusLB;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button laskeBT;
        private Label bmiLB;
        private Label vastausLB;
    }
}