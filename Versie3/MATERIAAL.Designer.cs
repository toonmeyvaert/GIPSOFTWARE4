﻿namespace Versie3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MATERIAAL));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAantal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBeschikbaarheid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnToev = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnToevoegen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lvMateriaal = new System.Windows.Forms.ListView();
            this.chNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBeschikbaarheid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.txtNaam.Location = new System.Drawing.Point(393, -2);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(98, 24);
            this.txtNaam.TabIndex = 74;
            this.txtNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNaam.Visible = false;
            // 
            // txtAantal
            // 
            this.txtAantal.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAantal.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAantal.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtAantal.BorderThickness = 3;
            this.txtAantal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAantal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAantal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAantal.isPassword = false;
            this.txtAantal.Location = new System.Drawing.Point(393, 24);
            this.txtAantal.Margin = new System.Windows.Forms.Padding(4);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(98, 24);
            this.txtAantal.TabIndex = 75;
            this.txtAantal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAantal.Visible = false;
            // 
            // txtBeschikbaarheid
            // 
            this.txtBeschikbaarheid.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBeschikbaarheid.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBeschikbaarheid.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtBeschikbaarheid.BorderThickness = 3;
            this.txtBeschikbaarheid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBeschikbaarheid.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBeschikbaarheid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBeschikbaarheid.isPassword = false;
            this.txtBeschikbaarheid.Location = new System.Drawing.Point(393, 49);
            this.txtBeschikbaarheid.Margin = new System.Windows.Forms.Padding(4);
            this.txtBeschikbaarheid.Name = "txtBeschikbaarheid";
            this.txtBeschikbaarheid.Size = new System.Drawing.Size(98, 25);
            this.txtBeschikbaarheid.TabIndex = 76;
            this.txtBeschikbaarheid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBeschikbaarheid.Visible = false;
            // 
            // btnToev
            // 
            this.btnToev.ActiveBorderThickness = 1;
            this.btnToev.ActiveCornerRadius = 20;
            this.btnToev.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnToev.ActiveForecolor = System.Drawing.Color.White;
            this.btnToev.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnToev.BackColor = System.Drawing.SystemColors.Control;
            this.btnToev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToev.BackgroundImage")));
            this.btnToev.ButtonText = "Toevoegen";
            this.btnToev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToev.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnToev.IdleBorderThickness = 1;
            this.btnToev.IdleCornerRadius = 20;
            this.btnToev.IdleFillColor = System.Drawing.Color.White;
            this.btnToev.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnToev.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnToev.Location = new System.Drawing.Point(370, 83);
            this.btnToev.Margin = new System.Windows.Forms.Padding(5);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(121, 41);
            this.btnToev.TabIndex = 77;
            this.btnToev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToev.Visible = false;
            this.btnToev.Click += new System.EventHandler(this.btnToev_Click_1);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.ActiveBorderThickness = 1;
            this.btnToevoegen.ActiveCornerRadius = 20;
            this.btnToevoegen.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnToevoegen.ActiveForecolor = System.Drawing.Color.White;
            this.btnToevoegen.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnToevoegen.BackColor = System.Drawing.SystemColors.Control;
            this.btnToevoegen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnToevoegen.BackgroundImage")));
            this.btnToevoegen.ButtonText = "Toevoegen";
            this.btnToevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToevoegen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnToevoegen.IdleBorderThickness = 1;
            this.btnToevoegen.IdleCornerRadius = 20;
            this.btnToevoegen.IdleFillColor = System.Drawing.Color.White;
            this.btnToevoegen.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnToevoegen.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnToevoegen.Location = new System.Drawing.Point(14, 211);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(5);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(121, 41);
            this.btnToevoegen.TabIndex = 79;
            this.btnToevoegen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click_1);
            // 
            // lvMateriaal
            // 
            this.lvMateriaal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNaam,
            this.chAantal,
            this.chBeschikbaarheid});
            this.lvMateriaal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvMateriaal.Location = new System.Drawing.Point(9, 10);
            this.lvMateriaal.Margin = new System.Windows.Forms.Padding(2);
            this.lvMateriaal.MultiSelect = false;
            this.lvMateriaal.Name = "lvMateriaal";
            this.lvMateriaal.Size = new System.Drawing.Size(278, 195);
            this.lvMateriaal.TabIndex = 80;
            this.lvMateriaal.UseCompatibleStateImageBehavior = false;
            this.lvMateriaal.View = System.Windows.Forms.View.Details;
            this.lvMateriaal.SelectedIndexChanged += new System.EventHandler(this.lvMateriaal_SelectedIndexChanged);
            // 
            // chNaam
            // 
            this.chNaam.Text = "Naam";
            // 
            // chAantal
            // 
            this.chAantal.Text = "Aantal";
            // 
            // chBeschikbaarheid
            // 
            this.chBeschikbaarheid.Text = "Beschikbaarheid";
            this.chBeschikbaarheid.Width = 100;
            // 
            // MATERIAAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 264);
            this.Controls.Add(this.lvMateriaal);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnToev);
            this.Controls.Add(this.txtBeschikbaarheid);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MATERIAAL";
            this.Text = "MATERIAAL";
            this.Load += new System.EventHandler(this.MATERIAAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAantal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBeschikbaarheid;
        private Bunifu.Framework.UI.BunifuThinButton2 btnToev;
        private Bunifu.Framework.UI.BunifuThinButton2 btnToevoegen;
        private System.Windows.Forms.ListView lvMateriaal;
        private System.Windows.Forms.ColumnHeader chNaam;
        private System.Windows.Forms.ColumnHeader chAantal;
        private System.Windows.Forms.ColumnHeader chBeschikbaarheid;
    }
}