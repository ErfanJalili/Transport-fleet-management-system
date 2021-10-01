
namespace Transport_fleet_management_system
{
    partial class EditUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserFrm));
            this.gbCheckUser = new System.Windows.Forms.GroupBox();
            this.lblCheckNationCode = new DevComponents.DotNetBar.LabelX();
            this.txtNationCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.cbRole = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Admin = new DevComponents.Editors.ComboItem();
            this.User = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEditNationCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gbCheckUser.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCheckUser
            // 
            this.gbCheckUser.Controls.Add(this.simpleButton1);
            this.gbCheckUser.Controls.Add(this.lblCheckNationCode);
            this.gbCheckUser.Controls.Add(this.txtNationCode);
            this.gbCheckUser.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheckUser.Location = new System.Drawing.Point(12, 29);
            this.gbCheckUser.Name = "gbCheckUser";
            this.gbCheckUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbCheckUser.Size = new System.Drawing.Size(716, 118);
            this.gbCheckUser.TabIndex = 1;
            this.gbCheckUser.TabStop = false;
            this.gbCheckUser.Text = "بررسی کاربر";
            // 
            // lblCheckNationCode
            // 
            // 
            // 
            // 
            this.lblCheckNationCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCheckNationCode.Location = new System.Drawing.Point(526, 52);
            this.lblCheckNationCode.Name = "lblCheckNationCode";
            this.lblCheckNationCode.Size = new System.Drawing.Size(75, 23);
            this.lblCheckNationCode.TabIndex = 1;
            this.lblCheckNationCode.Text = "کدملی :";
            // 
            // txtNationCode
            // 
            // 
            // 
            // 
            this.txtNationCode.Border.Class = "TextBoxBorder";
            this.txtNationCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNationCode.Location = new System.Drawing.Point(366, 52);
            this.txtNationCode.Name = "txtNationCode";
            this.txtNationCode.PreventEnterBeep = true;
            this.txtNationCode.Size = new System.Drawing.Size(141, 28);
            this.txtNationCode.TabIndex = 0;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.simpleButton2);
            this.gbUserInfo.Controls.Add(this.pictureEdit1);
            this.gbUserInfo.Controls.Add(this.cbRole);
            this.gbUserInfo.Controls.Add(this.labelX3);
            this.gbUserInfo.Controls.Add(this.labelX4);
            this.gbUserInfo.Controls.Add(this.labelX2);
            this.gbUserInfo.Controls.Add(this.labelX1);
            this.gbUserInfo.Controls.Add(this.txtNewPassword);
            this.gbUserInfo.Controls.Add(this.txtUserName);
            this.gbUserInfo.Controls.Add(this.txtEditNationCode);
            this.gbUserInfo.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserInfo.Location = new System.Drawing.Point(12, 153);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbUserInfo.Size = new System.Drawing.Size(716, 233);
            this.gbUserInfo.TabIndex = 2;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "ویرایش کاربر";
            this.gbUserInfo.Visible = false;
            // 
            // cbRole
            // 
            this.cbRole.DisplayMember = "Text";
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.ItemHeight = 23;
            this.cbRole.Items.AddRange(new object[] {
            this.Admin,
            this.User});
            this.cbRole.Location = new System.Drawing.Point(309, 114);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(125, 29);
            this.cbRole.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbRole.TabIndex = 2;
            // 
            // Admin
            // 
            this.Admin.Text = "Admin";
            // 
            // User
            // 
            this.User.Text = "User";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(454, 114);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "نقش کاربر :";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(181, 114);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "رمز عبور جدید :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(170, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "نام و نام خانوادگی :";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(454, 41);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "کدملی :";
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.Border.Class = "TextBoxBorder";
            this.txtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPassword.Location = new System.Drawing.Point(30, 114);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PreventEnterBeep = true;
            this.txtNewPassword.Size = new System.Drawing.Size(125, 28);
            this.txtNewPassword.TabIndex = 0;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.Location = new System.Drawing.Point(30, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(125, 28);
            this.txtUserName.TabIndex = 0;
            // 
            // txtEditNationCode
            // 
            // 
            // 
            // 
            this.txtEditNationCode.Border.Class = "TextBoxBorder";
            this.txtEditNationCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEditNationCode.Location = new System.Drawing.Point(309, 41);
            this.txtEditNationCode.Name = "txtEditNationCode";
            this.txtEditNationCode.PreventEnterBeep = true;
            this.txtEditNationCode.Size = new System.Drawing.Size(125, 28);
            this.txtEditNationCode.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(6, 175);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(149, 52);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "ویرایش کاربر";
            this.simpleButton2.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(600, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(101, 96);
            this.pictureEdit1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Vazir", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 52);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "برسی اطلاعات";
            this.simpleButton1.Click += new System.EventHandler(this.btnCheckData_Click);
            // 
            // EditUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 432);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbCheckUser);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("EditUserFrm.IconOptions.LargeImage")));
            this.Name = "EditUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserFrm";
            this.gbCheckUser.ResumeLayout(false);
            this.gbUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCheckUser;
        private DevComponents.DotNetBar.LabelX lblCheckNationCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNationCode;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbRole;
        private DevComponents.Editors.ComboItem Admin;
        private DevComponents.Editors.ComboItem User;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEditNationCode;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}