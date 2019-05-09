namespace Versie3
{
    partial class KLUSJE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KLUSJE));
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lvKlusje = new System.Windows.Forms.ListView();
            this.chSoortenKlusje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVerantwoordelijke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPlanning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beschikbare Klusjes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Hoofdleiding";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(189, 255);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(181, 41);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // lvKlusje
            // 
            this.lvKlusje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSoortenKlusje,
            this.chVerantwoordelijke,
            this.chPlanning});
            this.lvKlusje.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvKlusje.Location = new System.Drawing.Point(122, 36);
            this.lvKlusje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvKlusje.MultiSelect = false;
            this.lvKlusje.Name = "lvKlusje";
            this.lvKlusje.Size = new System.Drawing.Size(410, 213);
            this.lvKlusje.TabIndex = 3;
            this.lvKlusje.UseCompatibleStateImageBehavior = false;
            this.lvKlusje.View = System.Windows.Forms.View.Details;
            this.lvKlusje.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chSoortenKlusje
            // 
            this.chSoortenKlusje.Text = "SoortenKlusje";
            this.chSoortenKlusje.Width = 80;
            // 
            // chVerantwoordelijke
            // 
            this.chVerantwoordelijke.Text = "Verantwoordelijke";
            this.chVerantwoordelijke.Width = 110;
            // 
            // chPlanning
            // 
            this.chPlanning.Text = "Planning";
            this.chPlanning.Width = 80;
            // 
            // KLUSJE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 334);
            this.Controls.Add(this.lvKlusje);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KLUSJE";
            this.Text = "KLUSJE";
            this.Load += new System.EventHandler(this.KLUSJE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.ListView lvKlusje;
        private System.Windows.Forms.ColumnHeader chSoortenKlusje;
        private System.Windows.Forms.ColumnHeader chVerantwoordelijke;
        private System.Windows.Forms.ColumnHeader chPlanning;
    }
}