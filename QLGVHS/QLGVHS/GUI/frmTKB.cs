using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using QLGCHS_ValueObject;
using QLGVHS_BUS;
using QLGVHS_DATA;

namespace QLGVHS.GUI
{
    public partial class frmTKB : Form
    {
        private SQL_tblGiangday DAL_Giang = new SQL_tblGiangday();
        private SQL_tblGiaovien DAL_GV = new SQL_tblGiaovien();
        private SQL_tblLop DAL_Lop = new SQL_tblLop();
        private EC_tblGiangday EC_Giang = new EC_tblGiangday();
        private bool _them = false;
        private string dk = "";
        public frmTKB()
        {
            InitializeComponent();
        }

        private void frmTKB_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                dgvTKB.Rows.Add();
                dgvTKB.Rows[i].Cells["Tiet"].Value = i + 1;
            }
            DataTable tb = DAL_Lop.getAllLop();
            cmbClass.SelectedIndex = -1;
            cmbClass.DataSource = tb;
            cmbClass.DisplayMember = "TenLop";
            cmbClass.ValueMember = "MaLop";

            int rule = int.Parse(ConfigurationManager.AppSettings.Get("Quyen"));
            checkRule(rule);
        }

        private void checkRule(int rule)
        {
            if (rule <= 2)
                btnAdd.Enabled = false;
        }
        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = dgvTKB.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                dgvTKB.Rows.RemoveAt(0);
            }

            for (int i = 0; i < 6; i++)
            {
                dgvTKB.Rows.Add();
                dgvTKB.Rows[i].Cells["Tiet"].Value = i + 1;
            }
            KetNoiDB db = new KetNoiDB();
            DataTable tb = db.getDatatable(@"select gg.Thu, gg.Tietday, m.TenMon,l.TenLop,g.TenGV as Hoten, gg.MaGV  from tblGiangday gg, tblLop l, tblGiaovien g, tblMonhoc m
                                           where gg.MaGV = g.MaGV and l.MaLop = gg.MaLop and m.MaMon = g.MaMon and l.TenLop='" + cmbClass.Text + @"' order by gg.Tietday");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                string thu = tb.Rows[i]["Thu"].ToString();
                int tiet = int.Parse(tb.Rows[i]["Tietday"].ToString());
                dgvTKB.Rows[tiet - 1].Cells["Thu" + thu].Value = tb.Rows[i]["TenMon"].ToString();
                dgvTKB.Rows[tiet - 1].Cells["TenGV" + thu].Value = tb.Rows[i]["Hoten"].ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
