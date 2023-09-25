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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyStore
{
    public partial class ViewSaleCustomer : Form
    {
        Query_DB qd = new Query_DB();
        public ViewSaleCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            string name = textBox1.Text;
            qd.GetSaleCustomer(dataGridView1, name);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            
            qd.GetAllsale(dataGridView1);
        }

        private void ViewSaleCustomer_Load(object sender, EventArgs e)
        {
            qd.GetAllsale(dataGridView1);
            qd.GetSaleCustomerNum(chart1);
        }
    }
}
