using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using QLGVHS_BUS;
using QLGVHS_DATA;
using QLGCHS_ValueObject;

namespace QLGVHS.GUI
{
    public partial class frmDangnhap : Form
    {
        BUS_tblUser busUser = new BUS_tblUser();
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("Save") == "true")
            {
                ckcSave.Checked = true;
                txtUsername.Text = ConfigurationManager.AppSettings.Get("Username");
                txtPassword.Text = ConfigurationManager.AppSettings.Get("Password");
            }

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == null)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập !");
            }
            if (txtPassword.Text == null)
            {
                MessageBox.Show("Chưa nhập mật khẩu !");
            }
            if (busUser.checkLogin(txtUsername.Text, txtPassword.Text) != null)
            {
                EC_tblUser ecUser = busUser.getUser(txtUsername.Text, txtPassword.Text);

                if (ckcSave.Checked == true)
                {

                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    _config.AppSettings.Settings["Username"].Value = ecUser.Username;
                    _config.AppSettings.Settings["MaGV"].Value = ecUser.MaGV;
                    _config.AppSettings.Settings["Quyen"].Value = ecUser.Quyen;
                    _config.AppSettings.Settings["Save"].Value = "true";

                    _config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                else
                {
                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    _config.AppSettings.Settings["Save"].Value = "false";

                    _config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckcHienpw_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcHienpw.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPassword.Focus();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnDangnhap_Click(sender, null);
        }

        private void frmDangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
