using System;
using System.Collections.Generic;
using System.Data;
using EF_Version.DAL;

namespace EF_Version.BLL
{
    internal class BLLDoctor
    {
        private DBMain dbMain = new DBMain();

        public bool Add(Doctor d, out string err, out int newId)
        {
            try
            {
                err = string.Empty;
                string sql = "INSERT INTO Doctors (FullName, Specialty, Phone, IsDeleted) " +
                             $"VALUES ('{d.FullName}', '{d.Specialty}', '{d.Phone}', 0); SELECT SCOPE_IDENTITY();";
                DataTable dt = dbMain.ExecuteQuery(sql);
                newId = Convert.ToInt32(dt.Rows[0][0]);
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                newId = 0;
                return false;
            }
        }

        public bool Update(Doctor d, out string err)
        {
            try
            {
                err = string.Empty;
                string sql = $"UPDATE Doctors SET FullName = '{d.FullName}', Specialty = '{d.Specialty}', " +
                             $"Phone = '{d.Phone}' WHERE DoctorID = {d.DoctorID}";

                return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
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
                string sql = $"UPDATE Doctors SET IsDeleted = 1 WHERE DoctorID = {id}";
                return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public List<Doctor> GetAll(out string err)
        {
            try
            {
                string sql = "SELECT * FROM Doctors WHERE IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);
                List<Doctor> doctors = new List<Doctor>();

                foreach (DataRow row in dt.Rows)
                {
                    doctors.Add(RowToDoctor(row));
                }

                err = string.Empty;
                return doctors;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Doctor>();
            }
        }

        public Doctor GetById(int id, out string err)
        {
            try
            {
                string sql = $"SELECT * FROM Doctors WHERE DoctorID = {id} AND IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);

                if (dt.Rows.Count == 0)
                {
                    err = "Doctor not found";
                    return null;
                }

                err = string.Empty;
                return RowToDoctor(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public List<Doctor> GetBySpecialty(string specialty, out string err)
        {
            try
            {
                string sql = $"SELECT * FROM Doctors WHERE Specialty = '{specialty}' AND IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);
                List<Doctor> doctors = new List<Doctor>();

                foreach (DataRow row in dt.Rows)
                {
                    doctors.Add(RowToDoctor(row));
                }

                err = string.Empty;
                return doctors;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Doctor>();
            }
        }

        public List<Doctor> GetByName(string name, out string err)
        {
            try
            {
                string sql = $"SELECT * FROM Doctors WHERE FullName LIKE '%{name}%' AND IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);
                List<Doctor> doctors = new List<Doctor>();

                foreach (DataRow row in dt.Rows)
                {
                    doctors.Add(RowToDoctor(row));
                }

                err = string.Empty;
                return doctors;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Doctor>();
            }
        }

        private Doctor RowToDoctor(DataRow row)
        {
            return new Doctor
            {
                DoctorID = Convert.ToInt32(row["DoctorID"]),
                FullName = row["FullName"].ToString(),
                Specialty = row["Specialty"].ToString(),
                Phone = row["Phone"].ToString(),
                IsDeleted = Convert.ToBoolean(row["IsDeleted"])
            };
        }
    }
}