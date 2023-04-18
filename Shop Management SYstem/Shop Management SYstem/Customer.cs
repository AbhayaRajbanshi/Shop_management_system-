using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Shop_Management_SYstem
{
    public partial class Customer : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Shop Management SYstem\Shop Management SYstem\Database.mdb'");
        public Customer()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back1_btn_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void ok1_btn_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string address = txt_address.Text;
            if(name != "" && address != "")
            {
                connection.Open();
                string sql = "INSERT INTO Customer_detail ( Name , Address) Values ('" + name + "','" + address + "')";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please Insert Your Name And Address ");

            }

        }
    }
}
