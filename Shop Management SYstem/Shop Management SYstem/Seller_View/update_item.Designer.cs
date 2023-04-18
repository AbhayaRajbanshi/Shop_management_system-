
namespace Shop_Management_SYstem.Seller_View
{
    partial class update_item
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back1_btn = new System.Windows.Forms.Button();
            this.ok1_btn = new System.Windows.Forms.Button();
            this.up_sp = new System.Windows.Forms.TextBox();
            this.up_cp = new System.Windows.Forms.TextBox();
            this.up_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sn_number = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 500);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE ITEM";
            // 
            // back1_btn
            // 
            this.back1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back1_btn.BackColor = System.Drawing.Color.Crimson;
            this.back1_btn.ForeColor = System.Drawing.Color.Black;
            this.back1_btn.Location = new System.Drawing.Point(250, 314);
            this.back1_btn.Name = "back1_btn";
            this.back1_btn.Size = new System.Drawing.Size(128, 39);
            this.back1_btn.TabIndex = 18;
            this.back1_btn.Text = " Cancel";
            this.back1_btn.UseVisualStyleBackColor = false;
            // 
            // ok1_btn
            // 
            this.ok1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok1_btn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ok1_btn.ForeColor = System.Drawing.Color.Black;
            this.ok1_btn.Location = new System.Drawing.Point(656, 314);
            this.ok1_btn.Name = "ok1_btn";
            this.ok1_btn.Size = new System.Drawing.Size(128, 39);
            this.ok1_btn.TabIndex = 17;
            this.ok1_btn.Text = "Update";
            this.ok1_btn.UseVisualStyleBackColor = false;
            this.ok1_btn.Click += new System.EventHandler(this.ok1_btn_Click);
            // 
            // up_sp
            // 
            this.up_sp.Location = new System.Drawing.Point(362, 234);
            this.up_sp.MaxLength = 6;
            this.up_sp.Name = "up_sp";
            this.up_sp.Size = new System.Drawing.Size(60, 22);
            this.up_sp.TabIndex = 16;
            // 
            // up_cp
            // 
            this.up_cp.Location = new System.Drawing.Point(362, 169);
            this.up_cp.MaxLength = 5;
            this.up_cp.Name = "up_cp";
            this.up_cp.Size = new System.Drawing.Size(60, 22);
            this.up_cp.TabIndex = 15;
            // 
            // up_name
            // 
            this.up_name.Location = new System.Drawing.Point(362, 101);
            this.up_name.MaxLength = 35;
            this.up_name.Name = "up_name";
            this.up_name.Size = new System.Drawing.Size(283, 22);
            this.up_name.TabIndex = 14;
            this.up_name.TextChanged += new System.EventHandler(this.up_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Selling Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cost Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name of item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = " Insert Serial Number";
            // 
            // sn_number
            // 
            this.sn_number.Location = new System.Drawing.Point(543, 50);
            this.sn_number.MaxLength = 5;
            this.sn_number.Name = "sn_number";
            this.sn_number.Size = new System.Drawing.Size(67, 22);
            this.sn_number.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(629, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "FIND";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sn_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back1_btn);
            this.Controls.Add(this.ok1_btn);
            this.Controls.Add(this.up_sp);
            this.Controls.Add(this.up_cp);
            this.Controls.Add(this.up_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "update_item";
            this.Text = "update_item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back1_btn;
        private System.Windows.Forms.Button ok1_btn;
        private System.Windows.Forms.TextBox up_sp;
        private System.Windows.Forms.TextBox up_cp;
        private System.Windows.Forms.TextBox up_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sn_number;
        private System.Windows.Forms.Button button1;
    }
}