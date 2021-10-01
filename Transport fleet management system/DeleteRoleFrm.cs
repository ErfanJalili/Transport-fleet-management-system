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
using Transport_fleet_management_system.BL;
using Transport_fleet_management_system.Methods;

namespace Transport_fleet_management_system
{
    public partial class DeleteRoleFrm : DevExpress.XtraEditors.XtraForm
    {
        public DeleteRoleFrm()
        {
            InitializeComponent();
        }

        private void DeleteRoleFrm_Load(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {

                var methods = new RoleMethods();
              
                try
                {

                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        roleBindingSource.DataSource = methods.GetRoles(db);
                     }
                } catch (Exception ex) 
                {
                    XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var selectedRole= roleBindingSource.Current as Role;

            if (selectedRole != null)
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {

                    var methods = new RoleMethods();

                    try
                    {

                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            var result = methods.DeleteRoleById(db, selectedRole.Id);
                            XtraMessageBox.Show($"با موفقیت حذف گردید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            roleBindingSource.DataSource = methods.GetRoles(db);
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            else 
            {
             XtraMessageBox.Show($"یک مورد را انتخاب نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}