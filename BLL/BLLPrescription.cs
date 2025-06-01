using System;
using System.Data;
using EF_Version.DAL;

namespace EF_Version.BLL
{
    internal class BLLPrescription
    {
        private DBMain dbMain = new DBMain();

        public bool Update(Prescription p, out string err)
        {
            err = string.Empty;
            string sql = $"UPDATE Prescriptions SET DateIssued = '{p.DateIssued:yyyy-MM-dd}', " +
                         $"AppointmentID = {p.AppointmentID}, Notes = N'{p.Notes}', " +
                         $"Diagnosis = N'{p.Diagnosis}', IsDeleted = {(p.IsDeleted ? 1 : 0)} " +
                         $"WHERE PrescriptionID = {p.PrescriptionID}";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool Add(Prescription p, out string err)
        {
            err = string.Empty;
            string sql = "INSERT INTO Prescriptions (DateIssued, AppointmentID, Notes, Diagnosis, IsDeleted) " +
                         $"VALUES ('{p.DateIssued:yyyy-MM-dd}', {p.AppointmentID}, N'{p.Notes}', " +
                         $"N'{p.Diagnosis}', {(p.IsDeleted ? 1 : 0)})";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool Delete(int id, out string err)
        {
            err = string.Empty;
            // Using soft delete
            string sql = $"UPDATE Prescriptions SET IsDeleted = 1 WHERE PrescriptionID = {id}";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public Prescription GetById(int id, out string err)
        {
            err = string.Empty;
            string sql = $"SELECT * FROM Prescriptions WHERE PrescriptionID = '{id}' AND IsDeleted = 0";

            DataTable dt = dbMain.ExecuteQuery(sql);

            if (dt.Rows.Count == 0)
                return null;

            return DataRowToPrescription(dt.Rows[0]);
        }

        public Prescription GetByAppointmentId(int id, out string err)
        {
            err = string.Empty;
            string sql = $"SELECT * FROM Prescriptions WHERE AppointmentID = '{id}' AND IsDeleted = 0";

            DataTable dt = dbMain.ExecuteQuery(sql);

            if (dt.Rows.Count == 0)
                return null;

            return DataRowToPrescription(dt.Rows[0]);
        }

        private Prescription DataRowToPrescription(DataRow row)
        {
            return new Prescription
            {
                PrescriptionID = Convert.ToInt32(row["PrescriptionID"]),
                DateIssued = Convert.ToDateTime(row["DateIssued"]),
                AppointmentID = Convert.ToInt32(row["AppointmentID"]),
                Notes = row["Notes"].ToString(),
                Diagnosis = row["Diagnosis"].ToString(),
                IsDeleted = Convert.ToBoolean(row["IsDeleted"])
            };
        }
    }
}