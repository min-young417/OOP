using MyStore.Code;
using System;
using System.Windows.Forms;

namespace MyStore
{
    public partial class CreateCustomer : Form
    {
        Query_DB qd = new Query_DB();
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UEmail.Text = "";
            UMobile.Text="";
            UAddress.Text = "";
            UName.Text = "";
            UMale.Checked = false;
            UFemale.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (!qd.CheckCustomer(UName.Text, UMobile.Text))
                  {
                    String NAME = UName.Text;
                    String ADDRESS = UAddress.Text;
                    String EMAIL = UEmail.Text;
                    String MOBILE = UMobile.Text;
                    String GENDER=" ";
                    if (UMale.Checked) { GENDER = "Male"; }
                    if (UFemale.Checked) { GENDER = "Female"; }

                    qd.CreateCustomer(NAME, EMAIL, GENDER, MOBILE, ADDRESS);
                }
                else {
                    MessageBox.Show("User already Exist");
                }

            this.Dispose();
            }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
    }
}
