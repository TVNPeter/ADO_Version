using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EF_Version.BLL
{
    internal class BLLSecretary
    {
        DAL.DBMain db = new DAL.DBMain();

        public bool Add(Secretary s, out string err, out int newId)
        {
            try
            {
                string sql = "INSERT INTO Secretaries (FullName, Phone, IsDeleted) VALUES ('" + s.FullName + "', '" + s.Phone + "', 0); SELECT SCOPE_IDENTITY();";
                DataTable dt = db.ExecuteQuery(sql);
                newId = Convert.ToInt32(dt.Rows[0][0]);
                err = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                newId = 0;
                return false;
            }
        }

        public bool Update(Secretary s, out string err)
        {
            try
            {
                err = string.Empty;
                string sql = "UPDATE Secretaries SET FullName = '" + s.FullName + "', Phone = '" + s.Phone + "' WHERE SecretaryID = " + s.SecretaryID;
                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool Delete(int id, out string err)
        {
            try
            {
                err = string.Empty;
                string sql = "UPDATE Secretaries SET IsDeleted = 1 WHERE SecretaryID = " + id;
                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public List<Secretary> GetAll(out string err)
        {
            try
            {
                string sql = "SELECT * FROM Secretaries WHERE IsDeleted = 0";
                DataTable dt = db.ExecuteQuery(sql);
                List<Secretary> secretaries = new List<Secretary>();

                foreach (DataRow row in dt.Rows)
                {
                    secretaries.Add(new Secretary
                    {
                        SecretaryID = Convert.ToInt32(row["SecretaryID"]),
                        FullName = row["FullName"].ToString(),
                        Phone = row["Phone"].ToString(),
                        IsDeleted = Convert.ToBoolean(row["IsDeleted"])
                    });
                }

                err = string.Empty;
                return secretaries;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Secretary>();
            }
        }

        public Secretary GetById(int id, out string err)
        {
            try
            {
                string sql = "SELECT * FROM Secretaries WHERE SecretaryID = " + id + " AND IsDeleted = 0";
                DataTable dt = db.ExecuteQuery(sql);

                if (dt.Rows.Count == 0)
                {
                    err = "Secretary not found";
                    return null;
                }

                DataRow row = dt.Rows[0];
                Secretary secretary = new Secretary
                {
                    SecretaryID = Convert.ToInt32(row["SecretaryID"]),
                    FullName = row["FullName"].ToString(),
                    Phone = row["Phone"].ToString(),
                    IsDeleted = Convert.ToBoolean(row["IsDeleted"])
                };

                err = string.Empty;
                return secretary;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public List<Secretary> GetByName(string name, out string err)
        {
            try
            {
                string sql = "SELECT * FROM Secretaries WHERE FullName LIKE '%" + name + "%' AND IsDeleted = 0";
                DataTable dt = db.ExecuteQuery(sql);
                List<Secretary> secretaries = new List<Secretary>();

                foreach (DataRow row in dt.Rows)
                {
                    secretaries.Add(new Secretary
                    {
                        SecretaryID = Convert.ToInt32(row["SecretaryID"]),
                        FullName = row["FullName"].ToString(),
                        Phone = row["Phone"].ToString(),
                        IsDeleted = Convert.ToBoolean(row["IsDeleted"])
                    });
                }

                err = string.Empty;
                return secretaries;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Secretary>();
            }
        }
    }
}