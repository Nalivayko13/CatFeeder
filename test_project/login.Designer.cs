namespace CatFeeder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.login_btn = new System.Windows.Forms.Button();
			this.username_txtbx = new System.Windows.Forms.TextBox();
			this.password_txtbx = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.no_account_btn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// login_btn
			// 
			this.login_btn.ForeColor = System.Drawing.SystemColors.InfoText;
			this.login_btn.Location = new System.Drawing.Point(555, 347);
			this.login_btn.Margin = new System.Windows.Forms.Padding(4);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(118, 36);
			this.login_btn.TabIndex = 1;
			this.login_btn.Text = "Log in";
			this.login_btn.UseVisualStyleBackColor = true;
			this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
			// 
			// username_txtbx
			// 
			this.username_txtbx.Location = new System.Drawing.Point(515, 135);
			this.username_txtbx.Margin = new System.Windows.Forms.Padding(4);
			this.username_txtbx.Name = "username_txtbx";
			this.username_txtbx.Size = new System.Drawing.Size(228, 31);
			this.username_txtbx.TabIndex = 2;
			// 
			// password_txtbx
			// 
			this.password_txtbx.Location = new System.Drawing.Point(515, 229);
			this.password_txtbx.Margin = new System.Windows.Forms.Padding(4);
			this.password_txtbx.Name = "password_txtbx";
			this.password_txtbx.PasswordChar = '*';
			this.password_txtbx.Size = new System.Drawing.Size(228, 31);
			this.password_txtbx.TabIndex = 2;
			this.password_txtbx.UseSystemPasswordChar = true;
			this.password_txtbx.TextChanged += new System.EventHandler(this.password_txtbx_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(397, 141);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(401, 235);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// no_account_btn
			// 
			this.no_account_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.no_account_btn.Location = new System.Drawing.Point(141, 450);
			this.no_account_btn.Margin = new System.Windows.Forms.Padding(4);
			this.no_account_btn.Name = "no_account_btn";
			this.no_account_btn.Size = new System.Drawing.Size(165, 36);
			this.no_account_btn.TabIndex = 5;
			this.no_account_btn.Text = "Create account";
			this.no_account_btn.UseVisualStyleBackColor = true;
			this.no_account_btn.Click += new System.EventHandler(this.no_account_btn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::View.Properties.Resources.main_cat;
			this.pictureBox1.Location = new System.Drawing.Point(88, 45);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(268, 338);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.no_account_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.password_txtbx);
			this.Controls.Add(this.username_txtbx);
			this.Controls.Add(this.login_btn);
			this.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.RightToLeftLayout = true;
			this.Text = "login";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox username_txtbx;
        private System.Windows.Forms.TextBox password_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button no_account_btn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

