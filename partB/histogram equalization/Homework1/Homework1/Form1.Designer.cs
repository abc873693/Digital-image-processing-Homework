namespace Homework1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox_Equalization = new System.Windows.Forms.PictureBox();
            this.button_Equalization = new System.Windows.Forms.Button();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.openfile = new System.Windows.Forms.Button();
            this.chart_original = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Equalization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equalization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Equalization)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Equalization
            // 
            this.pictureBox_Equalization.Location = new System.Drawing.Point(12, 258);
            this.pictureBox_Equalization.Name = "pictureBox_Equalization";
            this.pictureBox_Equalization.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_Equalization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Equalization.TabIndex = 15;
            this.pictureBox_Equalization.TabStop = false;
            // 
            // button_Equalization
            // 
            this.button_Equalization.Location = new System.Drawing.Point(93, 12);
            this.button_Equalization.Name = "button_Equalization";
            this.button_Equalization.Size = new System.Drawing.Size(141, 23);
            this.button_Equalization.TabIndex = 14;
            this.button_Equalization.Text = "Histogram Equalization";
            this.button_Equalization.UseVisualStyleBackColor = true;
            this.button_Equalization.Click += new System.EventHandler(this.button_Equalization_Click);
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 41);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 13;
            this.pictureBox_original.TabStop = false;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 12;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // chart_original
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_original.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_original.Legends.Add(legend5);
            this.chart_original.Location = new System.Drawing.Point(219, 41);
            this.chart_original.Name = "chart_original";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_original.Series.Add(series5);
            this.chart_original.Size = new System.Drawing.Size(343, 200);
            this.chart_original.TabIndex = 16;
            this.chart_original.Text = "chart1";
            // 
            // chart_Equalization
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_Equalization.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_Equalization.Legends.Add(legend6);
            this.chart_Equalization.Location = new System.Drawing.Point(218, 258);
            this.chart_Equalization.Name = "chart_Equalization";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart_Equalization.Series.Add(series6);
            this.chart_Equalization.Size = new System.Drawing.Size(343, 200);
            this.chart_Equalization.TabIndex = 17;
            this.chart_Equalization.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 472);
            this.Controls.Add(this.chart_Equalization);
            this.Controls.Add(this.chart_original);
            this.Controls.Add(this.pictureBox_Equalization);
            this.Controls.Add(this.button_Equalization);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Histogram Equalization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Equalization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Equalization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Equalization;
        private System.Windows.Forms.Button button_Equalization;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Equalization;
    }
}

