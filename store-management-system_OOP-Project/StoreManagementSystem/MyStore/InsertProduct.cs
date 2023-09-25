using MySql.Data.MySqlClient;
using MyStore.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class InsertProduct : Form
    {
        Query_DB qd = new Query_DB();
        public InsertProduct()
        {
            InitializeComponent();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.ViewProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = Itbname.Text;
            int price = Convert.ToInt32(Itbprice.Text);
            int qty = Convert.ToInt32(Itbqty.Text);
            int quantity = qd.SearchProductNum(name);

            if (qd.CheckStock(name, price))
            {
                qd.UpdateProduct(name, price, quantity + qty);
            }
            else
            {
                qd.InsertProduct(name, price, qty);
            }

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.ViewProduct();

            Itbname.Text = "";
            Itbprice.Text = "";
            Itbqty.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name = Searchtb.Text;

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.SearchProduct(name);

            Searchtb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.ViewProduct();
        }
    }
}
