using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TransportManagementBLLibrary
{
    public class Booking
    {

        private SqlConnection conn;
        private SqlCommand cmdAllocateBus, cmdGetBus;

        public Booking()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conTransport"].ConnectionString);
        }

        public bool AllocateBusForEmployee(int eid, string busno)
        {
            cmdAllocateBus = new SqlCommand("proc_allocateBusTomEmployee", conn);
            cmdAllocateBus.CommandType = CommandType.StoredProcedure;
            cmdAllocateBus.Parameters.AddWithValue("@eid", eid);
            cmdAllocateBus.Parameters.AddWithValue("@busno", busno);

            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                cmdAllocateBus.ExecuteNonQuery();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> GetBusForEmployee(int id)
        {
            List<string> busNumbers = new List<string>();
            DataSet dsBus = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            cmdGetBus = new SqlCommand("proc_GetBusForEmployee", conn);
            cmdGetBus.CommandType = CommandType.StoredProcedure;
            cmdGetBus.Parameters.AddWithValue("@eid", id);
            
            da.SelectCommand = cmdGetBus;
            da.Fill(dsBus,"BusNumber");

            foreach (DataRow dataRow in dsBus.Tables["BusNumber"].Rows)
            {
                busNumbers.Add(dataRow[0].ToString());
            }

            return busNumbers;
        }
    }
}