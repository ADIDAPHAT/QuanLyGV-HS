using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using QLGVHS_DATA;
using QLGVHS_BUS;
using QLGCHS_ValueObject;
using System.Configuration;

namespace QLGVHS.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblHi.Text += ConfigurationManager.AppSettings.Get("Username");
            int rule = int.Parse(ConfigurationManager.AppSettings.Get("Quyen"));
            checkRule(rule);
        }
        private void checkRule(int rule)
        {
            foreach (Control ctr in panel1.Controls)
            {
                ctr.Enabled = false;
            }

            menuStrip1.Enabled = true;
            if (rule >= 0)
            {
                btnLogout.Enabled = true;
                btnHocsinh.Enabled = true;
                btnListstudent.Enabled = true;
                btnSearchstudent.Enabled = true;
                btnHuongdan.Enabled = true;
                btnStudent.Enabled = true;
                btnTkb.Enabled = true;

                btnRegisterteach.Enabled = false;
                btnTeacher.Enabled = false;
                btnAcc.Enabled = false;
            }
            if (rule >= 1)
            {
                btnGiaovien.Enabled = true;
                btnListteacher.Enabled = true;
                btnSearchtecher.Enabled = true;
                btnTeacher.Enabled = true;
                btnAcc.Enabled = true;
            }
            if (rule >= 2)
            {
                btnTkb.Enabled = true;
                btnRegisterteach.Enabled = true;

            }
            if (rule >= 4)
            {
                foreach (Control ctr in this.Controls)
                {
                    ctr.Enabled = true;
                }
            }
        }
        private void btnF1_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://qlgvhs.herobo.com/");
        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnListstudent_Click(object sender, EventArgs e)
        {
            frmHocsinh hs = new GUI.frmHocsinh();
            hs.ShowDialog();
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://qlgvhs.herobo.com/");
            
        }

        private void btnTkb_Click(object sender, EventArgs e)
        {
            frmTKB tkb = new frmTKB();
            tkb.ShowDialog();

        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            frmHocsinh hs = new frmHocsinh();
            hs.ShowDialog();
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new GUI.frmGiaoVien();
            gv.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmDangnhap dn = new frmDangnhap();
            this.Close();
            dn.Show();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            frmQuantri qt = new frmQuantri();
            qt.ShowDialog();
        }

        private void btnRegisterteach_Click(object sender, EventArgs e)
        {
            frmQLGD qlgd = new GUI.frmQLGD();
            qlgd.ShowDialog();
        }

        private void btnListteacher_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.ShowDialog();
        }

        private void btnSearchstudent_Click(object sender, EventArgs e)
        {
            frmHocsinh hs = new frmHocsinh();
            hs.ShowDialog();
        }

        private void btnSearchtecher_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.ShowDialog();
        }
    }
}
