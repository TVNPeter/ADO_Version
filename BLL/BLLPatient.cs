using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using EF_Version.DAL;

namespace EF_Version.BLL
{
    internal class BLLPatient
    {
        private DBMain db = new DBMain();

        public bool Add(Patient p, out string err)
        {
            err = string.Empty;
            try
            {
                string birthDate = p.BirthDate.ToString("yyyy-MM-dd");
                string sql = $"INSERT INTO Patients (FullName, Gender, BirthDate, Address, Phone, IsDeleted) " +
                             $"VALUES ('{p.FullName}', '{p.Gender}', '{birthDate}', " +
                             $"'{p.Address}', '{p.Phone}', 0)";

                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (SqlException ex)
            {
                err = "Database error: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool Update(Patient p, out string err)
        {
            err = string.Empty;
            try
            {
                string birthDate = p.BirthDate.ToString("yyyy-MM-dd");
                string sql = $"UPDATE Patients SET " +
                             $"FullName = '{p.FullName}', " +
                             $"Gender = '{p.Gender}', " +
                             $"BirthDate = '{birthDate}', " +
                             $"Address = '{p.Address}', " +
                             $"Phone = '{p.Phone}' " +
                             $"WHERE PatientID = {p.PatientID}";

                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (SqlException ex)
            {
                err = "Database error: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool Delete(int id, out string err)
        {
            err = string.Empty;
            try
            {
                // Soft delete
                string sql = $"UPDATE Patients SET IsDeleted = 1 WHERE PatientID = {id}";
                return db.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (SqlException ex)
            {
                err = "Database error: " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public List<Patient> GetAll(out string err)
        {
            err = string.Empty;
            List<Patient> patients = new List<Patient>();

            try
            {
                string sql = "SELECT * FROM Patients WHERE IsDeleted = 0 ORDER BY FullName";
                DataTable dt = db.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    patients.Add(RowToPatient(row));
                }
            }
            catch (SqlException ex)
            {
                err = "Database error: " + ex.Message;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return patients;
        }

        public Patient GetById(int id, out string err)
        {
            err = string.Empty;

            try
            {
                string sql = $"SELECT * FROM Patients WHERE PatientID = {id} AND IsDeleted = 0";
                DataTable dt = db.ExecuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    return RowToPatient(dt.Rows[0]);
                }
            }
            catch (SqlException ex)
            {
                err = "Database error: " + ex.Message;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return null;
        }

        public List<Patient> GetByName(string name, out string err)
        {
            err = string.Empty;
            List<Patient> patients = new List<Patient>();

            try
            {
                string sql = $"SELECT * FROM Patients WHERE FullName LIKE '%{name}%' AND IsDeleted = 0 ORDER BY FullName";
                DataTable dt = db.ExecuteQuery(sql);

                foreach (DataRow row in dt.Rows)
                {
                    patients.Add(RowToPatient(row));
                }
            }
            catch (SqlException ex)
            {
                err = "Database error: " + ex.Message;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }

            return patients;
        }

        private Patient RowToPatient(DataRow row)
        {
            Patient p = new Patient();
            p.PatientID = Convert.ToInt32(row["PatientID"]);
            p.FullName = row["FullName"].ToString();
            p.Gender = row["Gender"].ToString();
            p.BirthDate = Convert.ToDateTime(row["BirthDate"]);
            p.Address = row["Address"].ToString();
            p.Phone = row["Phone"].ToString();
            p.IsDeleted = Convert.ToBoolean(row["IsDeleted"]);
            return p;
        }
    }
}