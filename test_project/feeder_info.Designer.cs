namespace CatFeeder
{
    partial class feeder_info
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feeder_info));
			this.label1 = new System.Windows.Forms.Label();
			this.back_btn = new System.Windows.Forms.Button();
			this.check_logs_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(341, 96);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Stats";
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(82, 431);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 1;
			this.back_btn.Text = "Go back";
			this.back_btn.UseVisualStyleBackColor = true;
			// 
			// check_logs_btn
			// 
			this.check_logs_btn.Location = new System.Drawing.Point(475, 431);
			this.check_logs_btn.Margin = new System.Windows.Forms.Padding(4);
			this.check_logs_btn.Name = "check_logs_btn";
			this.check_logs_btn.Size = new System.Drawing.Size(199, 36);
			this.check_logs_btn.TabIndex = 2;
			this.check_logs_btn.Text = "View logs";
			this.check_logs_btn.UseVisualStyleBackColor = true;
			// 
			// feeder_info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.check_logs_btn);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "feeder_info";
			this.Text = "feeder_info";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button check_logs_btn;
    }
}