namespace WindowsFormsApp1
{
	partial class ProductReportForm
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(610, 39);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(151, 173);
			this.listBox1.TabIndex = 31;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Code,
            this.Store});
			this.dataGridView1.Location = new System.Drawing.Point(85, 39);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(343, 208);
			this.dataGridView1.TabIndex = 32;
			// 
			// Name
			// 
			this.Name.HeaderText = "Name";
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			// 
			// Code
			// 
			this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Code.HeaderText = "Code";
			this.Code.Name = "Code";
			this.Code.ReadOnly = true;
			// 
			// Store
			// 
			this.Store.HeaderText = "Store";
			this.Store.Name = "Store";
			this.Store.ReadOnly = true;
			// 
			// ProductReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.listBox1);
			this.Text = "ProductReportForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Code;
		private System.Windows.Forms.DataGridViewTextBoxColumn Store;
	}
}