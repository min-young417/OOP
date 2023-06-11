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
    public partial class ViewSaleDate : Form
    {
        Query_DB qd = new Query_DB();
        public ViewSaleDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            string name = textBox1.Text;
            qd.GetSaleDate(dataGridView1, textBox1.Text);
            textBox1.Text = "";
        }

        private void ViewSaleDate_Load(object sender, EventArgs e)
        {
            qd.GetAllsale(dataGridView1);
            qd.GetSaleDateNum(chart1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            qd.GetAllsale(dataGridView1);
        }

    }
}
