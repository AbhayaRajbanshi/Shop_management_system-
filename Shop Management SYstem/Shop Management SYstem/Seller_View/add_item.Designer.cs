
namespace Shop_Management_SYstem.Seller_View
{
    partial class add_item
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itm_name = new System.Windows.Forms.TextBox();
            this.itm_cp = new System.Windows.Forms.TextBox();
            this.itm_sp = new System.Windows.Forms.TextBox();
            this.back1_btn = new System.Windows.Forms.Button();
            this.ok1_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD ITEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 468);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selling Price";
            // 
            // itm_name
            // 
            this.itm_name.Location = new System.Drawing.Point(390, 94);
            this.itm_name.MaxLength = 35;
            this.itm_name.Name = "itm_name";
            this.itm_name.Size = new System.Drawing.Size(283, 22);
            this.itm_name.TabIndex = 5;
            // 
            // itm_cp
            // 
            this.itm_cp.Location = new System.Drawing.Point(390, 175);
            this.itm_cp.Name = "itm_cp";
            this.itm_cp.Size = new System.Drawing.Size(60, 22);
            this.itm_cp.TabIndex = 6;
            // 
            // itm_sp
            // 
            this.itm_sp.Location = new System.Drawing.Point(390, 252);
            this.itm_sp.Name = "itm_sp";
            this.itm_sp.Size = new System.Drawing.Size(60, 22);
            this.itm_sp.TabIndex = 7;
            // 
            // back1_btn
            // 
            this.back1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back1_btn.BackColor = System.Drawing.Color.Crimson;
            this.back1_btn.ForeColor = System.Drawing.Color.Black;
            this.back1_btn.Location = new System.Drawing.Point(276, 366);
            this.back1_btn.Name = "back1_btn";
            this.back1_btn.Size = new System.Drawing.Size(128, 39);
            this.back1_btn.TabIndex = 10;
            this.back1_btn.Text = "Cancel";
            this.back1_btn.UseVisualStyleBackColor = false;
            this.back1_btn.Click += new System.EventHandler(this.back1_btn_Click);
            // 
            // ok1_btn
            // 
            this.ok1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok1_btn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ok1_btn.ForeColor = System.Drawing.Color.Black;
            this.ok1_btn.Location = new System.Drawing.Point(812, 366);
            this.ok1_btn.Name = "ok1_btn";
            this.ok1_btn.Size = new System.Drawing.Size(128, 39);
            this.ok1_btn.TabIndex = 9;
            this.ok1_btn.Text = " Add";
            this.ok1_btn.UseVisualStyleBackColor = false;
            this.ok1_btn.Click += new System.EventHandler(this.ok1_btn_Click);
            // 
            // add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 457);
            this.Controls.Add(this.back1_btn);
            this.Controls.Add(this.ok1_btn);
            this.Controls.Add(this.itm_sp);
            this.Controls.Add(this.itm_cp);
            this.Controls.Add(this.itm_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_item";
            this.Text = "add_item";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.add_item_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itm_name;
        private System.Windows.Forms.TextBox itm_cp;
        private System.Windows.Forms.TextBox itm_sp;
        private System.Windows.Forms.Button back1_btn;
        private System.Windows.Forms.Button ok1_btn;
    }
}