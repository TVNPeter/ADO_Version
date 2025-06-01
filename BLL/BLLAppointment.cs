using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EF_Version.DAL;

namespace EF_Version.BLL
{
    internal class BLLAppointment
    {
        private DBMain dbMain = new DBMain();

        public bool Add(Appointment appointment, out string err)
        {
            try
            {
                err = string.Empty;
                string sql = $"INSERT INTO Appointments (AppointmentDate, Status, PatientID, DoctorID, Fee, IsDeleted) " +
                             $"VALUES ('{appointment.AppointmentDate:yyyy-MM-dd HH:mm:ss}', 'Scheduled', " +
                             $"{appointment.PatientID}, {appointment.DoctorID}, {appointment.Fee}, 0); " +
                             $"SELECT SCOPE_IDENTITY();";  // Get the newly inserted ID
                
                int newAppointmentId = Convert.ToInt32(dbMain.ExecuteScalar(sql, CommandType.Text, ref err));
                
                if (newAppointmentId > 0)
                {
                    try
                    {
                        sql = $"INSERT INTO Prescriptions (DateIssued, AppointmentID, Notes, Diagnosis, IsDeleted) " +
                              $"VALUES ('{DateTime.Now:yyyy-MM-dd HH:mm:ss}', {newAppointmentId}, '', '', 0)";
                        return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
                    }
                    catch (Exception ex)
                    {
                        err = "Error creating prescription: " + ex.Message;
                        return false;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool UpdateStatus(string id, string status, out string err)
        {
            try
            {
                err = string.Empty;
                string sql = "UPDATE Appointments SET Status = '" + status + "' WHERE AppointmentID = " + id;
                return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool UpdateFee(int id, double fee, out string err)
        {
            try
            {
                err = string.Empty;
                string sql = $"UPDATE Appointments SET Fee = '{fee}' WHERE AppointmentID = {id}";
                return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public Appointment GetById(int id, out string err)
        {
            try
            {
                string sql = $"SELECT * FROM Appointments WHERE AppointmentID = {id} AND IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);

                if (dt.Rows.Count == 0)
                {
                    err = "Appointment not found";
                    return null;
                }

                err = string.Empty;
                return DataRowToAppointment(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public List<Appointment> GetByPatientID(int patientId, out string err)
        {
            try
            {
                string sql = $"SELECT * FROM Appointments WHERE PatientID = {patientId} AND IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);
                List<Appointment> appointments = new List<Appointment>();

                foreach (DataRow row in dt.Rows)
                {
                    appointments.Add(DataRowToAppointment(row));
                }

                err = string.Empty;
                return appointments;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Appointment>();
            }
        }

        public List<Appointment> GetByDoctorID(int doctorId, out string err)
        {
            try
            {
                string sql = $"SELECT * FROM Appointments WHERE DoctorID = {doctorId} AND IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);
                List<Appointment> appointments = new List<Appointment>();

                foreach (DataRow row in dt.Rows)
                {
                    appointments.Add(DataRowToAppointment(row));
                }

                err = string.Empty;
                return appointments;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Appointment>();
            }
        }

        public List<Appointment> GetByDate(DateTime date, out string err)
        {
            try
            {
                string formattedDate = date.ToString("yyyy-MM-dd");
                string sql = $"SELECT * FROM Appointments WHERE CONVERT(date, AppointmentDate) = '{formattedDate}' AND IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);
                List<Appointment> appointments = new List<Appointment>();

                foreach (DataRow row in dt.Rows)
                {
                    appointments.Add(DataRowToAppointment(row));
                }

                err = string.Empty;
                return appointments;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Appointment>();
            }
        }

        public List<Appointment> GetAll(out string err)
        {
            try
            {
                string sql = "SELECT * FROM Appointments WHERE IsDeleted = 0";
                DataTable dt = dbMain.ExecuteQuery(sql);
                List<Appointment> appointments = new List<Appointment>();

                foreach (DataRow row in dt.Rows)
                {
                    appointments.Add(DataRowToAppointment(row));
                }

                err = string.Empty;
                return appointments;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Appointment>();
            }
        }

        // Overload to match call in uc_Appointment.cs
        public List<Appointment> GetAll()
        {
            string err;
            return GetAll(out err);
        }

        private Appointment DataRowToAppointment(DataRow row)
        {
            return new Appointment
            {
                AppointmentID = Convert.ToInt32(row["AppointmentID"]),
                AppointmentDate = Convert.ToDateTime(row["AppointmentDate"]),
                Status = row["Status"].ToString(),
                PatientID = Convert.ToInt32(row["PatientID"]),
                DoctorID = Convert.ToInt32(row["DoctorID"]),
                Fee = row["Fee"] != DBNull.Value ? Convert.ToDouble(row["Fee"]) : 0,
                IsDeleted = Convert.ToBoolean(row["IsDeleted"])
            };
        }
    }
}