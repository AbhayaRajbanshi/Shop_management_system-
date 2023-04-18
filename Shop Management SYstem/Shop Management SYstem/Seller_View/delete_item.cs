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

namespace Shop_Management_SYstem.Seller_View
{
    public partial class delete_item : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Shop Management SYstem\Shop Management SYstem\Database.mdb'");
        public delete_item()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ok1_btn_Click(object sender, EventArgs e)
        {
            if (sn_name.Text != "")
            {
                con.Open();

                string sql = @"DELETE * from seller_database where SN = " + sn_name .Text;
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA DELETED SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show("DATA NOT AVAILABLE");
            }
            con.Close();
        }
    }
}
