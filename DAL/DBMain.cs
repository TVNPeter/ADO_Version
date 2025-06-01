using System;
using System.Data;
using System.Data.SqlClient;

namespace EF_Version.DAL
{
    internal class DBMain
    {
        private string ConnStr = "Data Source=LAPTOP-PETER\\SQLEXPRESS;Initial Catalog=ClinicDataBase;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand comm;
        private SqlDataAdapter da;

        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = new SqlCommand();
            comm.Connection = conn;
        }

        public DataTable ExecuteQuery(string sql, CommandType commandType = CommandType.Text)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                comm.CommandText = sql;
                comm.CommandType = commandType;
                comm.Parameters.Clear();

                da = new SqlDataAdapter(comm);
                da.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataTable;
        }

        public System.Data.DataSet ExecuteQueryDataSet(string sql, CommandType commandType = CommandType.Text)
        {
            System.Data.DataSet dataSet = new System.Data.DataSet();
            try
            {
                conn.Open();
                comm.CommandText = sql;
                comm.CommandType = commandType;
                comm.Parameters.Clear();

                da = new SqlDataAdapter(comm);
                da.Fill(dataSet);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return dataSet;
        }

        public bool ExecuteNonQuery(string sql, CommandType commandType, ref string error)
        {
            bool result = false;
            try
            {
                conn.Open();
                comm.CommandText = sql;
                comm.CommandType = commandType;
                comm.Parameters.Clear();
                comm.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        public object ExecuteScalar(string sql, CommandType commandType, ref string error)
        {
            object result = null;
            try
            {
                conn.Open();
                comm.CommandText = sql;
                comm.CommandType = commandType;
                comm.Parameters.Clear();
                result = comm.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}