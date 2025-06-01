using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EF_Version.BLL
{
    internal class BLLAccount
    {
        DAL.DBMain db = new DAL.DBMain();

        public Account GetAccountByUsername(string username, out string err)
        {
            try
            {
                string sql = "SELECT * FROM Accounts WHERE Username = '" + username + "' AND IsDeleted = 0";
                DataTable dt = db.ExecuteQuery(sql);

                if (dt.Rows.Count == 0)
                {
                    err = "Username not found";
                    return null;
                }

                DataRow row = dt.Rows[0];
                Account account = new Account
                {
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString(),
                    UserId = Convert.ToInt32(row["UserId"]),
                    IsDeleted = Convert.ToBoolean(row["IsDeleted"])
                };

                err = string.Empty;
                return account;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public bool AddAccount(Account account, out string err)
        {
            try
            {
                err = string.Empty;
                string hashedPassword = PasswordHelper.HashPassword(account.Password);
                string sql = "INSERT INTO Accounts (Username, Password, Role, UserId, IsDeleted) VALUES ('"
                    + account.Username + "', '"
                    + hashedPassword + "', '"
                    + account.Role + "', "
                    + account.UserId + ", 0)";

                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool ChangePassword(Account account, out string err)
        {
            try
            {
                err = string.Empty;
                string hashedPassword = PasswordHelper.HashPassword(account.Password);
                string sql = "UPDATE Accounts SET Password = '" + hashedPassword +
                    "' WHERE Username = '" + account.Username + "'";

                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool DeleteAccount(string username, out string err)
        {
            try
            {
                err = string.Empty;
                string sql = "UPDATE Accounts SET IsDeleted = 1 WHERE Username = '" + username + "'";
                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}