using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai1
{
	internal class DanhSachSv
	{
		public List<SinhVien> dsSinhVien=new List<SinhVien>();
		public void DocTuFile()
		{
			string filename = "DanhSach_SV.txt", t;
			string[] s;
			SinhVien sv;
			using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open)))
			{
				while ((t = sr.ReadLine()) != null)
				{
					s = t.Split(';');
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
					dsSinhVien.Add(sv);
				}
				sr.Close();
			}
			
		}
		public void XuatDSSV()
		{
			foreach(SinhVien sv in dsSinhVien)
			{
				Console.WriteLine(sv.MSSV,sv.HoTen, sv.Phai);
			}
		}
	}
}

