using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management_SYstem
{
    public partial class Select_Role : Form
    {
        public Select_Role()
        {
            InitializeComponent();
        }



        private void back1_btn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); 

        }

        private void ok1_btn_Click(object sender, EventArgs e)
        {
            if(customer_radioButton1.Checked)
            {
                Customer c1 = new Customer();
                c1.Show();
                this.Hide();
            }
            if(seller_radioButton2.Checked)
            {
                Seller s1 = new Seller();
                s1.Show();
                this.Hide();
            }
        }
    }
}
