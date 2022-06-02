using System;
using System.Collections.Generic;
using System.IO;

namespace Lab3_Demo
{
    // Khai báo một delegate SoSanh
    public delegate int SoSanh(object sv1, object sv2);
    class QuanLySinhVien
    {
        public List<SinhVien> DanhSach; // Field
        public QuanLySinhVien()//phuong thuc mac dinh
        {
            DanhSach = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        //xoa cac object trong danh sach neu thao dieu kien so sanh
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    DanhSach.RemoveAt(i);
        }
        //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
            {
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            }
            return svresult;
        }
        //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh, gán lại thông tin cho sinh viên này thành svsua
        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = DanhSach.Count - 1;
            for (i = 0; i < count; i++)
            {
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svSua;
                    kq = true;
                    break;
                }
            }
            return kq;
        }
        // Hàm đọc danh sách sinh viên từ tập tin txt
        public void DocTuFile()
        {
            string fileName = System.Windows.Forms.Application.StartupPath + "\\Data.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.NgaySinh = DateTime.Parse(s[2]);
                sv.DiaChi = s[3];
                sv.Lop = s[4];
                sv.Hinh = s[5];
                sv.GioiTinh = false;
                if (s[6] == "1")
                    sv.GioiTinh = true;
                string[] cn = s[7].Split(',');
                foreach (string c in cn)
                {
                    sv.ChuyenNganh.Add(c);
                }
                Them(sv);
            }
            sr.Close();
        }
        // public void SaveChange(String filename)
        // {
        //     int count = 0;
        //     using (var stream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite))
        //     {
        //         using (var write = new StreamWriter(stream))
        //         {
        //             foreach (var sv in DanhSach)
        //             {
        //                 string gt = "0";
        //                 if (sv.GioiTinh == true) gt = "1";
        //                 write.Write(sv.MaSo + "*" + sv.HoTen + "*" + sv.NgaySinh + "*" + sv.DiaChi + "*" + sv.Lop + "*" + sv.Hinh + "*" + gt + "*");
        //                 for(int i =0; i<sv.ChuyenNganh.Count; i++)
        //                 {
        //                     if (i == sv.ChuyenNganh.Count - 1)
        //                         write.Write(sv.ChuyenNganh[i]);
        //                     else
        //                         write.Write(sv.ChuyenNganh[i] + ",");
        //                 }
        //                 count++;
        //                 if (count < DanhSach.Count) write.Write("\n");
        //             }
        //         }
        //     }
        // }

    }
}
