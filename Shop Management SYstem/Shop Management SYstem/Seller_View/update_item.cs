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
    public partial class update_item : Form
    {
        public update_item()
        {
            InitializeComponent();
        }

        private void ok1_btn_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Shop Management SYstem\Shop Management SYstem\Database.mdb'");
            if (up_name.Text != "" && up_cp.Text != "" && up_sp.Text != "")
            {
                int num = int.Parse(sn_number.Text);
                con.Open();
                string sql = "Update seller_database SET Name,SP,CP ('" + up_name + "','" + up_sp + ",'" + up_cp + "') WHERE SN = ('" + sn_number + "')";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated");
                up_name.Clear();
                up_cp.Clear();
                up_sp.Clear();
            }
            else
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
               


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void up_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='E:\Shop Management SYstem\Shop Management SYstem\Database.mdb'");
            if (sn_number.Text != "")
            {
                string sql = "Select * from seller_database";
                OleDbCommand cmd = new OleDbCommand(sql, con);
                DataSet ds = new DataSet();
                OleDbDataAdapter daa = new OleDbDataAdapter(cmd);
                daa.Fill(ds);
                int a = ds.Tables[0].Rows.Count;
                int num = int.Parse(sn_number.Text);
                int n = num - 1;
                if (num <= a)
                {
                    up_name.Text = ds.Tables[0].Rows[n]["Name"].ToString();
                    up_cp.Text = ds.Tables[0].Rows[n]["CP"].ToString();
                    up_sp.Text = ds.Tables[0].Rows[n]["SP"].ToString();
                }
                else
                {
                    MessageBox.Show("Unable to find Serial Number ' " + sn_number.Text + " '", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
