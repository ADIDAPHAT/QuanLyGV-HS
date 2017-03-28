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
    public partial class frmQuantri : Form
    {
        EC_tblUser ecUser = new EC_tblUser();
        BUS_tblUser busUser = new BUS_tblUser();
        int dong = -1;
        public frmQuantri()
        {
            InitializeComponent();
        }

        private void frmQuantri_Load(object sender, EventArgs e)
        {
            dgvAcc.DataSource = busUser.getUserinfo("");
            for (int i = 0; i < dgvAcc.RowCount; i++)
            {
                if (dgvAcc.Rows[i].Cells["TenQuyen"].Value.ToString() == "Administrator") dgvAcc.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void frmQuantri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Dispose();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn tài khoản để xóa .");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa ?", "Hỏi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ecUser.Username = dgvAcc.Rows[dong].Cells["Username"].Value.ToString();
                    ecUser.Password = dgvAcc.Rows[dong].Cells["Password"].Value.ToString();
                    busUser.delUser(ecUser);
                    frmQuantri_Load(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn tài khoản!");
                return;
            }
            frmThemtaikhoan frm = new frmThemtaikhoan(ecUser);
            frm.Show();
            this.Hide();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemtaikhoan frm = new frmThemtaikhoan();
            frm.ShowDialog();
        }

        private void dgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            ecUser.Username = dgvAcc.Rows[dong].Cells["Username"].Value.ToString();
            ecUser.Password = dgvAcc.Rows[dong].Cells["Password"].Value.ToString();
            ecUser.MaGV = dgvAcc.Rows[dong].Cells["MaGV"].Value.ToString();
            ecUser.Quyen = dgvAcc.Rows[dong].Cells["TenQuyen"].Value.ToString();
        }

        private void dgvAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            ecUser.Username = dgvAcc.Rows[dong].Cells["Username"].Value.ToString();
            ecUser.Password = dgvAcc.Rows[dong].Cells["Password"].Value.ToString();
            ecUser.MaGV = dgvAcc.Rows[dong].Cells["MaGV"].Value.ToString();
            ecUser.Quyen = dgvAcc.Rows[dong].Cells["TenQuyen"].Value.ToString();
        }
    }
}
