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
    public partial class UserControlFrm : DevExpress.XtraEditors.XtraForm
    {
        public UserControlFrm()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

       

        private void UserControlFrm_Load_1(object sender, EventArgs e)
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
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            new DeleteRoleFrm().ShowDialog();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            new AddRoleFrm().ShowDialog();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            new EditUserFrm().ShowDialog();

        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            new DeleteUserFrm().ShowDialog();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            new AddUserFrm().ShowDialog();
        }
    }
}