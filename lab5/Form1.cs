using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
namespace lab5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}
		private List<StudentInfo> LoadJson(string Path)
		{
			List<StudentInfo> list = new List<StudentInfo>();
			StreamReader sr = new StreamReader(Path);
			string json = sr.ReadToEnd();
			var array = (JObject)JsonConvert.DeserializeObject(json);
			var students = array["sinhvien"].Children();
			foreach (var student in students)
			{
				string mssv = student["MSSV"].Value<string>();
				string hoten = student["hoten"].Value<string>();
				int tuoi = student["tuoi"].Value<int>();
				double diem = student["diem"].Value<double>();
				bool tongiao = student["tongiao"].Value<bool>();
				StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
				list.Add(info);
			}
			return list;
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			string str = "";
			string path = Application.StartupPath+"\\tsconfig1.json";
			List<StudentInfo> list = LoadJson(path);
			for(int i = 0; i < list.Count; i++)
			{
				StudentInfo student = list[i];
				str += string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2},điểm TB: {3}\r\n", (i + 1), 
					student.MSSV, student.Hoten, student.Diem);
			}
			MessageBox.Show(str);
		}
		private void DocFileXML(string path)
		{
			
			var xmlDoc = new XmlDocument();
			xmlDoc.Load(path);
			XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");
			string s = "";
			foreach (XmlNode node in nodeList)
			{
				string isbn = node.Attributes["ISBN"].Value;
				string title = node.SelectSingleNode("title").InnerText;
				var price = node.SelectSingleNode("price").InnerText;
				var firstName = node.SelectSingleNode("author/first-name").InnerText;
				var lastName = node.SelectSingleNode("author/last-name").InnerText;
				 s+= isbn+ title+ firstName+ lastName+ price+"\n ";
			}
			MessageBox.Show(s);
		}

		private void btn_XML_Click(object sender, EventArgs e)
		{
			DocFileXML("book.xml");
		}

		private void WriteXMLandCreate()
		{
			using (XmlWriter writer = XmlWriter.Create("books.xml"))
			{
				// Write Processing Instruction 
				String pi = "type=\"text/xsl\" href=\"book.xsl\"";
				writer.WriteProcessingInstruction("xml-stylesheet", pi);
				// Write DocumentType 
				writer.WriteDocType("catalog", null, null, "<!ENTITY h\"hardcover\">");
				// Write a Comment 
				writer.WriteComment("This is a book sample XML");
				// Root element - start tag 
				writer.WriteStartElement("book");
				// Write ISBN attribute 
				writer.WriteAttributeString("ISBN", "9831123212");
				// Write year attribute 
				writer.WriteAttributeString("yearpublished", "2002");
				// Write title 
				writer.WriteElementString("author", "Mahesh Chand");
				// Write author 
				writer.WriteElementString("title", "Visual C# Programming");
				// Write price 
				writer.WriteElementString("price", "44.95");
				// Root element - end tag 
				writer.WriteEndElement();
				// End Documentd 
				writer.WriteEndDocument();
				// Flush it 
				writer.Flush();
			}
		}
		void WriteXML()
		{
			string xmlFilePath = "book.xml";
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(xmlFilePath);

			// Tạo phần tử <book> mới
			XmlElement newBook = xmlDoc.CreateElement("book");
			newBook.SetAttribute("ISBN", "9781234567890");
			newBook.SetAttribute("yearpublished", "2023");

			// Tạo và thêm phần tử <title> vào <book>
			XmlElement title = xmlDoc.CreateElement("title");
			title.InnerText = "Learning C# for Beginners";
			newBook.AppendChild(title);

			// Tạo và thêm phần tử <author> vào <book>
			XmlElement author = xmlDoc.CreateElement("author");
			XmlElement firstName = xmlDoc.CreateElement("first-name");
			firstName.InnerText = "John";
			XmlElement lastName = xmlDoc.CreateElement("last-name");
			lastName.InnerText = "Doe";
			author.AppendChild(firstName);
			author.AppendChild(lastName);
			newBook.AppendChild(author);

			// Tạo và thêm phần tử <publisher> vào <book>
			XmlElement publisher = xmlDoc.CreateElement("publisher");
			publisher.InnerText = "TechBooks Publishing";
			newBook.AppendChild(publisher);

			// Tạo và thêm phần tử <price> vào <book>
			XmlElement price = xmlDoc.CreateElement("price");
			price.InnerText = "39.99";
			newBook.AppendChild(price);

			// Thêm phần tử <book> mới vào <catalog>
			XmlNode catalog = xmlDoc.SelectSingleNode("/catalog");
			if (catalog != null)
			{
				catalog.AppendChild(newBook);
			}

			// Lưu tệp XML đã cập nhật
			xmlDoc.Save(xmlFilePath);

		}

		private void btn_WriteXML_Click(object sender, EventArgs e)
		{
			WriteXML();
			//WriteXMLandCreate();
		}
		static void Excel()
		{
			string s = "";
			// Đường dẫn tới tệp Excel
			string filePath = Application.StartupPath+ "\\Test.xlsx";

			// Tạo đối tượng Excel
			Excel.Application excelApp = new Excel.Application();
			Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);
			Excel._Worksheet worksheet = workbook.Sheets[1];
			Excel.Range range = worksheet.UsedRange;

			// Lấy số lượng hàng và cột
			int rowCount = range.Rows.Count;
			int colCount = range.Columns.Count;

			// Duyệt qua từng hàng và cột để đọc dữ liệu
			for (int row = 1; row <= rowCount; row++)
			{
				for (int col = 1; col <= colCount; col++)
				{
					// Lấy giá trị từng ô
					var cellValue = (range.Cells[row, col] as Excel.Range).Value2;
					s+=(cellValue + "\t");
				}
				s+="\n";
			}

			// Đóng workbook và thoát ứng dụng Excel
			workbook.Close(false);
			excelApp.Quit();

			// Giải phóng tài nguyên
			System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
			System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
			System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

			Console.WriteLine("Đã đọc xong tệp Excel.");
			MessageBox.Show(s);
		}

		private void btne_Click(object sender, EventArgs e)
		{
			Excel();
		}
	}
}
