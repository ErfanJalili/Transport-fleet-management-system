using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_fleet_management_system.BL;

namespace Transport_fleet_management_system.Methods
{
    public class UserMethods
    {

        public List<GetUserWithRoleDto> GetUsers(IDbConnection db) 
        {

            string getUsersQuery = "SELECT dbo.tblRole.Name as RoleName, tblUser.Id , tblUser.Name  ,NationCode, Password , Image  , InsertDate FROM dbo.tblUserRole INNER JOIN dbo.tblUser ON tblUser.Id = tblUserRole.UserId INNER JOIN dbo.tblRole ON tblRole.Id = tblUserRole.RoleId";
            var result = db.Query<GetUserWithRoleDto>(getUsersQuery,

                commandType: CommandType.Text).ToList();

            return result;

        }

       

        public int AddUserMethod(IDbConnection db,User user) 
        {
            string insertQuery = @"INSERT INTO [dbo].[tblUser]([Name] , [NationCode], [InsertDate], [Image], [Password]) OUTPUT Inserted.Id VALUES (@Name, @NationCode, @InsertDate, @Image, @Password)";

            var result1 = db.QuerySingle<int>(insertQuery, new
            {

                Name = user.Name,
                NationCode = user.NationCode,
                InsertDate = user.InsertDate,
                Image = user.Image,
                Password = user.Password
            });

            if (result1 > 0 )
            {
                XtraMessageBox.Show("کاربر با موفقیت ثبت گردید", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result1 == 0)
            {
                XtraMessageBox.Show("اطلاعات وارد شده صحیح نمیباشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result1;
        }

        public void AddUserRole(IDbConnection db, int userId, object roleId)
        {
            string insertQuery = @"INSERT INTO [dbo].[tblUserRole]([UserId] , [RoleId]) OUTPUT Inserted.Id VALUES (@UserId, @RoleId)";

            var result1 = db.QuerySingle<int>(insertQuery, new
            {
                UserId = userId,
                RoleId = roleId,
            });
           
        }

        public int GetRoleId(IDbConnection db, string selectedValue)
        {
            string getRoleId = $"select Id from tblRole where NormalName ='{selectedValue}'";

            var result = db.QuerySingle<int>(getRoleId);

            return result;
        }

        public DeleteUserDto GetUserByNationCode(IDbConnection db, string NationCode)
        {
            string getUser = $"SELECT tblUser.Id, tblUser.Name ,tblRole.Name AS RoleName,NationCode ,Password,Image,InsertDate FROM tblUserRole INNER JOIN dbo.tblUser ON tblUser.Id = tblUserRole.UserId INNER JOIN dbo.tblRole ON tblRole.Id = tblUserRole.RoleId WHERE NationCode='{NationCode}'";

            var result = db.Query<DeleteUserDto>(getUser,

                commandType: CommandType.Text).SingleOrDefault();

            return result;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }

        public object DeleteUserByNationCode(IDbConnection db, string text)
        {
            string getUser = $"DELETE U OUTPUT Deleted.Id FROM dbo.tblUserRole AS UR JOIN dbo.tblUser AS U ON UR.UserId = U.Id  WHERE U.NationCode ='{text}'";

            var result = db.Query<int>(getUser,

                commandType: CommandType.Text).FirstOrDefault();

            return result;
        }
        public int UpdateAndSaveChanges(IDbConnection db,string oldNationCode, string newName, string newNationCode, string newPassword, int newRoleId) 
        {
            string updateUser = $"UPDATE U SET U.Name=N'{newName}', U.NationCode=N'{newNationCode}', U.Password=N'{newPassword}' OUTPUT deleted.Id FROM dbo.tblUser AS U INNER JOIN dbo.tblUserRole AS UR  ON UR.UserId = U.Id WHERE U.NationCode = '{oldNationCode}' ";

            var result = db.Query<int>(updateUser,

                commandType: CommandType.Text).FirstOrDefault();

            string updateUserRole = $"UPDATE UR SET UR.RoleId={newRoleId} FROM dbo.tblUserRole AS UR INNER JOIN dbo.tblUser AS U ON U.Id = UR.UserId WHERE U.Id='{result}' ";
            db.Query(updateUserRole, commandType: CommandType.Text);
            return result;
        }

        public int UpdateUserByNationCode(IDbConnection db, string oldNationCode, string newName,string newNationCode,string newPassword,int newRoleId )
        {
            var userExist= GetUserByNationCode(db, newNationCode);


            if (userExist != null)
            {
                if (oldNationCode == newNationCode) 
                {
                    return UpdateAndSaveChanges(db, oldNationCode, newName, newNationCode, newPassword, newRoleId);

                }
                else if (userExist.NationCode != newNationCode) 
                {
                    return UpdateAndSaveChanges(db, oldNationCode,  newName,  newNationCode,  newPassword,newRoleId);
                }
                return -1;
            }
            else if ( userExist ==null) 
            {
                return UpdateAndSaveChanges(db, oldNationCode, newName, newNationCode, newPassword, newRoleId);
            }
            else
            return -2;
        }
    }
}
