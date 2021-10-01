using DevExpress.XtraBars;
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
using System.Windows.Forms;
using Transport_fleet_management_system.Methods;

namespace Transport_fleet_management_system
{
    public partial class AdminFrm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public AdminFrm()
        {
            InitializeComponent();
            
        }

        private void MTI_Add_User_Click(object sender, EventArgs e)
        {
            new AddUserFrm().ShowDialog();

        }

        private void MTI_Delete_User_Click(object sender, EventArgs e)
        {
            new DeleteUserFrm().ShowDialog();
        }

        private void MTI_Edit_User_Click(object sender, EventArgs e)
        {
            new EditUserFrm().ShowDialog();
        }

        private void MTI_Search_User_Click(object sender, EventArgs e)
        {
            new ManageUserFrm().ShowDialog();
        }

        private void MTI_Add_Vehicle_Click(object sender, EventArgs e)
        {
            new AddVehicleFrm().ShowDialog();
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            new ManageUserFrm().ShowDialog();
        }

        private void metroTileItem1_Click_1(object sender, EventArgs e)
        {
            new UserControlFrm().ShowDialog();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            new UserControlFrm().ShowDialog();
        }

        private void AdminFrm_Load(object sender, EventArgs e)
        {
            //UserMethods methods = new UserMethods();
            //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            //{
            //    try
            //    {

            //        if (db.State == ConnectionState.Closed)
            //        {
            //            db.Open();
            //            var users = methods.GetUsers(db);
            //            getUserWithRoleDtoBindingSource.DataSource = users;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void MTI_Delete_Vehicle_Click(object sender, EventArgs e)
        {
            new DeleteVehicleFrm().ShowDialog();
        }

        private void MTI_Edit_Vehicle_Click(object sender, EventArgs e)
        {
            new EditVehicleFrm().ShowDialog();
        }

        private void MTLI_Add_Fuel_Sheet_Click(object sender, EventArgs e)
        {
            new AddFuelFrm().ShowDialog();
        }

        private void metroTilePanel1_ItemClick(object sender, EventArgs e)
        {
           
        }

        private void MTLI_Edit_Fuel_Sheet_Click(object sender, EventArgs e)
        {
            new EditFuelsFrm().ShowDialog();
        }
    }
}
