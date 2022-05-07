using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using PracCheck.Models;

namespace PracCheck.BO
{
    public class MenuOperation
    {
        private string connection = @"server=LAPTOP-JDMG0GDJ;database=dbPracCheck;Integrated Security = true";
        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            string query = "select * from menuitems";

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = null;

            con.Open();

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var menuItem = new MenuItem()
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = reader.GetValue(1).ToString(),
                        Active = Convert.ToBoolean(reader.GetValue(2)),
                        Price = Convert.ToDouble(reader.GetValue(3)),
                        DateOfLaunch = Convert.ToDateTime(reader.GetValue(4)),
                        FreeDelivery = Convert.ToBoolean(reader.GetValue(5)),
                        CategoryName = reader.GetValue(6).ToString(),
                    };

                    menuItems.Add(menuItem);
                }
            }

            con.Close();

            return menuItems;
        }

        public void AddItem(MenuItem menuItem)
        {
            var conn = new SqlConnection(connection);
            var comm = new SqlCommand("insert into menuitems values(@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            comm.Parameters.AddWithValue("@p1", menuItem.Name);
            comm.Parameters.AddWithValue("@p2", menuItem.Price);
            comm.Parameters.AddWithValue("@p3", menuItem.Active);
            comm.Parameters.AddWithValue("@p4", menuItem.DateOfLaunch);
            comm.Parameters.AddWithValue("@p5", menuItem.CategoryName);
            comm.Parameters.AddWithValue("@p6", menuItem.FreeDelivery);

            conn.Open();
            
            comm.ExecuteNonQuery();
            
            conn.Close();
        }

        public MenuItem GetMenuItem(int id)
        {
            MenuItem menu = null;
            var conn = new SqlConnection(connection);
            var comm = new SqlCommand("select * from MenuItems where Id=@id", conn);
            
            conn.Open();
            
            comm.Parameters.AddWithValue("@id", id);
            
            var reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                menu = new MenuItem();
                reader.Read();

                menu.Id = reader.GetInt32(0);
                menu.Name = reader.GetString(1);
                menu.Active = reader.GetBoolean(2);
                menu.Price = Convert.ToDouble(reader[3]);
                menu.DateOfLaunch = reader.GetDateTime(4);
                menu.FreeDelivery = reader.GetBoolean(5);
                menu.CategoryName = reader.GetString(6);
                
            }
            reader.Close();
            conn.Close();

            return menu;
        }

        public void Update(MenuItem m)
        {
            var conn = new SqlConnection(connection);
            var comm = new SqlCommand("update menuitems set Name=@p1, Price=@p2 ,Active=@p4,DateOfLaunch=@p5,Category=@p6,FreeDelivery=@p7 where Id=@p3", conn);
            comm.Parameters.AddWithValue("@p1", m.Name);
            comm.Parameters.AddWithValue("@p2", m.Price);
            comm.Parameters.AddWithValue("@p3", m.Id);
            comm.Parameters.AddWithValue("@p4", m.Active);

            comm.Parameters.AddWithValue("@p5", m.DateOfLaunch);

            comm.Parameters.AddWithValue("@p6", m.CategoryName);
            comm.Parameters.AddWithValue("@p7", m.FreeDelivery);

            conn.Open();
            
            comm.ExecuteNonQuery();
            conn.Close();

        }

        public void Delete(int id)
        {
            var conn = new SqlConnection(connection);
            var comm = new SqlCommand("delete from menuitems where Id=@p1", conn);
            comm.Parameters.AddWithValue("@p1", id);

            conn.Open();
            
            comm.ExecuteNonQuery();
            
            conn.Close();
        }


        //Cart Operations
        public List<Cart> GetCartItems(int id)
        {
            List<Cart> cartItems = new List<Cart>();
            
            string cmdText = "SELECT * FROM Cart WHERE MenuItemId=" + id;
            SqlDataAdapter da = new SqlDataAdapter(cmdText, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Cart obj = new Cart();
                obj.MenuItemId = (int)item["MenuItemId"];
                obj.CartId = (int)item["CartId"];
                //

                cartItems.Add(obj);
            }

            return cartItems;
        }

        public Cart GetCartItem(int id)
        {
            Cart obj = null;

            string cmdText = "SELECT * FROM Cart WHERE CartId=" + id;
            
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                obj = new Cart();
                obj.CartId = (int)dr["CartId"];
                obj.MenuItemId = (int)dr["MenuItemId"];
            }

            dr.Close();
            conn.Close();
            return obj;
        }

        public void AddCartItem(Cart obj)
        {
            string cmdText = string.Format("INSERT INTO Cart VALUES({0}, {1})", obj.CartId, obj.MenuItemId);
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteCartItem(int id)
        {

            string cmdText = string.Format("DELETE FROM Cart WHERE MenuItemId={0}", id);

            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Close();
            conn.Close();

        }

        public void AddUser(User obj)
        {
            string cmdText = string.Format("INSERT INTO User VALUES('{0}','{1}')", obj.UserName, obj.PassWord);

            string connStr = @"Data Source=PC445664\SQLEXPRESS;Initial Catalog=CoreDb;Persist Security Info=True;User ID=sa;Password=Rihabkasim8";

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand(cmdText, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public User GetUser(int id)
        {
            User obj = null;

            string cmdText = "SELECT * FROM Customer WHERE Id=" + id;
            string connStr = @"Data Source=PC445664\SQLEXPRESS;Initial Catalog=CoreDb;Persist Security Info=True;User ID=sa;Password=Rihabkasim8";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(cmdText, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
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


    }
}
