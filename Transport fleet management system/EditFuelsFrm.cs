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
    public partial class EditFuelsFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditFuelsFrm()
        {
            InitializeComponent();
        }

        private void EditFuelsFrm_Load(object sender, EventArgs e)
        {
           
           
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (txtPlateNumber.Text == String.Empty || txtPlateSerisNumber.Text == String.Empty)
                    {
                        XtraMessageBox.Show($"شماره پلاک را وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();

                            VehicleMethods methods = new VehicleMethods(db);
                            FuelMethods fuelMethods= new FuelMethods(db);

                            CarDto carInDb = methods.GetCarByPlateWithDependency(txtPlateNumber.Text, txtPlateSerisNumber.Text);

                            if (carInDb != null)
                            {
                                groupBox1.Enabled = false;
                                simpleButton1.Enabled = false;
                                groupBox2.Visible = true;
                                groupBox3.Visible = true;

                                fuelBindingSource.DataSource = fuelMethods.GetAllFuelByPlateOrderByFuelDate(carInDb.Id);

                            }
                            else if (carInDb == null)
                            {
                                XtraMessageBox.Show($"خودرو با پلاک {txtPlateNumber.Text} یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                XtraMessageBox.Show($"خودرو با پلاک {carInDb.PlateNumber} {carInDb.PlateSeriesNumber} یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var selectedItem = fuelBindingSource.Current as Fuel;
            if(selectedItem != null) 
            {
                txtCarFunction.Text = selectedItem.CarFunction.ToString();
                txtComment.Text = selectedItem.Comment.ToString();
                txtCurrentMileage.Text = selectedItem.CurrentMileage.ToString();
                txtDay.Text = selectedItem.Day.ToString();
                txtFactorNum.Text = selectedItem.FactorNumber.ToString();
                txtFuelAVG.Text = selectedItem.ConsumptionLiters.ToString();
                txtLastMileage.Text = selectedItem.LastMileage.ToString();
                txtLiter.Text = selectedItem.Liter.ToString();
                txtMonth.Text = selectedItem.Month.ToString();
                txtPrice.Text = selectedItem.Price.ToString();
               
                txtRegiserar.Text = selectedItem.RegistereName.ToString();
                txtVehicleId.Text = selectedItem.VehicleId.ToString();
                txtYear.Text = selectedItem.Year.ToString();
            }
           
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}