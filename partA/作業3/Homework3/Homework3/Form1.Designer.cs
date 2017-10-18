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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openfile = new System.Windows.Forms.Button();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.chart_original = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Histogram_Shrink = new System.Windows.Forms.Button();
            this.chart_Shrink = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox_Shrink = new System.Windows.Forms.PictureBox();
            this.chart_Stretch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox_Stretch = new System.Windows.Forms.PictureBox();
            this.Histogram_Stretch = new System.Windows.Forms.Button();
            this.button_Equalization = new System.Windows.Forms.Button();
            this.chart_Equalization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox_Equalization = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Shrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Shrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stretch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stretch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Equalization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equalization)).BeginInit();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 1;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 41);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 2;
            this.pictureBox_original.TabStop = false;
            // 
            // chart_original
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_original.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_original.Legends.Add(legend1);
            this.chart_original.Location = new System.Drawing.Point(218, 41);
            this.chart_original.Name = "chart_original";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_original.Series.Add(series1);
            this.chart_original.Size = new System.Drawing.Size(339, 200);
            this.chart_original.TabIndex = 3;
            this.chart_original.Text = "chart1";
            // 
            // Histogram_Shrink
            // 
            this.Histogram_Shrink.Location = new System.Drawing.Point(93, 12);
            this.Histogram_Shrink.Name = "Histogram_Shrink";
            this.Histogram_Shrink.Size = new System.Drawing.Size(119, 23);
            this.Histogram_Shrink.TabIndex = 4;
            this.Histogram_Shrink.Text = "Histogram Shrink";
            this.Histogram_Shrink.UseVisualStyleBackColor = true;
            this.Histogram_Shrink.Click += new System.EventHandler(this.Histogram_Shrink_Click);
            // 
            // chart_Shrink
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Shrink.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_Shrink.Legends.Add(legend2);
            this.chart_Shrink.Location = new System.Drawing.Point(769, 41);
            this.chart_Shrink.Name = "chart_Shrink";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_Shrink.Series.Add(series2);
            this.chart_Shrink.Size = new System.Drawing.Size(339, 200);
            this.chart_Shrink.TabIndex = 6;
            this.chart_Shrink.Text = "chart2";
            // 
            // pictureBox_Shrink
            // 
            this.pictureBox_Shrink.Location = new System.Drawing.Point(563, 41);
            this.pictureBox_Shrink.Name = "pictureBox_Shrink";
            this.pictureBox_Shrink.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_Shrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Shrink.TabIndex = 5;
            this.pictureBox_Shrink.TabStop = false;
            // 
            // chart_Stretch
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_Stretch.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_Stretch.Legends.Add(legend3);
            this.chart_Stretch.Location = new System.Drawing.Point(218, 273);
            this.chart_Stretch.Name = "chart_Stretch";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_Stretch.Series.Add(series3);
            this.chart_Stretch.Size = new System.Drawing.Size(339, 200);
            this.chart_Stretch.TabIndex = 8;
            this.chart_Stretch.Text = "chart2";
            // 
            // pictureBox_Stretch
            // 
            this.pictureBox_Stretch.Location = new System.Drawing.Point(12, 273);
            this.pictureBox_Stretch.Name = "pictureBox_Stretch";
            this.pictureBox_Stretch.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_Stretch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Stretch.TabIndex = 7;
            this.pictureBox_Stretch.TabStop = false;
            // 
            // Histogram_Stretch
            // 
            this.Histogram_Stretch.Location = new System.Drawing.Point(218, 12);
            this.Histogram_Stretch.Name = "Histogram_Stretch";
            this.Histogram_Stretch.Size = new System.Drawing.Size(119, 23);
            this.Histogram_Stretch.TabIndex = 9;
            this.Histogram_Stretch.Text = "Histogram Shrink";
            this.Histogram_Stretch.UseVisualStyleBackColor = true;
            this.Histogram_Stretch.Click += new System.EventHandler(this.Histogram_Stretch_Click);
            // 
            // button_Equalization
            // 
            this.button_Equalization.Location = new System.Drawing.Point(343, 12);
            this.button_Equalization.Name = "button_Equalization";
            this.button_Equalization.Size = new System.Drawing.Size(141, 23);
            this.button_Equalization.TabIndex = 10;
            this.button_Equalization.Text = "Histogram Equalization";
            this.button_Equalization.UseVisualStyleBackColor = true;
            this.button_Equalization.Click += new System.EventHandler(this.button_Slide_Click);
            // 
            // chart_Equalization
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_Equalization.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_Equalization.Legends.Add(legend4);
            this.chart_Equalization.Location = new System.Drawing.Point(769, 273);
            this.chart_Equalization.Name = "chart_Equalization";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_Equalization.Series.Add(series4);
            this.chart_Equalization.Size = new System.Drawing.Size(339, 200);
            this.chart_Equalization.TabIndex = 12;
            this.chart_Equalization.Text = "chart2";
            // 
            // pictureBox_Equalization
            // 
            this.pictureBox_Equalization.Location = new System.Drawing.Point(563, 273);
            this.pictureBox_Equalization.Name = "pictureBox_Equalization";
            this.pictureBox_Equalization.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_Equalization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Equalization.TabIndex = 11;
            this.pictureBox_Equalization.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 591);
            this.Controls.Add(this.chart_Equalization);
            this.Controls.Add(this.pictureBox_Equalization);
            this.Controls.Add(this.button_Equalization);
            this.Controls.Add(this.Histogram_Stretch);
            this.Controls.Add(this.chart_Stretch);
            this.Controls.Add(this.pictureBox_Stretch);
            this.Controls.Add(this.chart_Shrink);
            this.Controls.Add(this.pictureBox_Shrink);
            this.Controls.Add(this.Histogram_Shrink);
            this.Controls.Add(this.chart_original);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Histogram ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Shrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Shrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stretch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stretch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Equalization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equalization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_original;
        private System.Windows.Forms.Button Histogram_Shrink;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Shrink;
        private System.Windows.Forms.PictureBox pictureBox_Shrink;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Stretch;
        private System.Windows.Forms.PictureBox pictureBox_Stretch;
        private System.Windows.Forms.Button Histogram_Stretch;
        private System.Windows.Forms.Button button_Equalization;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Equalization;
        private System.Windows.Forms.PictureBox pictureBox_Equalization;
    }
}

