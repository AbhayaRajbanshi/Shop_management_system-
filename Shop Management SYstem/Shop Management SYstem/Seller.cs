using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Management_SYstem.Seller_View;
using Shop_Management_SYstem.NewFolder1;

namespace Shop_Management_SYstem
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void Seller_Load(object sender, EventArgs e)
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
            if(txt_name.Text=="admin" && txt_password.Text =="admin")
            {
                seller_front sf1 = new seller_front();
                sf1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Access Denied");
                txt_name.Clear();
                txt_password.Clear();
            }
        }
    }
}
