namespace CatFeeder
{
    partial class manage_timetables
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manage_timetables));
			this.back_btn = new System.Windows.Forms.Button();
			this.import_btn = new System.Windows.Forms.Button();
			this.timetables = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.timetables.SuspendLayout();
			this.SuspendLayout();
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(50, 482);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 1;
			this.back_btn.Text = "Go back";
			this.back_btn.UseVisualStyleBackColor = true;
			this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
			// 
			// import_btn
			// 
			this.import_btn.Location = new System.Drawing.Point(613, 482);
			this.import_btn.Margin = new System.Windows.Forms.Padding(4);
			this.import_btn.Name = "import_btn";
			this.import_btn.Size = new System.Drawing.Size(118, 36);
			this.import_btn.TabIndex = 2;
			this.import_btn.Text = "Import All";
			this.import_btn.UseVisualStyleBackColor = true;
			// 
			// timetables
			// 
			this.timetables.AutoScroll = true;
			this.timetables.Controls.Add(this.button4);
			this.timetables.Controls.Add(this.button5);
			this.timetables.Controls.Add(this.button6);
			this.timetables.Controls.Add(this.label2);
			this.timetables.Controls.Add(this.button3);
			this.timetables.Controls.Add(this.button2);
			this.timetables.Controls.Add(this.button1);
			this.timetables.Controls.Add(this.label1);
			this.timetables.Location = new System.Drawing.Point(50, 49);
			this.timetables.Margin = new System.Windows.Forms.Padding(4);
			this.timetables.Name = "timetables";
			this.timetables.Size = new System.Drawing.Size(681, 372);
			this.timetables.TabIndex = 3;
			this.timetables.Paint += new System.Windows.Forms.PaintEventHandler(this.timetables_Paint);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(524, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 34);
			this.button3.TabIndex = 3;
			this.button3.Text = "Remove";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(370, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 34);
			this.button2.TabIndex = 2;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(217, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 1;
			this.button1.Text = "Export";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "TimetableName 1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(524, 108);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 34);
			this.button4.TabIndex = 7;
			this.button4.Text = "Remove";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(370, 108);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(112, 34);
			this.button5.TabIndex = 6;
			this.button5.Text = "Edit";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(217, 108);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 34);
			this.button6.TabIndex = 5;
			this.button6.Text = "Export";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "TimetableName 2";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// manage_timetables
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.timetables);
			this.Controls.Add(this.import_btn);
			this.Controls.Add(this.back_btn);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "manage_timetables";
			this.Text = "manage_timetables";
			this.Load += new System.EventHandler(this.manage_timetables_Load);
			this.timetables.ResumeLayout(false);
			this.timetables.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Panel timetables;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label2;
	}
}