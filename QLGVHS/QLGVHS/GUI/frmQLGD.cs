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
using System.Data.SqlClient;
namespace QLGVHS.GUI
{
    public partial class frmQLGD : Form
    {
        DataTable dt, tb;
        private SQL_tblGiangday DAL_Giang = new SQL_tblGiangday();
        private SQL_tblGiaovien DAL_GV = new SQL_tblGiaovien();
        private SQL_tblLop DAL_Lop = new SQL_tblLop();
        private EC_tblGiangday EC_Giang = new EC_tblGiangday();
        private bool _them = false;
        private string dk = "";
        public frmQLGD()
        {
            InitializeComponent();
        }

        private void frmQLGD_Load(object sender, EventArgs e)
        {
            var source = new AutoCompleteStringCollection();
            
             tb = DAL_GV.getThongTinGV();
            cboGiaoVien.DataSource = tb;
            cboGiaoVien.DisplayMember = "HoTen";
            cboGiaoVien.ValueMember = "MaGV";
            for (int _i = 0; _i < tb.Rows.Count; _i++) source.Add(tb.Rows[_i]["HoTen"].ToString());
            cboGiaoVien.AutoCompleteCustomSource = source;

            tb = DAL_Lop.getAllLop();
            cboLop.DataSource = tb;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            for (int _i = 0; _i < tb.Rows.Count; _i++) source.Add(tb.Rows[_i]["TenLop"].ToString());
            cboLop.AutoCompleteCustomSource = source;
            dt = DAL_Giang.getThongTinGD();
            dgvDanhSach.DataSource = dt;
             
        }

        private void dgvDanhSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count - 1)
            {
                txtTiet.Text = dgvDanhSach.Rows[e.RowIndex].Cells["Tiet"].Value.ToString();
                cmbThu.Text = dgvDanhSach.Rows[e.RowIndex].Cells["Thu"].Value.ToString();
                cboGiaoVien.Text = dgvDanhSach.Rows[e.RowIndex].Cells["TenGV"].Value.ToString();
                cboLop.Text = dgvDanhSach.Rows[e.RowIndex].Cells["Lop"].Value.ToString();
            }
            else
            {
                ResetData();
            }
        }
        private void ResetData()
        {
            cboGiaoVien.ResetText();
            cboLop.ResetText();
            txtTiet.ResetText();
            cmbThu.ResetText();
        }
        private void MoBtn()
        {
            txtTiet.Enabled = true;
            cboLop.Enabled = true;
            cboGiaoVien.Enabled = true;
            cmbThu.Enabled = true;
            btnLuu.Enabled = true;
            dgvDanhSach.Enabled = false;
        }

        private void KhoaBtn()
        {
            txtTiet.Enabled = false;
            cboLop.Enabled = false;
            cboGiaoVien.Enabled = false;
            cmbThu.Enabled = false;
            btnLuu.Enabled = false;
            dgvDanhSach.Enabled = true;
        }
        private void Reset()
        {
            dgvDanhSach.DataSource = DAL_Giang.getThongTinGD();
        }
        private void cboGiaoVien_Validated(object sender, EventArgs e)
        {
            if (cboGiaoVien.SelectedValue == null)
            {
                MessageBox.Show("Không có giáo viên");
                cboGiaoVien.Focus();
            }
        }

        private void cboLop_Validated(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null)
            {
                MessageBox.Show("Không có lớp");
                cboLop.Focus();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoBtn();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            ResetData();

            _them = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTiet.Enabled = true;
            btnLuu.Enabled = true;
            dgvDanhSach.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            EC_Giang.Tietday = txtTiet.Text;
            EC_Giang.Thu = cmbThu.Text;
            EC_Giang.MaLop = cboLop.SelectedValue.ToString();
            EC_Giang.MaGV = cboGiaoVien.SelectedValue.ToString();
            DAL_Giang.delGiangday(EC_Giang);
            Reset();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.Text != "" && cboGiaoVien.SelectedValue != null) EC_Giang.MaGV = cboGiaoVien.SelectedValue.ToString();
            else
            {
                MessageBox.Show("Giáo viên không xác định");
                cboGiaoVien.Focus();
                return;
            }
            if (cboLop.Text != "" && cboLop.SelectedValue != null) EC_Giang.MaLop = cboLop.SelectedValue.ToString();
            else
            {
                MessageBox.Show("Lớp không xác định");
                cboLop.Focus();
                return;
            }
            EC_Giang.Thu = cmbThu.Text;
            EC_Giang.Tietday = txtTiet.Text;

            if (_them)
            {
                //them tt
                DAL_Giang.addGiangday(EC_Giang);

                KhoaBtn();
                Reset();
            }
            else
            {
                //sua tt
                DAL_Giang.updateGiangday(EC_Giang);
                KhoaBtn();
                Reset();
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void txtTimGV_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[HoTen] like '%{0}%'", txtTimGV.Text);
            dt.DefaultView.RowFilter = st;
        }

        private void txtTimLop_TextChanged(object sender, EventArgs e)
        {
            string st = string.Format("[TenLop] like '%{0}%'", txtTimLop.Text);
            dt.DefaultView.RowFilter = st;
        }

        private void frmQLGD_FormClosed(object sender, FormClosedEventArgs e)
        {
        //    frmMain frm = new frmMain();
        //    frm.Show();
        //    this.Dispose();
        }

        private void txtTimGV_Click(object sender, EventArgs e)
        {
            txtTimGV.Text = "";
        }

        private void txtTimLop_Click(object sender, EventArgs e)
        {
            txtTimLop.Text = "";
        }
    }
}
