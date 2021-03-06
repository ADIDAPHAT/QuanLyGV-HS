﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGVHS_BUS;
using QLGVHS_DATA;
using QLGCHS_ValueObject;
using QLGVHS_DATA;
namespace QLGVHS.GUI
{
    public partial class frmGiaoVien : Form
    {
        int dong = -1;
        SQL_tblGiaovien gv = new SQL_tblGiaovien();
        SQL_tblMonhoc MH = new SQL_tblMonhoc();
        EC_tblGiaovien teacher = new EC_tblGiaovien();
        DataTable dt = new DataTable();
        private bool themmoi;

        public void SetNull()
        {
            txtMaGV.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtLuong.Text = "";
            dtpNS.Value = new DateTime(1900, 1, 1);
        }
        public void MoDieuKhien()
        {
            txtMaGV.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtLuong.ReadOnly = false;
        }
        public void KhoaDieuKhien()
        {
            txtMaGV.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtLuong.ReadOnly = true;
        }
        private bool _dangTimMaGV = false;
        private bool _dangTimHo = false;
        private bool _dangTimTen = false;
        private bool _dangTimMaMon = false;
        private bool _dangTimDiaChi = false;

        private BUS_tblGiaovien busGV = new BUS_tblGiaovien();
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {        
            KhoaDieuKhien();
            btnLuu.Enabled = false;
            dgvGiaoVien.DataSource = gv.getAllgiaovien();
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtMaGV.Text = dgvGiaoVien.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dgvGiaoVien.Rows[dong].Cells[1].Value.ToString();
                cbGT.Text = dgvGiaoVien.Rows[dong].Cells[2].Value.ToString();
                dtpNS.Text = dgvGiaoVien.Rows[dong].Cells[3].Value.ToString();
                txtSDT.Text = dgvGiaoVien.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvGiaoVien.Rows[dong].Cells[5].Value.ToString();
                txtLuong.Text = dgvGiaoVien.Rows[dong].Cells[6].Value.ToString();
                cbTenMon.DataSource = MH.getMonhoc("where MaMon = '" + dgvGiaoVien.Rows[dong].Cells[7].Value.ToString()+ "'");
                cbTenMon.DisplayMember = "TenMon";
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt = MH.getAllMonhoc();
            cbTenMon.DataSource = dt;
            cbTenMon.DisplayMember = "TenMon";
            cbTenMon.ValueMember = "MaMon";
            txtMaGV.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaGV.Focus();
            MoDieuKhien();
            SetNull();
            txtLuong.Text = "500000";
            themmoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn giáo viên để sửa!");
                return;
            }
            MoDieuKhien();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            dt = MH.getAllMonhoc();
            cbTenMon.DataSource = dt;
            cbTenMon.DisplayMember = "TenMon";
            cbTenMon.ValueMember = "MaMon";
            cbTenMon.DataSource = MH.getMonhoc("where MaMon = '" + dgvGiaoVien.Rows[dong].Cells[7].Value.ToString() + "'");
            cbTenMon.DisplayMember = "TenMon";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                KhoaDieuKhien();
                return;
            }
            else
            {
                if (themmoi == true)/*đang ở trang thái thêm mới*/
                {
                    try
                    {
                        teacher.MaGV = txtMaGV.Text;
                        teacher.TenGV = txtTen.Text;
                        teacher.GT = cbGT.Text;
                        teacher.NgaySinh = dtpNS.Value.Year.ToString() + "-" + dtpNS.Value.Month.ToString() + "-" + dtpNS.Value.Day.ToString();
                        teacher.DiaChi = txtDiaChi.Text;
                        teacher.Luong = txtLuong.Text;
                        teacher.MaMon = cbTenMon.SelectedValue.ToString();
                        teacher.SDT = txtSDT.Text;

                        busGV.addGiaovien(teacher);
                        MessageBox.Show("Đã thêm mới thành công");/*dòng thông báo*/
                        //toolStripMenuItem1_Click(sender, e);
                        txtMaGV.Enabled = false;
                        btnLuu.Enabled = false;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        SetNull();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        teacher.MaGV = txtMaGV.Text;
                        teacher.TenGV = txtTen.Text;
                        teacher.GT = cbGT.Text;
                        teacher.NgaySinh = dtpNS.Value.Year.ToString() + "-" + dtpNS.Value.Month.ToString() + "-" + dtpNS.Value.Day.ToString();
                        teacher.DiaChi = txtDiaChi.Text;
                        teacher.Luong = txtLuong.Text;
                        teacher.MaMon = cbTenMon.SelectedValue.ToString();
                        teacher.SDT = txtSDT.Text;
                        gv.updateGiaovien(teacher);
                        MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        MessageBox.Show("Đã sửa thành công");

                        SetNull();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                SetNull();
                KhoaDieuKhien();/*không cho thao tác*/
                dgvGiaoVien.DataSource = gv.getAllgiaovien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
				DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                teacher.MaGV = txtMaGV.Text;
                gv.delGiaovien(teacher);
                SetNull();
                dgvGiaoVien.DataSource = gv.getAllgiaovien();
            }


        }

        private void txtTimMaGV_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMaGV.Text != "") _dangTimMaGV = true;
            else _dangTimMaGV = false;
            string dieukien = "where MaGV like N'%" + txtTimMaGV.Text + "%'";

            if (_dangTimTen) dieukien += "AND TenGV like N'%" + txtTen.Text + "%'";
            
           

            DataTable tbl = busGV.getgiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }

        private void txtTimTenGv_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTenGv.Text != "") _dangTimTen = true;
            else _dangTimTen = false;
            string dieukien = "where TenGV like N'%" + txtTimTenGv.Text + "%'";

            if (_dangTimMaGV) dieukien += "AND MaGV like N'%" + txtTen.Text + "%'";



            DataTable tbl = busGV.getgiaovien(dieukien);
            dgvGiaoVien.DataSource = tbl;
        }

        private void txtTimMaGV_Click(object sender, EventArgs e)
        {
            txtTimMaGV.Text = "";

        }

        private void txtTimTenGv_Click(object sender, EventArgs e)
        {
            txtTimTenGv.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Thoát hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                SetNull();
                KhoaDieuKhien();/*không cho thao tác*/
                dgvGiaoVien.DataSource = gv.getAllgiaovien();
            }
        }
    }
}
