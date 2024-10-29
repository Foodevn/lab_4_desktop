namespace Lab7_Advanced_Command
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblCatName = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cbbCategory = new System.Windows.Forms.ComboBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmCalculateQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSeperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAddFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmUpdateFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn món ăn :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(272, 395);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "món ăn thuộc nhóm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(91, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Có tất cả";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(169, 395);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(22, 16);
			this.lblQuantity.TabIndex = 0;
			this.lblQuantity.Text = ". . .";
			// 
			// lblCatName
			// 
			this.lblCatName.AutoSize = true;
			this.lblCatName.Location = new System.Drawing.Point(427, 395);
			this.lblCatName.Name = "lblCatName";
			this.lblCatName.Size = new System.Drawing.Size(22, 16);
			this.lblCatName.TabIndex = 0;
			this.lblCatName.Text = ". . .";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 269);
			this.dataGridView1.TabIndex = 1;
			// 
			// cbbCategory
			// 
			this.cbbCategory.FormattingEnabled = true;
			this.cbbCategory.Location = new System.Drawing.Point(216, 28);
			this.cbbCategory.Name = "cbbCategory";
			this.cbbCategory.Size = new System.Drawing.Size(121, 24);
			this.cbbCategory.TabIndex = 2;
			this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantityToolStripMenuItem,
            this.tsmSeperatorToolStripMenuItem,
            this.tsmAddFoodToolStripMenuItem,
            this.tsmUpdateFoodToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(220, 128);
			// 
			// tsmCalculateQuantityToolStripMenuItem
			// 
			this.tsmCalculateQuantityToolStripMenuItem.Name = "tsmCalculateQuantityToolStripMenuItem";
			this.tsmCalculateQuantityToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
			this.tsmCalculateQuantityToolStripMenuItem.Text = "tsmCalculateQuantity";
			this.tsmCalculateQuantityToolStripMenuItem.Click += new System.EventHandler(this.tsmCalculateQuantityToolStripMenuItem_Click);
			// 
			// tsmSeperatorToolStripMenuItem
			// 
			this.tsmSeperatorToolStripMenuItem.Name = "tsmSeperatorToolStripMenuItem";
			this.tsmSeperatorToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
			this.tsmSeperatorToolStripMenuItem.Text = "tsmSeperator";
			// 
			// tsmAddFoodToolStripMenuItem
			// 
			this.tsmAddFoodToolStripMenuItem.Name = "tsmAddFoodToolStripMenuItem";
			this.tsmAddFoodToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
			this.tsmAddFoodToolStripMenuItem.Text = "tsmAddFood";
			// 
			// tsmUpdateFoodToolStripMenuItem
			// 
			this.tsmUpdateFoodToolStripMenuItem.Name = "tsmUpdateFoodToolStripMenuItem";
			this.tsmUpdateFoodToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
			this.tsmUpdateFoodToolStripMenuItem.Text = "tsmUpdateFood";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbbCategory);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.lblCatName);
			this.Controls.Add(this.lblQuantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Có tất cả";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblCatName;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cbbCategory;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmSeperatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmAddFoodToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmUpdateFoodToolStripMenuItem;
	}
}

