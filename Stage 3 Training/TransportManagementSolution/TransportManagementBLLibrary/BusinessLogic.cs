using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TransportManagementBLLibrary
{
    public class BusinessLogic
    {
        private readonly SqlConnection conn;
        private SqlCommand cmdInsert;

        public readonly string userName = "admin";
        public readonly string passWord = "admin";

        public BusinessLogic()
        {
            //conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conTransport"].ConnectionString);
        }

        public int TestCheck()
        {
            return 100;
        }

        public List<string> TestCheck2()
        {
            var result = new List<string>()
            {
                "Hello",
                "World!"
            };

            return result;
        }

        public bool CreateEmployee(Employee employee)
        {
            bool result = false;
            cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "proc_InsertEmployee";
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@eName", employee.Name);
            cmdInsert.Parameters.AddWithValue("@eAddress", employee.Address);
            cmdInsert.Parameters.AddWithValue("@eLocation", employee.Location);
            cmdInsert.Parameters.AddWithValue("@eAge", employee.Age);
            cmdInsert.Parameters.AddWithValue("@ePhone", employee.Phone);
            cmdInsert.Parameters.AddWithValue("@eEmail", employee.Email);

            if(conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();
            if (cmdInsert.ExecuteNonQuery() > 0)
                result = true;
            conn.Close();

            return result;
        }

        public bool CreateDriver(Driver driver)
        {
            bool result = false;
            cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "proc_InsertDriver";
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@eName", driver.Name);
            cmdInsert.Parameters.AddWithValue("@ePhone", driver.PhoneNumber);

            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();
            if (cmdInsert.ExecuteNonQuery() > 0)
                result = true;
            conn.Close();

            return result;
        }

        public bool CreateBus(Bus bus)
        {
            bool result = false;
            cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "proc_InsertBus";
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@eBus_Number", bus.BusNumber);
            cmdInsert.Parameters.AddWithValue("@eCapacity", bus.Capacity);
            cmdInsert.Parameters.AddWithValue("@eOccupancy", bus.Occupancy);

            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();
            if (cmdInsert.ExecuteNonQuery() > 0)
                result = true;
            conn.Close();

            return result;
        }

        public bool CreateTrips(Trips trip)
        {
            bool result = false;
            cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "proc_InsertTrips";
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@eBusId", trip.BusName);
            cmdInsert.Parameters.AddWithValue("@eDriverId", trip.DriverId);
            cmdInsert.Parameters.AddWithValue("@eStop1", trip.Stop1);
            cmdInsert.Parameters.AddWithValue("@eStop1_time", trip.Stop1Time);
            cmdInsert.Parameters.AddWithValue("@eStop2", trip.Stop2);
            cmdInsert.Parameters.AddWithValue("@eStop2_time", trip.Stop2Time);
            cmdInsert.Parameters.AddWithValue("@eStop3", trip.Stop3);
            cmdInsert.Parameters.AddWithValue("@eStop3_time", trip.Stop3Time);

            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();
            if (cmdInsert.ExecuteNonQuery() > 0)
                result = true;
            conn.Close();

            return result;
        }

        public bool LoginCheck(string username, string password)
        {
            bool result = false;

            SqlCommand cmd = new SqlCommand("proc_loginCheck", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            if (conn.State == ConnectionState.Open)
                conn.Close();

            conn.Open();
            var value = (int)cmd.ExecuteScalar();
            if (value > 0)
                result = true;

            return result;
        }
    }
}
