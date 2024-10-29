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
using System.Xml.Serialization;

namespace Lab7_Advanced_Command
{
	public partial class Form1 : Form
	{
		SqlConnection conn;
		SqlCommand sqlCommand;
		DataTable foodTable;

		public Form1()
		{
			InitializeComponent();


		}
		void Connection()
		{
			string connectString = "server = hoangphuc ; database= RestaurantManagement ; integrated security = true ;";
			conn = new SqlConnection(connectString);
			sqlCommand = conn.CreateCommand();
		}
		void LoadCategory()
		{
			Connection();
			sqlCommand.CommandText = "SELECT ID,Name FROM Category";
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataTable dt = new DataTable();

			conn.Open();

			adapter.Fill(dt);

			conn.Close();
			conn.Dispose();

			cbbCategory.DataSource = dt;

			cbbCategory.DisplayMember = "Name";// viết thường hay viết hoa đều được
			cbbCategory.ValueMember = "ID";

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			LoadCategory();
		}

		private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbbCategory.SelectedIndex == -1) return;
			Connection();

			sqlCommand = conn.CreateCommand();
			sqlCommand.CommandText = "select * from Food where FoodCategory = @categoryId";
			sqlCommand.Parameters.Add("@categoryId", SqlDbType.Char);

			if (cbbCategory.SelectedValue is DataRowView)
			{
				DataRowView row = cbbCategory.SelectedValue as DataRowView;
				sqlCommand.Parameters["@categoryId"].Value = row["ID"];

			}
			else
			{

				sqlCommand.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
			}

			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			foodTable = new DataTable();

			conn.Open();
			adapter.Fill(foodTable);

			conn.Close();
			conn.Dispose();

			dataGridView1.DataSource = foodTable;

			lblQuantity.Text = foodTable.Rows.Count.ToString();
			lblCatName.Text = cbbCategory.Text;

		}


		private void tsmCalculateQuantityToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Connection();
			sqlCommand = conn.CreateCommand();
			sqlCommand.CommandText = "select @sum = sum(quantity) from BillDetails where FoodID = @foodId";
			if (dataGridView1.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				sqlCommand.Parameters.Add("@foodId", SqlDbType.Int);
				sqlCommand.Parameters["@foodId"].Value = rowView["ID"];

				sqlCommand.Parameters.Add("@sum", SqlDbType.Int);
				sqlCommand.Parameters["@sum"].Direction = ParameterDirection.Output;

				conn.Open();

				sqlCommand.ExecuteNonQuery();
				string result = sqlCommand.Parameters["@sum"].Value.ToString();
				if (result == "")
				{
					MessageBox.Show("chưa bán được " + rowView["unit"] + " " + rowView["name"] + " nào");
				}
				else
				{
					MessageBox.Show("tổng số lượng " + rowView["name"] + " đã bán là: " + result + " " + rowView["unit"]);
				}
				conn.Close();


			}
			sqlCommand.Dispose();
			conn.Dispose();
		}

	}
}
