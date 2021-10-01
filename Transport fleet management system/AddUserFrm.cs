using Dapper;
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
    public partial class AddUserFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddUserFrm()
        {
            InitializeComponent();
        }

        private void AddUserFrm_Load(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                {
                    db.Open();


                    string query = $" SELECT * FROM  tblRole";
                    var result = db.Query<Role>(query, commandType: CommandType.Text).ToList();

                    foreach (Role item in result)
                    {
                        cbRole.Items.Add(item.Name);
                    }
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CultureInfo persianCulture = new CultureInfo("fa-IR");


            if (txtNationCode.Text == null || txtNationCode.Text == String.Empty)
            {
                XtraMessageBox.Show("کد ملی را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (tctUserName.Text == null || tctUserName.Text == String.Empty)
            {
                XtraMessageBox.Show("نام کاربر را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    try
                    {

                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            string query = $" SELECT  NationCode FROM  dbo.tblUser WHERE NationCode='{txtNationCode.Text}'";
                            var result = db.Query<string>(query, commandType: CommandType.Text);

                            if (result.Count() > 0)
                            {
                                XtraMessageBox.Show("این کاربر موجود می باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                UserMethods methods = new UserMethods();
                                User user = new User()
                                {
                                    NationCode = txtNationCode.Text,
                                    Name = tctUserName.Text,
                                    InsertDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"), persianCulture),
                                    Image = null,
                                    Password = txtNationCode.Text
                                };

                                if (pictureEdit1.Image != null)
                                {

                                    Bitmap b = (Bitmap)pictureEdit1.Image;

                                    MemoryStream ms = new MemoryStream();
                                    b.Save(ms, b.RawFormat);
                                    byte[] arrPic = ms.GetBuffer();
                                    ms.Close();
                                    user.Image = arrPic;

                                }
                                try
                                {
                                    if (db.State == ConnectionState.Closed)
                                    {
                                        db.Open();

                                        var userId = methods.AddUserMethod(db, user);
                                        var roleId = methods.GetRoleId(db, cbRole.SelectedItem.ToString().ToUpper());
                                        methods.AddUserRole(db, userId, roleId);

                                    }
                                    else if (db.State == ConnectionState.Open)
                                    {
                                        var userId = methods.AddUserMethod(db, user);
                                        var roleId = methods.GetRoleId(db, cbRole.SelectedItem.ToString().ToUpper());

                                        methods.AddUserRole(db, userId, roleId);
                                    }
                                }
                                catch (Exception ex)
                                {

                                    XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }


                            }
                            db.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            pictureEdit1.Image = new Bitmap(op.FileName);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                pictureEdit1.Image = new Bitmap(op.FileName);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CultureInfo persianCulture = new CultureInfo("fa-IR");


            if (txtNationCode.Text == null || txtNationCode.Text == String.Empty)
            {
                XtraMessageBox.Show("کد ملی را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (tctUserName.Text == null || tctUserName.Text == String.Empty)
            {
                XtraMessageBox.Show("نام کاربر را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbRole.SelectedItem == null )
            {
                XtraMessageBox.Show("نقش کاربر را وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    try
                    {

                        if (db.State == ConnectionState.Closed)
                        {
                            db.Open();
                            string query = $" SELECT  NationCode FROM  dbo.tblUser WHERE NationCode='{txtNationCode.Text}'";
                            var result = db.Query<string>(query, commandType: CommandType.Text);

                            if (result.Count() > 0)
                            {
                                XtraMessageBox.Show("این کاربر موجود می باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                UserMethods methods = new UserMethods();
                                User user = new User()
                                {
                                    NationCode = txtNationCode.Text,
                                    Name = tctUserName.Text,
                                    InsertDate = DateTime.Parse(DateTime.Now.ToShortDateString(), persianCulture),
                                    Image = null,
                                    Password = txtNationCode.Text
                                };

                                if (pictureEdit1.Image != null)
                                {

                                    Bitmap b = (Bitmap)pictureEdit1.Image;

                                    MemoryStream ms = new MemoryStream();
                                    b.Save(ms, b.RawFormat);
                                    byte[] arrPic = ms.GetBuffer();
                                    ms.Close();
                                    user.Image = arrPic;

                                }
                                try
                                {
                                    if (db.State == ConnectionState.Closed)
                                    {
                                        db.Open();

                                        var userId = methods.AddUserMethod(db, user);


                                    }
                                    else if (db.State == ConnectionState.Open)
                                    {
                                        var userId = methods.AddUserMethod(db, user);
                                        var roleId = methods.GetRoleId(db, cbRole.SelectedItem.ToString().ToUpper());

                                        methods.AddUserRole(db, userId, roleId);
                                    }
                                }
                                catch (Exception ex)
                                {

                                    XtraMessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                                db.Close();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}

