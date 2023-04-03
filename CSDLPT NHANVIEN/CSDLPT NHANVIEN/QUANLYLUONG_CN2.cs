﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using CSDLPT_NHANVIEN.Model;
using CSDLPT_NHANVIEN.Controller;

namespace CSDLPT_NHANVIEN
{
    public partial class QUANLYLUONG_CN2 : Form
    {
        LuongController LControl = new LuongController();
        public QUANLYLUONG_CN2()
        {
            InitializeComponent();
        }

        private void QUANLYLUONG_CN2_Load(object sender, EventArgs e)
        {
            loadNV();
        }
        public void loadNV()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                DataTable dtLuong = new DataTable();
                dtLuong = LControl.HienThiDuLieuLuong2();
                dataGridView1.DataSource = dtLuong;
                dataGridView1.DataSource = dtLuong;
                dataGridView1.Columns[0].DataPropertyName = "MaNV";
                dataGridView1.Columns[1].DataPropertyName = "HeSoLuong";
                dataGridView1.Columns[2].DataPropertyName = "LuongCB";
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            //lblTinhLuong = Double.Parse(txtHSLUONG.Text * txtLuongCB.Text);
        }
    }
}
