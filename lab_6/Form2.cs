using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			
		}
		public void LoadFood(int categoryID)
		{
			string connectionString = "server = hoangPhuc; database = RestaurantManagement1; Integrated Security = true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlcommand = sqlConnection.CreateCommand();

			string query = "select Name from Category where ID= " +categoryID + "";

			sqlcommand.CommandText = query;
			sqlConnection.Open();

			string catName= sqlcommand.ExecuteScalar().ToString();
			this.Text = catName;

			sqlcommand.CommandText = "select *from food where foodcategoryID= " + categoryID;
			SqlDataAdapter adapter = new SqlDataAdapter(sqlcommand);	

			DataTable dataTable = new DataTable("food");
			adapter.Fill(dataTable);

			dataGridView1.DataSource = dataTable;

			sqlcommand.Dispose();
			sqlConnection.Close();
			adapter.Dispose();


			
		}
	}
}
