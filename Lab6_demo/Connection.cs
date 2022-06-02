using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab6
{
    public class Connection
    {
        //string conStr = @"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True");
    }
}
