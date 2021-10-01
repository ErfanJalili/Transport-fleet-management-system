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
    public partial class ManageUserFrm : DevExpress.XtraEditors.XtraForm
    {
        public ManageUserFrm()
        {
            InitializeComponent();
        }

        private void ManageUserFrm_Load(object sender, EventArgs e)
        {
           
            UserMethods methods = new UserMethods();
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                try
                {

                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                        var users = methods.GetUsers(db);
                        getUserWithRoleDtoBindingSource.DataSource = users;
                    }
                }
                catch(Exception ex) 
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }
    }
}