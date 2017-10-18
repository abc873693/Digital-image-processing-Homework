namespace Homework2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.openfile = new System.Windows.Forms.Button();
            this.button_unsharp_masking = new System.Windows.Forms.Button();
            this.pictureBox_unsharp_masking = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_unsharp_masking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 37);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(378, 367);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 15;
            this.pictureBox_original.TabStop = false;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 8);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 14;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.Openfile_Click);
            // 
            // button_unsharp_masking
            // 
            this.button_unsharp_masking.Location = new System.Drawing.Point(93, 8);
            this.button_unsharp_masking.Name = "button_unsharp_masking";
            this.button_unsharp_masking.Size = new System.Drawing.Size(119, 23);
            this.button_unsharp_masking.TabIndex = 16;
            this.button_unsharp_masking.Text = "unsharp masking";
            this.button_unsharp_masking.UseVisualStyleBackColor = true;
            this.button_unsharp_masking.Click += new System.EventHandler(this.Button_unsharp_masking_Click);
            // 
            // pictureBox_unsharp_masking
            // 
            this.pictureBox_unsharp_masking.Location = new System.Drawing.Point(396, 37);
            this.pictureBox_unsharp_masking.Name = "pictureBox_unsharp_masking";
            this.pictureBox_unsharp_masking.Size = new System.Drawing.Size(398, 367);
            this.pictureBox_unsharp_masking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_unsharp_masking.TabIndex = 17;
            this.pictureBox_unsharp_masking.TabStop = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(825, 37);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 200);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 425);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox_unsharp_masking);
            this.Controls.Add(this.button_unsharp_masking);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "unsharp masking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_unsharp_masking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button button_unsharp_masking;
        private System.Windows.Forms.PictureBox pictureBox_unsharp_masking;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

