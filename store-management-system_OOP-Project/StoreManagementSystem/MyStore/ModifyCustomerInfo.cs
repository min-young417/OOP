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
    public partial class ModifyCustomerInfo : Form
    {
        Query_DB qd = new Query_DB();
        public ModifyCustomerInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UEmail.Text = "";
            UMobile.Text = "";
            UAddress.Text = "";
            UName.Text = "";
            UMale.Checked = false;
            UFemale.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qd.CheckCustomer(UName.Text, UMobile.Text))
            {
                String NAME = UName.Text;
                String ADDRESS = UAddress.Text;
                String EMAIL = UEmail.Text;
                String MOBILE = UMobile.Text;
                String GENDER = " ";
                if (UMale.Checked) { GENDER = "Male"; }
                if (UFemale.Checked) { GENDER = "Female"; }

                qd.UpdateCustomer(EMAIL, NAME, MOBILE, ADDRESS, GENDER);
            }
            else
            {
                MessageBox.Show("User already Exist");
            }
        }
    }
}
