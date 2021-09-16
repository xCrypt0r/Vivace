
namespace Vivace
{
    partial class ListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstMatched = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSkipped = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMatchedCount = new System.Windows.Forms.Label();
            this.lblSkippedCount = new System.Windows.Forms.Label();
            this.lblCorrectRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMatched
            // 
            this.lstMatched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lstMatched.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMatched.FormattingEnabled = true;
            this.lstMatched.ItemHeight = 12;
            this.lstMatched.Location = new System.Drawing.Point(22, 58);
            this.lstMatched.Name = "lstMatched";
            this.lstMatched.Size = new System.Drawing.Size(140, 216);
            this.lstMatched.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(55, 10, 55, 10);
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "정답";
            // 
            // lstSkipped
            // 
            this.lstSkipped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lstSkipped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSkipped.FormattingEnabled = true;
            this.lstSkipped.ItemHeight = 12;
            this.lstSkipped.Location = new System.Drawing.Point(168, 58);
            this.lstSkipped.Name = "lstSkipped";
            this.lstSkipped.Size = new System.Drawing.Size(140, 216);
            this.lstSkipped.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(168, 23);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(55, 10, 55, 10);
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "오답";
            // 
            // lblMatchedCount
            // 
            this.lblMatchedCount.AutoSize = true;
            this.lblMatchedCount.Location = new System.Drawing.Point(83, 9);
            this.lblMatchedCount.Name = "lblMatchedCount";
            this.lblMatchedCount.Size = new System.Drawing.Size(11, 12);
            this.lblMatchedCount.TabIndex = 6;
            this.lblMatchedCount.Text = "0";
            // 
            // lblSkippedCount
            // 
            this.lblSkippedCount.AutoSize = true;
            this.lblSkippedCount.Location = new System.Drawing.Point(232, 11);
            this.lblSkippedCount.Name = "lblSkippedCount";
            this.lblSkippedCount.Size = new System.Drawing.Size(11, 12);
            this.lblSkippedCount.TabIndex = 7;
            this.lblSkippedCount.Text = "0";
            // 
            // lblCorrectRate
            // 
            this.lblCorrectRate.AutoSize = true;
            this.lblCorrectRate.Location = new System.Drawing.Point(23, 286);
            this.lblCorrectRate.Name = "lblCorrectRate";
            this.lblCorrectRate.Size = new System.Drawing.Size(81, 12);
            this.lblCorrectRate.TabIndex = 8;
            this.lblCorrectRate.Text = "정답률: 0.00%";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.lblCorrectRate);
            this.Controls.Add(this.lblSkippedCount);
            this.Controls.Add(this.lblMatchedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSkipped);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMatched);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lstMatched;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSkipped;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMatchedCount;
        private System.Windows.Forms.Label lblSkippedCount;
        private System.Windows.Forms.Label lblCorrectRate;
    }
}
