namespace WindowsFormsApp1
{
    partial class StoreReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExchangeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExchangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermitNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(28, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 196);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Store ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Store Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Store address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Responsible person";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(518, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(518, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 22);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(518, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 22);
            this.textBox4.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExchangeNumber,
            this.ExchangeDate,
            this.PermitNumber,
            this.PermitDate});
            this.dataGridView1.Location = new System.Drawing.Point(43, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 169);
            this.dataGridView1.TabIndex = 25;
            // 
            // ExchangeNumber
            // 
            this.ExchangeNumber.HeaderText = "Exchange Number";
            this.ExchangeNumber.MinimumWidth = 6;
            this.ExchangeNumber.Name = "ExchangeNumber";
            this.ExchangeNumber.Width = 125;
            // 
            // ExchangeDate
            // 
            this.ExchangeDate.HeaderText = "Exchange Date";
            this.ExchangeDate.MinimumWidth = 6;
            this.ExchangeDate.Name = "ExchangeDate";
            this.ExchangeDate.Width = 125;
            // 
            // PermitNumber
            // 
            this.PermitNumber.HeaderText = "Permit Number";
            this.PermitNumber.MinimumWidth = 6;
            this.PermitNumber.Name = "PermitNumber";
            this.PermitNumber.Width = 125;
            // 
            // PermitDate
            // 
            this.PermitDate.HeaderText = "Permit Date";
            this.PermitDate.MinimumWidth = 6;
            this.PermitDate.Name = "PermitDate";
            this.PermitDate.Width = 125;
            // 
            // StoreReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "StoreReport";
            this.Text = "StoreReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExchangeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermitNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermitDate;
    }
}