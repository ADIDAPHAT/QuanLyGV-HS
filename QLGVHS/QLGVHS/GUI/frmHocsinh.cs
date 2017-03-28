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
            this.Close();
        }

        private void txtTimMaHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimTenHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTimMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTimDanToc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
