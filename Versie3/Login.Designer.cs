namespace Versie3
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtWachtwoord = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNaam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = false;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(24, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.Red;
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(169, 34);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtWachtwoord.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWachtwoord.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtWachtwoord.BorderThickness = 3;
            this.txtWachtwoord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWachtwoord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtWachtwoord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWachtwoord.isPassword = true;
            this.txtWachtwoord.Location = new System.Drawing.Point(24, 113);
            this.txtWachtwoord.Margin = new System.Windows.Forms.Padding(4);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.Size = new System.Drawing.Size(169, 41);
            this.txtWachtwoord.TabIndex = 6;
            this.txtWachtwoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNaam
            // 
            this.txtNaam.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNaam.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNaam.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNaam.BorderThickness = 3;
            this.txtNaam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNaam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNaam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNaam.isPassword = false;
            this.txtNaam.Location = new System.Drawing.Point(24, 64);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(169, 41);
            this.txtNaam.TabIndex = 7;
            this.txtNaam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 227);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNaam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtWachtwoord;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private System.Windows.Forms.Label label1;
    }
}