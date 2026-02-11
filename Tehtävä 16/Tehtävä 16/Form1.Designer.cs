namespace Tehtävä_16
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
            this.components = new System.ComponentModel.Container();
            this.minuutitLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.minuutitCB = new System.Windows.Forms.ComboBox();
            this.sekunnitCB = new System.Windows.Forms.ComboBox();
            this.aikaLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.ajastinTR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Location = new System.Drawing.Point(31, 32);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(91, 30);
            this.minuutitLB.TabIndex = 0;
            this.minuutitLB.Text = "minuutit";
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.Location = new System.Drawing.Point(184, 32);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(91, 30);
            this.sekunnitLB.TabIndex = 1;
            this.sekunnitLB.Text = "sekunnit";
            // 
            // minuutitCB
            // 
            this.minuutitCB.FormattingEnabled = true;
            this.minuutitCB.Location = new System.Drawing.Point(12, 65);
            this.minuutitCB.Name = "minuutitCB";
            this.minuutitCB.Size = new System.Drawing.Size(121, 38);
            this.minuutitCB.TabIndex = 2;
            // 
            // sekunnitCB
            // 
            this.sekunnitCB.FormattingEnabled = true;
            this.sekunnitCB.Location = new System.Drawing.Point(165, 65);
            this.sekunnitCB.Name = "sekunnitCB";
            this.sekunnitCB.Size = new System.Drawing.Size(121, 38);
            this.sekunnitCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            this.aikaLB.AutoSize = true;
            this.aikaLB.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aikaLB.Location = new System.Drawing.Point(3, 106);
            this.aikaLB.Name = "aikaLB";
            this.aikaLB.Size = new System.Drawing.Size(283, 128);
            this.aikaLB.TabIndex = 4;
            this.aikaLB.Text = "00:00";
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(17, 235);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(94, 42);
            this.startBT.TabIndex = 5;
            this.startBT.Text = "start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.Location = new System.Drawing.Point(184, 235);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(94, 42);
            this.stopBT.TabIndex = 6;
            this.stopBT.Text = "stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // ajastinTR
            // 
            this.ajastinTR.Interval = 1000;
            this.ajastinTR.Tick += new System.EventHandler(this.ajastinTR_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 319);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.aikaLB);
            this.Controls.Add(this.sekunnitCB);
            this.Controls.Add(this.minuutitCB);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.minuutitLB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label minuutitLB;
        private Label sekunnitLB;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Label aikaLB;
        private Button startBT;
        private Button stopBT;
        private System.Windows.Forms.Timer ajastinTR;
    }
}