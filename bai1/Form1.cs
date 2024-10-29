using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace bai1
{
	public partial class Form1 : Form
	{
		DanhSachSv ds = new DanhSachSv();
		bool thayDoiDuLieu = false;
		public Form1()
		{
			InitializeComponent();
			listViewDS.Click += new EventHandler(listviewds_click);
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			//ds.DocTuFileTXT();
			ds.DocFileJson();
			//ds.RunJSON();
			
			
			TaiDanhSach();
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			LuuListViewVaoDS();
			if (thayDoiDuLieu)
			{
				DialogResult result = MessageBox.Show("bạn có lưu những thay đổi không",
					"lưu thay đổi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				if (result == DialogResult.OK)
				{
					//SaveDataInTXT();
					GhiFileJson();
				}
				else e.Cancel = true;
			}
		}

		public void TaiDanhSach()
		{
			listViewDS.Items.Clear();
			for (int i = 0; i < ds.dsSinhVien.Count; i++)
			{
				SinhVien sv1 = ds.dsSinhVien[i];
				string[] s = new string[9];
				s[0] = sv1.MSSV;
				s[1] = sv1.HoTen;
				s[2] = sv1.Phai;
				s[3] = sv1.NgaySinh.ToString();
				s[4] = sv1.Lop;
				s[5] = sv1.SDT;
				s[6] = sv1.Email;
				s[7] = sv1.DiaChi;
				s[8] = sv1.Hinh;
				ListViewItem item = new ListViewItem(s);
				listViewDS.Items.Add(item);
			}
			listViewDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

		}
		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnChonHinh_Click(object sender, EventArgs e)
		{

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					tbDuongDanHinh.Text = openFileDialog.FileName;
					pictureBoxHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
				}
			}
		}
		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			tbMSSV.Text = "";
			tbHoTen.Text = "";
			tbEmail.Text = "";
			tbDiaChi.Text = "";
			rdbNam.Checked = true;
			cbbLop.TabIndex = 0;
			mtbSDT.Text = "";
			tbDuongDanHinh.Text = "";
			pictureBoxHinhAnh.Image = null;

		}
		public string[] ThemSVVaoDS()
		{
			string[] s = new string[9];
			s[0] = tbMSSV.Text;
			s[1] = tbHoTen.Text;
			s[2] = rdbNam.Text;
			if (rdbNu.Checked == true)
				s[2] = rdbNu.Text;
			s[3] = dtpNgaySinh.Text;
			s[4] = cbbLop.Text;
			s[5] = mtbSDT.Text;
			s[6] = tbEmail.Text;
			s[7] = tbDiaChi.Text;
			s[8] = tbDuongDanHinh.Text;
			return s;

		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			ListViewItem item = new ListViewItem(ThemSVVaoDS());
			listViewDS.Items.Add(item);
			listViewDS.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			thayDoiDuLieu = true;
		}
		public void listviewds_click(object sender, EventArgs e)
		{
			ListViewItem Item = listViewDS.SelectedItems[0];
			tbMSSV.Text = Item.SubItems[0].Text;
			tbHoTen.Text = Item.SubItems[1].Text;
			rdbNam.Text = Item.SubItems[2].Text;
			dtpNgaySinh.Text = Item.SubItems[3].Text;
			cbbLop.Text = Item.SubItems[4].Text;
			mtbSDT.Text = Item.SubItems[5].Text;
			tbEmail.Text = Item.SubItems[6].Text;
			tbDiaChi.Text = Item.SubItems[7].Text;
			tbDuongDanHinh.Text = Item.SubItems[8].Text;
		}
		private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listViewDS.SelectedItems.Count > 0)
			{
				ListViewItem Item = listViewDS.SelectedItems[0];
				listViewDS.Items.RemoveAt(Item.Index);
			}
			thayDoiDuLieu = true;

		}
		private void tảiLạiDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TaiDanhSach();
		}
		void GhiFileJson()
		{
			string filepath = "DS_SV.json";
			string jsonData = JsonConvert.SerializeObject(ds,Formatting.Indented);
			File.WriteAllText(filepath, jsonData);
		}
		void LuuListViewVaoDS()
		{
			ds.XoaDS();
			foreach (ListViewItem item in listViewDS.Items)
			{
				
				SinhVien sv = new SinhVien();
				sv.MSSV = item.SubItems[0].Text;
				sv.HoTen = item.SubItems[1].Text;
				sv.Phai = item.SubItems[2].Text;
				sv.NgaySinh=DateTime.Parse((string)item.SubItems[3].Text);
				sv.Lop= item.SubItems[4].Text;
				sv.SDT= item.SubItems[5].Text;
				sv.Email= item.SubItems[6].Text;
				sv.DiaChi= item.SubItems[7].Text;
				sv.Hinh= item.SubItems[8].Text;
				ds.ThemSV(sv);
			}
		}
		

		public void SaveDataInTXT()
		{
			using (StreamWriter streamWriter = new StreamWriter("DanhSach_SV.txt"))
			{
				foreach (ListViewItem item in listViewDS.Items)
				{
					string mssv = item.SubItems[0].Text;
					string hoten = item.SubItems[1].Text;
					string phai = item.SubItems[2].Text;
					string ngaysinh = item.SubItems[3].Text;
					string lop = item.SubItems[4].Text;
					string sdt = item.SubItems[5].Text;
					string email = item.SubItems[6].Text;
					string diachi = item.SubItems[7].Text;
					string hinh = item.SubItems[8].Text;
					streamWriter.WriteLine($"{mssv};{hoten};{phai};{ngaysinh};{lop};{sdt};{email};{diachi};{hinh}");
				}
				streamWriter.Close();
			}
			thayDoiDuLieu = false;

		}


	}
}
