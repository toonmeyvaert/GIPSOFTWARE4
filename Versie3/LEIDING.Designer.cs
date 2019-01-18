namespace Versie3
{
    partial class LEIDING
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
            this.btnAk = new System.Windows.Forms.Button();
            this.txtTak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGeboorte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeiding = new System.Windows.Forms.Button();
            this.lstLeiding = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAk
            // 
            this.btnAk.Location = new System.Drawing.Point(545, 456);
            this.btnAk.Name = "btnAk";
            this.btnAk.Size = new System.Drawing.Size(142, 42);
            this.btnAk.TabIndex = 81;
            this.btnAk.Text = "Toevoegen";
            this.btnAk.UseVisualStyleBackColor = true;
            this.btnAk.Visible = false;
            this.btnAk.Click += new System.EventHandler(this.btnAk_Click);
            // 
            // txtTak
            // 
            this.txtTak.Location = new System.Drawing.Point(545, 413);
            this.txtTak.Name = "txtTak";
            this.txtTak.Size = new System.Drawing.Size(142, 22);
            this.txtTak.TabIndex = 80;
            this.txtTak.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "Tak/Groep:";
            this.label7.Visible = false;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(330, 466);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(142, 22);
            this.txtAdres.TabIndex = 77;
            this.txtAdres.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Hoodleiding:";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtGeboorte
            // 
            this.txtGeboorte.Location = new System.Drawing.Point(545, 357);
            this.txtGeboorte.Name = "txtGeboorte";
            this.txtGeboorte.Size = new System.Drawing.Size(134, 22);
            this.txtGeboorte.TabIndex = 72;
            this.txtGeboorte.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Start Leiding:";
            this.label3.Visible = false;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(330, 413);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(142, 22);
            this.txtAchternaam.TabIndex = 70;
            this.txtAchternaam.Visible = false;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(330, 355);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(142, 22);
            this.txtNaam.TabIndex = 69;
            this.txtNaam.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Achternaam:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Naam:";
            this.label1.Visible = false;
            // 
            // btnLeiding
            // 
            this.btnLeiding.Location = new System.Drawing.Point(107, 357);
            this.btnLeiding.Name = "btnLeiding";
            this.btnLeiding.Size = new System.Drawing.Size(157, 58);
            this.btnLeiding.TabIndex = 66;
            this.btnLeiding.Text = "Voeg leiding toe";
            this.btnLeiding.UseVisualStyleBackColor = true;
            this.btnLeiding.Click += new System.EventHandler(this.btnLeiding_Click);
            // 
            // lstLeiding
            // 
            this.lstLeiding.FormattingEnabled = true;
            this.lstLeiding.ItemHeight = 16;
            this.lstLeiding.Location = new System.Drawing.Point(107, 42);
            this.lstLeiding.Name = "lstLeiding";
            this.lstLeiding.Size = new System.Drawing.Size(731, 292);
            this.lstLeiding.TabIndex = 65;
            this.lstLeiding.SelectedIndexChanged += new System.EventHandler(this.lstLeiding_SelectedIndexChanged);
            // 
            // LEIDING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 599);
            this.Controls.Add(this.btnAk);
            this.Controls.Add(this.txtTak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGeboorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeiding);
            this.Controls.Add(this.lstLeiding);
            this.Name = "LEIDING";
            this.Text = "LEIDING";
            this.Load += new System.EventHandler(this.LEIDING_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAk;
        private System.Windows.Forms.TextBox txtTak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGeboorte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeiding;
        private System.Windows.Forms.ListBox lstLeiding;
    }
}