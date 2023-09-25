using MyStore.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyStore
{
    public partial class BlackList : Form
    {
        Query_DB qd = new Query_DB();
        public BlackList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
        }

        private void BlackList_Load(object sender, EventArgs e)
        {
            qd.GetBlackconsumer(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(qd.CheckCustomer(textBox1.Text, textBox2.Text))
            {
                qd.OutBlackList(textBox1.Text, textBox2.Text);
            }

            textBox1.Text = "";
            textBox2.Text = "";

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            qd.GetBlackconsumer(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (qd.CheckCustomer(textBox4.Text, textBox3.Text))
            {
                qd.PutBlackList(textBox4.Text, textBox3.Text);
            }

            textBox3.Text = "";
            textBox4.Text = "";

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            qd.GetBlackconsumer(dataGridView1);
        }
    }
}
