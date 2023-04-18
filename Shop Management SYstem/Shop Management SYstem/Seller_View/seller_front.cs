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
using System.Data.OleDb;

namespace Shop_Management_SYstem.NewFolder1
{

    public partial class seller_front : Form
    {
        public seller_front()
        {
            InitializeComponent();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            form_panel.Controls.Clear();
            add_item add= new add_item() { TopLevel = false, TopMost = true };
            form_panel.Controls.Add(add);
            add.Show();
            add.Dock = DockStyle.Fill;

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            form_panel.Controls.Clear();
            update_item update = new update_item() { TopLevel = false, TopMost = true };
            form_panel.Controls.Add(update);
            update.Show();
            update.Dock = DockStyle.Fill;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            form_panel.Controls.Clear();
            delete_item delete = new delete_item() { TopLevel = false, TopMost = true };
            form_panel.Controls.Add(delete);
            delete.Show();
            delete.Dock = DockStyle.Fill;
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            form_panel.Controls.Clear();
            View_data view = new View_data() { TopLevel = false, TopMost = true };
            form_panel.Controls.Add(view);
            view.Show();
            view.Dock = DockStyle.Fill;
        }

        private void form_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
