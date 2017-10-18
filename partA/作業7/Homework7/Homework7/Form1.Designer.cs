namespace Homework7
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
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_Prewitt1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Prewitt_vertical = new System.Windows.Forms.PictureBox();
            this.pictureBox_Prewitt_horizontal = new System.Windows.Forms.PictureBox();
            this.button_Prewitt_operator_Dedge = new System.Windows.Forms.Button();
            this.button_Prewitt_operator_HVedge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_original = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_Prewitt2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Prewitt_diagonalB = new System.Windows.Forms.PictureBox();
            this.pictureBox_Prewitt_diagonalA = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox_Sobel2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sobel_diagonalB = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sobel_diagonalA = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox_Sobel1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sobel_vertical = new System.Windows.Forms.PictureBox();
            this.pictureBox_Sobel_horizontal = new System.Windows.Forms.PictureBox();
            this.button_Sobel_operator_Dedge = new System.Windows.Forms.Button();
            this.button_Sobel_operator_HVedge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_diagonalB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_diagonalA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_diagonalB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_diagonalA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_horizontal)).BeginInit();
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 755);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "進度條";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(56, 744);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1598, 23);
            this.progressBar1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox_Prewitt2);
            this.groupBox1.Controls.Add(this.pictureBox_Prewitt_diagonalB);
            this.groupBox1.Controls.Add(this.pictureBox_Prewitt_diagonalA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox_Prewitt1);
            this.groupBox1.Controls.Add(this.pictureBox_Prewitt_vertical);
            this.groupBox1.Controls.Add(this.pictureBox_Prewitt_horizontal);
            this.groupBox1.Location = new System.Drawing.Point(12, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 459);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prewitt operator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 59;
            this.label5.Text = "vertical";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 58;
            this.label4.Text = " horizontal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 57;
            this.label3.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 56;
            this.label2.Text = "+";
            // 
            // pictureBox_Prewitt1
            // 
            this.pictureBox_Prewitt1.Location = new System.Drawing.Point(552, 30);
            this.pictureBox_Prewitt1.Name = "pictureBox_Prewitt1";
            this.pictureBox_Prewitt1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Prewitt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Prewitt1.TabIndex = 55;
            this.pictureBox_Prewitt1.TabStop = false;
            // 
            // pictureBox_Prewitt_vertical
            // 
            this.pictureBox_Prewitt_vertical.Location = new System.Drawing.Point(279, 30);
            this.pictureBox_Prewitt_vertical.Name = "pictureBox_Prewitt_vertical";
            this.pictureBox_Prewitt_vertical.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Prewitt_vertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Prewitt_vertical.TabIndex = 54;
            this.pictureBox_Prewitt_vertical.TabStop = false;
            // 
            // pictureBox_Prewitt_horizontal
            // 
            this.pictureBox_Prewitt_horizontal.Location = new System.Drawing.Point(6, 30);
            this.pictureBox_Prewitt_horizontal.Name = "pictureBox_Prewitt_horizontal";
            this.pictureBox_Prewitt_horizontal.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Prewitt_horizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Prewitt_horizontal.TabIndex = 53;
            this.pictureBox_Prewitt_horizontal.TabStop = false;
            // 
            // button_Prewitt_operator_Dedge
            // 
            this.button_Prewitt_operator_Dedge.Enabled = false;
            this.button_Prewitt_operator_Dedge.Location = new System.Drawing.Point(394, 12);
            this.button_Prewitt_operator_Dedge.Name = "button_Prewitt_operator_Dedge";
            this.button_Prewitt_operator_Dedge.Size = new System.Drawing.Size(225, 23);
            this.button_Prewitt_operator_Dedge.TabIndex = 51;
            this.button_Prewitt_operator_Dedge.Text = "Prewitt operator for detecting diagonal edges";
            this.button_Prewitt_operator_Dedge.UseVisualStyleBackColor = true;
            this.button_Prewitt_operator_Dedge.Click += new System.EventHandler(this.button_Prewitt_operator_Dedge_Click);
            // 
            // button_Prewitt_operator_HVedge
            // 
            this.button_Prewitt_operator_HVedge.Enabled = false;
            this.button_Prewitt_operator_HVedge.Location = new System.Drawing.Point(93, 12);
            this.button_Prewitt_operator_HVedge.Name = "button_Prewitt_operator_HVedge";
            this.button_Prewitt_operator_HVedge.Size = new System.Drawing.Size(295, 23);
            this.button_Prewitt_operator_HVedge.TabIndex = 50;
            this.button_Prewitt_operator_HVedge.Text = "Prewitt operator for detecting horizontal and vertical edges";
            this.button_Prewitt_operator_HVedge.UseVisualStyleBackColor = true;
            this.button_Prewitt_operator_HVedge.Click += new System.EventHandler(this.button_Prewitt_operator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "original";
            // 
            // pictureBox_original
            // 
            this.pictureBox_original.Location = new System.Drawing.Point(12, 67);
            this.pictureBox_original.Name = "pictureBox_original";
            this.pictureBox_original.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_original.TabIndex = 52;
            this.pictureBox_original.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 66;
            this.label6.Text = "diagonal B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 12);
            this.label7.TabIndex = 65;
            this.label7.Text = "diagonal A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 64;
            this.label8.Text = "=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 63;
            this.label9.Text = "+";
            // 
            // pictureBox_Prewitt2
            // 
            this.pictureBox_Prewitt2.Location = new System.Drawing.Point(552, 250);
            this.pictureBox_Prewitt2.Name = "pictureBox_Prewitt2";
            this.pictureBox_Prewitt2.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Prewitt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Prewitt2.TabIndex = 62;
            this.pictureBox_Prewitt2.TabStop = false;
            // 
            // pictureBox_Prewitt_diagonalB
            // 
            this.pictureBox_Prewitt_diagonalB.Location = new System.Drawing.Point(279, 250);
            this.pictureBox_Prewitt_diagonalB.Name = "pictureBox_Prewitt_diagonalB";
            this.pictureBox_Prewitt_diagonalB.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Prewitt_diagonalB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Prewitt_diagonalB.TabIndex = 61;
            this.pictureBox_Prewitt_diagonalB.TabStop = false;
            // 
            // pictureBox_Prewitt_diagonalA
            // 
            this.pictureBox_Prewitt_diagonalA.Location = new System.Drawing.Point(6, 250);
            this.pictureBox_Prewitt_diagonalA.Name = "pictureBox_Prewitt_diagonalA";
            this.pictureBox_Prewitt_diagonalA.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Prewitt_diagonalA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Prewitt_diagonalA.TabIndex = 60;
            this.pictureBox_Prewitt_diagonalA.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.pictureBox_Sobel2);
            this.groupBox2.Controls.Add(this.pictureBox_Sobel_diagonalB);
            this.groupBox2.Controls.Add(this.pictureBox_Sobel_diagonalA);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.pictureBox_Sobel1);
            this.groupBox2.Controls.Add(this.pictureBox_Sobel_vertical);
            this.groupBox2.Controls.Add(this.pictureBox_Sobel_horizontal);
            this.groupBox2.Location = new System.Drawing.Point(836, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 459);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobel operator";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 12);
            this.label11.TabIndex = 66;
            this.label11.Text = "diagonal B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(94, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 12);
            this.label12.TabIndex = 65;
            this.label12.Text = "diagonal A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(535, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 64;
            this.label13.Text = "=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 63;
            this.label14.Text = "+";
            // 
            // pictureBox_Sobel2
            // 
            this.pictureBox_Sobel2.Location = new System.Drawing.Point(552, 250);
            this.pictureBox_Sobel2.Name = "pictureBox_Sobel2";
            this.pictureBox_Sobel2.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Sobel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sobel2.TabIndex = 62;
            this.pictureBox_Sobel2.TabStop = false;
            // 
            // pictureBox_Sobel_diagonalB
            // 
            this.pictureBox_Sobel_diagonalB.Location = new System.Drawing.Point(279, 250);
            this.pictureBox_Sobel_diagonalB.Name = "pictureBox_Sobel_diagonalB";
            this.pictureBox_Sobel_diagonalB.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Sobel_diagonalB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sobel_diagonalB.TabIndex = 61;
            this.pictureBox_Sobel_diagonalB.TabStop = false;
            // 
            // pictureBox_Sobel_diagonalA
            // 
            this.pictureBox_Sobel_diagonalA.Location = new System.Drawing.Point(6, 250);
            this.pictureBox_Sobel_diagonalA.Name = "pictureBox_Sobel_diagonalA";
            this.pictureBox_Sobel_diagonalA.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Sobel_diagonalA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sobel_diagonalA.TabIndex = 60;
            this.pictureBox_Sobel_diagonalA.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(367, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 12);
            this.label15.TabIndex = 59;
            this.label15.Text = "vertical";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(94, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 12);
            this.label16.TabIndex = 58;
            this.label16.Text = " horizontal";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(535, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 57;
            this.label17.Text = "=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(262, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 56;
            this.label18.Text = "+";
            // 
            // pictureBox_Sobel1
            // 
            this.pictureBox_Sobel1.Location = new System.Drawing.Point(552, 30);
            this.pictureBox_Sobel1.Name = "pictureBox_Sobel1";
            this.pictureBox_Sobel1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Sobel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sobel1.TabIndex = 55;
            this.pictureBox_Sobel1.TabStop = false;
            // 
            // pictureBox_Sobel_vertical
            // 
            this.pictureBox_Sobel_vertical.Location = new System.Drawing.Point(279, 30);
            this.pictureBox_Sobel_vertical.Name = "pictureBox_Sobel_vertical";
            this.pictureBox_Sobel_vertical.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Sobel_vertical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sobel_vertical.TabIndex = 54;
            this.pictureBox_Sobel_vertical.TabStop = false;
            // 
            // pictureBox_Sobel_horizontal
            // 
            this.pictureBox_Sobel_horizontal.Location = new System.Drawing.Point(6, 30);
            this.pictureBox_Sobel_horizontal.Name = "pictureBox_Sobel_horizontal";
            this.pictureBox_Sobel_horizontal.Size = new System.Drawing.Size(250, 200);
            this.pictureBox_Sobel_horizontal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sobel_horizontal.TabIndex = 53;
            this.pictureBox_Sobel_horizontal.TabStop = false;
            // 
            // button_Sobel_operator_Dedge
            // 
            this.button_Sobel_operator_Dedge.Enabled = false;
            this.button_Sobel_operator_Dedge.Location = new System.Drawing.Point(926, 12);
            this.button_Sobel_operator_Dedge.Name = "button_Sobel_operator_Dedge";
            this.button_Sobel_operator_Dedge.Size = new System.Drawing.Size(225, 23);
            this.button_Sobel_operator_Dedge.TabIndex = 56;
            this.button_Sobel_operator_Dedge.Text = "Sobel operator for detecting diagonal edges";
            this.button_Sobel_operator_Dedge.UseVisualStyleBackColor = true;
            this.button_Sobel_operator_Dedge.Click += new System.EventHandler(this.button_Sobel_operator_Dedge_Click);
            // 
            // button_Sobel_operator_HVedge
            // 
            this.button_Sobel_operator_HVedge.Enabled = false;
            this.button_Sobel_operator_HVedge.Location = new System.Drawing.Point(625, 12);
            this.button_Sobel_operator_HVedge.Name = "button_Sobel_operator_HVedge";
            this.button_Sobel_operator_HVedge.Size = new System.Drawing.Size(295, 23);
            this.button_Sobel_operator_HVedge.TabIndex = 55;
            this.button_Sobel_operator_HVedge.Text = "Sobel operator for detecting horizontal and vertical edges";
            this.button_Sobel_operator_HVedge.UseVisualStyleBackColor = true;
            this.button_Sobel_operator_HVedge.Click += new System.EventHandler(this.button_Sobel_operator_HVedge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 783);
            this.Controls.Add(this.button_Sobel_operator_Dedge);
            this.Controls.Add(this.button_Sobel_operator_HVedge);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_original);
            this.Controls.Add(this.button_Prewitt_operator_Dedge);
            this.Controls.Add(this.button_Prewitt_operator_HVedge);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.openfile);
            this.Name = "Form1";
            this.Text = "Prewitt operator & Sobel operator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_diagonalB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Prewitt_diagonalA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_diagonalB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_diagonalA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sobel_horizontal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Prewitt_operator_Dedge;
        private System.Windows.Forms.Button button_Prewitt_operator_HVedge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_Prewitt1;
        private System.Windows.Forms.PictureBox pictureBox_Prewitt_vertical;
        private System.Windows.Forms.PictureBox pictureBox_Prewitt_horizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_original;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox_Prewitt2;
        private System.Windows.Forms.PictureBox pictureBox_Prewitt_diagonalB;
        private System.Windows.Forms.PictureBox pictureBox_Prewitt_diagonalA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox_Sobel2;
        private System.Windows.Forms.PictureBox pictureBox_Sobel_diagonalB;
        private System.Windows.Forms.PictureBox pictureBox_Sobel_diagonalA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox_Sobel1;
        private System.Windows.Forms.PictureBox pictureBox_Sobel_vertical;
        private System.Windows.Forms.PictureBox pictureBox_Sobel_horizontal;
        private System.Windows.Forms.Button button_Sobel_operator_Dedge;
        private System.Windows.Forms.Button button_Sobel_operator_HVedge;
    }
}

