namespace Versie3
{
    partial class AANKOOP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.lstAankoop = new System.Windows.Forms.ListBox();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtVoorwerp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(219, 12);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(164, 67);
            this.btnVoegToe.TabIndex = 15;
            this.btnVoegToe.Text = "VOEG TOE ";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click_1);
            // 
            // lstAankoop
            // 
            this.lstAankoop.FormattingEnabled = true;
            this.lstAankoop.Location = new System.Drawing.Point(44, 98);
            this.lstAankoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstAankoop.Name = "lstAankoop";
            this.lstAankoop.Size = new System.Drawing.Size(230, 134);
            this.lstAankoop.TabIndex = 14;
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(102, 59);
            this.txtPrijs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(104, 20);
            this.txtPrijs.TabIndex = 13;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(102, 37);
            this.txtAantal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(104, 20);
            this.txtAantal.TabIndex = 12;
            // 
            // txtVoorwerp
            // 
            this.txtVoorwerp.Location = new System.Drawing.Point(102, 14);
            this.txtVoorwerp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVoorwerp.Name = "txtVoorwerp";
            this.txtVoorwerp.Size = new System.Drawing.Size(104, 20);
            this.txtVoorwerp.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prijs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aantal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Voorwerp:";
            // 
            // AANKOOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lstAankoop);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtVoorwerp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AANKOOP";
            this.Text = "AANKOOP";
            this.Load += new System.EventHandler(this.AANKOOP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.ListBox lstAankoop;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtVoorwerp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}