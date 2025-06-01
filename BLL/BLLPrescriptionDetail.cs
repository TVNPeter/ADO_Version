using System;
using System.Collections.Generic;
using System.Data;
using EF_Version.DAL;

namespace EF_Version.BLL
{
    internal class BLLPrescriptionDetail
    {
        private DBMain dbMain = new DBMain();

        public bool Add(PrescriptionDetail detail, out string err)
        {
            err = string.Empty;
            string sql = "INSERT INTO PrescriptionDetails (PrescriptionID, MedicineID, Quantity, Frequency) " +
                         $"VALUES ({detail.PrescriptionID}, {detail.MedicineID}, {detail.Quantity}, " +
                         $"'{detail.Frequency}')";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool Update(PrescriptionDetail detail, out string err)
        {
            err = string.Empty;
            string sql = $"UPDATE PrescriptionDetails SET Quantity = {detail.Quantity}, " +
                         $"Frequency = '{detail.Frequency}'" +
                         $"WHERE PrescriptionID = {detail.PrescriptionID} AND MedicineID = {detail.MedicineID}";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool Delete(int prescriptionId, int medicineId, out string err)
        {
            err = string.Empty;
            // Using soft delete
            string sql = $"DELETE FROM PrescriptionDetails " +
                         $"WHERE PrescriptionID = {prescriptionId} AND MedicineID = {medicineId}";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public List<PrescriptionDetail> GetByPrescriptionId(int prescriptionId, out string err)
        {
            err = string.Empty;
            string sql = $"SELECT * FROM PrescriptionDetails WHERE PrescriptionID = {prescriptionId}";

            DataTable dt = dbMain.ExecuteQuery(sql);
            List<PrescriptionDetail> details = new List<PrescriptionDetail>();

            foreach (DataRow row in dt.Rows)
            {
                details.Add(DataRowToPrescriptionDetail(row));
            }

            return details;
        }

        public PrescriptionDetail GetByIds(int prescriptionId, int medicineId, out string err)
        {
            err = string.Empty;
            string sql = $"SELECT * FROM PrescriptionDetails " +
                         $"WHERE PrescriptionID = {prescriptionId} AND MedicineID = {medicineId}";

            DataTable dt = dbMain.ExecuteQuery(sql);

            if (dt.Rows.Count == 0)
                return null;

            return DataRowToPrescriptionDetail(dt.Rows[0]);
        }

        public double CalculateTotalMedicationCost(int prescriptionId, out string err)
        {
            try
            {
                // SQL that joins PrescriptionDetails with Medicines to calculate total cost
                string sql =
                    $@"SELECT SUM(pd.Quantity * m.Price) AS TotalCost
                       FROM PrescriptionDetails pd
                       INNER JOIN Medicines m ON pd.MedicineID = m.MedicineID
                       WHERE pd.PrescriptionID = {prescriptionId}
                       AND m.IsDeleted = 0";

                DataTable dt = dbMain.ExecuteQuery(sql);

                if (dt.Rows.Count > 0 && dt.Rows[0]["TotalCost"] != DBNull.Value)
                {
                    double totalCost = Convert.ToDouble(dt.Rows[0]["TotalCost"]);
                    err = string.Empty;
                    return totalCost;
                }

                err = string.Empty;
                return 0.0;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return 0.0;
            }
        }

        private PrescriptionDetail DataRowToPrescriptionDetail(DataRow row)
        {
            return new PrescriptionDetail
            {
                PrescriptionID = Convert.ToInt32(row["PrescriptionID"]),
                MedicineID = Convert.ToInt32(row["MedicineID"]),
                Quantity = Convert.ToInt32(row["Quantity"]),
                Frequency = row["Frequency"].ToString(),
            };
        }
    }
}