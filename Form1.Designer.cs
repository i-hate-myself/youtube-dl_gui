namespace youtube_downloadergui
{
    partial class Form1
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
            this.det = new System.Windows.Forms.Label();
            this.tubelink = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // det
            // 
            this.det.AutoSize = true;
            this.det.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.det.Location = new System.Drawing.Point(12, 128);
            this.det.Name = "det";
            this.det.Size = new System.Drawing.Size(128, 18);
            this.det.TabIndex = 0;
            this.det.Text = "details will go here\r\n";
            // 
            // tubelink
            // 
            this.tubelink.Location = new System.Drawing.Point(12, 12);
            this.tubelink.Name = "tubelink";
            this.tubelink.Size = new System.Drawing.Size(377, 20);
            this.tubelink.TabIndex = 1;
            this.tubelink.Text = "link";
            this.tubelink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(15, 38);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(136, 34);
            this.download.TabIndex = 2;
            this.download.Text = "info";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(652, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "code";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            ".mp4",
            ".mp3",
            ".%(ext)s"});
            this.listBox1.Location = new System.Drawing.Point(395, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = ".%(ext)s\r\n is just the format\r\n you chose";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.download);
            this.Controls.Add(this.tubelink);
            this.Controls.Add(this.det);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label det;
        private System.Windows.Forms.TextBox tubelink;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

