namespace CatFeeder
{
    partial class user_list
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
			this.delete_btn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.back_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 59);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "<Username>";
			// 
			// delete_btn
			// 
			this.delete_btn.Location = new System.Drawing.Point(507, 53);
			this.delete_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(118, 36);
			this.delete_btn.TabIndex = 1;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(312, 59);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "<ID>";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(13, 495);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 3;
			this.back_btn.Text = "Go back";
			this.back_btn.UseVisualStyleBackColor = true;
			// 
			// user_list
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.delete_btn);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "user_list";
			this.Text = "user_list";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
    }
}