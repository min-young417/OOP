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
    public partial class ViewStaffInfo : Form
    {
        Query_DB qd = new Query_DB();
        public ViewStaffInfo()
        {
            InitializeComponent();
        }

        private void ViewStaffInfo_Load(object sender, EventArgs e)
        {
            qd.GetStaff(dataGridView1);
        }
    }
}
