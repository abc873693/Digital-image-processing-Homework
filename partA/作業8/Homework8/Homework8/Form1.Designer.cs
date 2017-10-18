namespace Homework8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.openfile = new System.Windows.Forms.Button();
            this.button_DCT_8X8 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button_General_Wavelet_form = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_original_GWF = new System.Windows.Forms.PictureBox();
            this.pictureBox_GWF = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original_GWF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GWF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 56;
            this.label1.Text = "original";
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_original.Image")));
            this.pictureBox_original.Location = new System.Drawing.Point(12, 67);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 55;
            this.pictureBox_original.TabStop = false;
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(12, 12);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(75, 23);
            this.openfile.TabIndex = 54;
            this.openfile.Text = "開啟檔案";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // button_DCT_8X8
            // 
            this.button_DCT_8X8.Location = new System.Drawing.Point(93, 12);
            this.button_DCT_8X8.Name = "button_DCT_8X8";
            this.button_DCT_8X8.Size = new System.Drawing.Size(75, 23);
            this.button_DCT_8X8.TabIndex = 57;
            this.button_DCT_8X8.Text = "DCT 8X8";
            this.button_DCT_8X8.UseVisualStyleBackColor = true;
            this.button_DCT_8X8.Click += new System.EventHandler(this.button_DCT_8X8_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(793, 67);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(215, 200);
            this.richTextBox1.TabIndex = 58;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(793, 288);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(215, 185);
            this.richTextBox2.TabIndex = 59;
            this.richTextBox2.Text = "";
            // 
            // button_General_Wavelet_form
            // 
            this.button_General_Wavelet_form.Enabled = false;
            this.button_General_Wavelet_form.Location = new System.Drawing.Point(174, 12);
            this.button_General_Wavelet_form.Name = "button_General_Wavelet_form";
            this.button_General_Wavelet_form.Size = new System.Drawing.Size(144, 23);
            this.button_General_Wavelet_form.TabIndex = 60;
            this.button_General_Wavelet_form.Text = "General Wavelet form";
            this.button_General_Wavelet_form.UseVisualStyleBackColor = true;
            this.button_General_Wavelet_form.Click += new System.EventHandler(this.button_General_Wavelet_form_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "original";
            // 
            // pictureBox_original_GWF
            // 
            this.pictureBox_original_GWF.Location = new System.Drawing.Point(12, 329);
            this.pictureBox_original_GWF.Name = "pictureBox_original_GWF";
            this.pictureBox_original_GWF.Size = new System.Drawing.Size(250, 250);
            this.pictureBox_original_GWF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original_GWF.TabIndex = 61;
            this.pictureBox_original_GWF.TabStop = false;
            // 
            // pictureBox_GWF
            // 
            this.pictureBox_GWF.Location = new System.Drawing.Point(268, 67);
            this.pictureBox_GWF.Name = "pictureBox_GWF";
            this.pictureBox_GWF.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_GWF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_GWF.TabIndex = 63;
            this.pictureBox_GWF.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(791, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 64;
            this.label3.Text = "原區塊";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(792, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 65;
            this.label4.Text = "DCT後";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 597);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_GWF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_original_GWF);
            this.Controls.Add(this.button_General_Wavelet_form);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_DCT_8X8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "DCT & General Wavelet form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original_GWF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GWF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button button_DCT_8X8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_General_Wavelet_form;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_original_GWF;
        private System.Windows.Forms.PictureBox pictureBox_GWF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

