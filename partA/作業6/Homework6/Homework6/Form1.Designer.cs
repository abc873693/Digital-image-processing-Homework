namespace Homework6
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.openfile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_spatial_high_pass_filter3X3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_spatial_high_pass_filter5X5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox_spatial_high_pass_filter7X7 = new System.Windows.Forms.PictureBox();
            this.button_spatial_high_pass_filter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_spatial_high_boost_filter3X3_3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_spatial_high_boost_filter3X3_2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox_spatial_high_boost_filter3X3_1 = new System.Windows.Forms.PictureBox();
            this.button_spatial_high_boost_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_pass_filter3X3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_pass_filter5X5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_pass_filter7X7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_boost_filter3X3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_boost_filter3X3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_boost_filter3X3_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "original";
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 58);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 15;
            this.pictureBox_original.TabStop = false;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 14;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "進度條";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(52, 501);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(978, 23);
            this.progressBar1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "spatial_high_pass_filter3X3";
            // 
            // pictureBox_spatial_high_pass_filter3X3
            // 
            this.pictureBox_spatial_high_pass_filter3X3.Location = new System.Drawing.Point(268, 58);
            this.pictureBox_spatial_high_pass_filter3X3.Name = "pictureBox_spatial_high_pass_filter3X3";
            this.pictureBox_spatial_high_pass_filter3X3.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_spatial_high_pass_filter3X3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_spatial_high_pass_filter3X3.TabIndex = 32;
            this.pictureBox_spatial_high_pass_filter3X3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "spatial_high_pass_filter5X5";
            // 
            // pictureBox_spatial_high_pass_filter5X5
            // 
            this.pictureBox_spatial_high_pass_filter5X5.Location = new System.Drawing.Point(524, 58);
            this.pictureBox_spatial_high_pass_filter5X5.Name = "pictureBox_spatial_high_pass_filter5X5";
            this.pictureBox_spatial_high_pass_filter5X5.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_spatial_high_pass_filter5X5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_spatial_high_pass_filter5X5.TabIndex = 34;
            this.pictureBox_spatial_high_pass_filter5X5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "spatial_high_pass_filter7X7";
            // 
            // pictureBox_spatial_high_pass_filter7X7
            // 
            this.pictureBox_spatial_high_pass_filter7X7.Location = new System.Drawing.Point(780, 58);
            this.pictureBox_spatial_high_pass_filter7X7.Name = "pictureBox_spatial_high_pass_filter7X7";
            this.pictureBox_spatial_high_pass_filter7X7.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_spatial_high_pass_filter7X7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_spatial_high_pass_filter7X7.TabIndex = 36;
            this.pictureBox_spatial_high_pass_filter7X7.TabStop = false;
            // 
            // button_spatial_high_pass_filter
            // 
            this.button_spatial_high_pass_filter.Enabled = false;
            this.button_spatial_high_pass_filter.Location = new System.Drawing.Point(93, 12);
            this.button_spatial_high_pass_filter.Name = "button_spatial_high_pass_filter";
            this.button_spatial_high_pass_filter.Size = new System.Drawing.Size(134, 23);
            this.button_spatial_high_pass_filter.TabIndex = 38;
            this.button_spatial_high_pass_filter.Text = "spatial_high_pass_filter";
            this.button_spatial_high_pass_filter.UseVisualStyleBackColor = true;
            this.button_spatial_high_pass_filter.Click += new System.EventHandler(this.button_spatial_high_pass_filter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 12);
            this.label5.TabIndex = 46;
            this.label5.Text = "spatial_high-boost_filter3X3_3";
            // 
            // pictureBox_spatial_high_boost_filter3X3_3
            // 
            this.pictureBox_spatial_high_boost_filter3X3_3.Location = new System.Drawing.Point(780, 284);
            this.pictureBox_spatial_high_boost_filter3X3_3.Name = "pictureBox_spatial_high_boost_filter3X3_3";
            this.pictureBox_spatial_high_boost_filter3X3_3.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_spatial_high_boost_filter3X3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_spatial_high_boost_filter3X3_3.TabIndex = 45;
            this.pictureBox_spatial_high_boost_filter3X3_3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 12);
            this.label6.TabIndex = 44;
            this.label6.Text = "spatial_high-boost_filter3X3_3";
            // 
            // pictureBox_spatial_high_boost_filter3X3_2
            // 
            this.pictureBox_spatial_high_boost_filter3X3_2.Location = new System.Drawing.Point(524, 284);
            this.pictureBox_spatial_high_boost_filter3X3_2.Name = "pictureBox_spatial_high_boost_filter3X3_2";
            this.pictureBox_spatial_high_boost_filter3X3_2.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_spatial_high_boost_filter3X3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_spatial_high_boost_filter3X3_2.TabIndex = 43;
            this.pictureBox_spatial_high_boost_filter3X3_2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "spatial_high-boost_filter3X3_1";
            // 
            // pictureBox_spatial_high_boost_filter3X3_1
            // 
            this.pictureBox_spatial_high_boost_filter3X3_1.Location = new System.Drawing.Point(268, 284);
            this.pictureBox_spatial_high_boost_filter3X3_1.Name = "pictureBox_spatial_high_boost_filter3X3_1";
            this.pictureBox_spatial_high_boost_filter3X3_1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_spatial_high_boost_filter3X3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_spatial_high_boost_filter3X3_1.TabIndex = 41;
            this.pictureBox_spatial_high_boost_filter3X3_1.TabStop = false;
            // 
            // button_spatial_high_boost_filter
            // 
            this.button_spatial_high_boost_filter.Enabled = false;
            this.button_spatial_high_boost_filter.Location = new System.Drawing.Point(233, 12);
            this.button_spatial_high_boost_filter.Name = "button_spatial_high_boost_filter";
            this.button_spatial_high_boost_filter.Size = new System.Drawing.Size(134, 23);
            this.button_spatial_high_boost_filter.TabIndex = 47;
            this.button_spatial_high_boost_filter.Text = "spatial_high-boost_filter";
            this.button_spatial_high_boost_filter.UseVisualStyleBackColor = true;
            this.button_spatial_high_boost_filter.Click += new System.EventHandler(this.button_spatial_high_boost_filter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 535);
            this.Controls.Add(this.button_spatial_high_boost_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox_spatial_high_boost_filter3X3_3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox_spatial_high_boost_filter3X3_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox_spatial_high_boost_filter3X3_1);
            this.Controls.Add(this.button_spatial_high_pass_filter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_spatial_high_pass_filter7X7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_spatial_high_pass_filter5X5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_spatial_high_pass_filter3X3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Sharpening Filter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_pass_filter3X3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_pass_filter5X5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_pass_filter7X7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_boost_filter3X3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_boost_filter3X3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_spatial_high_boost_filter3X3_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_spatial_high_pass_filter3X3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_spatial_high_pass_filter5X5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_spatial_high_pass_filter7X7;
        private System.Windows.Forms.Button button_spatial_high_pass_filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_spatial_high_boost_filter3X3_3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_spatial_high_boost_filter3X3_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox_spatial_high_boost_filter3X3_1;
        private System.Windows.Forms.Button button_spatial_high_boost_filter;
    }
}

