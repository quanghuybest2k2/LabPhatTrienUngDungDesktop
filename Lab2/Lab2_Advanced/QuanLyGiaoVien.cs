using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Advanced
{
    enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSDT
    }
    class QuanLyGiaoVien
    {
        public List<GiaoVien> dsGiaoVien;

        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index] as GiaoVien; }
            set { dsGiaoVien[index] = value; }
        }
        // so sanh
        public void SapXep(SoSanh ss)
        {
            
        }
        public delegate int SoSanh(object a, object b);

        public bool Them(GiaoVien gv)
        {
            dsGiaoVien.Add(gv);
            return true;
        }
        public GiaoVien Tim(object temp, SoSanh ss)
        {
            GiaoVien gvresult = null;
            foreach (GiaoVien gv in dsGiaoVien)
                if (ss(temp, gv) == 0)
                {
                    gvresult = gv;
                    break;
                }
            return gvresult;
        }

        //Xóa các obj trong danh sách nếu thỏa điều kiện so sánh
        public void Xoa(object temp, SoSanh ss)
        {
            int i = dsGiaoVien.Count - 1;
            for (; i >= 0; i--)
                if (ss(temp, this[i]) == 0)
                    this.dsGiaoVien.RemoveAt(i);
        }

    }
}
