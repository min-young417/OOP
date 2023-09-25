using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStore
{
    public partial class ModifyProduct : Form
    {
        Code.Query_DB qd = new Code.Query_DB();
        public ModifyProduct()
        {
            InitializeComponent();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.ViewProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = PName.Text;

            qd.DeleteProduct(name);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.ViewProduct();

            PName.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String name = Searchtb.Text;

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.SearchProduct(name);

            Searchtb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = Itbname.Text;
            int price = Convert.ToInt32(Itbprice.Text);
            int qty = Convert.ToInt32(Itbqty.Text);

            qd.UpdateProduct(name, price, qty);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.ViewProduct();

            Itbname.Text = "";
            Itbprice.Text = "";
            Itbqty.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = qd.ViewProduct();
        }
    }
}
