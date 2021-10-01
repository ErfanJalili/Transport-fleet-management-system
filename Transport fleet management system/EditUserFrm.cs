using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_fleet_management_system.Methods;

namespace Transport_fleet_management_system
{
    public partial class EditUserFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditUserFrm()
        {
            InitializeComponent();
        }

        private void btnCheckData_Click(object sender, EventArgs e)
        {
            UserMethods methods = new UserMethods();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {

                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        var result = methods.GetUserByNationCode(db, txtNationCode.Text);

                       

                        if (result != null)
                        {
                            txtNationCode.Enabled = false;
                            gbUserInfo.Visible = true;
                            txtEditNationCode.Text = result.NationCode;
                            txtUserName.Text = result.Name;
                            cbRole.Text = result.RoleName;
                            txtNewPassword.Text = result.Password;
                            if (result.Image != null)
                            {
                                pictureEdit1.Image = methods.byteArrayToImage(result.Image);
                            }
                            

                        }
                        else
                        {
                            XtraMessageBox.Show($"کاربر با کد ملی {txtNationCode.Text} یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("آیا از تغییرات کاربر مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                UserMethods methods = new UserMethods();
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    try
                    {

                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();

                            var resultOfEditing= methods.UpdateUserByNationCode(db, txtNationCode.Text, txtUserName.Text, txtEditNationCode.Text, txtNewPassword.Text, methods.GetRoleId(db, cbRole.SelectedItem.ToString().ToUpper()));
                            if (resultOfEditing == -1 ) 
                            {
                                XtraMessageBox.Show("کد ملی جدید معتبر نیست،کاربر دیگری با این کد ملی وجود دارد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               
                            }
                            if (resultOfEditing == -2)
                            {
                                XtraMessageBox.Show("خطای سیستمی", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                XtraMessageBox.Show("کاربر با موفقیت ویرایش گردید", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                            gbUserInfo.Visible = false;
                        }
                    }
                    catch (Exception ex) 
                    {
                        XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                           
            }
            gbUserInfo.Visible = false;
            txtNationCode.Enabled = true;
        }
    }
}