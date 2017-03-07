using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGCHS_ValueObject
{
    public class EC_tblGiaovien
    {
        private string _MaGV;

        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }
        private string _Ten;

        public string TenGV
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        private string _GT;

        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }
        private string _NgaySinh;

        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _Luong;

        public string Luong
        {
            get { return _Luong; }
            set { _Luong = value; }
        }
        private string _MaMon;

        public string MaMon
        {
            get { return _MaMon; }
            set { _MaMon = value; }
        }
    }
}
