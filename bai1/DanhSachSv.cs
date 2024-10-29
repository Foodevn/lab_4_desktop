using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai1
{
	internal class DanhSachSv
	{
		public List<SinhVien> dsSinhVien = new List<SinhVien>();
		public DanhSachSv()
		{
		
		}

		public void DocTuFileTXT()
		{
			string filename = Application.StartupPath+"/DanhSach_SV.txt", t;
			string[] s;
			SinhVien sv;
			using (StreamReader sr = new StreamReader(filename))
			{
				while ((t = sr.ReadLine()) != null)
				{
					s = t.Split(';');
					if (s.Length == 9)
					{
						sv = new SinhVien();
						sv.MSSV = s[0];
						sv.HoTen = s[1];
						sv.Phai = s[2];
						sv.NgaySinh = DateTime.Parse(s[3]);
						sv.Lop = s[4];
						sv.SDT = s[5];
						sv.Email = s[6];
						sv.DiaChi = s[7];
						sv.Hinh = s[8];
						ThemSV(sv);
					}
					else
					{
						MessageBox.Show("so index cua mang s: " + s.Length);
						break;
					}
				}
				sr.Close();
			}
		}
		public void ThemSV(SinhVien sv)
		{
			dsSinhVien.Add(sv);
		}
		public void XoaDS()
		{
			dsSinhVien.Clear();
		}
		public void DocFileJson()
		{
			string filePath =  "DS_SV.json";
			string jsonData = File.ReadAllText(filePath);
			DanhSachSv ds = JsonConvert.DeserializeObject<DanhSachSv>(jsonData);
			if (ds != null && ds.dsSinhVien != null)
			{
				this.dsSinhVien = ds.dsSinhVien;
			}
			//try
			//{
			//	string filePath = Application.StartupPath + "/DS_SV.json";
			//	string jsonData = File.ReadAllText(filePath);
			//	dsSinhVien = JsonConvert.DeserializeObject<List<SinhVien>>(jsonData);
			//}
			//catch (FileNotFoundException)
			//{
			//	MessageBox.Show("Không tìm thấy file.");
			//	return ; // Trả về danh sách rỗng nếu file không tồn tại
			//}
			//catch (JsonException ex)
			//{
			//	MessageBox.Show("Lỗi trong quá trình đọc JSON: " + ex.Message);
			//	return ; // Trả về danh sách rỗng nếu JSON không hợp lệ
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
			//	return; // Trả về danh sách rỗng khi gặp lỗi khác
			//}

		}
		
		public void XuatDSSV()
		{
			foreach (SinhVien sv in dsSinhVien)
			{
				Console.WriteLine(sv.MSSV, sv.HoTen, sv.Phai);
			}
		}
		public static List<SinhVien> DocDanhSachSinhVien(string filePath)
		{
			try
			{
				// Đọc toàn bộ nội dung file JSON
				string jsonData = File.ReadAllText(filePath);

				// Deserialize chuỗi JSON thành danh sách SinhVien
				List<SinhVien> danhSachSinhVien = JsonConvert.DeserializeObject<List<SinhVien>>(jsonData);

				return danhSachSinhVien;
			}
			catch (FileNotFoundException)
			{
				Console.WriteLine("Không tìm thấy file.");
				return new List<SinhVien>(); // Trả về danh sách rỗng nếu file không tồn tại
			}
			catch (JsonException ex)
			{
				Console.WriteLine("Lỗi trong quá trình đọc JSON: " + ex.Message);
				return new List<SinhVien>(); // Trả về danh sách rỗng nếu JSON không hợp lệ
			}
			catch (Exception ex)
			{
				Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
				return new List<SinhVien>(); // Trả về danh sách rỗng khi gặp lỗi khác
			}
		}

		

	}
}

