namespace lab5
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTest = new System.Windows.Forms.Button();
			this.btn_XML = new System.Windows.Forms.Button();
			this.btnWriteXML = new System.Windows.Forms.Button();
			this.buttone = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(145, 117);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 0;
			this.btnTest.Text = "Json";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btn_XML
			// 
			this.btn_XML.Location = new System.Drawing.Point(413, 117);
			this.btn_XML.Name = "btn_XML";
			this.btn_XML.Size = new System.Drawing.Size(106, 23);
			this.btn_XML.TabIndex = 1;
			this.btn_XML.Text = "XML";
			this.btn_XML.UseVisualStyleBackColor = true;
			this.btn_XML.Click += new System.EventHandler(this.btn_XML_Click);
			// 
			// btnWriteXML
			// 
			this.btnWriteXML.Location = new System.Drawing.Point(413, 157);
			this.btnWriteXML.Name = "btnWriteXML";
			this.btnWriteXML.Size = new System.Drawing.Size(106, 23);
			this.btnWriteXML.TabIndex = 1;
			this.btnWriteXML.Text = "Write XML";
			this.btnWriteXML.UseVisualStyleBackColor = true;
			this.btnWriteXML.Click += new System.EventHandler(this.btn_WriteXML_Click);
			// 
			// buttone
			// 
			this.buttone.Location = new System.Drawing.Point(145, 205);
			this.buttone.Name = "buttone";
			this.buttone.Size = new System.Drawing.Size(75, 23);
			this.buttone.TabIndex = 0;
			this.buttone.Text = "e";
			this.buttone.UseVisualStyleBackColor = true;
			this.buttone.Click += new System.EventHandler(this.btne_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnWriteXML);
			this.Controls.Add(this.btn_XML);
			this.Controls.Add(this.buttone);
			this.Controls.Add(this.btnTest);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btn_XML;
		private System.Windows.Forms.Button btnWriteXML;
		private System.Windows.Forms.Button buttone;
	}
}

