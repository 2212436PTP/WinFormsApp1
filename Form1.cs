namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnDangKy_Click(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtTen, "");
			errorProvider1.SetError(txtTuoi, "");
			errorProvider1.SetError(dtpNgayDangKy, "");
			if (txtTen.Text == "")
			{ 
				errorProvider1.SetError(txtTen, " Bat buoc phai nhap ten "); 
				return;
			}

			int tuoi = 0;
			if(int.TryParse(txtTuoi.Text,out tuoi)==false)
			{
				errorProvider1.SetError(txtTuoi, " Nhap dung so tuoi ");
				return;
			}
			else
			{
				if (tuoi < 17)
				{ 
					errorProvider1.SetError(txtTuoi, " Nguoi tren 17 tuoi moi duoc dang ky thi "); 
					return;
				}
			}
			if(dtpNgayDangKy.Value.DayOfWeek == DayOfWeek.Sunday)
			{
				errorProvider1.SetError(dtpNgayDangKy, " Chu nhat trung tam dang ky nghi ");
				return;
			}
			MaskedTextBox.Show("Ban da nhap thong tin hop le. Chuc ban thi tot");
		}
	}
}
