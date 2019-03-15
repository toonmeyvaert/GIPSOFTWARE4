namespace Versie3
{
    partial class MATERIAAL
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
            this.btnToev = new System.Windows.Forms.Button();
            this.txtBeschikbaarheid = new System.Windows.Forms.TextBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReserveren = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lstMateriaal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnToev
            // 
            this.btnToev.Location = new System.Drawing.Point(393, 72);
            this.btnToev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(98, 24);
            this.btnToev.TabIndex = 19;
            this.btnToev.Text = "Toevoegen";
            this.btnToev.UseVisualStyleBackColor = true;
            this.btnToev.Visible = false;
            this.btnToev.Click += new System.EventHandler(this.btnToev_Click_1);
            // 
            // txtBeschikbaarheid
            // 
            this.txtBeschikbaarheid.Location = new System.Drawing.Point(393, 50);
            this.txtBeschikbaarheid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBeschikbaarheid.Name = "txtBeschikbaarheid";
            this.txtBeschikbaarheid.Size = new System.Drawing.Size(99, 20);
            this.txtBeschikbaarheid.TabIndex = 18;
            this.txtBeschikbaarheid.Visible = false;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(393, 27);
            this.txtAantal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(99, 20);
            this.txtAantal.TabIndex = 17;
            this.txtAantal.Visible = false;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(393, 4);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(99, 20);
            this.txtNaam.TabIndex = 16;
            this.txtNaam.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Beschikbaarheid:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Aantal:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naam:";
            this.label1.Visible = false;
            // 
            // btnReserveren
            // 
            this.btnReserveren.Location = new System.Drawing.Point(145, 228);
            this.btnReserveren.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReserveren.Name = "btnReserveren";
            this.btnReserveren.Size = new System.Drawing.Size(142, 24);
            this.btnReserveren.TabIndex = 12;
            this.btnReserveren.Text = "Reserveren";
            this.btnReserveren.UseVisualStyleBackColor = true;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(3, 228);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(142, 24);
            this.btnToevoegen.TabIndex = 11;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click_1);
            // 
            // lstMateriaal
            // 
            this.lstMateriaal.FormattingEnabled = true;
            this.lstMateriaal.Location = new System.Drawing.Point(3, 12);
            this.lstMateriaal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMateriaal.Name = "lstMateriaal";
            this.lstMateriaal.Size = new System.Drawing.Size(285, 212);
            this.lstMateriaal.TabIndex = 10;
            // 
            // MATERIAAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 264);
            this.Controls.Add(this.btnToev);
            this.Controls.Add(this.txtBeschikbaarheid);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReserveren);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lstMateriaal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MATERIAAL";
            this.Text = "MATERIAAL";
            this.Load += new System.EventHandler(this.MATERIAAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToev;
        private System.Windows.Forms.TextBox txtBeschikbaarheid;
        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReserveren;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ListBox lstMateriaal;
    }
}