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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AANKOOP));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoorwerp = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAantal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPrijs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnVoegToe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lvAankoop = new System.Windows.Forms.ListView();
            this.chPrijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVoorwerp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prijs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aantal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Voorwerp:";
            // 
            // txtVoorwerp
            // 
            this.txtVoorwerp.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtVoorwerp.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVoorwerp.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtVoorwerp.BorderThickness = 3;
            this.txtVoorwerp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVoorwerp.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtVoorwerp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVoorwerp.isPassword = false;
            this.txtVoorwerp.Location = new System.Drawing.Point(113, 11);
            this.txtVoorwerp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVoorwerp.Name = "txtVoorwerp";
            this.txtVoorwerp.Size = new System.Drawing.Size(98, 24);
            this.txtVoorwerp.TabIndex = 75;
            this.txtVoorwerp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtAantal.Location = new System.Drawing.Point(113, 35);
            this.txtAantal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(98, 24);
            this.txtAantal.TabIndex = 76;
            this.txtAantal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrijs
            // 
            this.txtPrijs.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPrijs.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrijs.BorderColorMouseHover = System.Drawing.Color.SeaGreen;
            this.txtPrijs.BorderThickness = 3;
            this.txtPrijs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrijs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrijs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrijs.isPassword = false;
            this.txtPrijs.Location = new System.Drawing.Point(113, 67);
            this.txtPrijs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(98, 24);
            this.txtPrijs.TabIndex = 77;
            this.txtPrijs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.ActiveBorderThickness = 1;
            this.btnVoegToe.ActiveCornerRadius = 20;
            this.btnVoegToe.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnVoegToe.ActiveForecolor = System.Drawing.Color.White;
            this.btnVoegToe.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoegToe.BackColor = System.Drawing.SystemColors.Control;
            this.btnVoegToe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoegToe.BackgroundImage")));
            this.btnVoegToe.ButtonText = "Toevoegen";
            this.btnVoegToe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoegToe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoegToe.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnVoegToe.IdleBorderThickness = 1;
            this.btnVoegToe.IdleCornerRadius = 20;
            this.btnVoegToe.IdleFillColor = System.Drawing.Color.White;
            this.btnVoegToe.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnVoegToe.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoegToe.Location = new System.Drawing.Point(260, 11);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(164, 65);
            this.btnVoegToe.TabIndex = 78;
            this.btnVoegToe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvAankoop
            // 
            this.lvAankoop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPrijs,
            this.chAantal,
            this.chVoorwerp});
            this.lvAankoop.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAankoop.Location = new System.Drawing.Point(9, 100);
            this.lvAankoop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvAankoop.MultiSelect = false;
            this.lvAankoop.Name = "lvAankoop";
            this.lvAankoop.Size = new System.Drawing.Size(294, 136);
            this.lvAankoop.TabIndex = 79;
            this.lvAankoop.UseCompatibleStateImageBehavior = false;
            this.lvAankoop.View = System.Windows.Forms.View.Details;
            this.lvAankoop.SelectedIndexChanged += new System.EventHandler(this.lvAankoop_SelectedIndexChanged);
            // 
            // chPrijs
            // 
            this.chPrijs.Text = "Prijs";
            // 
            // chAantal
            // 
            this.chAantal.Text = "Aantal";
            // 
            // chVoorwerp
            // 
            this.chVoorwerp.Text = "Voorwerp";
            // 
            // AANKOOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 245);
            this.Controls.Add(this.lvAankoop);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.txtVoorwerp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AANKOOP";
            this.Text = "AANKOOP";
            this.Load += new System.EventHandler(this.AANKOOP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtVoorwerp;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAantal;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrijs;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVoegToe;
        private System.Windows.Forms.ListView lvAankoop;
        private System.Windows.Forms.ColumnHeader chPrijs;
        private System.Windows.Forms.ColumnHeader chAantal;
        private System.Windows.Forms.ColumnHeader chVoorwerp;
    }
}