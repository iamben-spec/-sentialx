using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Sentialx.Classes
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString =
             @"Server=(localdb)\MSSQLLocalDB;Database=Sentialx;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                throw new Exception("Database connection failed: " + ex.Message);
            }
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex) { throw new Exception("Query failed: " + ex.Message); }
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { throw new Exception("NonQuery failed: " + ex.Message); }
        }

        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex) { throw new Exception("Scalar failed: " + ex.Message); }
        }
    }
}