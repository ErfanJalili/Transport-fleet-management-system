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
    public partial class AddRoleFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddRoleFrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            if (txtNationCode.Text == null || txtNationCode.Text == String.Empty)
            {
                XtraMessageBox.Show("نقش را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {

                    var methods = new RoleMethods();
                    var role = new BL.Role()
                    {
                        Name = txtNationCode.Text,
                        NormalName = txtNationCode.Text.ToUpper()
                    };
                    try
                    {

                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            var checkRoleExsist = methods.IsRoleExist(db, role.NormalName);
                            if (checkRoleExsist == false)
                            {
                                var result = methods.AddRoleMethod(db, role);

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
        }
    }
}