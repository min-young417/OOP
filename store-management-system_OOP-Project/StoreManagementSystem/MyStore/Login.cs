using MyStore.Code;
using System;
using System.Windows.Forms;

namespace MyStore
{
    public partial class Login : Form
    {
        Query_DB qd = new Query_DB();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qd.CheckStaff(Id.Text, Password.Text))
            {
                DashBoard db = new DashBoard(qd);
                db.Show();
            }

            Id.Text = "";
            Password.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Id.Text = "";
            Password.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateStaff cs = new CreateStaff();
            cs.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Id.Text = "hong";
            Password.Text = "1234";
        }
    }
}
