namespace WindowsFormsApp1
{
	partial class TransferItemReportForm
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
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FromStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ToStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(189, 21);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(151, 147);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Date,
            this.FromStore,
            this.ToStore,
            this.Quantity});
			this.dataGridView1.Location = new System.Drawing.Point(12, 208);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(518, 137);
			this.dataGridView1.TabIndex = 33;
			// 
			// Name
			// 
			this.Name.HeaderText = "Name";
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			// 
			// FromStore
			// 
			this.FromStore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.FromStore.HeaderText = "From Store";
			this.FromStore.Name = "FromStore";
			this.FromStore.ReadOnly = true;
			// 
			// ToStore
			// 
			this.ToStore.HeaderText = "To Store";
			this.ToStore.Name = "ToStore";
			this.ToStore.ReadOnly = true;
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.ReadOnly = true;
			// 
			// TransferItemReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.listBox1);
			this.Text = "TransferItemReportForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn FromStore;
		private System.Windows.Forms.DataGridViewTextBoxColumn ToStore;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
	}
}