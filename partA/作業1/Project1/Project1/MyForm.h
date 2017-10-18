#pragma once

namespace Project1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// MyForm 的摘要
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: 在此加入建構函式程式碼
			//
			pictures[0] = pictureBox1;
			pictures[1] = pictureBox2;
			pictures[2] = pictureBox3;
			pictures[3] = pictureBox4;
			pictures[4] = pictureBox5;
			pictures[5] = pictureBox6;
			pictures[6] = pictureBox7;
			pictures[7] = pictureBox8;
			pictures[8] = pictureBox9;
			pictures[9] = pictureBox10;
		}

	protected:
		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::PictureBox^  pictureBox2;
	private: System::Windows::Forms::PictureBox^  pictureBox3;
	private: System::Windows::Forms::PictureBox^  pictureBox4;
	private: System::Windows::Forms::PictureBox^  pictureBox5;
	private: System::Windows::Forms::PictureBox^  pictureBox6;
	private: System::Windows::Forms::PictureBox^  pictureBox7;
	private: System::Windows::Forms::PictureBox^  pictureBox8;
	private: System::Windows::Forms::PictureBox^  pictureBox9;
	private: System::Windows::Forms::PictureBox^  pictureBox10;
	private: System::Windows::Forms::PictureBox^  pictureBoxA;
	private: System::Windows::Forms::PictureBox^  pictureBoxB;
	private: System::Windows::Forms::PictureBox^  pictureBoxP;
	protected: 

	private:
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
		/// 修改這個方法的內容。
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->pictureBox2 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox3 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox4 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox5 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox6 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox7 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox8 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox9 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox10 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBoxA = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBoxB = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBoxP = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox3))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox4))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox5))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox6))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox7))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox8))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox9))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox10))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxA))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxB))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxP))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(69, 42);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"開啟";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// pictureBox1
			// 
			this->pictureBox1->Location = System::Drawing::Point(69, 229);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(133, 118);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 1;
			this->pictureBox1->TabStop = false;
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(167, 42);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 23);
			this->button2->TabIndex = 2;
			this->button2->Text = L"處理";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// pictureBox2
			// 
			this->pictureBox2->Location = System::Drawing::Point(208, 229);
			this->pictureBox2->Name = L"pictureBox2";
			this->pictureBox2->Size = System::Drawing::Size(133, 118);
			this->pictureBox2->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox2->TabIndex = 3;
			this->pictureBox2->TabStop = false;
			// 
			// pictureBox3
			// 
			this->pictureBox3->Location = System::Drawing::Point(347, 229);
			this->pictureBox3->Name = L"pictureBox3";
			this->pictureBox3->Size = System::Drawing::Size(133, 118);
			this->pictureBox3->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox3->TabIndex = 4;
			this->pictureBox3->TabStop = false;
			// 
			// pictureBox4
			// 
			this->pictureBox4->Location = System::Drawing::Point(486, 229);
			this->pictureBox4->Name = L"pictureBox4";
			this->pictureBox4->Size = System::Drawing::Size(133, 118);
			this->pictureBox4->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox4->TabIndex = 5;
			this->pictureBox4->TabStop = false;
			// 
			// pictureBox5
			// 
			this->pictureBox5->Location = System::Drawing::Point(625, 229);
			this->pictureBox5->Name = L"pictureBox5";
			this->pictureBox5->Size = System::Drawing::Size(133, 118);
			this->pictureBox5->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox5->TabIndex = 6;
			this->pictureBox5->TabStop = false;
			// 
			// pictureBox6
			// 
			this->pictureBox6->Location = System::Drawing::Point(69, 389);
			this->pictureBox6->Name = L"pictureBox6";
			this->pictureBox6->Size = System::Drawing::Size(133, 118);
			this->pictureBox6->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox6->TabIndex = 7;
			this->pictureBox6->TabStop = false;
			// 
			// pictureBox7
			// 
			this->pictureBox7->Location = System::Drawing::Point(208, 389);
			this->pictureBox7->Name = L"pictureBox7";
			this->pictureBox7->Size = System::Drawing::Size(133, 118);
			this->pictureBox7->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox7->TabIndex = 8;
			this->pictureBox7->TabStop = false;
			// 
			// pictureBox8
			// 
			this->pictureBox8->Location = System::Drawing::Point(347, 389);
			this->pictureBox8->Name = L"pictureBox8";
			this->pictureBox8->Size = System::Drawing::Size(133, 118);
			this->pictureBox8->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox8->TabIndex = 9;
			this->pictureBox8->TabStop = false;
			// 
			// pictureBox9
			// 
			this->pictureBox9->Location = System::Drawing::Point(486, 389);
			this->pictureBox9->Name = L"pictureBox9";
			this->pictureBox9->Size = System::Drawing::Size(133, 118);
			this->pictureBox9->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox9->TabIndex = 10;
			this->pictureBox9->TabStop = false;
			// 
			// pictureBox10
			// 
			this->pictureBox10->Location = System::Drawing::Point(625, 389);
			this->pictureBox10->Name = L"pictureBox10";
			this->pictureBox10->Size = System::Drawing::Size(133, 118);
			this->pictureBox10->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox10->TabIndex = 11;
			this->pictureBox10->TabStop = false;
			// 
			// pictureBoxA
			// 
			this->pictureBoxA->Location = System::Drawing::Point(69, 93);
			this->pictureBoxA->Name = L"pictureBoxA";
			this->pictureBoxA->Size = System::Drawing::Size(133, 118);
			this->pictureBoxA->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBoxA->TabIndex = 12;
			this->pictureBoxA->TabStop = false;
			// 
			// pictureBoxB
			// 
			this->pictureBoxB->Location = System::Drawing::Point(208, 93);
			this->pictureBoxB->Name = L"pictureBoxB";
			this->pictureBoxB->Size = System::Drawing::Size(133, 118);
			this->pictureBoxB->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBoxB->TabIndex = 13;
			this->pictureBoxB->TabStop = false;
			// 
			// pictureBoxP
			// 
			this->pictureBoxP->Location = System::Drawing::Point(486, 93);
			this->pictureBoxP->Name = L"pictureBoxP";
			this->pictureBoxP->Size = System::Drawing::Size(133, 118);
			this->pictureBoxP->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBoxP->TabIndex = 14;
			this->pictureBoxP->TabStop = false;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(812, 606);
			this->Controls->Add(this->pictureBoxP);
			this->Controls->Add(this->pictureBoxB);
			this->Controls->Add(this->pictureBoxA);
			this->Controls->Add(this->pictureBox10);
			this->Controls->Add(this->pictureBox9);
			this->Controls->Add(this->pictureBox8);
			this->Controls->Add(this->pictureBox7);
			this->Controls->Add(this->pictureBox6);
			this->Controls->Add(this->pictureBox5);
			this->Controls->Add(this->pictureBox4);
			this->Controls->Add(this->pictureBox3);
			this->Controls->Add(this->pictureBox2);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox3))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox4))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox5))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox6))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox7))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox8))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox9))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox10))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxA))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxB))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxP))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
		//===變數宣告===
		//宣告點陣圖的格式
		Bitmap^ Image1;
		Bitmap^ Image2;
		Bitmap^ Image;
		Bitmap^ ImageP;
		//宣告圖像區域(設定為欲讀取、欲修正的圖像區域)
		Rectangle rect;
		Rectangle rect1;
		Rectangle rect2;
		Rectangle rectP;
		//宣告一int格式的指標
		IntPtr ptr;
		//掃瞄寬度- Byte資料寬度
		int BytesOfSkip1;
		int BytesOfSkip2;
		int BytesOfSkip;
		int BytesOfSkipP;
		//宣告為寬度的像素資訊
		int ByteNumber_Width;
		int ByteNumber_Width1;
		int ByteNumber_Width2;
		int ByteNumber_WidthP;
		//宣告一個Byte格式的指標
		Byte* p1;
		Byte* p2;
		Byte* p;
		Byte* pP;
	private: static array<System::Windows::Forms::PictureBox^>^ pictures=(gcnew array<System::Windows::Forms::PictureBox^>(64));
	private: static array<Bitmap^>^ Images=(gcnew array<Bitmap^>(64));
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
				 //===開圖主程式===
				 //new 一個 OpenFileDialog 物件
				 OpenFileDialog ^ openFileDialog1 = gcnew OpenFileDialog();
				 //設定Filter，用以限定使用者開啟的檔案
				 openFileDialog1->Filter = "點陣圖 (*.bmp)|*.bmp|All files (*.*)|*.*";
				 //預設檔案名稱為空值
				 openFileDialog1->FileName="";
				 //設定跳出選擇視窗的標題名稱
				 openFileDialog1->Title="載入影像";
				 //設定Filter選擇模式(依照Filter數，如本例選擇1表示起始出現的為點陣圖，選擇2表示All filts)
				 openFileDialog1->FilterIndex=1;
				 //跳出檔案選擇視窗(ShowDialog)，並且如果使用者點選檔案，並且檔案名稱超過0個字元，則判斷是為True，進入處理程序
				 if(openFileDialog1->ShowDialog()==System::Windows::Forms::DialogResult::OK && openFileDialog1->FileName->Length>0){
					 //將選取的檔案讀取並且存至Image1
					 Image1=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 //設定rect範圍大小
					 rect1=Rectangle(0,0,Image1->Width,Image1->Height);
					 //像素值為b,g,r方式排列下去，所以寬度實際上有*3的數值大小
					 //預設讀取3channel圖像
					 ByteNumber_Width=Image1->Width*3;
					 //顯示Image1於PictureBox1工具上
					 pictureBoxA->Image=Image1;
					 ImageP=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
				 }
				 if(openFileDialog1->ShowDialog()==System::Windows::Forms::DialogResult::OK && openFileDialog1->FileName->Length>0){
					 //將選取的檔案讀取並且存至Image1
					 Image2=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 //設定rect範圍大小
					 rect2=Rectangle(0,0,Image2->Width,Image2->Height);
					 //像素值為b,g,r方式排列下去，所以寬度實際上有*3的數值大小
					 //預設讀取3channel圖像
					 ByteNumber_Width=Image2->Width*3;
					 //顯示Image1於PictureBox1工具上
					 pictureBoxB->Image=Image2;
					 Image=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 for(int i=0;i<10;i++)
						 Images[i] =safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 //設定rect範圍大小
					 rect=Rectangle(0,0,Image->Width,Image->Height);
					 //像素值為b,g,r方式排列下去，所以寬度實際上有*3的數值大小
				 }


			 }
	private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
				 //==像素處理方式-彩圖轉灰階
				 //Lock欲處理的像素範圍(避免其他程序修改該向素值)，參數一為限定像素處理範圍，參數二為設定處理模式(讀取、寫入、讀取寫入，第三個像素為設定該像素模式bit? channel?)
				 //宣告為一BitmapData型態，表示像素值位置
				 Imaging::BitmapData^ ImageData1;
				 Imaging::BitmapData^ ImageData2;
				 //Imaging::BitmapData^ ImageData;
				 ImageData1=Image1->LockBits(rect1,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image1->PixelFormat);
				 ImageData2=Image2->LockBits(rect2,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image2->PixelFormat);
				 //ImageData=Image->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image->PixelFormat);
				 for(int i=0;i<10;i++){
					 Imaging::BitmapData^ ImageData;
					 ImageData=Images[i]->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image->PixelFormat);
					 //將int指標指向Image像素資料的最前面位置
					 IntPtr ptr1 = ImageData1->Scan0;
					 IntPtr ptr2 = ImageData2->Scan0;
					 IntPtr ptr = ImageData->Scan0;
					 //掃瞄寬度- Byte資料寬度
					 BytesOfSkip1=ImageData1->Stride - ByteNumber_Width1;
					 BytesOfSkip2=ImageData2->Stride - ByteNumber_Width2;
					 BytesOfSkip=ImageData->Stride - ByteNumber_Width;
					 //設定指標
					 //巡迴每一個像素
					 p1=(Byte*)((Void*)ptr1);
					 p2=(Byte*)((Void*)ptr2);
					 p=(Byte*)((Void*)ptr);
					 for(int y=0;y<Image1->Height;y++){
						 for(int x=0;x<Image1->Width;x++){
							 //計算灰階值(計算HSI的Y)
							 //像素值填入
							 p[0] =(Byte) (p1[0]*i/10 + p2[0]*(10-i)/10);	//填入像素值 channel 0 (Blue)
							 p[1] =(Byte) (p1[1]*i/10 + p2[1]*(10-i)/10);	//填入像素值 channel 1 (Green)
							 p[2] =(Byte) (p1[2]*i/10 + p2[2]*(10-i)/10);	//填入像素值 channel 2 (Red)

							 //指到下一個像素資訊
							 p1+=3;
							 p2+=3;
							 p+=3;
						 }
					 }
					 //Unlock處理完畢的像素範圍
					 Images[i]->UnlockBits(ImageData);
					 //將影像顯示在pictureBox1
					 pictures[i]->Image = Images[i];
				 }
				 Imaging::BitmapData^ ImageDataP;
				 ImageDataP=ImageP->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,ImageP->PixelFormat);
				 //將int指標指向Image像素資料的最前面位置
				 IntPtr ptrP = ImageDataP->Scan0;
				 //掃瞄寬度- Byte資料寬度
				 BytesOfSkipP=ImageDataP->Stride - ByteNumber_Width;
				 //設定指標
				 pP=(Byte*)((Void*)ptrP);
				 //巡迴每一個像素
				 for(int y=0;y<Image1->Height;y++){
					 for(int x=0;x<Image1->Width;x++){
						 //計算灰階值(計算HSI的Y)
						 int n =(int)( 0.114 * pP[0] + 0.587 * pP[1] + 0.299 * pP[2]) ;
						 int pixel =( pP[0] + pP[1] + pP[2])/3 ;
						 int xx = (n - pixel);
						 if((n - pixel)<=0)xx=0;
						 //像素值填入
						 pP[0]=(Byte)(xx);	//填入像素值 channel 0 (Blue)
						 pP[1]=(Byte)(xx);	//填入像素值 channel 1 (Green)
						 pP[2]=(Byte)(xx);	//填入像素值 channel 2 (Red)
						 //指到下一個像素資訊
						 pP+=3;
					 }
				 }
				 //Unlock處理完畢的像素範圍
				 ImageP->UnlockBits(ImageDataP);
				 //將影像顯示在pictureBox1
				 pictureBoxP->Image = ImageP;

			 }
	};
}
