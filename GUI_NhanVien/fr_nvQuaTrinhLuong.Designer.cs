namespace GUI_NhanVien
{
    partial class fr_nvQuaTrinhLuong
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
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.rdDenNgay = new System.Windows.Forms.RadioButton();
            this.rdHienTai = new System.Windows.Forms.RadioButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Ngày";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "";
            this.dtpNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(75, 70);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(189, 24);
            this.dtpNgay.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.rdDenNgay);
            this.groupBox1.Controls.Add(this.rdHienTai);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra Cứu";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(759, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 35);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rdDenNgay
            // 
            this.rdDenNgay.AutoSize = true;
            this.rdDenNgay.Location = new System.Drawing.Point(414, 72);
            this.rdDenNgay.Name = "rdDenNgay";
            this.rdDenNgay.Size = new System.Drawing.Size(129, 21);
            this.rdDenNgay.TabIndex = 5;
            this.rdDenNgay.TabStop = true;
            this.rdDenNgay.Text = "Hoặc Đến Ngày";
            this.rdDenNgay.UseVisualStyleBackColor = true;
            this.rdDenNgay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdDenNgay_MouseClick);
            // 
            // rdHienTai
            // 
            this.rdHienTai.AutoSize = true;
            this.rdHienTai.Location = new System.Drawing.Point(284, 73);
            this.rdHienTai.Name = "rdHienTai";
            this.rdHienTai.Size = new System.Drawing.Size(112, 21);
            this.rdHienTai.TabIndex = 4;
            this.rdHienTai.TabStop = true;
            this.rdHienTai.Text = "Đến Hiện Tại";
            this.rdHienTai.UseVisualStyleBackColor = true;
            this.rdHienTai.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdHienTai_MouseClick);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(549, 73);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(174, 24);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(592, 323);
            this.dataGridView1.TabIndex = 3;
            // 
            // fr_nvQuaTrinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fr_nvQuaTrinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quá trình lương";
            this.Load += new System.EventHandler(this.fr_nvQuaTrinhLuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.RadioButton rdDenNgay;
        private System.Windows.Forms.RadioButton rdHienTai;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}