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
using Shop_Management_SYstem.Seller_View;
using Shop_Management_SYstem.NewFolder1;

namespace Shop_Management_SYstem.Seller_View
{
    public partial class add_item : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Shop Management SYstem\Shop Management SYstem\Database.mdb'");
        public add_item()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok1_btn_Click(object sender, EventArgs e)
        {

            string item_name = itm_name.Text;
            string sp = itm_sp.Text;
            string cp = itm_cp.Text;
            if (item_name != "" && sp != "" && cp != "")
            {
                con.Open();
                string sql = "INSERT INTO seller_database ( Name , SP , CP) Values ('" + item_name + "','" + sp + "','" + cp + "')";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DATA INSERTED SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("PLEASE INSERT THE DATA ABOUT ITEM");
            }
        }

        private void back1_btn_Click(object sender, EventArgs e)
        {

        }

        private void add_item_Load(object sender, EventArgs e)
        {

        }
    }
}
