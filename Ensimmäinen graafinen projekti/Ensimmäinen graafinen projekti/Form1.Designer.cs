namespace Ensimmäinen_graafinen_projekti
{
    partial class EkaProjekti
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tekstiLB = new System.Windows.Forms.Label();
            this.tekstiBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tekstiLB
            // 
            this.tekstiLB.AutoSize = true;
            this.tekstiLB.Location = new System.Drawing.Point(40, 29);
            this.tekstiLB.Name = "tekstiLB";
            this.tekstiLB.Size = new System.Drawing.Size(78, 32);
            this.tekstiLB.TabIndex = 0;
            this.tekstiLB.Text = "label1";
            this.tekstiLB.Visible = false;
            // 
            // tekstiBT
            // 
            this.tekstiBT.Location = new System.Drawing.Point(46, 73);
            this.tekstiBT.Name = "tekstiBT";
            this.tekstiBT.Size = new System.Drawing.Size(112, 39);
            this.tekstiBT.TabIndex = 1;
            this.tekstiBT.Text = "Paina";
            this.tekstiBT.UseVisualStyleBackColor = true;
            this.tekstiBT.Click += new System.EventHandler(this.tekstiBT_Click_1);
            // 
            // EkaProjekti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 537);
            this.Controls.Add(this.tekstiBT);
            this.Controls.Add(this.tekstiLB);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EkaProjekti";
            this.Text = "Eka Projekti";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ErrorProvider errorProvider1;
        private Button tekstiBT;
        private Label tekstiLB;
    }
}