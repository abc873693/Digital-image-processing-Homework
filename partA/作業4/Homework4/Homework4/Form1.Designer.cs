namespace Homework4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openfile = new System.Windows.Forms.Button();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.pictureBox_Gaussian_noise = new System.Windows.Forms.PictureBox();
            this.button_Gaussian_noise = new System.Windows.Forms.Button();
            this.pictureBox_Uniform_noise = new System.Windows.Forms.PictureBox();
            this.button_Uniform_noise = new System.Windows.Forms.Button();
            this.pictureBox_Impulse_noise = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Impulse_noise = new System.Windows.Forms.Button();
            this.chart_Uniform_noise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Gaussian_noise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Impulse_noise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gaussian_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Uniform_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Impulse_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Uniform_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Gaussian_noise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Impulse_noise)).BeginInit();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 2;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 54);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 3;
            this.pictureBox_original.TabStop = false;
            // 
            // pictureBox_Gaussian_noise
            // 
            this.pictureBox_Gaussian_noise.Location = new System.Drawing.Point(12, 286);
            this.pictureBox_Gaussian_noise.Name = "pictureBox_Gaussian_noise";
            this.pictureBox_Gaussian_noise.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Gaussian_noise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Gaussian_noise.TabIndex = 4;
            this.pictureBox_Gaussian_noise.TabStop = false;
            // 
            // button_Gaussian_noise
            // 
            this.button_Gaussian_noise.Location = new System.Drawing.Point(93, 12);
            this.button_Gaussian_noise.Name = "button_Gaussian_noise";
            this.button_Gaussian_noise.Size = new System.Drawing.Size(99, 23);
            this.button_Gaussian_noise.TabIndex = 5;
            this.button_Gaussian_noise.Text = "Gaussian_noise";
            this.button_Gaussian_noise.UseVisualStyleBackColor = true;
            this.button_Gaussian_noise.Click += new System.EventHandler(this.button_Gaussian_noise_Click);
            // 
            // pictureBox_Uniform_noise
            // 
            this.pictureBox_Uniform_noise.Location = new System.Drawing.Point(268, 286);
            this.pictureBox_Uniform_noise.Name = "pictureBox_Uniform_noise";
            this.pictureBox_Uniform_noise.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Uniform_noise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Uniform_noise.TabIndex = 6;
            this.pictureBox_Uniform_noise.TabStop = false;
            // 
            // button_Uniform_noise
            // 
            this.button_Uniform_noise.Location = new System.Drawing.Point(198, 12);
            this.button_Uniform_noise.Name = "button_Uniform_noise";
            this.button_Uniform_noise.Size = new System.Drawing.Size(99, 23);
            this.button_Uniform_noise.TabIndex = 7;
            this.button_Uniform_noise.Text = "Uniform_noise";
            this.button_Uniform_noise.UseVisualStyleBackColor = true;
            this.button_Uniform_noise.Click += new System.EventHandler(this.button_Uniform_noise_Click);
            // 
            // pictureBox_Impulse_noise
            // 
            this.pictureBox_Impulse_noise.Location = new System.Drawing.Point(524, 286);
            this.pictureBox_Impulse_noise.Name = "pictureBox_Impulse_noise";
            this.pictureBox_Impulse_noise.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Impulse_noise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Impulse_noise.TabIndex = 8;
            this.pictureBox_Impulse_noise.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gaussian_noise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Uniform_noise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Impulse_noise";
            // 
            // button_Impulse_noise
            // 
            this.button_Impulse_noise.Location = new System.Drawing.Point(303, 12);
            this.button_Impulse_noise.Name = "button_Impulse_noise";
            this.button_Impulse_noise.Size = new System.Drawing.Size(102, 23);
            this.button_Impulse_noise.TabIndex = 13;
            this.button_Impulse_noise.Text = "Impulse_noise";
            this.button_Impulse_noise.UseVisualStyleBackColor = true;
            this.button_Impulse_noise.Click += new System.EventHandler(this.button_Impulse_noise_Click);
            // 
            // chart_Uniform_noise
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Uniform_noise.ChartAreas.Add(chartArea1);
            this.chart_Uniform_noise.Location = new System.Drawing.Point(268, 503);
            this.chart_Uniform_noise.Name = "chart_Uniform_noise";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart_Uniform_noise.Series.Add(series1);
            this.chart_Uniform_noise.Size = new System.Drawing.Size(250, 200);
            this.chart_Uniform_noise.TabIndex = 14;
            this.chart_Uniform_noise.Text = "chart1";
            // 
            // chart_Gaussian_noise
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Gaussian_noise.ChartAreas.Add(chartArea2);
            this.chart_Gaussian_noise.Location = new System.Drawing.Point(3, 503);
            this.chart_Gaussian_noise.Name = "chart_Gaussian_noise";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart_Gaussian_noise.Series.Add(series2);
            this.chart_Gaussian_noise.Size = new System.Drawing.Size(250, 200);
            this.chart_Gaussian_noise.TabIndex = 15;
            this.chart_Gaussian_noise.Text = "chart1";
            // 
            // chart_Impulse_noise
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_Impulse_noise.ChartAreas.Add(chartArea3);
            this.chart_Impulse_noise.Location = new System.Drawing.Point(524, 503);
            this.chart_Impulse_noise.Name = "chart_Impulse_noise";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart_Impulse_noise.Series.Add(series3);
            this.chart_Impulse_noise.Size = new System.Drawing.Size(250, 200);
            this.chart_Impulse_noise.TabIndex = 16;
            this.chart_Impulse_noise.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 792);
            this.Controls.Add(this.chart_Impulse_noise);
            this.Controls.Add(this.chart_Gaussian_noise);
            this.Controls.Add(this.chart_Uniform_noise);
            this.Controls.Add(this.button_Impulse_noise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Impulse_noise);
            this.Controls.Add(this.button_Uniform_noise);
            this.Controls.Add(this.pictureBox_Uniform_noise);
            this.Controls.Add(this.button_Gaussian_noise);
            this.Controls.Add(this.pictureBox_Gaussian_noise);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Noise Models";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gaussian_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Uniform_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Impulse_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Uniform_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Gaussian_noise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Impulse_noise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.PictureBox pictureBox_Gaussian_noise;
        private System.Windows.Forms.Button button_Gaussian_noise;
        private System.Windows.Forms.PictureBox pictureBox_Uniform_noise;
        private System.Windows.Forms.Button button_Uniform_noise;
        private System.Windows.Forms.PictureBox pictureBox_Impulse_noise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Impulse_noise;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Uniform_noise;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Gaussian_noise;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Impulse_noise;
    }
}

