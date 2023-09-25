using System;
using System.Windows.Forms;

namespace MyStore
{
    public partial class ViewSale : Form
    {
        Code.Query_DB qd = new Code.Query_DB();
        public ViewSale()
        {
           
            InitializeComponent();
        }

        private void ViewSale_Load(object sender, EventArgs e)
        {
            qd.GetAllsale(dataGridView1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
