
namespace Shop_Management_SYstem.Seller_View
{
    partial class delete_item
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
            this.sn_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back1_btn = new System.Windows.Forms.Button();
            this.ok1_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 510);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE ITEM";
            // 
            // sn_name
            // 
            this.sn_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sn_name.Location = new System.Drawing.Point(495, 129);
            this.sn_name.MaxLength = 35;
            this.sn_name.Name = "sn_name";
            this.sn_name.Size = new System.Drawing.Size(283, 34);
            this.sn_name.TabIndex = 16;
            this.sn_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter the SN of item";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // back1_btn
            // 
            this.back1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back1_btn.BackColor = System.Drawing.Color.Crimson;
            this.back1_btn.ForeColor = System.Drawing.Color.Black;
            this.back1_btn.Location = new System.Drawing.Point(253, 259);
            this.back1_btn.Name = "back1_btn";
            this.back1_btn.Size = new System.Drawing.Size(128, 39);
            this.back1_btn.TabIndex = 20;
            this.back1_btn.Text = "Cancel";
            this.back1_btn.UseVisualStyleBackColor = false;
            // 
            // ok1_btn
            // 
            this.ok1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok1_btn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ok1_btn.ForeColor = System.Drawing.Color.Black;
            this.ok1_btn.Location = new System.Drawing.Point(661, 259);
            this.ok1_btn.Name = "ok1_btn";
            this.ok1_btn.Size = new System.Drawing.Size(128, 39);
            this.ok1_btn.TabIndex = 19;
            this.ok1_btn.Text = "Delete";
            this.ok1_btn.UseVisualStyleBackColor = false;
            this.ok1_btn.Click += new System.EventHandler(this.ok1_btn_Click);
            // 
            // delete_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 399);
            this.Controls.Add(this.back1_btn);
            this.Controls.Add(this.ok1_btn);
            this.Controls.Add(this.sn_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_item";
            this.Text = "delete_item";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sn_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back1_btn;
        private System.Windows.Forms.Button ok1_btn;
    }
}