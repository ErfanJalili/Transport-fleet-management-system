using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_fleet_management_system.Methods;

namespace Transport_fleet_management_system
{
    public partial class DeleteUserFrm : DevExpress.XtraEditors.XtraForm
    {
        public DeleteUserFrm()
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
                            gbUserInfo.Visible = true;
                            lblNationCode.Text = result.NationCode;
                            lblUsername.Text = result.Name;
                            lblRole.Text = result.RoleName;
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا از حذف کاربر مطمئن هستید؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    try
                    {

                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            UserMethods methods = new UserMethods();
                            var removedUser = methods.DeleteUserByNationCode(db, txtNationCode.Text);
                            XtraMessageBox.Show($"{removedUser} با موفقیت حذف گردید", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbUserInfo.Visible = false;
                        }
                    }
                    catch (Exception ex) {
                        XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                            
                
            }
            
        }
    }
}