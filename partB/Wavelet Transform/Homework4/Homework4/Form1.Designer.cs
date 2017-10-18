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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_General_Wavelet_form = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_original_GWF = new System.Windows.Forms.PictureBox();
            this.pictureBox_GWF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original_GWF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GWF)).BeginInit();
            this.SuspendLayout();
            // 
            // button_General_Wavelet_form
            // 
            this.button_General_Wavelet_form.Enabled = false;
            this.button_General_Wavelet_form.Location = new System.Drawing.Point(93, 12);
            this.button_General_Wavelet_form.Name = "button_General_Wavelet_form";
            this.button_General_Wavelet_form.Size = new System.Drawing.Size(144, 23);
            this.button_General_Wavelet_form.TabIndex = 62;
            this.button_General_Wavelet_form.Text = "General Wavelet form";
            this.button_General_Wavelet_form.UseVisualStyleBackColor = true;
            this.button_General_Wavelet_form.Click += new System.EventHandler(this.button_General_Wavelet_form_Click);
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 61;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "original";
            // 
            // pictureBox_original_GWF
            // 
            this.pictureBox_original_GWF.Location = new System.Drawing.Point(12, 52);
            this.pictureBox_original_GWF.Name = "pictureBox_original_GWF";
            this.pictureBox_original_GWF.Size = new System.Drawing.Size(250, 250);
            this.pictureBox_original_GWF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original_GWF.TabIndex = 63;
            this.pictureBox_original_GWF.TabStop = false;
            // 
            // pictureBox_GWF
            // 
            this.pictureBox_GWF.Location = new System.Drawing.Point(268, 52);
            this.pictureBox_GWF.Name = "pictureBox_GWF";
            this.pictureBox_GWF.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_GWF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_GWF.TabIndex = 65;
            this.pictureBox_GWF.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 573);
            this.Controls.Add(this.pictureBox_GWF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_original_GWF);
            this.Controls.Add(this.button_General_Wavelet_form);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "General Wavelet form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original_GWF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GWF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_General_Wavelet_form;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_original_GWF;
        private System.Windows.Forms.PictureBox pictureBox_GWF;
    }
}

