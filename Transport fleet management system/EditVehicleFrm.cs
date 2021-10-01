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
    public partial class EditVehicleFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditVehicleFrm()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
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
                                CarImage.Image = methods.ConvertByteArrayToImage(carInDb.Image);
                                gb2.Visible = true;
                                txtCarName.Text = carInDb.Name;
                                txtCarChassie.Text = carInDb.ChassisNumber;
                                txtCarPlate.Text = carInDb.PlateNumber;
                                txtCarColor.Text = carInDb.Color;
                                txtCurrentMileage.Text = carInDb.CurrentMileage.ToString();
                                txtCarCode.Text = carInDb.CarCode;
                                txtCarEngineNum.Text = carInDb.EngineNumber;
                                txtCarPlateSeries.Text = carInDb.PlateSeriesNumber;
                                txtCarYear.Text = carInDb.Created_Year;
                                cbBrrackCategory.SelectedValue = carInDb.BarrackCategoryId;
                                cbCarBrand.SelectedValue = carInDb.VehicleBrandId;
                                cbCarFuel.SelectedValue = carInDb.FuelTypeId;
                                cbCarStatus.SelectedValue = carInDb.VehicleStatusId;
                                cbCarType.SelectedValue = carInDb.VehicletypeId;


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

        private void EditVehicleFrm_Load(object sender, EventArgs e)
        {
            gb2.Visible = false;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                {
                    db.Open();

                    VehicleMethods methods = new VehicleMethods(db);

                    var carBrands = methods.GetCarBrands();
                    var carFuelTypes = methods.GetCarFuleTypes();
                    var carTypes = methods.GetCarTypes();
                    var carBarrachCategory = methods.GetCarBarrackCategories();
                    var carStatuses = methods.GetCarStatus();

                    cbCarBrand.DataSource = new BindingSource(carBrands, null);
                    cbCarBrand.DisplayMember = "Name";
                    cbCarBrand.ValueMember = "Id";


                    cbCarFuel.DataSource = new BindingSource(carFuelTypes, null);
                    cbCarFuel.DisplayMember = "Name";
                    cbCarFuel.ValueMember = "Id";

                    cbCarType.DataSource = new BindingSource(carTypes, null);
                    cbCarType.DisplayMember = "Name";
                    cbCarType.ValueMember = "Id";

                    cbBrrackCategory.DataSource = new BindingSource(carBarrachCategory, null);
                    cbBrrackCategory.DisplayMember = "Name";
                    cbBrrackCategory.ValueMember = "Id";

                    cbCarStatus.DataSource = new BindingSource(carStatuses, null);
                    cbCarStatus.DisplayMember = "StatusName";
                    cbCarStatus.ValueMember = "Id";


                }
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

                    carInDb.Name = txtCarName.Text;
                    carInDb.VehicletypeId = Convert.ToInt32(cbCarType.SelectedValue);
                    carInDb.FuelTypeId = Convert.ToInt32(cbCarFuel.SelectedValue);
                    carInDb.BarrackCategoryId = Convert.ToInt32(cbBrrackCategory.SelectedValue);
                    carInDb.VehicleBrandId = Convert.ToInt32(cbCarBrand.SelectedValue);
                    carInDb.VehicleStatusId = Convert.ToInt32(cbCarStatus.SelectedValue);
                    carInDb.CarCode = txtCarCode.Text;
                    carInDb.ChassisNumber = txtCarChassie.Text;
                    carInDb.Color = txtCarColor.Text;
                    carInDb.Created_At = DateTime.Now;
                    carInDb.Created_Year = txtCarYear.Text;
                    carInDb.EngineNumber = txtCarEngineNum.Text;
                    carInDb.PlateNumber = txtCarPlate.Text;
                    carInDb.PlateSeriesNumber = txtCarPlateSeries.Text;
                    carInDb.Updated_At = DateTime.Now;
                    carInDb.CurrentMileage = Convert.ToInt32(txtCurrentMileage.Text);


                   var result = methods.UpdateVehicle(carInDb);

                    if (result == "updated")
                    { 
                        XtraMessageBox.Show($"خودروی {carInDb.Name} ویرایش گردید", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    gb2.Visible = false;
                    groupBox1.Enabled = true;
                    simpleButton3.Enabled = true;




                }
            }
        }
            catch (Exception ex) 
            {
                        XtraMessageBox.Show(ex.Message, "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gb2.Visible = false;
            groupBox1.Enabled = true;
            simpleButton3.Enabled = true;
        }
    }
}