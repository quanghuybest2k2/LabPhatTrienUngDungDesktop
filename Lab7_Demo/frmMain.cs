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


namespace Lab7_Demo
{
    public partial class frmMain : Form
    {
        private DataTable dataTable;
        public frmMain()
        {
            InitializeComponent();
        }
        private void LoadCategory()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=desktop-qdtenrh\sqlexpress;Initial Catalog=RestaurantManagement;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select id, name from category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // open
            conn.Open();
            //dổ dữ liệu vào datatable
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();
            //dua du lieu vao combobox
            cbbCategory.DataSource = dt;
            // hien thi ten san pham
            cbbCategory.DisplayMember = "Name";
            // lay id
            cbbCategory.ValueMember = "ID";
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            SqlConnection conn = new SqlConnection(@"Data Source=desktop-qdtenrh\sqlexpress;Initial Catalog=RestaurantManagement;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from food where foodCategoryID = @categoryID";
            //truyen tham so
            cmd.Parameters.AddWithValue("@categoryID", SqlDbType.Int);
            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryID"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryID"].Value = cbbCategory.SelectedValue;
            }
            //tao bo dieu phieu du lieu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            var foodTable = new DataTable();
            conn.Open();
            adapter.Fill(foodTable);
            conn.Close();
            conn.Dispose();
            // dua du lieu vao datagridview
            dtgvFoodList.DataSource = foodTable;
            //dem so luong
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;

        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=desktop-qdtenrh\sqlexpress;Initial Catalog=RestaurantManagement;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select @numSaleFood = sum(Quantity) From BillDetails where FoodID = @foodID";
            // lay thong tin san pham duoc chon
            if (dtgvFoodList.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = dtgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                //truyen tham so
                cmd.Parameters.AddWithValue("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];
                cmd.Parameters.AddWithValue("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;
                // mo 
                conn.Open();
                cmd.ExecuteNonQuery();
                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);

                conn.Close();
            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            fOODInfoForm foodForm = new fOODInfoForm();
            foodForm.FormClosed += new FormClosedEventHandler(fOODInfoForm_FormClosed);
            foodForm.Show(this);
        }
        private void fOODInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }


        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            // lay thong tin duoc chon
            if (dtgvFoodList.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = dtgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                fOODInfoForm foodForm = new fOODInfoForm();
                foodForm.FormClosed += new FormClosedEventHandler(fOODInfoForm_FormClosed);
                foodForm.Show(this);
                foodForm.DisPlayFoodInfo(rowView);
            }
        }
    }
}
