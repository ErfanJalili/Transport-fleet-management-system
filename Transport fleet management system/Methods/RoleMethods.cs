using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_fleet_management_system.BL;

namespace Transport_fleet_management_system.Methods
{
     public class RoleMethods
    {
        public List<Role> GetRoles(IDbConnection db) 
        {

            string getUsersQuery = "SELECT * FROM dbo.tblRole";
            var result = db.Query<Role>(getUsersQuery,

                commandType: CommandType.Text).ToList();

            return result;
        }

        public int AddRoleMethod(IDbConnection db, Role user)
        {
            string insertQuery = @"INSERT INTO [dbo].[tblRole]([Name] , [NormalName]) OUTPUT Inserted.Id VALUES (@Name, @NormalName)";

            var result1 = db.QuerySingle<int>(insertQuery, new
            {

                Name = user.Name,
                NormalName = user.NormalName.ToUpper(),

            }) ;

            if (result1 > 0)
            {
                XtraMessageBox.Show("نقش با موفقیت ثبت گردید", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result1 == 0)
            {
                XtraMessageBox.Show("اطلاعات وارد شده صحیح نمیباشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result1;
        }

        public object DeleteRoleById(IDbConnection db, int id)
        {

            var data =  DeleteUsersByRoleId(db, id);

            string deleteRole = $"DELETE R OUTPUT Deleted.Id FROM dbo.tblRole AS R WHERE R.Id = {id}";

            var result = db.Query<int>(deleteRole,

                commandType: CommandType.Text).ToList();

            return result;
        }

        public object DeleteUsersByRoleId(IDbConnection db, int id)
        {

            string deleteUsersWithRole = $"DELETE U OUTPUT Deleted.Id FROM dbo.tblUserRole  AS UR JOIN dbo.tblUser AS U ON U.Id = UR.UserId WHERE UR.RoleId = {id} ";

            var result = db.Query<int>(deleteUsersWithRole,

                commandType: CommandType.Text).ToList();

            

            return result;
        }

        public bool IsRoleExist(IDbConnection db, string normalName)
        {
            string query = $" SELECT  Name FROM  dbo.tblRole WHERE NormalName='{normalName}'";
            var result = db.Query<string>(query, commandType: CommandType.Text);

            if (result.Count() > 0)
            {
                XtraMessageBox.Show("این نقش موجود می باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        public object UpdateRoleById(IDbConnection db, int id, Role newRole)
        {
            string updateUser = $"UPDATE U SET U.Name=N'{newRole.Name}', U.NormalName=N'{newRole.NormalName}' OUTPUT deleted.Id FROM dbo.tblRole AS U INNER JOIN dbo.tblUserRole AS UR  ON UR.RoleId = U.Id WHERE U.Id = '{id}' ";

            var result = db.Query<int>(updateUser,

                commandType: CommandType.Text).FirstOrDefault();

            return result;
        }
    }
}
