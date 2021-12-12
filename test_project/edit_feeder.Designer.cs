namespace test_project
{
    partial class edit_feeder
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
			this.components = new System.ComponentModel.Container();
			this.feeder_name_txtbx = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.back_btn = new System.Windows.Forms.Button();
			this.save_btn = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// feeder_name_txtbx
			// 
			this.feeder_name_txtbx.Location = new System.Drawing.Point(32, 45);
			this.feeder_name_txtbx.Margin = new System.Windows.Forms.Padding(4);
			this.feeder_name_txtbx.Name = "feeder_name_txtbx";
			this.feeder_name_txtbx.Size = new System.Drawing.Size(155, 31);
			this.feeder_name_txtbx.TabIndex = 0;
			this.feeder_name_txtbx.TextChanged += new System.EventHandler(this.feeder_name_txtbx_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 112);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enter time";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(32, 496);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 4;
			this.back_btn.Text = "Go back";
			this.back_btn.UseVisualStyleBackColor = true;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// save_btn
			// 
			this.save_btn.Location = new System.Drawing.Point(845, 496);
			this.save_btn.Margin = new System.Windows.Forms.Padding(4);
			this.save_btn.Name = "save_btn";
			this.save_btn.Size = new System.Drawing.Size(118, 36);
			this.save_btn.TabIndex = 5;
			this.save_btn.Text = "Save name";
			this.save_btn.UseVisualStyleBackColor = true;
			this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(32, 151);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(155, 31);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(612, 498);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 7;
			this.button1.Text = "Save time";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// edit_feeder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 562);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.save_btn);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.feeder_name_txtbx);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "edit_feeder";
			this.Text = "edit_feeder";
			this.Load += new System.EventHandler(this.edit_feeder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox feeder_name_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button save_btn;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}