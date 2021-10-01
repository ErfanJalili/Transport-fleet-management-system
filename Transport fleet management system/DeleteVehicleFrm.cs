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
    public partial class DeleteVehicleFrm : DevExpress.XtraEditors.XtraForm
    {
        public DeleteVehicleFrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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

                            Car carInDb = methods.GetCarByPlate(txtPlateNumber.Text, txtPlateSerisNumber.Text);

                            if (carInDb != null)
                            {
                                groupBox1.Enabled = false;
                                simpleButton1.Enabled = false;
                                groupBox2.Visible = true;
                                labelX1.Text = carInDb.Name;
                                labelX4.Text = carInDb.ChassisNumber;
                                labelX5.Text = carInDb.PlateNumber;
                                labelX6.Text = carInDb.Color;
                                labelX7.Text = carInDb.CurrentMileage.ToString();
                                labelX8.Text = carInDb.CarCode;
                                labelX11.Text = carInDb.EngineNumber;
                                labelX12.Text = carInDb.PlateSeriesNumber;
                                labelX14.Text = carInDb.Created_Year;


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
            } catch (Exception ex) 
            {
                                XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();

                        VehicleMethods methods = new VehicleMethods(db);
                        Car carInDb = methods.GetCarByPlate(txtPlateNumber.Text, txtPlateSerisNumber.Text);



                        var result = methods.DeleteVehicle(carInDb);


                        XtraMessageBox.Show($"خودر {carInDb.Name} حذف گردید", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        groupBox2.Visible = false;
                        groupBox1.Enabled = true;
                        simpleButton1.Enabled = true;




                    }
                }
            }
            catch (Exception ex) 
            {
                        XtraMessageBox.Show(ex.Message, "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Enabled = true;
            simpleButton1.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}