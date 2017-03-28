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
    public partial class frmThemtaikhoan : Form
    {
        int them = 1;
        EC_tblUser ecUser = new EC_tblUser();
        BUS_tblUser busUser = new BUS_tblUser();
        BUS_tblGiaovien busGiaovien = new BUS_tblGiaovien();
        public frmThemtaikhoan()
        {
            InitializeComponent();
        }
        public frmThemtaikhoan(EC_tblUser ec)
        {
            InitializeComponent();
            txtUsername.Text = ec.Username;
            txtPassword.Text = ec.Password;
            cmbMaGV.Text = ec.MaGV;
            cmbQuyen.Text = ec.Quyen;
            switch (cmbQuyen.Text.ToString())
            {
                case "Học Sinh":
                    {
                        ecUser.Quyen = "0";
                        break;
                    }
                case "Trợ Giảng":
                    {
                        ecUser.Quyen = "1";
                        break;
                    }
                case "Giáo Viên":
                    {
                        ecUser.Quyen = "2";
                        break;
                    }
                case "Hiểu Trưởng":
                    {
                        ecUser.Quyen = "4";
                        break;
                    }

                case "Administrator":
                    {
                        ecUser.Quyen = "5";
                        break;
                    }
            }
            //switch (ec.Quyen)
            //{
            //    case "0":
            //        {
            //            cmbQuyen.Text = "Học Sinh";
            //            break;
            //        }
            //    case "1":
            //        {
            //            cmbQuyen.Text = "Trợ Giảng";
            //            break;
            //        }
            //    case "2":
            //        {
            //            cmbQuyen.Text = "Giáo Viên";
            //            break;
            //        }
            //    case "3":
            //        {
            //            cmbQuyen.Text = "Hiểu Trưởng";
            //            break;
            //        }

            //    case "4":
            //        {
            //            cmbQuyen.Text = "Administrator";
            //            break;
            //        }}

            this.Text = "Thay đổi thông tin";
            txtUsername.Enabled = false;
            them = 0;
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            ecUser.Username = txtUsername.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbAcc.Controls)//this will only select controls of groupbox2
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = "";
                }
                if (ctrl is CheckBox)
                {
                    (ctrl as CheckBox).Checked = false;
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndex = -1;
                }
                //etc
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmQuantri frm = new frmQuantri();
            frm.Show();

            this.Dispose();
        }

        private void cmbMaGV_Click(object sender, EventArgs e)
        {
            cmbMaGV.DataSource = busGiaovien.getField("MaGV");
            cmbMaGV.DisplayMember = "MaGV";
        }

        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbQuyen.Text.ToString())
            {
                case "Học Sinh":
                    {
                        ecUser.Quyen = "0";
                        break;
                    }
                case "Trợ Giảng":
                    {
                        ecUser.Quyen = "1";
                        break;
                    }
                case "Giáo Viên":
                    {
                        ecUser.Quyen = "2";
                        break;
                    }
                case "Hiểu Trưởng":
                    {
                        ecUser.Quyen = "4";
                        break;
                    }

                case "Administrator":
                    {
                        ecUser.Quyen = "5";
                        break;
                    }
                default:
                    {
                        ecUser.Quyen = "0";
                        break;
                    }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản!");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu!");
                return;
            }
            if (txtPassword.Text != txtRepassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại sai !");
                return;
            }
            if (cmbQuyen.Text == "")
            {
                MessageBox.Show("Chưa chọn quyền tài khoản!");
            }
            if (busUser.checkUser(txtUsername.Text) != null && them == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
                return;
            }
            string quyen = cmbQuyen.Text;
            switch (quyen)
            {
                case @"Học Sinh":
                    ecUser.Quyen = "0";
                    break;
                case @"Trợ Giảng":
                    ecUser.Quyen = "1";
                    break;
                case @"Giáo Viên":
                    ecUser.Quyen = "2";
                    break;
                case @"Hiểu Trưởng":
                    ecUser.Quyen = "4";
                    break;

                case @"Administrator":
                    ecUser.Quyen = "5";
                    break;
                default:
                    ecUser.Quyen = "0";
                    break;
            }
            if (them == 1) busUser.addUser(ecUser);
            else busUser.updateUser(ecUser);
            MessageBox.Show("OK!");
            this.frmThemtaikhoan_FormClosing(sender, null);
        }

        private void frmThemtaikhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmQuantri frm = new frmQuantri();
            //frm.Show();
            //this.Dispose();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ecUser.Password = txtPassword.Text;
        }

        private void cmbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMaGV_TextChanged(object sender, EventArgs e)
        {
            ecUser.MaGV = cmbMaGV.Text;
        }
    }
}
