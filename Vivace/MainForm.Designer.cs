
namespace Vivace
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picCover = new System.Windows.Forms.PictureBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.tmrUptime = new System.Windows.Forms.Timer(this.components);
            this.lblUptime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // picCover
            // 
            this.picCover.Image = global::Vivace.Properties.Resources.DefaultCover;
            this.picCover.InitialImage = null;
            this.picCover.Location = new System.Drawing.Point(95, 32);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(240, 240);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 0;
            this.picCover.TabStop = false;
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(191, 326);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(32, 12);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "artist";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(195, 296);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(24, 12);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "title";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtAnswer.ForeColor = System.Drawing.Color.White;
            this.txtAnswer.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtAnswer.Location = new System.Drawing.Point(14, 357);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(412, 25);
            this.txtAnswer.TabIndex = 0;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(15, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 12);
            this.lblCount.TabIndex = 6;
            // 
            // tmrUptime
            // 
            this.tmrUptime.Tick += new System.EventHandler(this.tmrUptime_Tick);
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.Location = new System.Drawing.Point(377, 9);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(49, 12);
            this.lblUptime.TabIndex = 7;
            this.lblUptime.Text = "00:00:00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(438, 409);
            this.Controls.Add(this.lblUptime);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.picCover);
            this.Font = new System.Drawing.Font("Gulim", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer tmrUptime;
        private System.Windows.Forms.Label lblUptime;
    }
}

