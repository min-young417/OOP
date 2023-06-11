using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyStore
{
    public partial class DashBoard : Form
    {
        Code.Query_DB pb = new Code.Query_DB();
        public DashBoard(Code.Query_DB qd)
        {
            InitializeComponent();
            pb = qd;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            pb.GetUser(dataGridView2);
            pb.GetProduct(dataGridView1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime nowdate = DateTime.Now;
            string date = nowdate.ToString("yyyy-MM-dd HH:mm:ss");
            if (pb.CreateSell(date, BName.Text, Convert.ToInt32(label7.Text)))
            {
                int b = 0;
                int qty, price, total; 
                string pname;
                string cname = BName.Text;
                foreach (DataGridViewRow p in dataGridView3.Rows)
                {
                    qty = Convert.ToInt32(dataGridView3.Rows[b].Cells["PQty"].Value.ToString());
                    price = Convert.ToInt32(dataGridView3.Rows[b].Cells["PPrice"].Value.ToString());
                    pname = dataGridView3.Rows[b].Cells["PName"].Value.ToString();
                    total = Convert.ToInt32(dataGridView3.Rows[b].Cells["PTotal"].Value.ToString());

                    if (pb.CreateSellProduct(date, cname, pname, price, qty, total)){
                    } else { 
                        MessageBox.Show("there is an erroe " + b); 
                    }
                    b++;
                 }
                 Bill bi = new Bill(date, BName.Text, (Convert.ToInt32(label7.Text)));
                 bi.Show();
                 BName.Text = "";
                 BMobile.Text = "";
                 textBox5.Text = "0";
                 textBox4.Text = "0";
                 dataGridView3.Rows.Clear();
                 dataGridView3.Refresh();
                 label7.Text = "0";
                 minus.Text = "( 0 - 0 )";
            }
         }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomer cu = new CreateCustomer();
            cu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateCustomer cu = new CreateCustomer();
            cu.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertProduct ap = new InsertProduct();
            ap.Show();
        }

        private void viewSellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSale vs = new ViewSale();
            vs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyProduct up = new ModifyProduct();
            up.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BName.Text = dataGridView2.SelectedCells[0].Value.ToString();
            BMobile.Text = dataGridView2.SelectedCells[1].Value.ToString();
            textBox5.Text = dataGridView2.SelectedCells[2].Value.ToString();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            pb.GetProductBySearch(dataGridView1, Search.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Search.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox1.Text = 1+"";
            label13.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();

            textBox1.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToInt32(textBox1.Text) > 0)
                {
                    label14.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
                    string[] row = new string[] { Search.Text, textBox2.Text, textBox1.Text, label14.Text};
                    if ((Convert.ToInt32(textBox1.Text)) <= (Convert.ToInt32(label13.Text)))
                    {
                        dataGridView3.Rows.Add(row);

                        int quantity = pb.SearchProductNum(Search.Text);
                        pb.UpdateProduct(Search.Text, Convert.ToInt32(textBox2.Text), quantity - Convert.ToInt32(textBox1.Text));

                        Search.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox4.Text = "";
                        int a = 0;
                        int total = 0;
                        foreach (DataGridViewRow pb in dataGridView3.Rows)
                        {
                            total += Convert.ToInt32(dataGridView3.Rows[a].Cells["PTotal"].Value.ToString());
                            a++;
                        }
                        textBox4.Text = total.ToString();
                        int btotal = Convert.ToInt32(textBox4.Text);
                        int discount = 0;
                        if (Convert.ToInt32(textBox5.Text) > 0)
                        {
                            discount = (int)((btotal * Convert.ToInt32(textBox5.Text)) / 100);
                        }
                        minus.Text = "( " + btotal.ToString() + " - " + discount.ToString() + " )";
                        label7.Text = (btotal - discount).ToString();

                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                        pb.GetProduct(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Please select less Quantity than stock");
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView3.SelectedRows.Count > 0)
            {
   
                string name = dataGridView3.SelectedRows[0].Cells["PName"].Value.ToString();
                int price = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["PPrice"].Value.ToString());
                int qty = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["PQty"].Value.ToString());
                int quantity = pb.SearchProductNum(name);
                pb.UpdateProduct(name, price, quantity + qty);

                dataGridView3.Rows.RemoveAt(this.dataGridView3.SelectedRows[0].Index);
            }

            int a = 0;
            int total = 0;
            foreach (DataGridViewRow pb in dataGridView3.Rows)
            {
                total += Convert.ToInt32(dataGridView3.Rows[a].Cells["PTotal"].Value.ToString());
                a++;
            }
            textBox4.Text = total.ToString();
            int btotal = Convert.ToInt32(textBox4.Text);
            int discount = 0;
            if (Convert.ToInt32(textBox5.Text) > 0)
            {
                discount = (int)((btotal * Convert.ToInt32(textBox5.Text)) / 100);
            }
            minus.Text = "( " + btotal.ToString() + " - " + discount.ToString() + " )";
            label7.Text = (btotal - discount).ToString();

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            pb.GetProduct(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = dataGridView3.Rows.Count;

            for (int i = 0; i<n; i++)
            {
                string name = dataGridView3.Rows[i].Cells["PName"].Value.ToString();
                int price = Convert.ToInt32(dataGridView3.Rows[i].Cells["PPrice"].Value.ToString());
                int qty = Convert.ToInt32(dataGridView3.Rows[i].Cells["PQty"].Value.ToString());
                int quantity = pb.SearchProductNum(name);
                pb.UpdateProduct(name, price, quantity + qty);
            }

            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
            pb.GetProduct(dataGridView1);

            minus.Text = "( 0 - 0 )";
            label7.Text = "0";
            textBox4.Text = "0";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int btotal = Convert.ToInt32(textBox4.Text);
            int discount = 0;
            if (textBox5.Text != "")
            {
                if (Convert.ToInt32(textBox5.Text) > 0)
                {
                    discount = (int)((btotal * Convert.ToInt32(textBox5.Text)) / 100);
                }
                minus.Text = "( " + btotal.ToString() + " - " + discount.ToString() + " )";
                label7.Text = (btotal - discount).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            pb.GetProduct(dataGridView1);
        }

        private void 신규회원등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomer cc = new CreateCustomer();
            cc.Show();
        }

        private void 고객별판매기록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSaleCustomer vsc = new ViewSaleCustomer();
            vsc.Show();
        }

        private void 제품별판매기록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSaleProduct vsp = new ViewSaleProduct();
            vsp.Show();
        }

        private void 직원정보등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStaff cs = new CreateStaff();
            cs.Show();
        }

        private void blackListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackList bl = new BlackList();
            bl.Show();
        }

        private void 직원정보수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyStaffInfo msi = new ModifyStaffInfo();
            msi.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pb.GetUser(dataGridView2);
        }

        private void 단골관리할인률ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDiscount cd = new CustomerDiscount();
            cd.Show();
        }

        private void 고객정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyCustomerInfo mci = new ModifyCustomerInfo();
            mci.Show();
        }

        private void 직원정보조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStaffInfo vsi = new ViewStaffInfo();
            vsi.Show();
        }

        private void 날짜별매출조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSaleDate vsd = new ViewSaleDate();
            vsd.Show();
        }
    }
}
