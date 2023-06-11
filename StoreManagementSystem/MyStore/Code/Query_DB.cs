using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;
using Mysqlx.Notice;

namespace MyStore.Code
{

    public class Query_DB
    {
        BussinessLogic bl = new BussinessLogic();

        public bool CheckStaff(String id, String password)
        {
            bl.openDB();
            
            string query = string.Format("SELECT id, pw FROM staff_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (id == (string)reader["id"] && password == (string)reader["pw"])
                {
                    bl.closeDB();
                    return true;
                }
            }
            bl.closeDB();
            return false;
        }

        public void CreateStaff(String id, String password, String name, String email, String gender, String mobile, String address)
        {
            bl.openDB();

            string query = string.Format("INSERT INTO staff_info (id, pw, name, email, gender, mobile, address) " +
                "VALUES ('"+id+"', '"+password+ "', '"+name+ "', '"+email+ "', '"+gender+ "', '"+mobile+ "', '"+address+"')");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Failed to insert data.");

            bl.closeDB();
        }

        public string SELECTStaffPW(String id)
        {
            bl.openDB();

            string pw;
            string query = string.Format("SELECT pw FROM staff_info WHERE id = '{0}'", id);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            pw = (string)reader["pw"];
            bl.closeDB();
            return pw;
        }
        public void ChangeStaffPW(String id, String password)
        {
            bl.openDB();

            string query = string.Format("UPDATE staff_info SET password = {1} WHERE id = '{0}'",id, password);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Failed to insert data.");

            bl.closeDB();
        }

        public bool CheckCustomer(String name, String mobile)
        {
            bl.openDB();

            string query = string.Format("SELECT name, mobile FROM customer_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (name == (string)reader["name"] && mobile == (string)reader["mobile"])
                {
                    bl.closeDB();
                    return true;
                }

            }
            bl.closeDB();
            return false;
        }

        public void CreateCustomer(String name, String email, String gender, String mobile, String address)
        {
            bl.openDB();

            string query = string.Format("INSERT INTO customer_info (name, email, gender, mobile, address) " +
                "VALUES ('"+ name + "', '" + email + "', '" + gender + "', '" + mobile + "', '" + address + "')");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Failed to insert data.");

            bl.closeDB();
        }

        public DataTable ViewProduct()
        {
            bl.openDB();

            String query = string.Format("SELECT * FROM stock_info");
            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(String));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString());
            }

            return table;
        }
        public DataTable SearchProduct(String name)
        {
            bl.openDB();

            String query = string.Format("SELECT * FROM stock_info WHERE name = '" + name + "'");
            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(String));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString());
            }

            return table;
        }

        public void InsertProduct(String name, int price, int quantity)
        {
            bl.openDB();

            string query = string.Format("INSERT INTO stock_info (name, price, quantity) VALUES ('" + name + "', '" + price + "', '" + quantity + "')");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Failed to insert data.");

            bl.closeDB();
        }

        public void UpdateProduct(String name, int price, int quantity)
        {
            bl.openDB();

            string query = string.Format("UPDATE stock_info SET price = '{1}', quantity = '{2}' WHERE name = '{0}'", name, price, quantity);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Failed to update data.");

            bl.closeDB();
        }

        public void DeleteProduct(String name)
        {
            bl.openDB();

            string query = string.Format("DELETE FROM stock_info WHERE name = '{0}'", name);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                MessageBox.Show("Failed to update data.");

            bl.closeDB();
        }

        public void GetProductBySearch(DataGridView gridview, string product)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM stock_info WHERE name = '{0}'", product);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(String));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString());
            }

            gridview.DataSource = table;

        }

        public void GetUserBySearch(DataGridView gridview)
        {
            bl.openDB();

            string query = string.Format("SELECT name, mobile, discount FROM customer_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(String));
            table.Columns.Add("mobile", typeof(String));
            table.Columns.Add("discount", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["mobile"].ToString(), reader["discount"].ToString()); ;
            }

            gridview.DataSource = table;

        }

        public void GetProduct(DataGridView gridview)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM stock_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(String));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString());
            }

            gridview.DataSource = table;

            bl.closeDB();
        }

        public void GetUser(DataGridView gridview) 
        { 
            bl.openDB();

            string query = string.Format("SELECT name, mobile, discount FROM customer_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(String));
            table.Columns.Add("mobile", typeof(String));
            table.Columns.Add("discount", typeof(string));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["mobile"].ToString(), reader["discount"].ToString());
            }

            gridview.DataSource = table;

        }

        public bool CreateSell(string date, string customername, int totalprice)
        {
            bl.openDB();

            string query = string.Format("INSERT INTO sell_info (date, customer, totalprice) VALUES ('" + date + "', '" + customername + "', '" + totalprice + "')");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                return false;

            bl.closeDB();

            return true;
        }

        public bool CreateSellProduct(string date, string cname, string pname, int price, int qty, int total)
        {
            bl.openDB();

            string query = string.Format("INSERT INTO soldproduct_info (date, cname, name, price, quantity, ptotal) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", date, cname, pname, price, qty, total);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            if (command.ExecuteNonQuery() != 1)
                return false;

            bl.closeDB();

            return true;
        }

        public void GetSellProduct(DataGridView gridview, string date)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM soldproduct_info WHERE date = '{0}'", date);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));
            table.Columns.Add("ptotal", typeof(int));


            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString(), reader["ptotal"].ToString());
            }

            gridview.DataSource = table;
        }

        public void GetAllsale(DataGridView gridview)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM soldproduct_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("date", typeof(string));
            table.Columns.Add("cname", typeof(string));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));
            table.Columns.Add("total", typeof(int));


            while (reader.Read())
            {
                table.Rows.Add(reader["date"].ToString(), reader["cname"].ToString(), reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString(), reader["ptotal"].ToString());
            }

            gridview.DataSource = table;
        }

        public void GetSaleCustomer(DataGridView gridview, string name)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM soldproduct_info WHERE cname = '{0}'", name);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("date", typeof(string));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));
            table.Columns.Add("ptotal", typeof(int));


            while (reader.Read())
            {
                table.Rows.Add(reader["date"].ToString(), reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString(), reader["ptotal"].ToString());
            }

            gridview.DataSource = table;
        }

        public void GetSaleCustomerNum(Chart chart)
        {
            bl.openDB();

            string query = string.Format("SELECT customer, SUM(totalprice) FROM sell_info GROUP BY customer");
            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart.Series["Series1"].Points.AddXY(reader["customer"].ToString(), Convert.ToInt32(reader["SUM(totalprice)"].ToString()));
            }

            bl.closeDB();
        }

        public void GetSaleProduct(DataGridView gridview, string name)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM soldproduct_info WHERE name = '{0}'", name);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));
            table.Columns.Add("ptotal", typeof(int));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString(), reader["ptotal"].ToString());
            }

            gridview.DataSource = table;
        }

        public int SearchProductNum(string name)
        {
            bl.openDB();

            int num = 0;
            string query = string.Format("SELECT quantity FROM stock_info WHERE name = '{0}'", name);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                num = Convert.ToInt32(reader["quantity"].ToString());
            }
           

            bl.closeDB();

            return num;
        }

        public void GetBlackconsumer(DataGridView dataGridView)
        {
            bl.openDB();

            string query = string.Format("SELECT name, mobile FROM customer_info WHERE blackconsumer = 'Y'");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(String));
            table.Columns.Add("mobile", typeof(String));

            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["mobile"].ToString());
            }

            dataGridView.DataSource = table;
        }

        public void UpdateStaff(String id, String password, String name, String email, String gender, String mobile, String address)
        {
            bl.openDB();

            if(CheckStaff(id, password))
            {
                string query = string.Format("UPDATE staff_info SET name = '{2}', email = '{3}', gender = '{4}', mobile = '{5}', address = '{6}'  WHERE id = '{0}' AND pw = '{1}", id, password, name, email, gender, mobile, address);

                MySqlCommand command = new MySqlCommand(query, bl.MySql);
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");
            }
            else
            {
                MessageBox.Show("등록된 직원 정보가 없습니다.");
            }
            bl.closeDB();
        }

        public void UpdateCustomer(string EMAIL, string NAME, string MOBILE, string ADDRESS, string GENDER)
        {
            bl.openDB();

            if(CheckCustomer(NAME, MOBILE))
            {
                string query = string.Format("Update staff_info SET email = '{2}', gender = '{3}', address = '{4}' WHERE name = '{0}' AND mobile = '{1}'", NAME, MOBILE, EMAIL, GENDER, ADDRESS);

                MySqlCommand command = new MySqlCommand(query, bl.MySql);
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");
            }

            bl.closeDB();
        }

        public void GetSaleDate(DataGridView gridview, string date)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM soldproduct_info WHERE DATE(date) = '{0}'", date);

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("price", typeof(int));
            table.Columns.Add("quantity", typeof(int));
            table.Columns.Add("ptotal", typeof(int));


            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["price"].ToString(), reader["quantity"].ToString(), reader["ptotal"].ToString());
            }
            gridview.DataSource = table;
        }

        public void PutBlackList(string name, string mobile)
        {
            bl.openDB();

                string query = string.Format("Update customer_info SET blackconsumer = 'Y' WHERE name = '{0}' AND mobile = '{1}'", name, mobile);
                MySqlCommand command = new MySqlCommand(query, bl.MySql);
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");

            bl.closeDB();
        }

        public void OutBlackList(string name, string mobile)
        {
            bl.openDB();

                string query = string.Format("Update customer_info SET blackconsumer = null WHERE name = '{0}' AND mobile = '{1}'", name, mobile);
                MySqlCommand command = new MySqlCommand(query, bl.MySql);
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");
            
            bl.closeDB();
        }

        public void GetStaff(DataGridView gridview)
        {
            bl.openDB();

            string query = string.Format("SELECT * FROM staff_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("email", typeof(string));
            table.Columns.Add("gender", typeof(string));
            table.Columns.Add("mobile", typeof(string));
            table.Columns.Add("address", typeof(string));


            while (reader.Read())
            {
                table.Rows.Add(reader["name"].ToString(), reader["email"].ToString(), reader["gender"].ToString(), reader["mobile"].ToString(), reader["address"].ToString());
            }

            gridview.DataSource = table;

            bl.closeDB();
        }

        public void UpdateDiscount(string name, string mobile, int discount)
        {
            bl.openDB();
  
                string query = string.Format("Update customer_info SET discount = '{2}' WHERE name = '{0}' AND mobile = '{1}'", name, mobile, discount);
                MySqlCommand command = new MySqlCommand(query, bl.MySql);
                if (command.ExecuteNonQuery() != 1)
                    MessageBox.Show("Failed to insert data.");

            bl.closeDB();
        }

        public void GetSaleProductNum(Chart chart)
        {
            bl.openDB();

            string query = string.Format("SELECT name, SUM(quantity) FROM soldproduct_info GROUP BY name");
            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart.Series["Series1"].Points.AddXY(reader["name"].ToString(), Convert.ToInt32(reader["SUM(quantity)"].ToString()));
            }

            bl.closeDB();
        }

        public void GetSaleDateNum(Chart chart)
        {
            bl.openDB();

            string query = string.Format("SELECT DATE(date), SUM(totalprice) FROM sell_info GROUP BY DATE(date)");
            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart.Series["Series1"].Points.AddXY(reader["DATE(date)"].ToString(), Convert.ToInt32(reader["SUM(totalprice)"].ToString()));
            }

            bl.closeDB();
        }

        public bool CheckStock(string name, int price)
        {
            bl.openDB();

            string query = string.Format("SELECT name, price FROM stock_info");

            MySqlCommand command = new MySqlCommand(query, bl.MySql);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (name == (string)reader["name"] && price == (int)reader["price"])
                {
                    bl.closeDB();
                    return true;
                }
            }
            bl.closeDB();
            return false;
        }
    }
}
