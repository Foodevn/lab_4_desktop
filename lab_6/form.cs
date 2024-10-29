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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			btnUpdate.Enabled = false;
			btnRemove.Enabled = false;

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			string connectionString = "server = hoangPhuc; database = RestaurantManagement1; Integrated Security = true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlcommand = sqlConnection.CreateCommand();

			string query = "SELECT ID, Name , Type FROM Category";
			sqlcommand.CommandText = query;
			sqlConnection.Open();

			SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

			this.DisplayCategory(sqlDataReader);
			sqlConnection.Close();
		}
		private void DisplayCategory(SqlDataReader reader)
		{
			lvCategory.Items.Clear();
			while (reader.Read())
			{
				ListViewItem item = new ListViewItem(reader["ID"].ToString());
				lvCategory.Items.Add(item);
				item.SubItems.Add(reader["Name"].ToString());
				item.SubItems.Add(reader["Type"].ToString());
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string connectionString = "server = HoangPhuc;database=RestaurantManagement1;Integrated Security=true; ";

			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlCommand.CommandText = "INSERT INTO Category(Name,Type) " +
				"VALUES ('" + tbTenThucAn.Text + "','" + tbLoai.Text + "')";

			sqlConnection.Open();



			int numOfRowEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();
			if (numOfRowEffected >= 1)
			{
				btnLoad.PerformClick();
			}
			else MessageBox.Show("đã có lỗi sảy ra");


		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string connectionString = "server = HoangPhuc;database=RestaurantManagement1;Integrated Security=true; ";

			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			int loai = tbLoai.Text == "thức uống" ? 0 : 1;


			sqlCommand.CommandText = "UPDATE Category SET Name='" + tbTenThucAn.Text +
				"',[Type]=" + loai +
				" WHERE ID='" + tbMaNhom.Text + "';";

			sqlConnection.Open();
			int numOfRowEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();
			if (numOfRowEffected >= 1)
			{


				btnLoad.PerformClick();

				tbTenThucAn.Text = "";
				tbLoai.Text = "";
				btnUpdate.Enabled = false;
				btnRemove.Enabled = false;

			}
			else MessageBox.Show("đã có lỗi sảy ra");



		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			string connectionString = "server = hoangPhuc; database = RestaurantManagement1; Integrated Security = true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlcommand = sqlConnection.CreateCommand();

			string query = "delete from category where ID= '" + tbMaNhom.Text + "'";
			sqlcommand.CommandText = query;
			sqlConnection.Open();
			int numofRowEffected = sqlcommand.ExecuteNonQuery();

			sqlConnection.Close();
			if (numofRowEffected >= 1)
			{

				btnLoad.PerformClick();
				tbMaNhom.Clear();
				tbLoai.Clear();
				tbTenThucAn.Clear();

			}

		}

		private void lvCategory_Click(object sender, EventArgs e)
		{
			ListViewItem item = lvCategory.SelectedItems[0];
			tbMaNhom.Text = item.Text;
			tbTenThucAn.Text = item.SubItems[1].Text;
			tbLoai.Text = item.SubItems[2].Text == "0" ? "thức uống" : "đồ ăn";
			btnUpdate.Enabled = true;
			btnRemove.Enabled = true;


		}

		private void tsmDelete_Click(object sender, EventArgs e)
		{

			if (lvCategory.SelectedItems.Count > 0)
				btnRemove.PerformClick();

		}

		private void tsmViewFood_Click(object sender, EventArgs e)
		{
			if (tbMaNhom.Text != "")
			{
				Form2 form = new Form2();
				form.Show();

				form.LoadFood(Convert.ToInt32(tbMaNhom.Text));
			}

		}
	}
}
