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
    public partial class fOODInfoForm : Form
    {
        public fOODInfoForm()
        {
            InitializeComponent();
        }

        private void fOODInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }
        private void InitValues()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select ID, Name from Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Category");
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";
            conn.Close();
            conn.Dispose();

        }
        private void ReSetText()
        {
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nrudPrice.ResetText();

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXEC InsertFood @ID output, @Name, @Unit, @FoodCategoryID, @Price,  @Notes";
                // them tham so vao cmd
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@FoodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@Price", SqlDbType.Int);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000);

                cmd.Parameters["@ID"].Direction = ParameterDirection.Output;
                // truyen gia tri  thu tuc qua tham so
                cmd.Parameters["@Name"].Value = txtName.Text;
                cmd.Parameters["@Unit"].Value = txtUnit.Text;
                cmd.Parameters["@FoodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@Price"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@Notes"].Value = txtNotes.Text;
                //
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    string foodID = cmd.Parameters["@ID"].Value.ToString();
                    MessageBox.Show("Food ID  = " + foodID, "Message");
                    this.ReSetText();
                }
                else
                {
                    MessageBox.Show("Add failed!!!");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Lỗi");
            }
        }
        private void DisPlayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nrudPrice.Text = rowView["Price"].ToString();

                cbbCatName.SelectedIndex = -1;
                // chon maon an tuong ung
                for (int i = 0; i < cbbCatName.Items.Count; i++)
                {
                    DataRowView cat = cbbCatName.Items[i] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = i;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "exec UpdateFood @ID, @Name, @Unit, @FoodCategoryID, @Price,  @Notes";
                // them tham so vao cmd
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@FoodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@Price", SqlDbType.Int);
                cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000);
                // truyen gia tri  thu tuc qua tham so
                cmd.Parameters["@ID"].Value = int.Parse(txtFoodID.Text);
                cmd.Parameters["@Name"].Value = txtName.Text;
                cmd.Parameters["@Unit"].Value = txtUnit.Text;
                cmd.Parameters["@FoodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@Price"].Value = nrudPrice.Value;
                cmd.Parameters["@Notes"].Value = txtNotes.Text;
                //
                conn.Open();
                int num = cmd.ExecuteNonQuery();
                if (num > 0)
                {
                    MessageBox.Show("Successfull!!!");
                    this.ReSetText();
                }
                else
                {
                    MessageBox.Show("Error!!!");
                }
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
