using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
        public SinhVien(string mSSV, string hoTen, bool phai, DateTime ngaySinh, string lop, string sDT, string email, string diaChi, string hinh)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            Phai = phai;
            NgaySinh = ngaySinh;
            Lop = lop;
            SDT = sDT;
            Email = email;
            DiaChi = diaChi;
            Hinh = hinh;
        }
        public SinhVien()
        {
            
        }
    }
}
