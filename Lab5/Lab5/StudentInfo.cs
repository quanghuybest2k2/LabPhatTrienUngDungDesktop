using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Lab5
{
    public class StudentInfo
    {
        
        //Các thuộc tính
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public double Diem { get; set; }
        public bool TonGiao { get; set; }
        // phuong thuc tao lap
        public StudentInfo(string mSSV, string hoTen, int tuoi, double diem, bool tonGiao)
        {
            MSSV = mSSV;
            HoTen = hoTen;
            Tuoi = tuoi;
            Diem = diem;
            TonGiao = tonGiao;
        }
       
    }
}
