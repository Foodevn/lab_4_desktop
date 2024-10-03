using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
	internal class SinhVien
	{
		public string MSSV { get; set; }
		public string HoTen { get; set; }
		public string Phai { get; set; }
		public DateTime NgaySinh { get; set; }
		public string Lop { get; set; }
		public string SDT { get; set; }
		public string Email { get; set; }
		public string DiaChi { get; set; }
		public string Hinh { get; set; }
        public SinhVien()
        {
            
        }
		public SinhVien(string mssv,string hoten,string phai,DateTime ngaysinh
			,string lop,string sdt,string email,string diachi, string hinh)
		{
			MSSV = mssv;
			HoTen = hoten;
			Phai = phai;
			NgaySinh = ngaysinh;
			Lop = lop;
			SDT = sdt;
			Email = email;
			DiaChi = diachi;
			Hinh = hinh;
		}
		public override string ToString()
		{
			return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}"
				,MSSV,HoTen,Phai,NgaySinh,Lop,SDT,Email,DiaChi,Hinh);
		}

	}
}
