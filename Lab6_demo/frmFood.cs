using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab6
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            
        }
        // load food
        public void loadFood(int categoryID)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "Select Name from Category where id = "+categoryID;
            //sqlCommand.Parameters.AddWithValue("@id", categoryID.ToString());
            //mo ket noi 
            sqlConnection.Open();
            // gan ten nhom san pham cho tieu de
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
            sqlCommand.CommandText = "Select * from Food Where FoodCategoryID = "+ categoryID;
            //sqlCommand.Parameters.AddWithValue("@id", categoryID.ToString());
            //tao doi tuong adapter
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            // tao database chua du lieu
            DataTable dt = new DataTable("Food");
            adapter.Fill(dt);
            // hien danh sach mon an len form
            dtgvFood.DataSource = dt;
            // dong ket noi va giai phong bo nho
            sqlConnection.Close();
            sqlConnection.Dispose();
            adapter.Dispose();
        }
    }
}
