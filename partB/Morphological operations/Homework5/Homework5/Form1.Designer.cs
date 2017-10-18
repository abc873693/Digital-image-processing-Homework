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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.button_Dilation = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.button_Erosion = new System.Windows.Forms.Button();
            this.button_Closing = new System.Windows.Forms.Button();
            this.button_Opening = new System.Windows.Forms.Button();
            this.pictureBox_result = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_result)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 68;
            this.label2.Text = "original";
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 52);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(250, 250);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 67;
            this.pictureBox_original.TabStop = false;
            // 
            // button_Dilation
            // 
            this.button_Dilation.Enabled = false;
            this.button_Dilation.Location = new System.Drawing.Point(93, 12);
            this.button_Dilation.Name = "button_Dilation";
            this.button_Dilation.Size = new System.Drawing.Size(80, 23);
            this.button_Dilation.TabIndex = 66;
            this.button_Dilation.Text = "Dilation";
            this.button_Dilation.UseVisualStyleBackColor = true;
            this.button_Dilation.Click += new System.EventHandler(this.Button_Dilation_Click);
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 65;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.Openfile_Click);
            // 
            // button_Erosion
            // 
            this.button_Erosion.Enabled = false;
            this.button_Erosion.Location = new System.Drawing.Point(179, 12);
            this.button_Erosion.Name = "button_Erosion";
            this.button_Erosion.Size = new System.Drawing.Size(80, 23);
            this.button_Erosion.TabIndex = 69;
            this.button_Erosion.Text = "Erosion";
            this.button_Erosion.UseVisualStyleBackColor = true;
            this.button_Erosion.Click += new System.EventHandler(this.Button_Erosion_Click);
            // 
            // button_Closing
            // 
            this.button_Closing.Enabled = false;
            this.button_Closing.Location = new System.Drawing.Point(351, 12);
            this.button_Closing.Name = "button_Closing";
            this.button_Closing.Size = new System.Drawing.Size(80, 23);
            this.button_Closing.TabIndex = 71;
            this.button_Closing.Text = "Closing";
            this.button_Closing.UseVisualStyleBackColor = true;
            this.button_Closing.Click += new System.EventHandler(this.Button_Closing_Click);
            // 
            // button_Opening
            // 
            this.button_Opening.Enabled = false;
            this.button_Opening.Location = new System.Drawing.Point(265, 12);
            this.button_Opening.Name = "button_Opening";
            this.button_Opening.Size = new System.Drawing.Size(80, 23);
            this.button_Opening.TabIndex = 70;
            this.button_Opening.Text = "Opening";
            this.button_Opening.UseVisualStyleBackColor = true;
            this.button_Opening.Click += new System.EventHandler(this.Button_Opening_Click);
            // 
            // pictureBox_result
            // 
            this.pictureBox_result.Location = new System.Drawing.Point(280, 52);
            this.pictureBox_result.Name = "pictureBox_result";
            this.pictureBox_result.Size = new System.Drawing.Size(250, 250);
            this.pictureBox_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_result.TabIndex = 72;
            this.pictureBox_result.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 73;
            this.label1.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_result);
            this.Controls.Add(this.button_Closing);
            this.Controls.Add(this.button_Opening);
            this.Controls.Add(this.button_Erosion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.button_Dilation);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Morphology";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button button_Dilation;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button button_Erosion;
        private System.Windows.Forms.Button button_Closing;
        private System.Windows.Forms.Button button_Opening;
        private System.Windows.Forms.PictureBox pictureBox_result;
        private System.Windows.Forms.Label label1;
    }
}

