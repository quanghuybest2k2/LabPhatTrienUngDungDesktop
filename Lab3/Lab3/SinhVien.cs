using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
    public class SinhVien
    {
        //các thuộc tính của lớp sinh viên
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> ChuyenNganh { get; set; }
        // Phương thức tạo lập mặc định
        public SinhVien()
        {
            ChuyenNganh = new List<string>();
        }
        // Phương thức tạo lập có tham số truyền vào
        public SinhVien(string maSo, string hoTen, DateTime ngaySinh, string diaChi, string lop, string hinh, bool gioiTinh, List<string> chuyenNganh)
        {
            MaSo = maSo; //không cần từ khóa this
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Lop = lop;
            Hinh = hinh;
            GioiTinh = gioiTinh;
            ChuyenNganh = chuyenNganh;
            
        }
    }
}
