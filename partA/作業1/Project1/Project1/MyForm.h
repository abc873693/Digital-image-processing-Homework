#pragma once

namespace Project1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// MyForm ���K�n
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: �b���[�J�غc�禡�{���X
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
		/// �M������ϥΤ����귽�C
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
		/// �]�p�u��һݪ��ܼơC
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// �����]�p�u��䴩�һݪ���k - �ФŨϥε{���X�s�边
		/// �ק�o�Ӥ�k�����e�C
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
			this->button1->Text = L"�}��";
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
			this->button2->Text = L"�B�z";
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
		//===�ܼƫŧi===
		//�ŧi�I�}�Ϫ��榡
		Bitmap^ Image1;
		Bitmap^ Image2;
		Bitmap^ Image;
		Bitmap^ ImageP;
		//�ŧi�Ϲ��ϰ�(�]�w����Ū���B���ץ����Ϲ��ϰ�)
		Rectangle rect;
		Rectangle rect1;
		Rectangle rect2;
		Rectangle rectP;
		//�ŧi�@int�榡������
		IntPtr ptr;
		//���˼e��- Byte��Ƽe��
		int BytesOfSkip1;
		int BytesOfSkip2;
		int BytesOfSkip;
		int BytesOfSkipP;
		//�ŧi���e�ת�������T
		int ByteNumber_Width;
		int ByteNumber_Width1;
		int ByteNumber_Width2;
		int ByteNumber_WidthP;
		//�ŧi�@��Byte�榡������
		Byte* p1;
		Byte* p2;
		Byte* p;
		Byte* pP;
	private: static array<System::Windows::Forms::PictureBox^>^ pictures=(gcnew array<System::Windows::Forms::PictureBox^>(64));
	private: static array<Bitmap^>^ Images=(gcnew array<Bitmap^>(64));
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
				 //===�}�ϥD�{��===
				 //new �@�� OpenFileDialog ����
				 OpenFileDialog ^ openFileDialog1 = gcnew OpenFileDialog();
				 //�]�wFilter�A�ΥH���w�ϥΪ̶}�Ҫ��ɮ�
				 openFileDialog1->Filter = "�I�}�� (*.bmp)|*.bmp|All files (*.*)|*.*";
				 //�w�]�ɮצW�٬��ŭ�
				 openFileDialog1->FileName="";
				 //�]�w���X��ܵ��������D�W��
				 openFileDialog1->Title="���J�v��";
				 //�]�wFilter��ܼҦ�(�̷�Filter�ơA�p���ҿ��1��ܰ_�l�X�{�����I�}�ϡA���2���All filts)
				 openFileDialog1->FilterIndex=1;
				 //���X�ɮ׿�ܵ���(ShowDialog)�A�åB�p�G�ϥΪ��I���ɮסA�åB�ɮצW�ٶW�L0�Ӧr���A�h�P�_�O��True�A�i�J�B�z�{��
				 if(openFileDialog1->ShowDialog()==System::Windows::Forms::DialogResult::OK && openFileDialog1->FileName->Length>0){
					 //�N������ɮ�Ū���åB�s��Image1
					 Image1=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 //�]�wrect�d��j�p
					 rect1=Rectangle(0,0,Image1->Width,Image1->Height);
					 //�����Ȭ�b,g,r�覡�ƦC�U�h�A�ҥH�e�׹�ڤW��*3���ƭȤj�p
					 //�w�]Ū��3channel�Ϲ�
					 ByteNumber_Width=Image1->Width*3;
					 //���Image1��PictureBox1�u��W
					 pictureBoxA->Image=Image1;
					 ImageP=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
				 }
				 if(openFileDialog1->ShowDialog()==System::Windows::Forms::DialogResult::OK && openFileDialog1->FileName->Length>0){
					 //�N������ɮ�Ū���åB�s��Image1
					 Image2=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 //�]�wrect�d��j�p
					 rect2=Rectangle(0,0,Image2->Width,Image2->Height);
					 //�����Ȭ�b,g,r�覡�ƦC�U�h�A�ҥH�e�׹�ڤW��*3���ƭȤj�p
					 //�w�]Ū��3channel�Ϲ�
					 ByteNumber_Width=Image2->Width*3;
					 //���Image1��PictureBox1�u��W
					 pictureBoxB->Image=Image2;
					 Image=safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 for(int i=0;i<10;i++)
						 Images[i] =safe_cast<Bitmap^>(Image::FromFile(openFileDialog1->FileName));
					 //�]�wrect�d��j�p
					 rect=Rectangle(0,0,Image->Width,Image->Height);
					 //�����Ȭ�b,g,r�覡�ƦC�U�h�A�ҥH�e�׹�ڤW��*3���ƭȤj�p
				 }


			 }
	private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
				 //==�����B�z�覡-�m����Ƕ�
				 //Lock���B�z�������d��(�קK��L�{�ǭק�ӦV����)�A�ѼƤ@�����w�����B�z�d��A�ѼƤG���]�w�B�z�Ҧ�(Ū���B�g�J�BŪ���g�J�A�ĤT�ӹ������]�w�ӹ����Ҧ�bit? channel?)
				 //�ŧi���@BitmapData���A�A��ܹ����Ȧ�m
				 Imaging::BitmapData^ ImageData1;
				 Imaging::BitmapData^ ImageData2;
				 //Imaging::BitmapData^ ImageData;
				 ImageData1=Image1->LockBits(rect1,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image1->PixelFormat);
				 ImageData2=Image2->LockBits(rect2,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image2->PixelFormat);
				 //ImageData=Image->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image->PixelFormat);
				 for(int i=0;i<10;i++){
					 Imaging::BitmapData^ ImageData;
					 ImageData=Images[i]->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,Image->PixelFormat);
					 //�Nint���Ы��VImage������ƪ��̫e����m
					 IntPtr ptr1 = ImageData1->Scan0;
					 IntPtr ptr2 = ImageData2->Scan0;
					 IntPtr ptr = ImageData->Scan0;
					 //���˼e��- Byte��Ƽe��
					 BytesOfSkip1=ImageData1->Stride - ByteNumber_Width1;
					 BytesOfSkip2=ImageData2->Stride - ByteNumber_Width2;
					 BytesOfSkip=ImageData->Stride - ByteNumber_Width;
					 //�]�w����
					 //���j�C�@�ӹ���
					 p1=(Byte*)((Void*)ptr1);
					 p2=(Byte*)((Void*)ptr2);
					 p=(Byte*)((Void*)ptr);
					 for(int y=0;y<Image1->Height;y++){
						 for(int x=0;x<Image1->Width;x++){
							 //�p��Ƕ���(�p��HSI��Y)
							 //�����ȶ�J
							 p[0] =(Byte) (p1[0]*i/10 + p2[0]*(10-i)/10);	//��J������ channel 0 (Blue)
							 p[1] =(Byte) (p1[1]*i/10 + p2[1]*(10-i)/10);	//��J������ channel 1 (Green)
							 p[2] =(Byte) (p1[2]*i/10 + p2[2]*(10-i)/10);	//��J������ channel 2 (Red)

							 //����U�@�ӹ�����T
							 p1+=3;
							 p2+=3;
							 p+=3;
						 }
					 }
					 //Unlock�B�z�����������d��
					 Images[i]->UnlockBits(ImageData);
					 //�N�v����ܦbpictureBox1
					 pictures[i]->Image = Images[i];
				 }
				 Imaging::BitmapData^ ImageDataP;
				 ImageDataP=ImageP->LockBits(rect,System::Drawing::Imaging::ImageLockMode::ReadWrite,ImageP->PixelFormat);
				 //�Nint���Ы��VImage������ƪ��̫e����m
				 IntPtr ptrP = ImageDataP->Scan0;
				 //���˼e��- Byte��Ƽe��
				 BytesOfSkipP=ImageDataP->Stride - ByteNumber_Width;
				 //�]�w����
				 pP=(Byte*)((Void*)ptrP);
				 //���j�C�@�ӹ���
				 for(int y=0;y<Image1->Height;y++){
					 for(int x=0;x<Image1->Width;x++){
						 //�p��Ƕ���(�p��HSI��Y)
						 int n =(int)( 0.114 * pP[0] + 0.587 * pP[1] + 0.299 * pP[2]) ;
						 int pixel =( pP[0] + pP[1] + pP[2])/3 ;
						 int xx = (n - pixel);
						 if((n - pixel)<=0)xx=0;
						 //�����ȶ�J
						 pP[0]=(Byte)(xx);	//��J������ channel 0 (Blue)
						 pP[1]=(Byte)(xx);	//��J������ channel 1 (Green)
						 pP[2]=(Byte)(xx);	//��J������ channel 2 (Red)
						 //����U�@�ӹ�����T
						 pP+=3;
					 }
				 }
				 //Unlock�B�z�����������d��
				 ImageP->UnlockBits(ImageDataP);
				 //�N�v����ܦbpictureBox1
				 pictureBoxP->Image = ImageP;

			 }
	};
}
