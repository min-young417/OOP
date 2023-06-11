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
    public partial class CustomerDiscount : Form
    {
        Query_DB qd = new Query_DB();
        public CustomerDiscount()
        {
            InitializeComponent();
        }

        private void CustomerDiscount_Load(object sender, EventArgs e)
        {
            qd.GetUser(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qd.CheckCustomer(textBox1.Text, textBox2.Text))
            {
                qd.UpdateDiscount(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            }
            else
            {
                MessageBox.Show("존재하지 않는 고객입니다.");
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            qd.GetUser(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            qd.GetUser(dataGridView1);
        }
    }
}
