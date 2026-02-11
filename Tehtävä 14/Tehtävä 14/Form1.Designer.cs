namespace Tehtävä_14
{
    partial class PaivakirjaFM
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
            this.paivakirjaTB = new System.Windows.Forms.TextBox();
            this.lisaaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paivakirjaTB
            // 
            this.paivakirjaTB.Location = new System.Drawing.Point(12, 12);
            this.paivakirjaTB.Multiline = true;
            this.paivakirjaTB.Name = "paivakirjaTB";
            this.paivakirjaTB.Size = new System.Drawing.Size(981, 382);
            this.paivakirjaTB.TabIndex = 0;
            // 
            // lisaaBT
            // 
            this.lisaaBT.Location = new System.Drawing.Point(12, 414);
            this.lisaaBT.Name = "lisaaBT";
            this.lisaaBT.Size = new System.Drawing.Size(981, 41);
            this.lisaaBT.TabIndex = 1;
            this.lisaaBT.Text = "Lisää päiväkirjaan";
            this.lisaaBT.UseVisualStyleBackColor = true;
            this.lisaaBT.Click += new System.EventHandler(this.lisaaBT_Click);
            // 
            // PaivakirjaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 475);
            this.Controls.Add(this.lisaaBT);
            this.Controls.Add(this.paivakirjaTB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PaivakirjaFM";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox paivakirjaTB;
        private Button lisaaBT;
    }
}