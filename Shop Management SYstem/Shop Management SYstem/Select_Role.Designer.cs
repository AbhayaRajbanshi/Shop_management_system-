
namespace Shop_Management_SYstem
{
    partial class Select_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Role));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customer_radioButton1 = new System.Windows.Forms.RadioButton();
            this.seller_radioButton2 = new System.Windows.Forms.RadioButton();
            this.back1_btn = new System.Windows.Forms.Button();
            this.ok1_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECT ROLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pictureBox1.Location = new System.Drawing.Point(468, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 289);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // customer_radioButton1
            // 
            this.customer_radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customer_radioButton1.AutoSize = true;
            this.customer_radioButton1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.customer_radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_radioButton1.Location = new System.Drawing.Point(569, 273);
            this.customer_radioButton1.Name = "customer_radioButton1";
            this.customer_radioButton1.Size = new System.Drawing.Size(165, 36);
            this.customer_radioButton1.TabIndex = 3;
            this.customer_radioButton1.TabStop = true;
            this.customer_radioButton1.Text = " Customer";
            this.customer_radioButton1.UseVisualStyleBackColor = false;
            // 
            // seller_radioButton2
            // 
            this.seller_radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seller_radioButton2.AutoSize = true;
            this.seller_radioButton2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.seller_radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seller_radioButton2.Location = new System.Drawing.Point(569, 357);
            this.seller_radioButton2.Name = "seller_radioButton2";
            this.seller_radioButton2.Size = new System.Drawing.Size(117, 36);
            this.seller_radioButton2.TabIndex = 4;
            this.seller_radioButton2.TabStop = true;
            this.seller_radioButton2.Text = " Seller";
            this.seller_radioButton2.UseVisualStyleBackColor = false;
            // 
            // back1_btn
            // 
            this.back1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back1_btn.BackColor = System.Drawing.Color.Crimson;
            this.back1_btn.Location = new System.Drawing.Point(384, 586);
            this.back1_btn.Name = "back1_btn";
            this.back1_btn.Size = new System.Drawing.Size(101, 54);
            this.back1_btn.TabIndex = 5;
            this.back1_btn.Text = "Cancel";
            this.back1_btn.UseVisualStyleBackColor = false;
            this.back1_btn.Click += new System.EventHandler(this.back1_btn_Click);
            // 
            // ok1_btn
            // 
            this.ok1_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok1_btn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ok1_btn.Location = new System.Drawing.Point(883, 586);
            this.ok1_btn.Name = "ok1_btn";
            this.ok1_btn.Size = new System.Drawing.Size(101, 54);
            this.ok1_btn.TabIndex = 6;
            this.ok1_btn.Text = "Enter";
            this.ok1_btn.UseVisualStyleBackColor = false;
            this.ok1_btn.Click += new System.EventHandler(this.ok1_btn_Click);
            // 
            // Select_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 761);
            this.Controls.Add(this.ok1_btn);
            this.Controls.Add(this.back1_btn);
            this.Controls.Add(this.seller_radioButton2);
            this.Controls.Add(this.customer_radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Select_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_Role";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton customer_radioButton1;
        private System.Windows.Forms.RadioButton seller_radioButton2;
        private System.Windows.Forms.Button back1_btn;
        private System.Windows.Forms.Button ok1_btn;
    }
}