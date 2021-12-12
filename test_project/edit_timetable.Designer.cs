namespace CatFeeder
{
    partial class edit_timetable
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_timetable));
			this.cancel_btn = new System.Windows.Forms.Button();
			this.save_btn = new System.Windows.Forms.Button();
			this.add_btn = new System.Windows.Forms.Button();
			this.timestamps = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cancel_btn
			// 
			this.cancel_btn.Location = new System.Drawing.Point(800, 600);
			this.cancel_btn.Margin = new System.Windows.Forms.Padding(4);
			this.cancel_btn.Name = "cancel_btn";
			this.cancel_btn.Size = new System.Drawing.Size(118, 36);
			this.cancel_btn.TabIndex = 1;
			this.cancel_btn.Text = "Cancel";
			this.cancel_btn.UseVisualStyleBackColor = true;
			// 
			// save_btn
			// 
			this.save_btn.Location = new System.Drawing.Point(776, 473);
			this.save_btn.Margin = new System.Windows.Forms.Padding(4);
			this.save_btn.Name = "save_btn";
			this.save_btn.Size = new System.Drawing.Size(120, 36);
			this.save_btn.TabIndex = 2;
			this.save_btn.Text = "Save";
			this.save_btn.UseVisualStyleBackColor = true;
			this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
			// 
			// add_btn
			// 
			this.add_btn.Location = new System.Drawing.Point(94, 473);
			this.add_btn.Margin = new System.Windows.Forms.Padding(4);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(150, 36);
			this.add_btn.TabIndex = 3;
			this.add_btn.Text = "Add time";
			this.add_btn.UseVisualStyleBackColor = true;
			this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
			// 
			// timestamps
			// 
			this.timestamps.AutoScroll = true;
			this.timestamps.Location = new System.Drawing.Point(94, 31);
			this.timestamps.Margin = new System.Windows.Forms.Padding(4);
			this.timestamps.Name = "timestamps";
			this.timestamps.Size = new System.Drawing.Size(800, 399);
			this.timestamps.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(984, 490);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 36);
			this.button1.TabIndex = 5;
			this.button1.Text = "Go back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(291, 473);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 36);
			this.button2.TabIndex = 6;
			this.button2.Text = "Remove time";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// edit_timetable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 544);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.timestamps);
			this.Controls.Add(this.add_btn);
			this.Controls.Add(this.save_btn);
			this.Controls.Add(this.cancel_btn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "edit_timetable";
			this.Text = "edit_timetable";
			this.Load += new System.EventHandler(this.edit_timetable_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel timestamps;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}