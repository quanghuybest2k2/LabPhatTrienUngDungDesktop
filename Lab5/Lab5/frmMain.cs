using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Lab5
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Phương thức đọc tập tin JSON
        /// </summary>
        /// <param name="Path">Đường dẫn tập tin</param>
        /// <returns>Danh sách các đối tượng từ tập tin JSON</returns>
        private List<StudentInfo> JsonLoad(string Path)
        {
            // Khai báo danh sách lưu trữ
            List<StudentInfo> list = new List<StudentInfo>();
            // Đối tượng đọc tập tin 
            StreamReader sr = new StreamReader(Path);
            string json = sr.ReadToEnd(); // đọc hết
            // Chuyển về thành mảng các đối tượng
            var array = (JObject)JsonConvert.DeserializeObject(json);
            // Lấy đối tượng sinhvien
            var students = array["SinhVien"].Children();
            foreach (var item in students) // Duyệt mảng
            {
                // Lấy các thành phần 
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["HoTen"].Value<string>();
                int tuoi = item["Tuoi"].Value<int>();
                double diem = item["Diem"].Value<double>();
                bool tongiao = item["TonGiao"].Value<bool>();
                // Chuyển vào đối tượng StudentInfo 
                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                list.Add(info);// Thêm vào danh sách
            }
            return list;
        }
        private void btnXemJsonFile_Click(object sender, EventArgs e)
        {
           
            //string str = "";
            string path = "../../JsonExample.json";// duong dan tap tin
            List<StudentInfo> list = JsonLoad(path);  //goi phuong thuc thong qua public
            lvSinhVien.Items.Clear();// xóa dữ liệu khi thêm vào
            for (int i = 0; i < list.Count; i++)
            {
                StudentInfo info = list[i];
                ////////////////
                string checkTongGiao = "";
                if (info.TonGiao == true)
                    checkTongGiao = "Có tôn giáo";
                else
                    checkTongGiao = "Không tôn giáo";
                //////////////
                ListViewItem lvItem = new ListViewItem(info.MSSV); // có checkboxs nên phải gán truyền thẳng
                lvItem.SubItems.Add(info.HoTen);
                lvItem.SubItems.Add(info.Tuoi.ToString());
                lvItem.SubItems.Add(info.Diem.ToString());
                lvItem.SubItems.Add(bool.Parse(info.TonGiao.ToString())==true? "Có tôn giáo": "Không tôn giáo");
                // them vao listview
                lvSinhVien.Items.Add(lvItem);
                //str += string.Format("\nSinh viên thứ {0}\nMã số: {1}\nHọ và tên: {2}\nTuổi: {3}\nĐiểm TB: {4}\nTôn giáo: {5}\n------------------------", (i + 1), info.MSSV, info.HoTen, info.Tuoi, info.Diem, checkTongGiao);
            }
            //MessageBox.Show(str);
        }
    }
}
