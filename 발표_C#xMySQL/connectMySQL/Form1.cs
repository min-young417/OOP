using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace connectMySQL
{
    public partial class Form1 : Form
    {
        string connStr;
        public Form1()
        {
            InitializeComponent();
            connStr = "Server=localhost;Port=3306;Database=데이터베이스_이름;Uid=유저_아이디;Pwd=비밀번호;";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO member_info (id, name, email, birth) VALUES ('{0}', '{1}', '{2}', '{3}');", tb_id.Text, tb_name.Text, tb_email.Text, tb_birth.Text);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");

                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_email.Text = "";
                    tb_birth.Text = "";

                    mysql.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string updateQuery = string.Format("UPDATE member_info SET name = '{1}', email = '{2}', birth = '{3}' WHERE id = '{0}';", tb_id.Text, tb_name.Text, tb_email.Text, tb_birth.Text);

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_email.Text = "";
                    tb_birth.Text = "";

                    mysql.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();
                    string deleteQuery = string.Format("DELETE FROM member_info WHERE id = '{0}';", tb_id.Text);

                    MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    tb_id.Text = "";
                    tb_name.Text = "";
                    tb_email.Text = "";
                    tb_birth.Text = "";

                    mysql.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(connStr))
                {
                    mysql.Open();        
                    string selectQuery = string.Format("SELECT * FROM member_info");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader reader = command.ExecuteReader();

                    list_result.Items.Clear();

                    while (reader.Read())
                    {   
                        ListViewItem item = new ListViewItem(reader["id"].ToString());
                        item.SubItems.Add(reader["name"].ToString());
                        item.SubItems.Add(reader["email"].ToString());
                        item.SubItems.Add(reader["birth"].ToString());

                        list_result.Items.Add(item);
                    }

                    reader.Close();
                    mysql.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
