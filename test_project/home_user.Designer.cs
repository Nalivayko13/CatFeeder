namespace CatFeeder
{
    partial class home_user
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_user));
			this.add_feeder_btn = new System.Windows.Forms.Button();
			this.manage_timetables_btn = new System.Windows.Forms.Button();
			this.quit_btn = new System.Windows.Forms.Button();
			this.feeders = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// add_feeder_btn
			// 
			this.add_feeder_btn.Location = new System.Drawing.Point(372, 449);
			this.add_feeder_btn.Margin = new System.Windows.Forms.Padding(4);
			this.add_feeder_btn.Name = "add_feeder_btn";
			this.add_feeder_btn.Size = new System.Drawing.Size(160, 36);
			this.add_feeder_btn.TabIndex = 5;
			this.add_feeder_btn.Text = "Add feeder";
			this.add_feeder_btn.UseVisualStyleBackColor = true;
			this.add_feeder_btn.Click += new System.EventHandler(this.add_feeder_btn_Click);
			// 
			// manage_timetables_btn
			// 
			this.manage_timetables_btn.Location = new System.Drawing.Point(564, 449);
			this.manage_timetables_btn.Margin = new System.Windows.Forms.Padding(4);
			this.manage_timetables_btn.Name = "manage_timetables_btn";
			this.manage_timetables_btn.Size = new System.Drawing.Size(160, 36);
			this.manage_timetables_btn.TabIndex = 6;
			this.manage_timetables_btn.Text = "Edit timetable";
			this.manage_timetables_btn.UseVisualStyleBackColor = true;
			this.manage_timetables_btn.Click += new System.EventHandler(this.manage_timetables_btn_Click);
			// 
			// quit_btn
			// 
			this.quit_btn.Location = new System.Drawing.Point(13, 495);
			this.quit_btn.Margin = new System.Windows.Forms.Padding(4);
			this.quit_btn.Name = "quit_btn";
			this.quit_btn.Size = new System.Drawing.Size(118, 36);
			this.quit_btn.TabIndex = 7;
			this.quit_btn.Tag = "";
			this.quit_btn.Text = "Go back";
			this.quit_btn.UseVisualStyleBackColor = true;
			this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
			// 
			// feeders
			// 
			this.feeders.AutoScroll = true;
			this.feeders.Location = new System.Drawing.Point(42, 49);
			this.feeders.Margin = new System.Windows.Forms.Padding(4);
			this.feeders.Name = "feeders";
			this.feeders.Size = new System.Drawing.Size(900, 378);
			this.feeders.TabIndex = 8;
			this.feeders.Paint += new System.Windows.Forms.PaintEventHandler(this.feeders_Paint);
			// 
			// home_user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 544);
			this.Controls.Add(this.feeders);
			this.Controls.Add(this.quit_btn);
			this.Controls.Add(this.manage_timetables_btn);
			this.Controls.Add(this.add_feeder_btn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "home_user";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.home_user_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button add_feeder_btn;
        private System.Windows.Forms.Button manage_timetables_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Panel feeders;
    }
}