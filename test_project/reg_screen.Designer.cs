namespace CatFeeder
{
    partial class reg_screen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_screen));
			this.register_btn = new System.Windows.Forms.Button();
			this.username_txtbx = new System.Windows.Forms.TextBox();
			this.password_txtbx = new System.Windows.Forms.TextBox();
			this.confirm_password_txtbx = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.have_account_btn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// register_btn
			// 
			this.register_btn.Location = new System.Drawing.Point(69, 429);
			this.register_btn.Margin = new System.Windows.Forms.Padding(4);
			this.register_btn.Name = "register_btn";
			this.register_btn.Size = new System.Drawing.Size(216, 36);
			this.register_btn.TabIndex = 0;
			this.register_btn.Text = "Create an account";
			this.register_btn.UseVisualStyleBackColor = true;
			this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
			// 
			// username_txtbx
			// 
			this.username_txtbx.Location = new System.Drawing.Point(208, 90);
			this.username_txtbx.Margin = new System.Windows.Forms.Padding(4);
			this.username_txtbx.Name = "username_txtbx";
			this.username_txtbx.Size = new System.Drawing.Size(155, 31);
			this.username_txtbx.TabIndex = 1;
			// 
			// password_txtbx
			// 
			this.password_txtbx.Location = new System.Drawing.Point(208, 200);
			this.password_txtbx.Margin = new System.Windows.Forms.Padding(4);
			this.password_txtbx.Name = "password_txtbx";
			this.password_txtbx.Size = new System.Drawing.Size(155, 31);
			this.password_txtbx.TabIndex = 2;
			// 
			// confirm_password_txtbx
			// 
			this.confirm_password_txtbx.Location = new System.Drawing.Point(208, 320);
			this.confirm_password_txtbx.Margin = new System.Windows.Forms.Padding(4);
			this.confirm_password_txtbx.Name = "confirm_password_txtbx";
			this.confirm_password_txtbx.Size = new System.Drawing.Size(155, 31);
			this.confirm_password_txtbx.TabIndex = 3;
			this.confirm_password_txtbx.TextChanged += new System.EventHandler(this.confirm_password_txtbx_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 90);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 203);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 320);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Repeat password";
			// 
			// have_account_btn
			// 
			this.have_account_btn.Location = new System.Drawing.Point(457, 64);
			this.have_account_btn.Margin = new System.Windows.Forms.Padding(4);
			this.have_account_btn.Name = "have_account_btn";
			this.have_account_btn.Size = new System.Drawing.Size(219, 36);
			this.have_account_btn.TabIndex = 7;
			this.have_account_btn.Text = "I have an account";
			this.have_account_btn.UseVisualStyleBackColor = true;
			this.have_account_btn.Click += new System.EventHandler(this.have_account_btn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(421, 191);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(364, 363);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// reg_screen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.have_account_btn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.confirm_password_txtbx);
			this.Controls.Add(this.password_txtbx);
			this.Controls.Add(this.username_txtbx);
			this.Controls.Add(this.register_btn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "reg_screen";
			this.Text = "reg_screen";
			this.Load += new System.EventHandler(this.reg_screen_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.TextBox confirm_password_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button have_account_btn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}