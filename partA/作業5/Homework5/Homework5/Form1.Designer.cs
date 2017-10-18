namespace Homework5
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
            this.openfile = new System.Windows.Forms.Button();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.button_Smoothing_filter = new System.Windows.Forms.Button();
            this.pictureBox_Smoothing_filter = new System.Windows.Forms.PictureBox();
            this.pictureBox_Impulse_noise = new System.Windows.Forms.PictureBox();
            this.pictureBox_median_filter3X3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_median_filter5X5 = new System.Windows.Forms.PictureBox();
            this.button_median_filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_21X21 = new System.Windows.Forms.RadioButton();
            this.radioButton_9X9 = new System.Windows.Forms.RadioButton();
            this.radioButton_7X7 = new System.Windows.Forms.RadioButton();
            this.radioButton_5X5 = new System.Windows.Forms.RadioButton();
            this.radioButton_3X3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_Gaussian_noise_impulse_noise = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox_alpha_trimmed3X3_T2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox_alpha_trimmed3X3_T1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_alpha_trimmed3X3_T4 = new System.Windows.Forms.PictureBox();
            this.button_alpha_trimmed = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Smoothing_filter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Impulse_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_median_filter3X3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_median_filter5X5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gaussian_noise_impulse_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alpha_trimmed3X3_T2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alpha_trimmed3X3_T1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alpha_trimmed3X3_T4)).BeginInit();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 3;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 58);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 4;
            this.pictureBox_original.TabStop = false;
            // 
            // button_Smoothing_filter
            // 
            this.button_Smoothing_filter.Enabled = false;
            this.button_Smoothing_filter.Location = new System.Drawing.Point(93, 12);
            this.button_Smoothing_filter.Name = "button_Smoothing_filter";
            this.button_Smoothing_filter.Size = new System.Drawing.Size(111, 23);
            this.button_Smoothing_filter.TabIndex = 5;
            this.button_Smoothing_filter.Text = "Smoothing filter";
            this.button_Smoothing_filter.UseVisualStyleBackColor = true;
            this.button_Smoothing_filter.Click += new System.EventHandler(this.button_Smoothing_filter_Click);
            // 
            // pictureBox_Smoothing_filter
            // 
            this.pictureBox_Smoothing_filter.Location = new System.Drawing.Point(268, 58);
            this.pictureBox_Smoothing_filter.Name = "pictureBox_Smoothing_filter";
            this.pictureBox_Smoothing_filter.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Smoothing_filter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Smoothing_filter.TabIndex = 6;
            this.pictureBox_Smoothing_filter.TabStop = false;
            // 
            // pictureBox_Impulse_noise
            // 
            this.pictureBox_Impulse_noise.Location = new System.Drawing.Point(12, 279);
            this.pictureBox_Impulse_noise.Name = "pictureBox_Impulse_noise";
            this.pictureBox_Impulse_noise.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Impulse_noise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Impulse_noise.TabIndex = 9;
            this.pictureBox_Impulse_noise.TabStop = false;
            // 
            // pictureBox_median_filter3X3
            // 
            this.pictureBox_median_filter3X3.Location = new System.Drawing.Point(268, 279);
            this.pictureBox_median_filter3X3.Name = "pictureBox_median_filter3X3";
            this.pictureBox_median_filter3X3.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_median_filter3X3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_median_filter3X3.TabIndex = 10;
            this.pictureBox_median_filter3X3.TabStop = false;
            // 
            // pictureBox_median_filter5X5
            // 
            this.pictureBox_median_filter5X5.Location = new System.Drawing.Point(524, 279);
            this.pictureBox_median_filter5X5.Name = "pictureBox_median_filter5X5";
            this.pictureBox_median_filter5X5.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_median_filter5X5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_median_filter5X5.TabIndex = 11;
            this.pictureBox_median_filter5X5.TabStop = false;
            // 
            // button_median_filter
            // 
            this.button_median_filter.Enabled = false;
            this.button_median_filter.Location = new System.Drawing.Point(210, 12);
            this.button_median_filter.Name = "button_median_filter";
            this.button_median_filter.Size = new System.Drawing.Size(111, 23);
            this.button_median_filter.TabIndex = 12;
            this.button_median_filter.Text = "median filter";
            this.button_median_filter.UseVisualStyleBackColor = true;
            this.button_median_filter.Click += new System.EventHandler(this.button_median_filter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Smoothing filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "original to Impulse_noise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Impulse_noise to median_filter3X3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Impulse_noise to median_filter5X5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_21X21);
            this.groupBox1.Controls.Add(this.radioButton_9X9);
            this.groupBox1.Controls.Add(this.radioButton_7X7);
            this.groupBox1.Controls.Add(this.radioButton_5X5);
            this.groupBox1.Controls.Add(this.radioButton_3X3);
            this.groupBox1.Location = new System.Drawing.Point(524, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 134);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smoothing filter mask";
            // 
            // radioButton_21X21
            // 
            this.radioButton_21X21.AutoSize = true;
            this.radioButton_21X21.Location = new System.Drawing.Point(15, 109);
            this.radioButton_21X21.Name = "radioButton_21X21";
            this.radioButton_21X21.Size = new System.Drawing.Size(55, 16);
            this.radioButton_21X21.TabIndex = 4;
            this.radioButton_21X21.Text = "21X21";
            this.radioButton_21X21.UseVisualStyleBackColor = true;
            // 
            // radioButton_9X9
            // 
            this.radioButton_9X9.AutoSize = true;
            this.radioButton_9X9.Location = new System.Drawing.Point(15, 87);
            this.radioButton_9X9.Name = "radioButton_9X9";
            this.radioButton_9X9.Size = new System.Drawing.Size(43, 16);
            this.radioButton_9X9.TabIndex = 3;
            this.radioButton_9X9.Text = "9X9";
            this.radioButton_9X9.UseVisualStyleBackColor = true;
            // 
            // radioButton_7X7
            // 
            this.radioButton_7X7.AutoSize = true;
            this.radioButton_7X7.Location = new System.Drawing.Point(15, 65);
            this.radioButton_7X7.Name = "radioButton_7X7";
            this.radioButton_7X7.Size = new System.Drawing.Size(43, 16);
            this.radioButton_7X7.TabIndex = 2;
            this.radioButton_7X7.Text = "7X7";
            this.radioButton_7X7.UseVisualStyleBackColor = true;
            // 
            // radioButton_5X5
            // 
            this.radioButton_5X5.AutoSize = true;
            this.radioButton_5X5.Location = new System.Drawing.Point(15, 43);
            this.radioButton_5X5.Name = "radioButton_5X5";
            this.radioButton_5X5.Size = new System.Drawing.Size(43, 16);
            this.radioButton_5X5.TabIndex = 1;
            this.radioButton_5X5.Text = "5X5";
            this.radioButton_5X5.UseVisualStyleBackColor = true;
            // 
            // radioButton_3X3
            // 
            this.radioButton_3X3.AutoSize = true;
            this.radioButton_3X3.Checked = true;
            this.radioButton_3X3.Location = new System.Drawing.Point(15, 21);
            this.radioButton_3X3.Name = "radioButton_3X3";
            this.radioButton_3X3.Size = new System.Drawing.Size(43, 16);
            this.radioButton_3X3.TabIndex = 0;
            this.radioButton_3X3.TabStop = true;
            this.radioButton_3X3.Text = "3X3";
            this.radioButton_3X3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "original to Gaussian noise and impulse noise";
            // 
            // pictureBox_Gaussian_noise_impulse_noise
            // 
            this.pictureBox_Gaussian_noise_impulse_noise.Location = new System.Drawing.Point(788, 58);
            this.pictureBox_Gaussian_noise_impulse_noise.Name = "pictureBox_Gaussian_noise_impulse_noise";
            this.pictureBox_Gaussian_noise_impulse_noise.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Gaussian_noise_impulse_noise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gaussian_noise_impulse_noise.TabIndex = 19;
            this.pictureBox_Gaussian_noise_impulse_noise.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(788, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "alpha-trimmed mean filter 3*3 T=2";
            // 
            // pictureBox_alpha_trimmed3X3_T2
            // 
            this.pictureBox_alpha_trimmed3X3_T2.Location = new System.Drawing.Point(788, 279);
            this.pictureBox_alpha_trimmed3X3_T2.Name = "pictureBox_alpha_trimmed3X3_T2";
            this.pictureBox_alpha_trimmed3X3_T2.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_alpha_trimmed3X3_T2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_alpha_trimmed3X3_T2.TabIndex = 21;
            this.pictureBox_alpha_trimmed3X3_T2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1044, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "alpha-trimmed mean filter 3*3 T=1";
            // 
            // pictureBox_alpha_trimmed3X3_T1
            // 
            this.pictureBox_alpha_trimmed3X3_T1.Location = new System.Drawing.Point(1044, 58);
            this.pictureBox_alpha_trimmed3X3_T1.Name = "pictureBox_alpha_trimmed3X3_T1";
            this.pictureBox_alpha_trimmed3X3_T1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_alpha_trimmed3X3_T1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_alpha_trimmed3X3_T1.TabIndex = 23;
            this.pictureBox_alpha_trimmed3X3_T1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1046, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "alpha-trimmed mean filter 3*3 T=4";
            // 
            // pictureBox_alpha_trimmed3X3_T4
            // 
            this.pictureBox_alpha_trimmed3X3_T4.Location = new System.Drawing.Point(1046, 279);
            this.pictureBox_alpha_trimmed3X3_T4.Name = "pictureBox_alpha_trimmed3X3_T4";
            this.pictureBox_alpha_trimmed3X3_T4.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_alpha_trimmed3X3_T4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_alpha_trimmed3X3_T4.TabIndex = 25;
            this.pictureBox_alpha_trimmed3X3_T4.TabStop = false;
            // 
            // button_alpha_trimmed
            // 
            this.button_alpha_trimmed.Enabled = false;
            this.button_alpha_trimmed.Location = new System.Drawing.Point(327, 12);
            this.button_alpha_trimmed.Name = "button_alpha_trimmed";
            this.button_alpha_trimmed.Size = new System.Drawing.Size(147, 23);
            this.button_alpha_trimmed.TabIndex = 27;
            this.button_alpha_trimmed.Text = "alpha-trimmed mean filter";
            this.button_alpha_trimmed.UseVisualStyleBackColor = true;
            this.button_alpha_trimmed.Click += new System.EventHandler(this.button_alpha_trimmed_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 491);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1237, 23);
            this.progressBar1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "進度條";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 537);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_alpha_trimmed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox_alpha_trimmed3X3_T4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox_alpha_trimmed3X3_T1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox_alpha_trimmed3X3_T2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox_Gaussian_noise_impulse_noise);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_median_filter);
            this.Controls.Add(this.pictureBox_median_filter5X5);
            this.Controls.Add(this.pictureBox_median_filter3X3);
            this.Controls.Add(this.pictureBox_Impulse_noise);
            this.Controls.Add(this.pictureBox_Smoothing_filter);
            this.Controls.Add(this.button_Smoothing_filter);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Smoothing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Smoothing_filter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Impulse_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_median_filter3X3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_median_filter5X5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gaussian_noise_impulse_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alpha_trimmed3X3_T2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alpha_trimmed3X3_T1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_alpha_trimmed3X3_T4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button button_Smoothing_filter;
        private System.Windows.Forms.PictureBox pictureBox_Smoothing_filter;
        private System.Windows.Forms.PictureBox pictureBox_Impulse_noise;
        private System.Windows.Forms.PictureBox pictureBox_median_filter3X3;
        private System.Windows.Forms.PictureBox pictureBox_median_filter5X5;
        private System.Windows.Forms.Button button_median_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_21X21;
        private System.Windows.Forms.RadioButton radioButton_9X9;
        private System.Windows.Forms.RadioButton radioButton_7X7;
        private System.Windows.Forms.RadioButton radioButton_5X5;
        private System.Windows.Forms.RadioButton radioButton_3X3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_Gaussian_noise_impulse_noise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox_alpha_trimmed3X3_T2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox_alpha_trimmed3X3_T1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox_alpha_trimmed3X3_T4;
        private System.Windows.Forms.Button button_alpha_trimmed;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label10;
    }
}

