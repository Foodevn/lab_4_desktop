namespace lab_6
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.lvCategory = new System.Windows.Forms.ListView();
			this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.tbMaNhom = new System.Windows.Forms.TextBox();
			this.tbTenThucAn = new System.Windows.Forms.TextBox();
			this.tbLoai = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(13, 176);
			this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(109, 28);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Lấy danh sách";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lvCategory
			// 
			this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
			this.lvCategory.FullRowSelect = true;
			this.lvCategory.GridLines = true;
			this.lvCategory.HideSelection = false;
			this.lvCategory.Location = new System.Drawing.Point(13, 212);
			this.lvCategory.Margin = new System.Windows.Forms.Padding(4);
			this.lvCategory.MultiSelect = false;
			this.lvCategory.Name = "lvCategory";
			this.lvCategory.Size = new System.Drawing.Size(536, 329);
			this.lvCategory.TabIndex = 1;
			this.lvCategory.UseCompatibleStateImageBehavior = false;
			this.lvCategory.View = System.Windows.Forms.View.Details;
			// 
			// chID
			// 
			this.chID.Text = "Mã Loại  ";
			this.chID.Width = 110;
			// 
			// chName
			// 
			this.chName.Text = "Tên Loại Thức Ăn";
			this.chName.Width = 210;
			// 
			// chType
			// 
			this.chType.Text = "Loại ";
			this.chType.Width = 184;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(206, 176);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(109, 28);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(323, 176);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(109, 28);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "Cập Nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(440, 176);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(109, 28);
			this.btnRemove.TabIndex = 0;
			this.btnRemove.Text = "Xóa";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// tbMaNhom
			// 
			this.tbMaNhom.Location = new System.Drawing.Point(158, 30);
			this.tbMaNhom.Name = "tbMaNhom";
			this.tbMaNhom.Size = new System.Drawing.Size(218, 22);
			this.tbMaNhom.TabIndex = 2;
			// 
			// tbTenThucAn
			// 
			this.tbTenThucAn.Location = new System.Drawing.Point(158, 73);
			this.tbTenThucAn.Name = "tbTenThucAn";
			this.tbTenThucAn.Size = new System.Drawing.Size(218, 22);
			this.tbTenThucAn.TabIndex = 2;
			// 
			// tbLoai
			// 
			this.tbLoai.Location = new System.Drawing.Point(158, 121);
			this.tbLoai.Name = "tbLoai";
			this.tbLoai.Size = new System.Drawing.Size(218, 22);
			this.tbLoai.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã nhóm:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tên nhóm thức ăn:";
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Location = new System.Drawing.Point(24, 127);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(33, 16);
			this.lbType.TabIndex = 3;
			this.lbType.Text = "Loại";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 554);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbLoai);
			this.Controls.Add(this.tbTenThucAn);
			this.Controls.Add(this.tbMaNhom);
			this.Controls.Add(this.lvCategory);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnLoad);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.TextBox tbMaNhom;
		private System.Windows.Forms.TextBox tbTenThucAn;
		private System.Windows.Forms.TextBox tbLoai;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbType;
	}
}

