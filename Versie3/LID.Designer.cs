namespace Versie3
{
    partial class LID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LID));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLid = new System.Windows.Forms.ListBox();
            this.cmbTak = new System.Windows.Forms.ComboBox();
            this.btnLid = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtadres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAchternaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtGeboorte = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMed = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Tak/Groep:";
            this.label7.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 416);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Email:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 370);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Adres:";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "MedischeFiche";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Geboortejaar:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Achternaam:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Naam:";
            this.label1.Visible = false;
            // 
            // lstLid
            // 
            this.lstLid.FormattingEnabled = true;
            this.lstLid.Location = new System.Drawing.Point(34, 41);
            this.lstLid.Margin = new System.Windows.Forms.Padding(2);
            this.lstLid.Name = "lstLid";
            this.lstLid.Size = new System.Drawing.Size(549, 238);
            this.lstLid.TabIndex = 48;
            this.lstLid.SelectedIndexChanged += new System.EventHandler(this.lstLid_SelectedIndexChanged);
            // 
            // cmbTak
            // 
            this.cmbTak.FormattingEnabled = true;
            this.cmbTak.Items.AddRange(new object[] {
            "Kapoenen",
            "Welpen",
            "Wolven",
            "Jong verkenners",
            "Verkenners",
            "Jin"});
            this.cmbTak.Location = new System.Drawing.Point(362, 385);
            this.cmbTak.Name = "cmbTak";
            this.cmbTak.Size = new System.Drawing.Size(121, 21);
            this.cmbTak.TabIndex = 65;
            this.cmbTak.Visible = false;
            this.cmbTak.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.btnLid.Location = new System.Drawing.Point(11, 321);
            this.btnLid.Margin = new System.Windows.Forms.Padding(5);
            this.btnLid.Name = "btnLid";
            this.btnLid.Size = new System.Drawing.Size(181, 41);
            this.btnLid.TabIndex = 66;
            this.btnLid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLid.Click += new System.EventHandler(this.btnLid_Click_1);
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
            this.btnAk.Location = new System.Drawing.Point(362, 416);
            this.btnAk.Margin = new System.Windows.Forms.Padding(5);
            this.btnAk.Name = "btnAk";
            this.btnAk.Size = new System.Drawing.Size(121, 41);
            this.btnAk.TabIndex = 67;
            this.btnAk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAk.Click += new System.EventHandler(this.btnAk_Click_1);
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
            this.txtEmail.Location = new System.Drawing.Point(201, 433);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 24);
            this.txtEmail.TabIndex = 68;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Visible = false;
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
            this.txtadres.Location = new System.Drawing.Point(201, 387);
            this.txtadres.Margin = new System.Windows.Forms.Padding(4);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(136, 24);
            this.txtadres.TabIndex = 69;
            this.txtadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtadres.Visible = false;
            this.txtadres.OnValueChanged += new System.EventHandler(this.txtadres_OnValueChanged);
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
            this.txtAchternaam.Location = new System.Drawing.Point(201, 343);
            this.txtAchternaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(136, 24);
            this.txtAchternaam.TabIndex = 70;
            this.txtAchternaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAchternaam.Visible = false;
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
            this.txtNaam.Location = new System.Drawing.Point(201, 297);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(136, 24);
            this.txtNaam.TabIndex = 71;
            this.txtNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNaam.Visible = false;
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
            this.txtGeboorte.Location = new System.Drawing.Point(362, 298);
            this.txtGeboorte.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeboorte.Name = "txtGeboorte";
            this.txtGeboorte.Size = new System.Drawing.Size(136, 24);
            this.txtGeboorte.TabIndex = 72;
            this.txtGeboorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGeboorte.Visible = false;
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
            this.txtMed.Location = new System.Drawing.Point(362, 341);
            this.txtMed.Margin = new System.Windows.Forms.Padding(4);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(136, 24);
            this.txtMed.TabIndex = 73;
            this.txtMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMed.Visible = false;
            // 
            // LID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 492);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtGeboorte);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAk);
            this.Controls.Add(this.btnLid);
            this.Controls.Add(this.cmbTak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LID";
            this.Text = "LID";
            this.Load += new System.EventHandler(this.LID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLid;
        private System.Windows.Forms.ComboBox cmbTak;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLid;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAk;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtadres;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAchternaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGeboorte;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMed;
    }
}