namespace JavaScript_tietovisa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kysymysLB = new System.Windows.Forms.Label();
            this.vastausGB = new System.Windows.Forms.GroupBox();
            this.aRB = new System.Windows.Forms.RadioButton();
            this.bRB = new System.Windows.Forms.RadioButton();
            this.cRB = new System.Windows.Forms.RadioButton();
            this.dRB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.vastausGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.vastausGB);
            this.panel1.Controls.Add(this.kysymysLB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 684);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(294, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yksinkertainen JavaScript tietovisa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Testaa tietosi JavaScriptin perusteista";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(2, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1159, 2);
            this.label3.TabIndex = 2;
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kysymysLB.Location = new System.Drawing.Point(44, 163);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(68, 30);
            this.kysymysLB.TabIndex = 3;
            this.kysymysLB.Text = "label4";
            // 
            // vastausGB
            // 
            this.vastausGB.Controls.Add(this.dRB);
            this.vastausGB.Controls.Add(this.cRB);
            this.vastausGB.Controls.Add(this.bRB);
            this.vastausGB.Controls.Add(this.aRB);
            this.vastausGB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vastausGB.Location = new System.Drawing.Point(44, 210);
            this.vastausGB.Name = "vastausGB";
            this.vastausGB.Size = new System.Drawing.Size(200, 196);
            this.vastausGB.TabIndex = 4;
            this.vastausGB.TabStop = false;
            this.vastausGB.Text = "Vaihtoehdot";
            // 
            // aRB
            // 
            this.aRB.AutoSize = true;
            this.aRB.Location = new System.Drawing.Point(6, 34);
            this.aRB.Name = "aRB";
            this.aRB.Size = new System.Drawing.Size(151, 34);
            this.aRB.TabIndex = 0;
            this.aRB.TabStop = true;
            this.aRB.Text = "radioButton1";
            this.aRB.UseVisualStyleBackColor = true;
            // 
            // bRB
            // 
            this.bRB.AutoSize = true;
            this.bRB.Location = new System.Drawing.Point(6, 74);
            this.bRB.Name = "bRB";
            this.bRB.Size = new System.Drawing.Size(151, 34);
            this.bRB.TabIndex = 1;
            this.bRB.TabStop = true;
            this.bRB.Text = "radioButton1";
            this.bRB.UseVisualStyleBackColor = true;
            // 
            // cRB
            // 
            this.cRB.AutoSize = true;
            this.cRB.Location = new System.Drawing.Point(6, 114);
            this.cRB.Name = "cRB";
            this.cRB.Size = new System.Drawing.Size(151, 34);
            this.cRB.TabIndex = 2;
            this.cRB.TabStop = true;
            this.cRB.Text = "radioButton1";
            this.cRB.UseVisualStyleBackColor = true;
            // 
            // dRB
            // 
            this.dRB.AutoSize = true;
            this.dRB.Location = new System.Drawing.Point(6, 154);
            this.dRB.Name = "dRB";
            this.dRB.Size = new System.Drawing.Size(151, 34);
            this.dRB.TabIndex = 3;
            this.dRB.TabStop = true;
            this.dRB.Text = "radioButton1";
            this.dRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1236, 737);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Yksinkertainen JavaScript tietovisa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.vastausGB.ResumeLayout(false);
            this.vastausGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label kysymysLB;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox vastausGB;
        private RadioButton dRB;
        private RadioButton cRB;
        private RadioButton bRB;
        private RadioButton aRB;
    }
}