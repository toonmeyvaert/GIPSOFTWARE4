namespace Versie3
{
    partial class MENU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuLid = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLeiding = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAankoop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMateriaal = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKlusje = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLid,
            this.MenuLeiding,
            this.MenuAankoop,
            this.MenuMateriaal,
            this.MenuKlusje});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuLid
            // 
            this.MenuLid.Name = "MenuLid";
            this.MenuLid.Size = new System.Drawing.Size(35, 20);
            this.MenuLid.Text = "Lid";
            this.MenuLid.Click += new System.EventHandler(this.lidToolStripMenuItem_Click);
            // 
            // MenuLeiding
            // 
            this.MenuLeiding.Name = "MenuLeiding";
            this.MenuLeiding.Size = new System.Drawing.Size(58, 20);
            this.MenuLeiding.Text = "Leiding";
            this.MenuLeiding.Click += new System.EventHandler(this.MenuLeiding_Click);
            // 
            // MenuAankoop
            // 
            this.MenuAankoop.Name = "MenuAankoop";
            this.MenuAankoop.Size = new System.Drawing.Size(67, 20);
            this.MenuAankoop.Text = "Aankoop";
            this.MenuAankoop.Click += new System.EventHandler(this.MenuAankoop_Click);
            // 
            // MenuMateriaal
            // 
            this.MenuMateriaal.Name = "MenuMateriaal";
            this.MenuMateriaal.Size = new System.Drawing.Size(68, 20);
            this.MenuMateriaal.Text = "Materiaal";
            this.MenuMateriaal.Click += new System.EventHandler(this.MenuMateriaal_Click);
            // 
            // MenuKlusje
            // 
            this.MenuKlusje.Name = "MenuKlusje";
            this.MenuKlusje.Size = new System.Drawing.Size(50, 20);
            this.MenuKlusje.Text = "Klusje";
            this.MenuKlusje.Click += new System.EventHandler(this.MenuKlusje_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 438);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MENU";
            this.Text = "Zolak";
            this.Load += new System.EventHandler(this.MENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuLid;
        private System.Windows.Forms.ToolStripMenuItem MenuLeiding;
        private System.Windows.Forms.ToolStripMenuItem MenuAankoop;
        private System.Windows.Forms.ToolStripMenuItem MenuMateriaal;
        private System.Windows.Forms.ToolStripMenuItem MenuKlusje;
    }
}

