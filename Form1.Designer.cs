namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			groupBox1 = new GroupBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtTen = new TextBox();
			txtTuoi = new TextBox();
			dtpNgayDangKy = new DateTimePicker();
			btnDangKy = new Button();
			errorProvider1 = new ErrorProvider(components);
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnDangKy);
			groupBox1.Controls.Add(dtpNgayDangKy);
			groupBox1.Controls.Add(txtTuoi);
			groupBox1.Controls.Add(txtTen);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(418, 229);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Đăng ký thi bằng lái xe";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 48);
			label1.Name = "label1";
			label1.Size = new Size(35, 20);
			label1.TabIndex = 0;
			label1.Text = "Tên:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 84);
			label2.Name = "label2";
			label2.Size = new Size(41, 20);
			label2.TabIndex = 1;
			label2.Text = "Tuổi:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 120);
			label3.Name = "label3";
			label3.Size = new Size(100, 20);
			label3.TabIndex = 2;
			label3.Text = "Ngày đăng ký";
			// 
			// txtTen
			// 
			txtTen.Location = new Point(121, 44);
			txtTen.Name = "txtTen";
			txtTen.Size = new Size(125, 27);
			txtTen.TabIndex = 3;
			txtTen.TextChanged += textBox1_TextChanged;
			// 
			// txtTuoi
			// 
			txtTuoi.Location = new Point(120, 77);
			txtTuoi.Name = "txtTuoi";
			txtTuoi.Size = new Size(125, 27);
			txtTuoi.TabIndex = 4;
			// 
			// dtpNgayDangKy
			// 
			dtpNgayDangKy.CustomFormat = "dd/MM/yyyy";
			dtpNgayDangKy.Format = DateTimePickerFormat.Custom;
			dtpNgayDangKy.Location = new Point(121, 113);
			dtpNgayDangKy.Name = "dtpNgayDangKy";
			dtpNgayDangKy.Size = new Size(250, 27);
			dtpNgayDangKy.TabIndex = 5;
			dtpNgayDangKy.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// btnDangKy
			// 
			btnDangKy.Location = new Point(121, 173);
			btnDangKy.Name = "btnDangKy";
			btnDangKy.Size = new Size(94, 29);
			btnDangKy.TabIndex = 6;
			btnDangKy.Text = "Đăng ký";
			btnDangKy.UseVisualStyleBackColor = true;
			btnDangKy.Click += btnDangKy_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(500, 346);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form 1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Button btnDangKy;
		private DateTimePicker dtpNgayDangKy;
		private TextBox txtTuoi;
		private TextBox txtTen;
		private Label label3;
		private Label label2;
		private Label label1;
		private ErrorProvider errorProvider1;
	}
}
