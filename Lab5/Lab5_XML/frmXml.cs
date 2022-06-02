using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace Lab5_XML
{
    public partial class frmXml : Form
    {
        public frmXml()
        {
            InitializeComponent();
        }

        private void frmXml_Load(object sender, EventArgs e)
        {

        }
        //private static void SaveXmlFile(List<Book> books)
        //{
        //    var serializer = new XmlSerializer(typeof(List<Book>)); // truyen vao list<Book>
        //    using (var write = new StreamWriter("books.xml"))
        //    {
        //        serializer.Serialize(write, books, null);
        //        write.Close();
        //    }
        //}

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            List<Book> list = new List<Book>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\books.xml", FileMode.Open, FileAccess.Read))
            {
                list = serializer.Deserialize(fs) as List<Book>;
            }
            dtgvBook.DataSource = list;
        }
    }
}
