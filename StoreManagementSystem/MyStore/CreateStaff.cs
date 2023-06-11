using MyStore.Code;
using System;
using System.Windows.Forms;

namespace MyStore
{
    public partial class CreateStaff : Form
    {
        Query_DB qd = new Query_DB();
        public CreateStaff()
        {
            InitializeComponent();
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

                qd.CreateStaff(ID, PASSWORD, NAME, EMAIL, GENDER, MOBILE, ADDRESS);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("User already Exist");
            }
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
    }
}
