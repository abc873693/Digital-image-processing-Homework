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
	protected: 
	private: System::Windows::Forms::PictureBox^  pictureBox1;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::PictureBox^  pictureBoxA;
	private: System::Windows::Forms::PictureBox^  pictureBox2;

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
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->pictureBoxA = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox2 = (gcnew System::Windows::Forms::PictureBox());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxA))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox2))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(158, 39);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"開啟";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// pictureBox1
			// 
			this->pictureBox1->Location = System::Drawing::Point(52, 75);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(150, 119);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::Zoom;
			this->pictureBox1->TabIndex = 1;
			this->pictureBox1->TabStop = false;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(52, 41);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(100, 22);
			this->textBox1->TabIndex = 2;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(361, 44);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(33, 12);
			this->label1->TabIndex = 3;
			this->label1->Text = L"label1";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(440, 44);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(33, 12);
			this->label2->TabIndex = 4;
			this->label2->Text = L"label2";
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(239, 39);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 23);
			this->button2->TabIndex = 5;
			this->button2->Text = L"處理";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// pictureBoxA
			// 
			this->pictureBoxA->Location = System::Drawing::Point(52, 227);
			this->pictureBoxA->Name = L"pictureBoxA";
			this->pictureBoxA->Size = System::Drawing::Size(349, 299);
			this->pictureBoxA->SizeMode = System::Windows::Forms::PictureBoxSizeMode::Zoom;
			this->pictureBoxA->TabIndex = 6;
			this->pictureBoxA->TabStop = false;
			// 
			// pictureBox2
			// 
			this->pictureBox2->Location = System::Drawing::Point(423, 227);
			this->pictureBox2->Name = L"pictureBox2";
			this->pictureBox2->Size = System::Drawing::Size(349, 299);
			this->pictureBox2->SizeMode = System::Windows::Forms::PictureBoxSizeMode::Zoom;
			this->pictureBox2->TabIndex = 7;
			this->pictureBox2->TabStop = false;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(822, 623);
			this->Controls->Add(this->pictureBox2);
			this->Controls->Add(this->pictureBoxA);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBoxA))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^  >(this->pictureBox2))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		Bitmap^ Image;
		Bitmap^ ImageA;
		Bitmap^ Imagez;
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
		int BytesOfSkipz;
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
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
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
					 Image=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 Imagez=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 //設定rect範圍大小
					 rect=Rectangle(0,0,Image->Width,Image->Height);
					 //像素值為b,g,r方式排列下去，所以寬度實際上有*3的數值大小
					 //預設讀取3channel圖像
					 ByteNumber_Width=Image->Width*3;
					 //顯示Image1於PictureBox1工具上
					 pictureBox1->Image=Image;
					 label1->Text = "X:" + Image -> Width;
					 label2->Text = "Y:" + Image ->Height;
				 }
			 }
	private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
				 //int N = System::Convert::ToInt32(textBox1-> Text);
				 int N = 2;
				 int xn =160;
				 int yn = 80;
				 Imaging::BitmapData^ ImageData;
				 ImageData=Image->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image->PixelFormat);
				 //將int指標指向Image像素資料的最前面位置
				 IntPtr ptr = ImageData->Scan0;
				 //掃瞄寬度- Byte資料寬度
				 BytesOfSkip=ImageData->Stride - ByteNumber_Width;
				 //設定指標
				 //巡迴每一個像素
				 p=(Byte*)((Void*)ptr);
				 Byte* po = (Byte*)((Void*)ptr);
				 int c=0;
				 for(int y=0;y<Image->Height;y++){
					 for(int x=0;x<Image->Width;x++){
						 //計算灰階值(計算HSI的Y)
						 //像素值填入
						 if(!(x>=320 &&x<480 && y>=200 &&y<280)){
							 p[0] =(Byte) (255);	//填入像素值 channel 0 (Blue)
							 p[1] =(Byte) (255);	//填入像素值 channel 1 (Green)
							 p[2] =(Byte) (255);	//填入像素值 channel 2 (Red)
						 }
						 else {
							 po[0]=p[0];
							 p[0] = (Byte)(255);
							 po[1]=p[1];
							 p[1] = (Byte)(255);
							 po[2]=p[2];
							 p[2] = (Byte)(255);
							 po+=3;
							 c++;
							 if(c>=160){
								 c=0;
								 po+= (480*3) ;
							 }
						 }
						 //指到下一個像素資訊
						 p+=3;
					 }
				 }
				 pictureBox2->Image = Image;
				 Imaging::BitmapData^ ImageDataz;
				 //Image->UnlockBits(ImageData);
				 rect=Rectangle(0,0,xn,yn);
				 ImageDataz=Imagez->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,Imagez->PixelFormat);
				 IntPtr ptrz = ImageDataz->Scan0;
				 BytesOfSkipz =ImageDataz->Stride - ByteNumber_Width;
				 Byte* pz = (Byte*)((Void*)ptrz);
				 Byte* p=(Byte*)((Void*)ptr);
				 c=0;
				 int m=0;
				 for(int y=0;y<Imagez->Height;y++){
					 for(int x=0;x<Imagez->Width;x++){
						 //計算灰階值(計算HSI的Y)
						 //像素值填入
						 if(x>=0 &&x<xn*N && y>=0 &&y<yn*N){
							 for(int i=0;i<N;i++){
								 pz[0]=(Byte)p[0];
								 pz[1]=(Byte)p[1];
								 pz[2]=(Byte)p[2];
								 pz+= (640*3*yn);
								 pz[0]=(Byte)p[0];
								 pz[1]=(Byte)p[1];
								 pz[2]=(Byte)p[2];
								 pz-= (640*3*yn);
								 pz+=3;
							 }
						 }

						 p+=3;
					 }
					 //pz-= (((640*N-xn*N))*3);
				 }
				 ptrz = ImageDataz->Scan0;
				 Byte* pzpe=(Byte*)((Void*)ptrz);
				 for(int y=0;y<Imagez->Height;y++){
					 for(int x=0;x<Imagez->Width;x++){
						 //計算灰階值(計算HSI的Y)
						 //像素值填入
						 if(!(x>=0 &&x<(160*N )&& y>=0 &&y<(80*N))){
							 pzpe[0] =(Byte) (255);	//填入像素值 channel 0 (Blue)
							 pzpe[1] =(Byte) (255);	//填入像素值 channel 1 (Green)
							 pzpe[2] =(Byte) (255);	//填入像素值 channel 2 (Red)
						 }
						 pzpe+=3;
					 }
				 }
				 //Unlock處理完畢的像素範圍
				 Image->UnlockBits(ImageData);
				 Imagez->UnlockBits(ImageDataz);
				 //將影像顯示在pictureBox1
				 pictureBoxA->Image = Imagez;
				 pictureBox2->Image = Image;
			 }
	};
}
