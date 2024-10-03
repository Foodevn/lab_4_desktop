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
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connectionString = "server = hoangPhuc; database = lab6; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlcommand = sqlConnection.CreateCommand();
            
            string query = "SELECT ID, Name , Type FROM Category";
            sqlcommand.CommandText = query;
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

            this.DisplayCategory(sqlDataReader);
            sqlConnection.Close();




        }
        private void DisplayCategory(SqlDataReader reader )
        {
            lvCategory.Items.Clear();
            while(reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(item);
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());

            }
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
            string connectionString = "server = HoangPhuc;database=lab6;Integrated Security=true; ";
		
			SqlConnection sqlConnection = new SqlConnection( connectionString );

            SqlCommand sqlCommand =sqlConnection.CreateCommand();
             
            sqlCommand.CommandText = "INSERT INTO Category(ID,Name,Type) " +
                "VALUES (N'"+tbMaNhom.Text+"','"+tbTenThucAn.Text+"','"+tbLoai.Text+"')";

            sqlConnection.Open();
            int numOfRowEffected = 0;

			 numOfRowEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            if (numOfRowEffected >= 1)
            {
                MessageBox.Show("Thêm món thành công");

                btnLoad.PerformClick();

                tbTenThucAn.Text = "";
                tbLoai.Text = "";

            }
            else MessageBox.Show("đã có lỗi sảy ra");

            
		 }

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string connectionString = "server = HoangPhuc;database=lab6;Integrated Security=true; ";

			SqlConnection sqlConnection = new SqlConnection(connectionString);

			SqlCommand sqlCommand = sqlConnection.CreateCommand();
           
            sqlCommand.CommandText = "UPDATE Category SET Name='"+tbTenThucAn.Text+"',Type='"+tbLoai.Text+"' WHERE ID='"+tbMaNhom.Text+"';";

			sqlConnection.Open();
			int numOfRowEffected = 0;

			numOfRowEffected = sqlCommand.ExecuteNonQuery();

			sqlConnection.Close();
			if (numOfRowEffected >= 1)
			{
				MessageBox.Show("Cập Nhật thành công");

				btnLoad.PerformClick();

				tbTenThucAn.Text = "";
				tbLoai.Text = "";

			}
			else MessageBox.Show("đã có lỗi sảy ra");



		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
            UserControl userControl = new UserControl1();
            userControl.Location = new Point(10, 10);
            userControl.Size=new Size(10000,10000);
            this.Controls.Add(userControl);
            userControl.BringToFront();
		}
	}
}
