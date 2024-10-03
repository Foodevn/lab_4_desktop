namespace bai1
{
	partial class FormBai2
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbHienThiTien = new System.Windows.Forms.Label();
			this.tbDonGia = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbTienMat = new System.Windows.Forms.RadioButton();
			this.rbChuyenTien = new System.Windows.Forms.RadioButton();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên Hàng:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Đơn Giá:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số Lượng:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(43, 362);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số Tiền Thanh Toán:";
			// 
			// lbHienThiTien
			// 
			this.lbHienThiTien.AutoSize = true;
			this.lbHienThiTien.Location = new System.Drawing.Point(247, 362);
			this.lbHienThiTien.Name = "lbHienThiTien";
			this.lbHienThiTien.Size = new System.Drawing.Size(14, 16);
			this.lbHienThiTien.TabIndex = 0;
			this.lbHienThiTien.Text = "0";
			// 
			// tbDonGia
			// 
			this.tbDonGia.Location = new System.Drawing.Point(147, 107);
			this.tbDonGia.Name = "tbDonGia";
			this.tbDonGia.ReadOnly = true;
			this.tbDonGia.Size = new System.Drawing.Size(142, 22);
			this.tbDonGia.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbTienMat);
			this.groupBox1.Controls.Add(this.rbChuyenTien);
			this.groupBox1.Location = new System.Drawing.Point(46, 191);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(243, 100);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hình Thức Thanh Toán";
			// 
			// rbTienMat
			// 
			this.rbTienMat.AutoSize = true;
			this.rbTienMat.Checked = true;
			this.rbTienMat.Location = new System.Drawing.Point(58, 62);
			this.rbTienMat.Name = "rbTienMat";
			this.rbTienMat.Size = new System.Drawing.Size(80, 20);
			this.rbTienMat.TabIndex = 1;
			this.rbTienMat.TabStop = true;
			this.rbTienMat.Text = "Tiền mặt";
			this.rbTienMat.UseVisualStyleBackColor = true;
			// 
			// rbChuyenTien
			// 
			this.rbChuyenTien.AutoSize = true;
			this.rbChuyenTien.Location = new System.Drawing.Point(58, 36);
			this.rbChuyenTien.Name = "rbChuyenTien";
			this.rbChuyenTien.Size = new System.Drawing.Size(97, 20);
			this.rbChuyenTien.TabIndex = 0;
			this.rbChuyenTien.Text = "Chuyển tiền";
			this.rbChuyenTien.UseVisualStyleBackColor = true;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(126, 310);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
			this.btnTinhTien.TabIndex = 3;
			this.btnTinhTien.Text = "Tính Tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phim"});
			this.comboBox1.Location = new System.Drawing.Point(147, 69);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(142, 24);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// nudSoLuong
			// 
			this.nudSoLuong.Location = new System.Drawing.Point(147, 143);
			this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSoLuong.Name = "nudSoLuong";
			this.nudSoLuong.Size = new System.Drawing.Size(142, 22);
			this.nudSoLuong.TabIndex = 5;
			this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// FormBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 450);
			this.Controls.Add(this.nudSoLuong);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbDonGia);
			this.Controls.Add(this.lbHienThiTien);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormBai2";
			this.Text = "FormBai2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbHienThiTien;
		private System.Windows.Forms.TextBox tbDonGia;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbTienMat;
		private System.Windows.Forms.RadioButton rbChuyenTien;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.NumericUpDown nudSoLuong;
	}
}