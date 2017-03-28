using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGCHS_ValueObject;
using QLGVHS_BUS;
using QLGVHS_DATA;

namespace QLGVHS.GUI
{
    public partial class frmHocsinh : Form
    {
        public frmHocsinh()
        {
            InitializeComponent();
        }
        private bool _dangTimMa = false;
        private bool _dangTimHo = false;
        private bool _dangTimTen = false;
        private bool _dangTimMaLop = false;
        private bool _dangTimDanToc = false;
        private bool _dangTimTonGiao = false;

        private BUS_tblHocSinh busHS = new BUS_tblHocSinh();
        private EC_tblHocsinh ectHS = new EC_tblHocsinh();
        private bool _koload = true;
        private bool _koclick = true;
        private bool _kotim = true;
        private bool _xacnhan = false;
        private bool themmoi;
        void SetNull()
        {
            txtMaHS.Text = "";
            txtTen.Text = "";
            cboMaLop.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.ResetText();
        }
        private void KhoaDieuKhien()
        {
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            txtMaHS.ReadOnly = true;
            txtTen.ReadOnly = true;
            cboMaLop.Enabled = false;
            txtDiaChi.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            cboTonGiao.Enabled = false;
            cboDanToc.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void MoDieuKhien()
        {
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            txtMaHS.ReadOnly = false;
            txtTen.ReadOnly = false;
            cboMaLop.Enabled = true;
            cboTonGiao.Enabled = true;
            cboDanToc.Enabled = true;
            txtDiaChi.ReadOnly = false;
            dtpNgaySinh.Enabled = true;
        }
        private void DoDLMaLop()
        {
            cboMaLop.DataSource = busHS.DoDLMaLop("");
            cboMaLop.DisplayMember = "MaLop";
        }
        public frmHocsinh(string action)
        {
            InitializeComponent();
            if (action == "TimKiem")
            grbThongTinHocSinh.Enabled = false;
            //btnLamMoiDuLieu.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void HienThi()
        {
            dgvHocSinh.DataSource = busHS.getAllHocsinh();
        }

        
        private void frmHocsinh_Load(object sender, EventArgs e)
        {
            DataTable tbl = busHS.getAllHocsinh();
            dgvHocSinh.DataSource = tbl;
            //load_data();
        }
        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtMaHS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTen.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboMaLop.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colMaLop"].Value.ToString();
                cboDanToc.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colDanToc"].Value.ToString();
                cboTonGiao.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colTonGiao"].Value.ToString();
                if (dgvHocSinh.Rows[e.RowIndex].Cells["colGT"].Value.ToString() == "Nam") rdbNam.Checked = true;
                else rdbNu.Checked = true;
                dtpNgaySinh.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colNgaySinh"].Value.ToString();

                txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells["colDiaChi"].Value.ToString();
            }
            catch
            {

            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            txtMaHS.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaHS.Focus();
            MoDieuKhien();
            SetNull();
            DoDLMaLop();
            themmoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            MoDieuKhien();
            txtMaHS.ReadOnly = true;
            themmoi = false;


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHS.Text == "" || txtTen.Text == "")
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
                        ectHS.MaHS = txtMaHS.Text;
                        ectHS.TenHS = txtTen.Text;
                        if (rdbNam.Checked) ectHS.GT = "Nam";
                        else ectHS.GT = "Nu";
                        ectHS.NgaySinh = dtpNgaySinh.Value.Year.ToString() + "-" + dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString();
                        ectHS.MaLop = cboMaLop.Text;
                        ectHS.DiaChi = txtDiaChi.Text;
                        ectHS.DanToc = cboDanToc.Text;
                        ectHS.TonGiao = cboTonGiao.Text;

                        busHS.addHocsinh(ectHS);
                        MessageBox.Show("Đã thêm mới thành công");/*dòng thông báo*/
                        //toolStripMenuItem1_Click(sender, e);
                        txtMaHS.Enabled = false;
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
                        ectHS.MaHS = txtMaHS.Text;
                        ectHS.TenHS = txtTen.Text;
                        if (rdbNam.Checked) ectHS.GT = "Nam";
                        else ectHS.GT = "Nu";
                        ectHS.NgaySinh = dtpNgaySinh.Value.Year.ToString() + "-" + dtpNgaySinh.Value.Month.ToString() + "-" + dtpNgaySinh.Value.Day.ToString();
                        ectHS.MaLop = cboMaLop.Text;
                        ectHS.DiaChi = txtDiaChi.Text;
                        ectHS.DanToc = cboDanToc.Text;
                        ectHS.TonGiao = cboTonGiao.Text;

                        busHS.updateHocsinh(ectHS);
                        MessageBox.Show("Đã sửa thành công");
                      
                        SetNull();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                SetNull();
                KhoaDieuKhien();/*không cho thao tác*/
                HienThi();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                  DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ectHS.MaHS = txtMaHS.Text;
                busHS.delHocsinh(ectHS);
                MessageBox.Show("Đã xóa thành công!");

                SetNull();
                dgvHocSinh.DataSource = busHS.getAllHocsinh();


            }
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
                dgvHocSinh.DataSource = busHS.getAllHocsinh();
            }
        }

        private void txtTimMaHS_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMaHS.Text != "") _dangTimMa = true;
            else _dangTimMa = false;
            string dieukien = "where MaHS like N'%" + txtTimMaHS.Text + "%'";
           
            if (_dangTimTen) dieukien += "AND TenHS like N'%" + txtTen.Text + "%'";
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimDanToc.Text + "%'";
            }
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
           
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }

        private void txtTimTenHS_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTenHS.Text != "") _dangTimTen = true;
            else _dangTimTen = false;
            string dieukien = "where TenHS like N'%" + txtTimTenHS.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
            if (_dangTimTen) dieukien += "AND TenHS like N'%" + txtTen.Text + "%'";
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
            }
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
            
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }

        private void cboTimMaLop_TextChanged(object sender, EventArgs e)
        {

            if (cboTimMaLop.SelectedIndex != 0) _dangTimMaLop = true;
            else _dangTimMaLop = false;
            string dieukien = "";
            if (cboTimMaLop.SelectedIndex == 0) dieukien = "where MaLop like N'%'";
            else dieukien = "where MaLop like N'%" + cboTimMaLop.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
            
            if (_dangTimDanToc)
            {
                if (cboTimDanToc.SelectedIndex != 0) dieukien += "AND DanToc like N'%" + cboTimDanToc.Text + "%'";
            }
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }

        private void cboTimDanToc_TextChanged(object sender, EventArgs e)
        {

            if (cboTimDanToc.SelectedIndex != 0) _dangTimDanToc = true;
            else _dangTimDanToc = false;
            string dieukien = "";
            if (cboTimDanToc.SelectedIndex == 0) dieukien = "where DanToc like N'%'";
            else dieukien = "where DanToc like N'%" + cboTimDanToc.Text + "%'";
            if (_dangTimMa) dieukien += "AND MaHS like N'%" + txtMaHS.Text + "%'";
           
            if (_dangTimMaLop)
            {
                if (cboTimMaLop.SelectedIndex != 0) dieukien += "AND MaLop like N'%" + cboTimMaLop.Text + "%'";
            }
            
            DataTable tbl = busHS.getHocsinh(dieukien);
            dgvHocSinh.DataSource = tbl;
        }

        private void txtTimMaHS_Click(object sender, EventArgs e)
        {
            txtTimMaHS.Text = "";
            if (_dangTimMa)
            {
                txtTimMaHS.SelectionStart = txtTimMaHS.Text.Length;
            }
            else
            {
                txtTimMaHS.SelectAll();
            }
        }

        private void txtTimTenHS_Click(object sender, EventArgs e)
        {
            txtTimTenHS.Text = "";
            if (_dangTimTen)
            {
                txtTimTenHS.SelectionStart = txtTimTenHS.Text.Length;
            }
            else
            {
                txtTimTenHS.SelectAll();
            }
        }

        private void cboTimMaLop_Click(object sender, EventArgs e)
        {
            cboTimMaLop.SelectionStart = cboTimMaLop.Text.Length;
            BUS_tblHocSinh busHs = new BUS_tblHocSinh();
            DataTable tb = busHs.getField("MaLop");
            cboTimMaLop.Items.Clear();
            cboTimMaLop.Items.Add("Tất cả");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimMaLop.Items.Add(tb.Rows[i]["MaLop"].ToString());
            }
        }

        private void cboTimDanToc_Click(object sender, EventArgs e)
        {
            cboTimDanToc.SelectionStart = cboTimDanToc.Text.Length;
            BUS_tblHocSinh busHs = new BUS_tblHocSinh();
            DataTable tb = busHs.getField("DanToc");
            cboTimDanToc.Items.Clear();
            cboTimDanToc.Items.Add("Tất cả");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cboTimDanToc.Items.Add(tb.Rows[i]["DanToc"].ToString());
            }
        }

        private void txtTimMaHS_Enter(object sender, EventArgs e)
        {
            txtMaHS.SelectionStart = txtMaHS.Text.Length;
        }

        private void txtTimTenHS_Enter(object sender, EventArgs e)
        {
            txtTen.SelectionStart = txtTen.Text.Length;
        }

        private void cboTimMaLop_Enter(object sender, EventArgs e)
        {
            cboMaLop.SelectionStart = cboMaLop.Text.Length;
        }

        private void cboTimDanToc_Enter(object sender, EventArgs e)
        {
            cboDanToc.SelectionStart = cboDanToc.Text.Length;
        }
    }
}
