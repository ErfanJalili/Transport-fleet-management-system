
namespace Transport_fleet_management_system
{
    partial class ManageUserFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserFrm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.getUserWithRoleDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsertDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.نقش = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUserWithRoleDtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.getUserWithRoleDtoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(889, 465);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // getUserWithRoleDtoBindingSource
            // 
            this.getUserWithRoleDtoBindingSource.DataSource = typeof(Transport_fleet_management_system.BL.GetUserWithRoleDto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Password,
            this.Image,
            this.InsertDate,
            this.نقش,
            this.NationCode,
            this.Name,
            this.Id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Password
            // 
            this.Password.Caption = "پسورد";
            this.Password.FieldName = "Password";
            this.Password.Name = "Password";
            this.Password.Visible = true;
            this.Password.VisibleIndex = 0;
            // 
            // Image
            // 
            this.Image.Caption = "تصویر کاربر";
            this.Image.FieldName = "Image";
            this.Image.Name = "Image";
            this.Image.Visible = true;
            this.Image.VisibleIndex = 1;
            // 
            // InsertDate
            // 
            this.InsertDate.Caption = "تاریخ ثبت";
            this.InsertDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.InsertDate.FieldName = "InsertDate";
            this.InsertDate.Name = "InsertDate";
            this.InsertDate.Visible = true;
            this.InsertDate.VisibleIndex = 2;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // نقش
            // 
            this.نقش.Caption = "نقش کاربر";
            this.نقش.FieldName = "RoleName";
            this.نقش.Name = "نقش";
            this.نقش.Visible = true;
            this.نقش.VisibleIndex = 3;
            // 
            // NationCode
            // 
            this.NationCode.Caption = "کدملی";
            this.NationCode.FieldName = "NationCode";
            this.NationCode.Name = "NationCode";
            this.NationCode.Visible = true;
            this.NationCode.VisibleIndex = 4;
            // 
            // Name
            // 
            this.Name.Caption = "نام کاربر";
            this.Name.FieldName = "Name";
            this.Name.Name = "Name";
            this.Name.Visible = true;
            this.Name.VisibleIndex = 5;
            // 
            // Id
            // 
            this.Id.Caption = "آیدی";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 6;
            // 
            // ManageUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 465);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("UserControlFrm.IconOptions.LargeImage")));
            
            this.Text = "ManageUserFrm";
            this.Load += new System.EventHandler(this.ManageUserFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUserWithRoleDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource getUserWithRoleDtoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Password;
        private DevExpress.XtraGrid.Columns.GridColumn Image;
        private DevExpress.XtraGrid.Columns.GridColumn InsertDate;
        private DevExpress.XtraGrid.Columns.GridColumn نقش;
        private DevExpress.XtraGrid.Columns.GridColumn NationCode;
        private DevExpress.XtraGrid.Columns.GridColumn Name;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
    }
}