using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Lab6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtType.Text = "";
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            // xóa dữ liệu hiện tại
            lvCategory.Items.Clear();
            // đọc một dòng dữ liệu
            while (reader.Read())
            {
                // tạo một dòng mới trong listview
                ListViewItem item = new ListViewItem(reader["ID"].ToString()); //truyen vao gia tri dau tien
                // them dong moi vao listview
                lvCategory.Items.Add(item);

                // bo sung cac thong tin khac cho listview
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());

            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
            // sqlcommand dùng thực thi truy vấn dữ liệu
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select id, name, type from category";
            //mở kết nối
            sqlConnection.Open();

            //Thực thi bằng phương thức ExcuteReader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            // hiển thị dữ liệu listview
            DisplayCategory(sqlDataReader);
            // dong ket noi
            sqlConnection.Close();

        }
        private void ChuaNhapThongTin()
        {
            if (txtName.Text == "" && txtType.Text == "")
            {
                MessageBox.Show("Bạn chưa điền thông tin!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
            // sqlcommand dùng thực thi truy vấn dữ liệu
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //insert into Category values(N'Mực khô nướng cá', 1)
            sqlCommand.CommandText = "insert into Category(Name, [type])" + "values (N'" + txtName.Text + "', " + txtType.Text + ")";
            sqlConnection.Open();
            ChuaNhapThongTin();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowEffected == 1)
            {
                MessageBox.Show("Thêm món ăn thành công!");
                btnLoad.PerformClick();
                reset();
            }
            else
            {
                MessageBox.Show("Lỗi rồi!!!");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            //lấy thằng được chọn
            ListViewItem item = lvCategory.SelectedItems[0];
            // hien thi du lieu len textbox
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";
            //hien thi nut cap nhat va xoa
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //sqlCommand.CommandText = "update Category set Name = N'" + txtName.Text + "', [Type] = " + txtType.Text + "where id = " + txtID.Text;
            //update category set Name = N'canh jack', [type] = 1 where id = 16
            sqlCommand.CommandText = "update category set Name = @Name, Type = @Type where id = @id";
            // them tham so
            sqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
            var type = txtType.Equals("Đồ ăn");
            sqlCommand.Parameters.AddWithValue("@Type", type);
            sqlCommand.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
            sqlConnection.Open();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (numOfRowEffected == 1)
            {
                //cap nhat lai listview
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text == "0" ? "Thức ăn" : "Đồ uống";

                // xoa cac o nhap
                reset();
                //an nut cap nhat va xoa
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Cập nhật thành công!");

            }
            else
            {
                MessageBox.Show("Cập nhật không được!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Delete from category where id = @id";
            sqlCommand.Parameters.AddWithValue("@id", txtID.Text);
            //mo ket noi
            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (num == 1)
            {
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);
                reset();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Xóa thành công");
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra!");
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count>0)
            {
                btnDelete.PerformClick();
            }
        }

        private void tsmiViewFood_Click(object sender, EventArgs e)
        {
            if (txtID.Text!="")
            {
                frmFood foodForm = new frmFood();
                foodForm.Show(this);
                foodForm.loadFood(Convert.ToInt32(txtID.Text));
            }
        }
    }
}
