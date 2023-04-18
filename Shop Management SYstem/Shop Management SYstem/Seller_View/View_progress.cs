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
    public partial class View_progress : UserControl
    {
        public View_progress()
        {
            InitializeComponent();
        }

        public bool TopLevel { get; internal set; }
        public bool TopMost { get; internal set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
