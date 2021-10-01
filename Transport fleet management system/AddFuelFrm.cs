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
    public partial class AddFuelFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddFuelFrm()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            txtVehicleId.Text = String.Empty;
            txtLiter.Text = String.Empty;
            txtPriceOfEachLiter.Text = String.Empty;
            txtRegiserar.Text = String.Empty;
            txtYear.Text = String.Empty;
            txtMonth.Text = String.Empty;
            txtDay.Text = String.Empty;
            txtFactorNum.Text = String.Empty;
            txtCurrentMileage.Text = String.Empty;
            txtCarFunction.Text = String.Empty;
            txtFuelAVG.Text = String.Empty;
            txtPrice.Text = String.Empty;
            groupBox1.Enabled = true;
            simpleButton1.Enabled = true;
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

                            CarDto carInDb = methods.GetCarByPlateWithDependency(txtPlateNumber.Text, txtPlateSerisNumber.Text);

                            if (carInDb != null)
                            {
                                groupBox1.Enabled = false;
                                simpleButton1.Enabled = false;
                                groupBox2.Visible = true;
                                if (carInDb.VehicleStatus == "سالم")
                                {
                                    groupBox3.Visible = true;
                                }
                                else 
                                {
                                    groupBox3.Visible = false;
                                }
                                

                                labelX1.Text = carInDb.VehicleName;
                                labelX4.Text = carInDb.ChassisNumber;
                                labelX5.Text = carInDb.PlateNumber;
                                labelX6.Text = carInDb.Color;
                                labelX7.Text = carInDb.CurrentMileage.ToString();
                                labelX8.Text = carInDb.CarCode;
                                labelX11.Text = carInDb.EngineNumber;
                                labelX12.Text = carInDb.PlateSeriesNumber;
                                labelX14.Text = carInDb.Created_Year;
                                labelX25.Text = carInDb.VehicleStatus;
                                labelX23.Text = carInDb.VehicleBrandName;
                                labelX22.Text = carInDb.BarrackCategory;
                                labelX29.Text = carInDb.FuelTypeName;
                                if (carInDb.Image != null) 
                                {
                                    pictureBox1.Image = methods.ConvertByteArrayToImage(carInDb.Image);
                                }

                                txtLastMileage.Enabled = false;
                                txtLastMileage.Text = carInDb.CurrentMileage.ToString();

                                txtVehicleId.Enabled = false;
                                txtVehicleId.Text = carInDb.Id.ToString();

                                txtLiter.Enabled = false;
                                txtPriceOfEachLiter.Enabled = false;
                                txtRegiserar.Enabled = false;
                                txtYear.Enabled = false;
                                txtMonth.Enabled = false;
                                txtDay.Enabled = false;
                                txtFactorNum.Enabled = false;
                                txtCurrentMileage.Enabled = true;
                                txtComment.Enabled = false;


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

        private void lblVehicleId_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrentMileage_TextChanged(object sender, EventArgs e)
        {
            if (txtCurrentMileage.Text != String.Empty && txtLastMileage.Text != String.Empty)
            {
                txtCarFunction.Text = (Convert.ToInt32(txtCurrentMileage.Text) - Convert.ToInt32(txtLastMileage.Text)).ToString();

            }
        }

        private void txtLiter_TextChanged(object sender, EventArgs e)
        {
            if (txtLiter.Text != String.Empty && txtCarFunction.Text != String.Empty)
            {
                if (Convert.ToInt32(txtCarFunction.Text) != 0)
                {
                    txtFuelAVG.Text = (((Convert.ToInt32(txtLiter.Text) * 100) / Convert.ToInt32(txtCarFunction.Text))).ToString();

                }
                else 
                {
                XtraMessageBox.Show("مسافت طی شده نمی تواند مقدار 0 بگیرد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void txtPriceOfEachLiter_TextChanged(object sender, EventArgs e)
        {
            if (txtLiter.Text != String.Empty && txtPriceOfEachLiter.Text != String.Empty)
            {
                txtPrice.Text = (Convert.ToDecimal(txtPriceOfEachLiter.Text) * Convert.ToInt32(txtLiter.Text)).ToString("C0", System.Globalization.CultureInfo.CreateSpecificCulture("fa-ir"));

            }
        }

        private void txtCurrentMileage_Leave(object sender, EventArgs e)
        {
           
                txtCurrentMileage.Enabled = false;
                txtLiter.Enabled = true;

           
        }

        private void txtLiter_Leave(object sender, EventArgs e)
        {
            txtLiter.Enabled = false;
            txtPriceOfEachLiter.Enabled = true;
        }

        private void txtPriceOfEachLiter_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == String.Empty)
            {
                XtraMessageBox.Show(" مبلغ نمیتواند خالی باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                txtPriceOfEachLiter.Enabled = false;
                txtComment.Enabled = true;
                txtRegiserar.Enabled = true;
                txtYear.Enabled = true;
                txtMonth.Enabled = true;
                txtDay.Enabled = true;
                txtFactorNum.Enabled = true;
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
                        }

                    VehicleMethods methods = new VehicleMethods(db);

                    Car carInDb = methods.GetCarByPlate(txtPlateNumber.Text, txtPlateSerisNumber.Text);
                    carInDb.CurrentMileage =Convert.ToInt32(txtCurrentMileage.Text);
                    carInDb.Updated_At = DateTime.Now;

                    

                    FuelMethods fuelMethods = new FuelMethods(db);
                    Fuel fuel = new Fuel
                        {
                     VehicleId=carInDb.Id,
                     Created_At=DateTime.Now,
                     Update_At=null,
                     LastMileage=carInDb.CurrentMileage,
                     CurrentMileage=Convert.ToInt32( txtCurrentMileage.Text),
                     CarFunction=Convert.ToInt32( txtCarFunction.Text),
                     ConsumptionLiters=Convert.ToInt32(txtFuelAVG.Text),
                     PriceOfEachLiter=txtPriceOfEachLiter.Text,
                     Price= txtPrice.Text,
                     RegistereName =txtRegiserar.Text,
                     Day=Convert.ToInt32(txtDay.Text),
                     Month=Convert.ToInt32(txtMonth.Text),
                     Year=Convert.ToInt32(txtYear.Text),
                     FuelTypeId=carInDb.FuelTypeId,
                     Comment=txtComment.Text,
                     Liter=float.Parse(txtLiter.Text),
                     FactorNumber=Convert.ToInt32(txtFactorNum.Text),
                    };

                    var mesaage= fuelMethods.InsertFuel(fuel);

                    if(mesaage != 0)
                    {
                        var result = methods.UpdateVehicle(carInDb);
                        XtraMessageBox.Show("سوخت ثبت گردید", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        groupBox3.Visible = false;
                        groupBox2.Visible = false;
                        txtVehicleId.Text = String.Empty;
                        txtLiter.Text = String.Empty;
                        txtPriceOfEachLiter.Text = String.Empty;
                        txtRegiserar.Text = String.Empty;
                        txtYear.Text = String.Empty;
                        txtMonth.Text = String.Empty;
                        txtDay.Text = String.Empty;
                        txtFactorNum.Text = String.Empty;
                        txtCurrentMileage.Text = String.Empty;
                        txtCarFunction.Text = String.Empty;
                        txtFuelAVG.Text = String.Empty;
                        txtPrice.Text = String.Empty;
                        groupBox1.Enabled = true;
                        simpleButton1.Enabled = true;
                    }
                  


                }
            } catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        } 
    }
}