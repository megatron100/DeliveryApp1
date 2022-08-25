using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DeliveryApp1
{
    public sealed class DbHandler
    {
        private static DbHandler Instance;
        private SqlConnection connection;
        private SqlCommand command;
        private string connectionString;
        private DataSet ds;
        private DbHandler()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }
        public static DbHandler GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DbHandler();
            }
            return Instance;
        }

        public DataRow GetOrderSummary(int Id)
        {
            ds = new DataSet();

            command = new SqlCommand("GetOrderSummaryProc", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(command);
            try
            {
                objSqlDataAdapter.Fill(ds);
                ds.Tables[0].TableName = "OrderDetailTable";

            }
            catch (Exception ex)
            {
                //logic for Exception handling

            }

            finally
            {

            }

            DataRow dr = ds.Tables["OrderDetailTable"].Rows[0];
            return dr;
        }

        public bool UpdateCost(int Id, int amount)
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand("UpdateCostProc", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@OrderId", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@Amount", SqlDbType.Int).Value = Id;

            try
            {
                //     command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //logic for Exception handling
                return false;
            }

            finally
            {
                ds.Dispose();
                command.Dispose();
            }
            return true;
        }

    }
}