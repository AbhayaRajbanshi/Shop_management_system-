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
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void role_btn_Click(object sender, EventArgs e)
        {
            Select_Role s1 = new Select_Role();
            s1.Show();
            this.Hide();

        }
    }
}
