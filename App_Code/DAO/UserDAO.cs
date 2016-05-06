using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

using HourseRentSystem.DB;

/// <summary>
/// UserDAO 的摘要说明
/// </summary>
/// 
namespace OABase
{
    public class UserDAO
    {
        public UserDAO()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        public void InsertIntoUser(string UserName,string Password,string Name,string Department,string JobTitle,string PhoneNumber)
        {
            DataBase db = new DataBase();
            StringBuilder sqlB = new StringBuilder();

            sqlB.Length = 0;
            sqlB.AppendLine("INSERT INTO `Users` (");
            sqlB.AppendLine("`UserID`                ");
            sqlB.AppendLine(",`Name`                 ");
            sqlB.AppendLine(",`UserName`             ");
            sqlB.AppendLine(",`RoleID`               ");
            sqlB.AppendLine(",`LocationID`           ");
            sqlB.AppendLine(",`Language`             ");
            sqlB.AppendLine(",`Email`                ");
            sqlB.AppendLine(",`Phone`                ");
            sqlB.AppendLine(",`Mobile`               ");
            sqlB.AppendLine(",`Fax`                  ");
            sqlB.AppendLine(",`Department`           ");
            sqlB.AppendLine(",`JobTitle`             ");
            sqlB.AppendLine(",`EmployeeNum`          ");
            sqlB.AppendLine(",`StartDate`            ");
            sqlB.AppendLine(",`City`                 ");
            sqlB.AppendLine(",`Password`             ");
            sqlB.AppendLine(",`PasswordExpireDate`   ");
            sqlB.AppendLine(",`LogonFailureCount`    ");
            sqlB.AppendLine(",`Profile`              ");
            sqlB.AppendLine(",`TimeUpdated`          ");
            sqlB.AppendLine(",`UpdatedBy`            ");
            sqlB.AppendLine(",`TimeCreated`          ");
            sqlB.AppendLine(",`CreatedBy`            ");
            sqlB.AppendLine(")                         ");
            sqlB.AppendLine("VALUES                    ");
            sqlB.AppendLine("(                         ");
            sqlB.AppendLine("default                        ");
            sqlB.AppendLine(",'" + Name + "'");
            sqlB.AppendLine(",'" + UserName + "'");
            sqlB.AppendLine(",1                        ");
            sqlB.AppendLine(",1                        ");
            sqlB.AppendLine(",'cn'                     ");
            sqlB.AppendLine(",'yukun@encom8.com'       ");
            sqlB.AppendLine(",'" + PhoneNumber + "'");
            sqlB.AppendLine(",'" + PhoneNumber + "'");
            sqlB.AppendLine(",'03228989977'            ");
            sqlB.AppendLine(",'" + Department + "'");
            sqlB.AppendLine(",'" + JobTitle + "'");
            sqlB.AppendLine(",'T201605050001'          ");
            sqlB.AppendLine(",now()                    ");
            sqlB.AppendLine(",'石家庄'                 ");
            sqlB.AppendLine(",'" + Password + "'");
            sqlB.AppendLine(",'2017-01-01'             ");
            sqlB.AppendLine(",0                        ");
            sqlB.AppendLine(",'I like Computer Scince' ");
            sqlB.AppendLine(",now()                    ");
            sqlB.AppendLine(",'yukun'                  ");
            sqlB.AppendLine(",now()                    ");
            sqlB.AppendLine(",'yukun'                  ");
            sqlB.AppendLine(")                         ");
            sqlB.AppendLine(";                         ");

            //db.ExecuteSQL(sqlB.ToString().Split(';'));
            try
            {
                db.InsertOrUpdate(sqlB.ToString());

            }
            catch (Exception myException)
            {
                throw new Exception("execute sql failed"+ myException);
            }
        }
    }

}
