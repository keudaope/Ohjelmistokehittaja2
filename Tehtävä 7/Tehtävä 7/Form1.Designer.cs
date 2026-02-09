namespace Tehtävä_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lainaTB = new System.Windows.Forms.TextBox();
            this.nesteetTB = new System.Windows.Forms.TextBox();
            this.vakuutusTB = new System.Windows.Forms.TextBox();
            this.muutTB = new System.Windows.Forms.TextBox();
            this.polttonesteTB = new System.Windows.Forms.TextBox();
            this.kilometritCB = new System.Windows.Forms.ComboBox();
            this.renkaatTB = new System.Windows.Forms.TextBox();
            this.huollotTB = new System.Windows.Forms.TextBox();
            this.pesutTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auton kustannuslaskuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lainan lyhennys korkoineen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lisättävät nesteet yms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Muut kulut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vakuutusmaksut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pesut:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Polttoneste:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kilometriä / vuosi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Renkaat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Huollot:";
            // 
            // lainaTB
            // 
            this.lainaTB.Location = new System.Drawing.Point(272, 124);
            this.lainaTB.Name = "lainaTB";
            this.lainaTB.Size = new System.Drawing.Size(100, 29);
            this.lainaTB.TabIndex = 10;
            // 
            // nesteetTB
            // 
            this.nesteetTB.Location = new System.Drawing.Point(272, 162);
            this.nesteetTB.Name = "nesteetTB";
            this.nesteetTB.Size = new System.Drawing.Size(100, 29);
            this.nesteetTB.TabIndex = 11;
            // 
            // vakuutusTB
            // 
            this.vakuutusTB.Location = new System.Drawing.Point(272, 200);
            this.vakuutusTB.Name = "vakuutusTB";
            this.vakuutusTB.Size = new System.Drawing.Size(100, 29);
            this.vakuutusTB.TabIndex = 12;
            // 
            // muutTB
            // 
            this.muutTB.Location = new System.Drawing.Point(272, 242);
            this.muutTB.Name = "muutTB";
            this.muutTB.Size = new System.Drawing.Size(100, 29);
            this.muutTB.TabIndex = 13;
            this.muutTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // polttonesteTB
            // 
            this.polttonesteTB.Location = new System.Drawing.Point(272, 280);
            this.polttonesteTB.Name = "polttonesteTB";
            this.polttonesteTB.Size = new System.Drawing.Size(100, 29);
            this.polttonesteTB.TabIndex = 14;
            // 
            // kilometritCB
            // 
            this.kilometritCB.FormattingEnabled = true;
            this.kilometritCB.Items.AddRange(new object[] {
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "45000",
            "50000"});
            this.kilometritCB.Location = new System.Drawing.Point(522, 241);
            this.kilometritCB.Name = "kilometritCB";
            this.kilometritCB.Size = new System.Drawing.Size(121, 29);
            this.kilometritCB.TabIndex = 15;
            this.kilometritCB.SelectedIndexChanged += new System.EventHandler(this.kilometritCB_SelectedIndexChanged);
            // 
            // renkaatTB
            // 
            this.renkaatTB.Location = new System.Drawing.Point(522, 202);
            this.renkaatTB.Name = "renkaatTB";
            this.renkaatTB.Size = new System.Drawing.Size(100, 29);
            this.renkaatTB.TabIndex = 16;
            // 
            // huollotTB
            // 
            this.huollotTB.Location = new System.Drawing.Point(522, 163);
            this.huollotTB.Name = "huollotTB";
            this.huollotTB.Size = new System.Drawing.Size(100, 29);
            this.huollotTB.TabIndex = 17;
            // 
            // pesutTB
            // 
            this.pesutTB.Location = new System.Drawing.Point(522, 124);
            this.pesutTB.Name = "pesutTB";
            this.pesutTB.Size = new System.Drawing.Size(100, 29);
            this.pesutTB.TabIndex = 18;
            this.pesutTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(61, 344);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(62, 21);
            this.vastausLB.TabIndex = 19;
            this.vastausLB.Text = "label11";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 383);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.pesutTB);
            this.Controls.Add(this.huollotTB);
            this.Controls.Add(this.renkaatTB);
            this.Controls.Add(this.kilometritCB);
            this.Controls.Add(this.polttonesteTB);
            this.Controls.Add(this.muutTB);
            this.Controls.Add(this.vakuutusTB);
            this.Controls.Add(this.nesteetTB);
            this.Controls.Add(this.lainaTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Auton kustannuslaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox lainaTB;
        private TextBox nesteetTB;
        private TextBox vakuutusTB;
        private TextBox muutTB;
        private TextBox polttonesteTB;
        private ComboBox kilometritCB;
        private TextBox renkaatTB;
        private TextBox huollotTB;
        private TextBox pesutTB;
        private Label vastausLB;
    }
}