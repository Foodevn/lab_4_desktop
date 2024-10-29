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

namespace bai1
{
	public partial class foodInfoForm : Form
	{
		SqlConnection conn;
		SqlCommand sqlCommand;
		DataTable foodTable;
		public foodInfoForm()
		{
			InitializeComponent();
		}

		
		void Connection()
		{
			string connectString = "server = hoangphuc ; database= RestaurantManagement ; integrated security = true ;";
			conn = new SqlConnection(connectString);
			sqlCommand = conn.CreateCommand();
		}
		private void foodInfoForm_Load(object sender, EventArgs e)
		{
			this.InitValues();
		}
		void InitValues()
		{
			this.Connection();
			sqlCommand.CommandText = "Select id, name from Category";
			SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
			DataSet ds = new DataSet();

			conn.Open();
			adapter.Fill(ds,"Category");

			conn.Close();
			conn.Dispose();

			cbbCategoryName.DataSource = ds.Tables["Category"];
			cbbCategoryName.DisplayMember = "Name";
			cbbCategoryName.ValueMember = "id";
		}
		void ResetText()
		{
			txtFoodID.ResetText();
			txtName.ResetText();
			txtNotes.ResetText();
			txtUnit.ResetText();
			cbbCategoryName.ResetText();
			numericUpDownPrice.ResetText();

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				this.Connection();
				sqlCommand.CommandText = "execute insertFood @ID OUTPUT,@name,@unit,@foodCategoryID,@price,@notes";

				SqlParameter idParam = sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
				idParam.Direction = ParameterDirection.Output;


				sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@unit", SqlDbType.NVarChar, 1000);
				sqlCommand.Parameters.Add("@foodCategoryID", SqlDbType.Int);
				sqlCommand.Parameters.Add("@price", SqlDbType.Int);
				sqlCommand.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

		
				sqlCommand.Parameters["@name"].Value = txtName.Text;
				sqlCommand.Parameters["@unit"].Value = txtUnit.Text;
				sqlCommand.Parameters["@foodCategoryID"].Value = cbbCategoryName.SelectedValue;
				sqlCommand.Parameters["@price"].Value = numericUpDownPrice.Value;
				sqlCommand.Parameters["@notes"].Value = txtNotes.Text;

				conn.Open();

				int numRowAffected = sqlCommand.ExecuteNonQuery();
				if (numRowAffected > 0)
				{
					string foodID = sqlCommand.Parameters["@ID"].Value.ToString();
					MessageBox.Show("thêm món mới thành công. food ID = "
						+ foodID, "message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("thêm món mới thất bại ");

				}
				conn.Close();
				conn.Dispose();

			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message, "error");
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "error");
			}
		}
	}
}
