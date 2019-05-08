namespace Versie3
{
    partial class LEDEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEDEN));
            this.txtMed = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtGeboorte = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAchternaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtadres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLid = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTak = new Bunifu.Framework.UI.BunifuDropdown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvLeden = new System.Windows.Forms.ListView();
            this.chNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGeboortejaar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMedischefiche = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmailOuder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAchternaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtMed
            // 
            this.txtMed.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMed.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMed.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtMed.BorderThickness = 3;
            this.txtMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMed.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMed.isPassword = false;
            this.txtMed.Location = new System.Drawing.Point(485, 391);
            this.txtMed.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(181, 36);
            this.txtMed.TabIndex = 90;
            this.txtMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMed.Visible = false;
            this.txtMed.OnValueChanged += new System.EventHandler(this.txtMed_OnValueChanged);
            // 
            // txtGeboorte
            // 
            this.txtGeboorte.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtGeboorte.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGeboorte.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtGeboorte.BorderThickness = 3;
            this.txtGeboorte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGeboorte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGeboorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGeboorte.isPassword = false;
            this.txtGeboorte.Location = new System.Drawing.Point(485, 338);
            this.txtGeboorte.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGeboorte.Name = "txtGeboorte";
            this.txtGeboorte.Size = new System.Drawing.Size(181, 36);
            this.txtGeboorte.TabIndex = 89;
            this.txtGeboorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGeboorte.Visible = false;
            // 
            // txtNaam
            // 
            this.txtNaam.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNaam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNaam.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtNaam.BorderThickness = 3;
            this.txtNaam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNaam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNaam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNaam.isPassword = false;
            this.txtNaam.Location = new System.Drawing.Point(271, 337);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(181, 36);
            this.txtNaam.TabIndex = 88;
            this.txtNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNaam.Visible = false;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAchternaam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAchternaam.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtAchternaam.BorderThickness = 3;
            this.txtAchternaam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAchternaam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAchternaam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAchternaam.isPassword = false;
            this.txtAchternaam.Location = new System.Drawing.Point(271, 394);
            this.txtAchternaam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(181, 36);
            this.txtAchternaam.TabIndex = 87;
            this.txtAchternaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAchternaam.Visible = false;
            // 
            // txtadres
            // 
            this.txtadres.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtadres.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtadres.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtadres.BorderThickness = 3;
            this.txtadres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtadres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtadres.isPassword = false;
            this.txtadres.Location = new System.Drawing.Point(271, 448);
            this.txtadres.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(181, 36);
            this.txtadres.TabIndex = 86;
            this.txtadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtadres.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(271, 505);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 36);
            this.txtEmail.TabIndex = 85;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Visible = false;
            // 
            // btnAk
            // 
            this.btnAk.ActiveBorderThickness = 1;
            this.btnAk.ActiveCornerRadius = 20;
            this.btnAk.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAk.ActiveForecolor = System.Drawing.Color.White;
            this.btnAk.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAk.BackColor = System.Drawing.SystemColors.Control;
            this.btnAk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAk.BackgroundImage")));
            this.btnAk.ButtonText = "Toevoegen";
            this.btnAk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAk.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAk.IdleBorderThickness = 1;
            this.btnAk.IdleCornerRadius = 20;
            this.btnAk.IdleFillColor = System.Drawing.Color.White;
            this.btnAk.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAk.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAk.Location = new System.Drawing.Point(485, 484);
            this.btnAk.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAk.Name = "btnAk";
            this.btnAk.Size = new System.Drawing.Size(161, 50);
            this.btnAk.TabIndex = 84;
            this.btnAk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAk.Visible = false;
            this.btnAk.Click += new System.EventHandler(this.btnAk_Click_1);
            // 
            // btnLid
            // 
            this.btnLid.ActiveBorderThickness = 1;
            this.btnLid.ActiveCornerRadius = 20;
            this.btnLid.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLid.ActiveForecolor = System.Drawing.Color.White;
            this.btnLid.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLid.BackColor = System.Drawing.SystemColors.Control;
            this.btnLid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLid.BackgroundImage")));
            this.btnLid.ButtonText = "Voeg lid toe";
            this.btnLid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLid.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLid.IdleBorderThickness = 1;
            this.btnLid.IdleCornerRadius = 20;
            this.btnLid.IdleFillColor = System.Drawing.Color.White;
            this.btnLid.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLid.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLid.Location = new System.Drawing.Point(17, 367);
            this.btnLid.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLid.Name = "btnLid";
            this.btnLid.Size = new System.Drawing.Size(241, 50);
            this.btnLid.TabIndex = 83;
            this.btnLid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLid.Click += new System.EventHandler(this.btnLid_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tak/Groep:";
            this.label7.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Email:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 79;
            this.label6.Text = "Adres:";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "MedischeFiche";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Geboortejaar:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Achternaam:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Naam:";
            this.label1.Visible = false;
            // 
            // cmbTak
            // 
            this.cmbTak.BackColor = System.Drawing.Color.Transparent;
            this.cmbTak.BorderRadius = 3;
            this.cmbTak.DisabledColor = System.Drawing.Color.Gray;
            this.cmbTak.ForeColor = System.Drawing.Color.White;
            this.cmbTak.Items = new string[] {
        "Kapoenen",
        "Welpen",
        "Wolven",
        "Jong verkenners",
        "Verkenners",
        "Jin"};
            this.cmbTak.Location = new System.Drawing.Point(485, 446);
            this.cmbTak.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbTak.Name = "cmbTak";
            this.cmbTak.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbTak.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbTak.selectedIndex = -1;
            this.cmbTak.Size = new System.Drawing.Size(181, 28);
            this.cmbTak.TabIndex = 91;
            this.cmbTak.Visible = false;
            this.cmbTak.onItemSelected += new System.EventHandler(this.cmbTak_onItemSelected);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(493, 454);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 92;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lvLeden
            // 
            this.lvLeden.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNaam,
            this.chGeboortejaar,
            this.chMedischefiche,
            this.chAdres,
            this.chEmailOuder,
            this.chTak,
            this.chAchternaam});
            this.lvLeden.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLeden.Location = new System.Drawing.Point(12, 12);
            this.lvLeden.MultiSelect = false;
            this.lvLeden.Name = "lvLeden";
            this.lvLeden.Size = new System.Drawing.Size(749, 301);
            this.lvLeden.TabIndex = 93;
            this.lvLeden.UseCompatibleStateImageBehavior = false;
            this.lvLeden.View = System.Windows.Forms.View.Details;
            this.lvLeden.SelectedIndexChanged += new System.EventHandler(this.lvLeden_SelectedIndexChanged);
            // 
            // chNaam
            // 
            this.chNaam.Text = "Naam";
            // 
            // chGeboortejaar
            // 
            this.chGeboortejaar.Text = "Geboortejaar";
            this.chGeboortejaar.Width = 80;
            // 
            // chMedischefiche
            // 
            this.chMedischefiche.Text = "Medischefiche";
            this.chMedischefiche.Width = 90;
            // 
            // chAdres
            // 
            this.chAdres.Text = "Adres";
            // 
            // chEmailOuder
            // 
            this.chEmailOuder.Text = "EmailOuder";
            this.chEmailOuder.Width = 80;
            // 
            // chTak
            // 
            this.chTak.Text = "Tak";
            // 
            // chAchternaam
            // 
            this.chAchternaam.Text = "Achternaam";
            this.chAchternaam.Width = 80;
            // 
            // LEDEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 558);
            this.Controls.Add(this.lvLeden);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbTak);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtGeboorte);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAk);
            this.Controls.Add(this.btnLid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LEDEN";
            this.Text = "LEDEN";
            this.Load += new System.EventHandler(this.LEDEN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtMed;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGeboorte;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAchternaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtadres;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAk;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cmbTak;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView lvLeden;
        private System.Windows.Forms.ColumnHeader chNaam;
        private System.Windows.Forms.ColumnHeader chGeboortejaar;
        private System.Windows.Forms.ColumnHeader chMedischefiche;
        private System.Windows.Forms.ColumnHeader chAdres;
        private System.Windows.Forms.ColumnHeader chEmailOuder;
        private System.Windows.Forms.ColumnHeader chTak;
        private System.Windows.Forms.ColumnHeader chAchternaam;
    }
}