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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MATERIAAL));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMateriaal = new System.Windows.Forms.ListBox();
            this.txtNaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAantal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBeschikbaarheid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnToev = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReserveren = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnToevoegen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Beschikbaarheid:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Aantal:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naam:";
            this.label1.Visible = false;
            // 
            // lstMateriaal
            // 
            this.lstMateriaal.FormattingEnabled = true;
            this.lstMateriaal.ItemHeight = 16;
            this.lstMateriaal.Location = new System.Drawing.Point(4, 15);
            this.lstMateriaal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMateriaal.Name = "lstMateriaal";
            this.lstMateriaal.Size = new System.Drawing.Size(379, 228);
            this.lstMateriaal.TabIndex = 10;
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
            this.txtNaam.Location = new System.Drawing.Point(524, -2);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(131, 30);
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
            this.txtAantal.Location = new System.Drawing.Point(524, 30);
            this.txtAantal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(131, 30);
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
            this.txtBeschikbaarheid.Location = new System.Drawing.Point(524, 60);
            this.txtBeschikbaarheid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBeschikbaarheid.Name = "txtBeschikbaarheid";
            this.txtBeschikbaarheid.Size = new System.Drawing.Size(131, 31);
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
            this.btnToev.Location = new System.Drawing.Point(493, 102);
            this.btnToev.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnToev.Name = "btnToev";
            this.btnToev.Size = new System.Drawing.Size(161, 50);
            this.btnToev.TabIndex = 77;
            this.btnToev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReserveren
            // 
            this.btnReserveren.ActiveBorderThickness = 1;
            this.btnReserveren.ActiveCornerRadius = 20;
            this.btnReserveren.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReserveren.ActiveForecolor = System.Drawing.Color.White;
            this.btnReserveren.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReserveren.BackColor = System.Drawing.SystemColors.Control;
            this.btnReserveren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReserveren.BackgroundImage")));
            this.btnReserveren.ButtonText = "Reserveren";
            this.btnReserveren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserveren.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveren.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReserveren.IdleBorderThickness = 1;
            this.btnReserveren.IdleCornerRadius = 20;
            this.btnReserveren.IdleFillColor = System.Drawing.Color.White;
            this.btnReserveren.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReserveren.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReserveren.Location = new System.Drawing.Point(203, 260);
            this.btnReserveren.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnReserveren.Name = "btnReserveren";
            this.btnReserveren.Size = new System.Drawing.Size(161, 50);
            this.btnReserveren.TabIndex = 78;
            this.btnReserveren.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnToevoegen.Location = new System.Drawing.Point(19, 260);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(161, 50);
            this.btnToevoegen.TabIndex = 79;
            this.btnToevoegen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MATERIAAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 325);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnReserveren);
            this.Controls.Add(this.btnToev);
            this.Controls.Add(this.txtBeschikbaarheid);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMateriaal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListBox lstMateriaal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAantal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtBeschikbaarheid;
        private Bunifu.Framework.UI.BunifuThinButton2 btnToev;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReserveren;
        private Bunifu.Framework.UI.BunifuThinButton2 btnToevoegen;
    }
}