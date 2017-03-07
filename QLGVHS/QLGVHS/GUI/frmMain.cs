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

namespace QLGVHS.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://quanlygvhs.comli.com/");
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
