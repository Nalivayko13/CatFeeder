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
			this.choose_timetable_cmbbx = new System.Windows.Forms.ComboBox();
			this.back_btn = new System.Windows.Forms.Button();
			this.save_btn = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
			this.label1.Size = new System.Drawing.Size(47, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Имя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 112);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Выбрать расписание";
			// 
			// choose_timetable_cmbbx
			// 
			this.choose_timetable_cmbbx.FormattingEnabled = true;
			this.choose_timetable_cmbbx.Location = new System.Drawing.Point(32, 142);
			this.choose_timetable_cmbbx.Margin = new System.Windows.Forms.Padding(4);
			this.choose_timetable_cmbbx.Name = "choose_timetable_cmbbx";
			this.choose_timetable_cmbbx.Size = new System.Drawing.Size(188, 33);
			this.choose_timetable_cmbbx.TabIndex = 3;
			this.choose_timetable_cmbbx.SelectedIndexChanged += new System.EventHandler(this.choose_timetable_cmbbx_SelectedIndexChanged);
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(32, 496);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 4;
			this.back_btn.Text = "Назад";
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
			this.save_btn.Text = "Сохранить";
			this.save_btn.UseVisualStyleBackColor = true;
			this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// edit_feeder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 562);
			this.Controls.Add(this.save_btn);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.choose_timetable_cmbbx);
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
        private System.Windows.Forms.ComboBox choose_timetable_cmbbx;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button save_btn;
		private System.Windows.Forms.ImageList imageList1;
	}
}