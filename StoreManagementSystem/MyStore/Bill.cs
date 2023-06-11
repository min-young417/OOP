using System;
using System.Windows.Forms;

namespace MyStore
{
    public partial class Bill : Form
    {
        Code.Query_DB qd = new Code.Query_DB();
        int s;
        public Bill(string date,String name,int total)
        {
            InitializeComponent();
            label4.Text = date;
            label3.Text = name;
            label7.Text = total+"";

            qd.GetSellProduct(dataGridView3,date);
        }

        private void Bill_Load(object sender, EventArgs e)
        {
        }
    }
}
