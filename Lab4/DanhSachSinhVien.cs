using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4
{
    public delegate int SoSanh(object sv1, object sv2);
    public class DanhSachSinhVien
    {
        public ArrayList DanhSach;
        public DanhSachSinhVien()
        {
            DanhSach = new ArrayList();
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index] as SinhVien; }
            set { DanhSach[index] = value; }
        }
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        //tim sinh vien
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svResult = null;
            foreach (SinhVien sv in DanhSach)
            {
                if (ss(obj, sv) == 0)
                {
                    svResult = sv;
                    break;
                }
            }
            return svResult;
        }
        //sửa sinh viên
        public bool Sua(SinhVien svSua, object obj, SoSanh ss)
        {
            bool kq = false;
            for (int i = 0; i < DanhSach.Count - 1; i++)
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
        // dọc file
        public void DocFile()
        {
            string fileName = System.Windows.Forms.Application.StartupPath +  "\\DSSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.MSSV = s[0];
                sv.HoTen = s[1];
                sv.Phai = false;
                if (s[2] == "1")
                {
                    sv.Phai = true;
                }
                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.Lop = s[4];
                sv.SDT = s[5];
                sv.Email = s[6];
                sv.DiaChi = s[7];
                sv.Hinh = s[8];
                Them(sv);
            }
            sr.Close();

        }
        
    }
}
