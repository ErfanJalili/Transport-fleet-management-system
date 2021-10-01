using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Dapper;

namespace Transport_fleet_management_system
{
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        public static string cn = "Transport_fleet_management_system.Properties.Settings.TransportFleetMnagementDbConnectionString";
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {

                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();


                        string query = $" SELECT  NormalName FROM  dbo.tblUser INNER JOIN dbo.tblUserRole ON tblUserRole.UserId = tblUser.Id INNER JOIN dbo.tblRole ON tblRole.Id = tblUserRole.RoleId WHERE NationCode = '{txtUsername.Text}' AND Password = '{txtPassword.Text}'";
                        var result = db.Query<string>(query, commandType: CommandType.Text);

                        if (result.Count() != 0)
                        {
                            if (result.First() == "ADMIN")
                            {
                                txtUsername.Text = null;
                                txtPassword.Text = null;
                                new AdminFrm().ShowDialog();
                            }
                            else if(result.First()=="USER")
                            {
                                txtUsername.Text = null;
                                txtPassword.Text = null;
                                new UserFrm().ShowDialog();
                            }

                        }
                        else if(result.Count() == 0)
                        {
                            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                            args.Caption = "کاربر یافت نشد";
                            args.Text = "نام کاربری یا رمز عبور اشتباه میباشد.";
                            args.Buttons = new DialogResult[] {  DialogResult.OK };
                            args.Showing += Args_Showing;
                            XtraMessageBox.Show(args).ToString();

                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            foreach (var control in e.Form.Controls)
            {
                SimpleButton button = control as SimpleButton;
                if (button != null)
                {
                    button.ImageOptions.SvgImageSize = new Size(16, 16);
                    //button.Height = 25;
                    switch (button.DialogResult.ToString())
                    {
                        case ("OK"):
                            
                            break;
                        case ("Cancel"):
                            
                            break;
                        case ("Retry"):
                           
                            break;
                    }
                }
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}