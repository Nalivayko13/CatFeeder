namespace CatFeeder
{
    partial class feeder_id_list
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
			this.back_btn = new System.Windows.Forms.Button();
			this.feeder_id_txtbx = new System.Windows.Forms.TextBox();
			this.add_btn = new System.Windows.Forms.Button();
			this.feeder_ids = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(46, 482);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 4;
			this.back_btn.Text = "Go back";
			this.back_btn.UseVisualStyleBackColor = true;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// feeder_id_txtbx
			// 
			this.feeder_id_txtbx.Location = new System.Drawing.Point(232, 482);
			this.feeder_id_txtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.feeder_id_txtbx.Name = "feeder_id_txtbx";
			this.feeder_id_txtbx.Size = new System.Drawing.Size(290, 31);
			this.feeder_id_txtbx.TabIndex = 5;
			// 
			// add_btn
			// 
			this.add_btn.Location = new System.Drawing.Point(568, 482);
			this.add_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(109, 36);
			this.add_btn.TabIndex = 7;
			this.add_btn.Text = "Add";
			this.add_btn.UseVisualStyleBackColor = true;
			this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
			// 
			// feeder_ids
			// 
			this.feeder_ids.AutoScroll = true;
			this.feeder_ids.Location = new System.Drawing.Point(46, 52);
			this.feeder_ids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.feeder_ids.Name = "feeder_ids";
			this.feeder_ids.Size = new System.Drawing.Size(786, 386);
			this.feeder_ids.TabIndex = 8;
			// 
			// feeder_id_list
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.feeder_ids);
			this.Controls.Add(this.add_btn);
			this.Controls.Add(this.feeder_id_txtbx);
			this.Controls.Add(this.back_btn);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "feeder_id_list";
			this.Text = "feeder_id_list";
			this.Load += new System.EventHandler(this.feeder_id_list_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox feeder_id_txtbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Panel feeder_ids;
    }
}