using Dapper;
using DevComponents.Editors.DateTimeAdv;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_fleet_management_system.BL;
using Transport_fleet_management_system.Methods;

namespace Transport_fleet_management_system
{
    public partial class AddVehicleFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddVehicleFrm()
        {

            InitializeComponent();


        }



        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();

            pictureEdit1.Image = new Bitmap(op.FileName);
            Bitmap b = (Bitmap)pictureEdit1.Image;
        }

        private void AddVehicleFrm_Load_1(object sender, EventArgs e)
        {

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
                    //foreach (CarBrand item in carBrands)
                    //{
                    //    cbCarBrand.Items.Add(item.Name);
                    //    cbCarBrand.AutoCompleteCustomSource.Add(item.Name);
                    //}
                    //foreach (CarFuelType item in carFuelTypes)
                    //{
                    //    cbCarFuel.Items.Add(item.Name);
                    //    cbCarFuel.AutoCompleteCustomSource.Add(item.Name);
                    //} 
                    //foreach (CarType item in carTypes)
                    //{
                    //    cbCarType.Items.Add(item.Name);
                    //    cbCarType.AutoCompleteCustomSource.Add(item.Name);
                    //}
                    // foreach (CarBarrackCategory item in carBarrachCategory)
                    //{
                    //    cbBrrackCategory.Items.Add(item.Name);
                    //    cbBrrackCategory.AutoCompleteCustomSource.Add(item.Name);
                    //}
                    //foreach (CarStatus item in carStatuses)
                    //{
                    //    cbCarStatus.Items.Add(item.StatusName);
                    //    cbCarStatus.AutoCompleteCustomSource.Add(item.StatusName);
                    //}

                }
            }

        }

        private void labelX12_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                CarImage.Image = new Bitmap(op.FileName);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                    VehicleMethods methods = new VehicleMethods(db);

                    var vehicle = methods.GetCarByPlate(txtCarPlate.Text,txtCarPlateSeries.Text);

                    if (vehicle != null)
                    {
                        MessageBox.Show("این پلاک برای خودروی " + vehicle.Name +  " ثبت شده است ");
                    }
                    else 
                    {

                        byte[] arrPic = null;
                        if (CarImage.Image != null)
                        {
                            Bitmap bitmap = (Bitmap)CarImage.Image;
                            arrPic = methods.ConvertImageToByteArray(bitmap);

                        }
                        else 
                        {
                            arrPic = null;
                        }
                        Car newCar = new Car()
                        {
                            Name = txtCarName.Text,
                            VehicletypeId = Convert.ToInt32(cbCarType.SelectedValue),
                            FuelTypeId = Convert.ToInt32(cbCarFuel.SelectedValue),
                            BarrackCategoryId = Convert.ToInt32(cbBrrackCategory.SelectedValue),
                            VehicleBrandId = Convert.ToInt32(cbCarBrand.SelectedValue),
                            VehicleStatusId = Convert.ToInt32(cbCarStatus.SelectedValue),
                            CarCode = txtCarCode.Text,
                            ChassisNumber = txtCarChassie.Text,
                            Color = txtCarColor.Text,
                            Created_At = DateTime.Now,
                            Created_Year = txtCarYear.Text,
                            EngineNumber = txtCarEngineNum.Text,
                            PlateNumber = txtCarPlate.Text,
                            PlateSeriesNumber = txtCarPlateSeries.Text,
                            Updated_At = null,
                            Image = arrPic,
                            CurrentMileage=Convert.ToInt32( txtCurrentMileage.Text)
                        };
                        var insertVehicle= methods.InsertVehicle(newCar);

                        if (insertVehicle < 0)
                        {
                            XtraMessageBox.Show("خطای ثبتی رخ داده است");
                        }
                        else if(insertVehicle > 0)
                        {
                            XtraMessageBox.Show("خودرو با موفقیت ثبت گردید", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }
            }
        }

        private void gb2_Enter(object sender, EventArgs e)
        {

        }
    }
}