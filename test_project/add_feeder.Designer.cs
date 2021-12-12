namespace CatFeeder
{
    partial class add_feeder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_feeder));
			this.add_feeder_txtbx = new System.Windows.Forms.TextBox();
			this.add_feeder_btn = new System.Windows.Forms.Button();
			this.back_btn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// add_feeder_txtbx
			// 
			this.add_feeder_txtbx.Location = new System.Drawing.Point(226, 374);
			this.add_feeder_txtbx.Margin = new System.Windows.Forms.Padding(4);
			this.add_feeder_txtbx.Name = "add_feeder_txtbx";
			this.add_feeder_txtbx.Size = new System.Drawing.Size(180, 31);
			this.add_feeder_txtbx.TabIndex = 0;
			this.add_feeder_txtbx.TextChanged += new System.EventHandler(this.add_feeder_txtbx_TextChanged);
			// 
			// add_feeder_btn
			// 
			this.add_feeder_btn.Location = new System.Drawing.Point(461, 374);
			this.add_feeder_btn.Margin = new System.Windows.Forms.Padding(4);
			this.add_feeder_btn.Name = "add_feeder_btn";
			this.add_feeder_btn.Size = new System.Drawing.Size(118, 36);
			this.add_feeder_btn.TabIndex = 1;
			this.add_feeder_btn.Text = "Add feeder";
			this.add_feeder_btn.UseVisualStyleBackColor = true;
			this.add_feeder_btn.Click += new System.EventHandler(this.add_feeder_btn_Click);
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(36, 476);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 2;
			this.back_btn.Text = "Go back";
			this.back_btn.UseVisualStyleBackColor = true;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::View.Properties.Resources.pivo1_cr_200x150_1;
			this.pictureBox1.Location = new System.Drawing.Point(226, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(353, 311);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// add_feeder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.add_feeder_btn);
			this.Controls.Add(this.add_feeder_txtbx);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "add_feeder";
			this.Text = "add_feeder";
			this.Load += new System.EventHandler(this.add_feeder_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_feeder_txtbx;
        private System.Windows.Forms.Button add_feeder_btn;
        private System.Windows.Forms.Button back_btn;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}