namespace test_project
{
    partial class adminHomePage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Manage_feeder_ids_btn = new System.Windows.Forms.Button();
            this.User_list_btn = new System.Windows.Forms.Button();
            this.Stats_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кормушка 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кормушка2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кормушка3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Инфо";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Manage_feeder_ids_btn
            // 
            this.Manage_feeder_ids_btn.Location = new System.Drawing.Point(43, 380);
            this.Manage_feeder_ids_btn.Name = "Manage_feeder_ids_btn";
            this.Manage_feeder_ids_btn.Size = new System.Drawing.Size(256, 29);
            this.Manage_feeder_ids_btn.TabIndex = 4;
            this.Manage_feeder_ids_btn.Text = "Управление идентификаторами";
            this.Manage_feeder_ids_btn.UseVisualStyleBackColor = true;
            this.Manage_feeder_ids_btn.Click += new System.EventHandler(this.Manage_feeder_ids_btn_Click);
            // 
            // User_list_btn
            // 
            this.User_list_btn.Location = new System.Drawing.Point(318, 380);
            this.User_list_btn.Name = "User_list_btn";
            this.User_list_btn.Size = new System.Drawing.Size(231, 29);
            this.User_list_btn.TabIndex = 5;
            this.User_list_btn.Text = "Список пользователей";
            this.User_list_btn.UseVisualStyleBackColor = true;
            // 
            // Stats_btn
            // 
            this.Stats_btn.Location = new System.Drawing.Point(566, 380);
            this.Stats_btn.Name = "Stats_btn";
            this.Stats_btn.Size = new System.Drawing.Size(94, 29);
            this.Stats_btn.TabIndex = 6;
            this.Stats_btn.Text = "Статистика";
            this.Stats_btn.UseVisualStyleBackColor = true;
            // 
            // Logout_btn
            // 
            this.Logout_btn.Location = new System.Drawing.Point(677, 380);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(94, 29);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Выйти";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // home_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Stats_btn);
            this.Controls.Add(this.User_list_btn);
            this.Controls.Add(this.Manage_feeder_ids_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "home_admin";
            this.Text = "home_admin";
            this.Load += new System.EventHandler(this.home_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Manage_feeder_ids_btn;
        private System.Windows.Forms.Button User_list_btn;
        private System.Windows.Forms.Button Stats_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Label label4;
    }
}