using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EF_Version.BLL
{
    internal class BLLAdmin
    {
        DAL.DBMain db = new DAL.DBMain();

        public List<Admin> GetAllAdmins(out string err)
        {
            try
            {
                string sql = "SELECT * FROM Admins";
                DataTable dt = db.ExecuteQuery(sql);
                List<Admin> admins = new List<Admin>();

                foreach (DataRow row in dt.Rows)
                {
                    admins.Add(new Admin
                    {
                        AdminID = Convert.ToInt32(row["AdminID"]),
                        FullName = row["FullName"].ToString()
                    });
                }

                err = string.Empty;
                return admins;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public Admin GetAdminById(int id, out string err)
        {
            try
            {
                string sql = "SELECT * FROM Admins WHERE AdminID = " + id;
                DataTable dt = db.ExecuteQuery(sql);

                if (dt.Rows.Count == 0)
                {
                    err = "Admin not found";
                    return null;
                }

                DataRow row = dt.Rows[0];
                Admin admin = new Admin
                {
                    AdminID = Convert.ToInt32(row["AdminID"]),
                    FullName = row["FullName"].ToString()
                };

                err = string.Empty;
                return admin;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }
    }
}