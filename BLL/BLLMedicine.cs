using System;
using System.Collections.Generic;
using System.Data;
using EF_Version.DAL;

namespace EF_Version.BLL
{
    internal class BLLMedicine
    {
        private DBMain dbMain = new DBMain();

        public bool Add(Medicine m, out string err)
        {
            err = string.Empty;
            string sql = "INSERT INTO Medicines (Name, Dosage, Price, IsDeleted) " +
                         $"VALUES (N'{m.Name}', N'{m.Dosage}', {m.Price}, {(m.IsDeleted ? 1 : 0)})";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool Update(Medicine m, out string err)
        {
            err = string.Empty;
            string sql = $"UPDATE Medicines SET Name = N'{m.Name}', Dosage = N'{m.Dosage}', " +
                         $"Price = {m.Price}, IsDeleted = {(m.IsDeleted ? 1 : 0)} " +
                         $"WHERE MedicineID = {m.MedicineID}";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public bool Delete(int id, out string err)
        {
            err = string.Empty;
            // Using soft delete
            string sql = $"UPDATE Medicines SET IsDeleted = 1 WHERE MedicineID = {id}";

            return dbMain.ExecuteNonQuery(sql, CommandType.Text, ref err);
        }

        public List<Medicine> GetAll(out string err)
        {
            err = string.Empty;
            string sql = "SELECT * FROM Medicines WHERE IsDeleted = 0";

            try
            {
                DataTable dt = dbMain.ExecuteQuery(sql);
                return ConvertDataTableToList(dt);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Medicine>();
            }
        }

        public Medicine GetById(int id, out string err)
        {
            err = string.Empty;
            string sql = $"SELECT * FROM Medicines WHERE MedicineID = {id} AND IsDeleted = 0";

            try
            {
                DataTable dt = dbMain.ExecuteQuery(sql);
                if (dt.Rows.Count == 0)
                    return null;

                return DataRowToMedicine(dt.Rows[0]);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
        }

        public List<Medicine> GetByName(string name, out string err)
        {
            err = string.Empty;
            string sql = $"SELECT * FROM Medicines WHERE Name LIKE N'%{name}%' AND IsDeleted = 0";

            try
            {
                DataTable dt = dbMain.ExecuteQuery(sql);
                return ConvertDataTableToList(dt);
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return new List<Medicine>();
            }
        }

        private List<Medicine> ConvertDataTableToList(DataTable dt)
        {
            List<Medicine> medicines = new List<Medicine>();
            foreach (DataRow row in dt.Rows)
            {
                medicines.Add(DataRowToMedicine(row));
            }
            return medicines;
        }

        private Medicine DataRowToMedicine(DataRow row)
        {
            return new Medicine
            {
                MedicineID = Convert.ToInt32(row["MedicineID"]),
                Name = row["Name"].ToString(),
                Dosage = row["Dosage"].ToString(),
                Price = Convert.ToDouble(row["Price"]),
                IsDeleted = Convert.ToBoolean(row["IsDeleted"])
            };
        }
    }
}