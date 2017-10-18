namespace Homework3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openfile = new System.Windows.Forms.Button();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.button_Hough_transform = new System.Windows.Forms.Button();
            this.pictureBox_Hough_transform = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox_acc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hough_transform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_acc)).BeginInit();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 15;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 41);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(378, 367);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 16;
            this.pictureBox_original.TabStop = false;
            // 
            // button_Hough_transform
            // 
            this.button_Hough_transform.Location = new System.Drawing.Point(93, 12);
            this.button_Hough_transform.Name = "button_Hough_transform";
            this.button_Hough_transform.Size = new System.Drawing.Size(117, 23);
            this.button_Hough_transform.TabIndex = 17;
            this.button_Hough_transform.Text = "Hough transform";
            this.button_Hough_transform.UseVisualStyleBackColor = true;
            this.button_Hough_transform.Click += new System.EventHandler(this.button_Hough_transform_Click);
            // 
            // pictureBox_Hough_transform
            // 
            this.pictureBox_Hough_transform.Location = new System.Drawing.Point(780, 41);
            this.pictureBox_Hough_transform.Name = "pictureBox_Hough_transform";
            this.pictureBox_Hough_transform.Size = new System.Drawing.Size(378, 367);
            this.pictureBox_Hough_transform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Hough_transform.TabIndex = 18;
            this.pictureBox_Hough_transform.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1164, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 367);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // pictureBox_acc
            // 
            this.pictureBox_acc.Location = new System.Drawing.Point(396, 41);
            this.pictureBox_acc.Name = "pictureBox_acc";
            this.pictureBox_acc.Size = new System.Drawing.Size(378, 367);
            this.pictureBox_acc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_acc.TabIndex = 20;
            this.pictureBox_acc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 495);
            this.Controls.Add(this.pictureBox_acc);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox_Hough_transform);
            this.Controls.Add(this.button_Hough_transform);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hough_transform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_acc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button button_Hough_transform;
        private System.Windows.Forms.PictureBox pictureBox_Hough_transform;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox_acc;
    }
}

