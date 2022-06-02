using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_XML
{
    public class Student
    {
        public string MSSV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string CMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public Student(string mSSV, string hoLot, string ten, DateTime ngaySinh, string lop, string cMND, string soDT, string diaChi)
        {
            MSSV = mSSV;
            HoLot = hoLot;
            Ten = ten;
            NgaySinh = ngaySinh;
            Lop = lop;
            CMND = cMND;
            SoDT = soDT;
            DiaChi = diaChi;
        }
        public Student()
        {

        }
    }
}
