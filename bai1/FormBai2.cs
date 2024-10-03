using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
	public partial class FormBai2 : Form
	{
		public FormBai2()
		{
			InitializeComponent();
			btnTinhTien.Enabled = false;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnTinhTien.Enabled=true;
			int stt = comboBox1.SelectedIndex;
			int s=0;
			switch (stt)
			{
				case 0:
					s = 100000;
					break;
					case 1:
					s = 2000000;
					break;
					case 2:
					s = 150000;
					break;
			}
			tbDonGia.Text = s.ToString();
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			float t = 0;
			t=int.Parse(tbDonGia.Text) * (int)nudSoLuong.Value;
			if (rbChuyenTien.Checked)
				t-=(t *5)/100;

			lbHienThiTien.Text=t.ToString("N0");
		}
	}
}
