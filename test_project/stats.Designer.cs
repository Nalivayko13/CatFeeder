namespace CatFeeder
{
    partial class stats
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
			this.back_btn = new System.Windows.Forms.Button();
			this.export_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 52);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Stats";
			// 
			// back_btn
			// 
			this.back_btn.Location = new System.Drawing.Point(59, 472);
			this.back_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(118, 36);
			this.back_btn.TabIndex = 1;
			this.back_btn.Text = "Go back";
			this.back_btn.UseVisualStyleBackColor = true;
			// 
			// export_btn
			// 
			this.export_btn.Location = new System.Drawing.Point(800, 600);
			this.export_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.export_btn.Name = "export_btn";
			this.export_btn.Size = new System.Drawing.Size(118, 36);
			this.export_btn.TabIndex = 2;
			this.export_btn.Text = "Export";
			this.export_btn.UseVisualStyleBackColor = true;
			// 
			// stats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 562);
			this.Controls.Add(this.export_btn);
			this.Controls.Add(this.back_btn);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "stats";
			this.Text = "stats";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button export_btn;
    }
}