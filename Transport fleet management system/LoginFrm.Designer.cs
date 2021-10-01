
namespace Transport_fleet_management_system
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUsername = new DevComponents.DotNetBar.LabelX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.hLblForgotPassword = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.gpBoxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.gpBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground;
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsername.Font = new System.Drawing.Font("Vazir", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(36, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PreventEnterBeep = true;
            this.txtUsername.Size = new System.Drawing.Size(145, 25);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveBackground;
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.Font = new System.Drawing.Font("Vazir", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(36, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(145, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUsername.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsername.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(187, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsername.Size = new System.Drawing.Size(76, 23);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "نام کاربری :";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(207, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassword.Size = new System.Drawing.Size(56, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "رمز عبور :";
            // 
            // hLblForgotPassword
            // 
            this.hLblForgotPassword.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.hLblForgotPassword.Appearance.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hLblForgotPassword.Appearance.Options.UseBackColor = true;
            this.hLblForgotPassword.Appearance.Options.UseFont = true;
            this.hLblForgotPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.hLblForgotPassword.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hLblForgotPassword.Location = new System.Drawing.Point(82, 166);
            this.hLblForgotPassword.Name = "hLblForgotPassword";
            this.hLblForgotPassword.Size = new System.Drawing.Size(181, 24);
            this.hLblForgotPassword.TabIndex = 6;
            this.hLblForgotPassword.Text = "رمز خود را فراموش کرده اید؟";
            // 
            // gpBoxLogin
            // 
            this.gpBoxLogin.AutoSize = true;
            this.gpBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.gpBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpBoxLogin.Controls.Add(this.simpleButton1);
            this.gpBoxLogin.Controls.Add(this.txtPassword);
            this.gpBoxLogin.Controls.Add(this.lblPassword);
            this.gpBoxLogin.Controls.Add(this.hLblForgotPassword);
            this.gpBoxLogin.Controls.Add(this.lblUsername);
            this.gpBoxLogin.Controls.Add(this.txtUsername);
            this.gpBoxLogin.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxLogin.Location = new System.Drawing.Point(153, 86);
            this.gpBoxLogin.Name = "gpBoxLogin";
            this.gpBoxLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gpBoxLogin.Size = new System.Drawing.Size(309, 299);
            this.gpBoxLogin.TabIndex = 7;
            this.gpBoxLogin.TabStop = false;
            this.gpBoxLogin.Text = "ورود به سیستم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Transport_fleet_management_system.Properties.Resources.fava_logo_slide_01;
            this.pictureBox1.Location = new System.Drawing.Point(255, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(32, 222);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(231, 50);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "ورود به سیستم";
            this.simpleButton1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkLabelControl1.Appearance.Options.UseBackColor = true;
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.hyperlinkLabelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(279, 408);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(55, 24);
            this.hyperlinkLabelControl1.TabIndex = 6;
            this.hyperlinkLabelControl1.Text = "درباره ما";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBoxLogin);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LoginFrm.IconOptions.LargeImage")));
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrm";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.gpBoxLogin.ResumeLayout(false);
            this.gpBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.LabelX lblUsername;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevExpress.XtraEditors.HyperlinkLabelControl hLblForgotPassword;
        private System.Windows.Forms.GroupBox gpBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}