﻿namespace Versie3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEIDING));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLeiding = new System.Windows.Forms.ListBox();
            this.txtNaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAchternaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHoofdLeiding = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtStart = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTak = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLeiding = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Tak/Groep:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Hoodleiding:";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Start Leiding:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Achternaam:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Naam:";
            this.label1.Visible = false;
            // 
            // lstLeiding
            // 
            this.lstLeiding.FormattingEnabled = true;
            this.lstLeiding.Location = new System.Drawing.Point(80, 34);
            this.lstLeiding.Margin = new System.Windows.Forms.Padding(2);
            this.lstLeiding.Name = "lstLeiding";
            this.lstLeiding.Size = new System.Drawing.Size(549, 238);
            this.lstLeiding.TabIndex = 65;
            this.lstLeiding.SelectedIndexChanged += new System.EventHandler(this.lstLeiding_SelectedIndexChanged);
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
            this.txtNaam.Location = new System.Drawing.Point(248, 291);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(136, 24);
            this.txtNaam.TabIndex = 82;
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
            this.txtAchternaam.Location = new System.Drawing.Point(248, 336);
            this.txtAchternaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(136, 24);
            this.txtAchternaam.TabIndex = 83;
            this.txtAchternaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAchternaam.Visible = false;
            // 
            // txtHoofdLeiding
            // 
            this.txtHoofdLeiding.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtHoofdLeiding.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoofdLeiding.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtHoofdLeiding.BorderThickness = 3;
            this.txtHoofdLeiding.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoofdLeiding.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtHoofdLeiding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoofdLeiding.isPassword = false;
            this.txtHoofdLeiding.Location = new System.Drawing.Point(248, 381);
            this.txtHoofdLeiding.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoofdLeiding.Name = "txtHoofdLeiding";
            this.txtHoofdLeiding.Size = new System.Drawing.Size(136, 24);
            this.txtHoofdLeiding.TabIndex = 84;
            this.txtHoofdLeiding.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHoofdLeiding.Visible = false;
            // 
            // txtStart
            // 
            this.txtStart.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtStart.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStart.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtStart.BorderThickness = 3;
            this.txtStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStart.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStart.isPassword = false;
            this.txtStart.Location = new System.Drawing.Point(409, 291);
            this.txtStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(136, 24);
            this.txtStart.TabIndex = 85;
            this.txtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStart.Visible = false;
            // 
            // txtTak
            // 
            this.txtTak.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtTak.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTak.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtTak.BorderThickness = 3;
            this.txtTak.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTak.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTak.isPassword = false;
            this.txtTak.Location = new System.Drawing.Point(409, 340);
            this.txtTak.Margin = new System.Windows.Forms.Padding(4);
            this.txtTak.Name = "txtTak";
            this.txtTak.Size = new System.Drawing.Size(136, 24);
            this.txtTak.TabIndex = 86;
            this.txtTak.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTak.Visible = false;
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
            this.btnAk.Location = new System.Drawing.Point(409, 373);
            this.btnAk.Margin = new System.Windows.Forms.Padding(5);
            this.btnAk.Name = "btnAk";
            this.btnAk.Size = new System.Drawing.Size(121, 41);
            this.btnAk.TabIndex = 87;
            this.btnAk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLeiding
            // 
            this.btnLeiding.ActiveBorderThickness = 1;
            this.btnLeiding.ActiveCornerRadius = 20;
            this.btnLeiding.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLeiding.ActiveForecolor = System.Drawing.Color.White;
            this.btnLeiding.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLeiding.BackColor = System.Drawing.SystemColors.Control;
            this.btnLeiding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeiding.BackgroundImage")));
            this.btnLeiding.ButtonText = "Voeg leiding toe";
            this.btnLeiding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeiding.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeiding.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLeiding.IdleBorderThickness = 1;
            this.btnLeiding.IdleCornerRadius = 20;
            this.btnLeiding.IdleFillColor = System.Drawing.Color.White;
            this.btnLeiding.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLeiding.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLeiding.Location = new System.Drawing.Point(93, 291);
            this.btnLeiding.Margin = new System.Windows.Forms.Padding(5);
            this.btnLeiding.Name = "btnLeiding";
            this.btnLeiding.Size = new System.Drawing.Size(121, 58);
            this.btnLeiding.TabIndex = 88;
            this.btnLeiding.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LEIDING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 487);
            this.Controls.Add(this.btnLeiding);
            this.Controls.Add(this.btnAk);
            this.Controls.Add(this.txtTak);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtHoofdLeiding);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLeiding);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LEIDING";
            this.Text = "LEIDING";
            this.Load += new System.EventHandler(this.LEIDING_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLeiding;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAchternaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHoofdLeiding;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtStart;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTak;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAk;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLeiding;
    }
}