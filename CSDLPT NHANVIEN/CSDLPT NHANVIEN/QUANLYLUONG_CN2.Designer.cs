namespace CSDLPT_NHANVIEN
{
    partial class QUANLYLUONG_CN2
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
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.txtHSLUONG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.lblTinhLuong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(295, 24);
            this.cboMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(152, 24);
            this.cboMaNV.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã NV";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(295, 141);
            this.txtLuongCB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(152, 22);
            this.txtLuongCB.TabIndex = 15;
            // 
            // txtHSLUONG
            // 
            this.txtHSLUONG.Location = new System.Drawing.Point(295, 84);
            this.txtHSLUONG.Margin = new System.Windows.Forms.Padding(4);
            this.txtHSLUONG.Name = "txtHSLUONG";
            this.txtHSLUONG.Size = new System.Drawing.Size(152, 22);
            this.txtHSLUONG.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lương Cơ Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hệ Số Lương";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HeSoLuong,
            this.LuongCB});
            this.dataGridView1.Location = new System.Drawing.Point(170, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(345, 185);
            this.dataGridView1.TabIndex = 11;
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.HeaderText = "Hệ Số Lương";
            this.HeSoLuong.Name = "HeSoLuong";
            // 
            // LuongCB
            // 
            this.LuongCB.HeaderText = "Lương Cơ Bản";
            this.LuongCB.Name = "LuongCB";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(182, 184);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(103, 29);
            this.btnTinhLuong.TabIndex = 19;
            this.btnTinhLuong.Text = "Tính Lương";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // lblTinhLuong
            // 
            this.lblTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhLuong.Location = new System.Drawing.Point(292, 184);
            this.lblTinhLuong.Name = "lblTinhLuong";
            this.lblTinhLuong.Size = new System.Drawing.Size(155, 29);
            this.lblTinhLuong.TabIndex = 20;
            // 
            // QUANLYLUONG_CN2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.lblTinhLuong);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtHSLUONG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QUANLYLUONG_CN2";
            this.Text = "QUANLYLUONG_CN2";
            this.Load += new System.EventHandler(this.QUANLYLUONG_CN2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.TextBox txtHSLUONG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Label lblTinhLuong;
    }
}