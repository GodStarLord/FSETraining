using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace PracticeCheckAPI.Models
{
    public class MenuOperation
    {
        private readonly string connStr = @"server=LAPTOP-JDMG0GDJ;database=dbCheckTwo;Integrated Security=true";
        public List<MenuItem> GetItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            string cmdText = "SELECT * FROM MenuItems";
            SqlDataAdapter da = new SqlDataAdapter(cmdText, connStr);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                MenuItem obj = new MenuItem();
                obj.Id = (int)item["Id"];
                obj.Name = (string)item["Name"];
                obj.Active = (bool)item["Active"];
                obj.Price = Convert.ToDouble(item["Price"]);
                obj.DateOfLaunch = Convert.ToDateTime(item["DateOfLaunch"]);
                obj.FreeDelivery = (bool)(item["FreeDelivery"]);
                obj.CategoryId = (int)(item["CategoryId"]);

                menuItems.Add(obj);
            }

            return menuItems;
        }

        public void AddItem(MenuItem obj)
        {
            string cmdText = string.Format("INSERT INTO MenuItems VALUES('{0}','{1}',{2} ,'{3}','{4}',{5})", obj.Name, obj.Active, obj.Price, obj.DateOfLaunch.ToShortDateString(), obj.FreeDelivery, obj.CategoryId);
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public MenuItem GetItem(int n)
        {
            MenuItem obj = null;
            string cmdText = "SELECT * FROM MenuItems WHERE Id=" + n;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                obj = new MenuItem();
                obj.Id = (int)dr["Id"];
                obj.Name = (string)dr["Name"];
                obj.Active = (bool)dr["Active"];
                obj.Price = Convert.ToDouble(dr["Price"]);
                obj.DateOfLaunch = Convert.ToDateTime(dr["DateOfLaunch"]);
                obj.FreeDelivery = (bool)(dr["FreeDelivery"]);
                obj.CategoryId = (int)(dr["CategoryId"]);
            }

            dr.Close();
            conn.Close();
            return obj;
        }

        public void UpdateItem(MenuItem item)
        {
            string cmdText = string.Format("UPDATE MenuItems SET Active='{0}' where Id={1}", item.Active, item.Id);

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            conn.Close();

        }

        public void DeleteItem(MenuItem item)
        {
            string cmdText = string.Format("DELETE FROM MenuItems WHERE Id={0}", item.Id);

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            conn.Close();
        }

        //Cart Operations
        public List<Cart> GetCartItems(int userId)
        {
            List<Cart> cartItems = new List<Cart>();
            string cmdText = "SELECT * FROM Carts WHERE userId=" + userId;
            SqlDataAdapter da = new SqlDataAdapter(cmdText, connStr);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Cart obj = new Cart();
                obj.Id = (int)item["Id"];
                obj.UserId = (int)item["UserId"];
                obj.MenuItemId = (int)item["MenuItemId"];


                cartItems.Add(obj);
            }

            return cartItems;
        }
        public Cart GetCartItem(int n)
        {
            Cart obj = null;

            string cmdText = "SELECT * FROM Carts WHERE Id=" + n;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                obj = new Cart();
                obj.Id = (int)dr["Id"];
                obj.UserId = (int)dr["UserId"];
                obj.MenuItemId = (int)dr["MenuItemId"];

            }

            dr.Close();
            conn.Close();
            return obj;
        }

        public void AddCartItem(Cart obj)
        {
            string cmdText = string.Format("INSERT INTO Carts VALUES({0}, {1})", obj.UserId, obj.MenuItemId);

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteCartItem(int id)
        {
            string cmdText = string.Format("DELETE FROM Carts WHERE MenuItemId={0}", id);

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            conn.Close();
        }

        //UserOperations
        public void AddUser(User obj)
        {
            string cmdText = string.Format("INSERT INTO Users VALUES('{0}')", obj.Password);

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public User GetUser(int id)
        {
            User obj = null;
            string cmdText = "SELECT * FROM Users WHERE Id=" + id;

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                obj = new User();
                obj.Id = (int)dr["Id"];
                obj.Password = (string)dr["Password"];

            }

            dr.Close();
            conn.Close();
            return obj;
        }

    }
}
