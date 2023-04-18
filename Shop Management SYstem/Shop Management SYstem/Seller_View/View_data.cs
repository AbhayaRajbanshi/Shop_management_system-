using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management_SYstem.Seller_View
{
    public partial class View_data : Form
    {
        public View_data()
        {
            InitializeComponent();
        }

        private void View_data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Customer_detail' table. You can move, or remove it, as needed.
            this.customer_detailTableAdapter.Fill(this.databaseDataSet1.Customer_detail);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
