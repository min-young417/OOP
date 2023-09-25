using MyStore.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class ModifyStaffInfo : Form
    {
        Query_DB qd = new Query_DB();
        public ModifyStaffInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UID.Text = "";
            UPassword.Text = "";
            UEmail.Text = "";
            UMobile.Text = "";
            UAddress.Text = "";
            UName.Text = "";
            UMale.Checked = false;
            UFemale.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!qd.CheckStaff(UID.Text, UPassword.Text))
            {
                String ID = UID.Text;
                String PASSWORD = UPassword.Text;
                String EMAIL = UEmail.Text;
                String NAME = UName.Text;
                String ADDRESS = UAddress.Text;
                String MOBILE = UMobile.Text;
                String GENDER = " ";
                if (UMale.Checked) { GENDER = "Male"; }
                if (UFemale.Checked) { GENDER = "Female"; }

                qd.UpdateStaff(ID, PASSWORD, NAME, EMAIL, GENDER, MOBILE, ADDRESS);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("User already Exist");
            }
        }
    }
}
