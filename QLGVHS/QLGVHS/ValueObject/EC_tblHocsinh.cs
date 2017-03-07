using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGCHS_ValueObject
{
    public class EC_tblHocsinh
    {
        private string _MaHS;
        public string MaHS
        {
            get { return _MaHS; }
            set { _MaHS = value;}
        }

        private string _Ten;
        public string TenHS
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
       
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _DanToc;

        public string DanToc
        {
            get { return _DanToc; }
            set { _DanToc = value; }
        }

        private string _TonGiao;
        public string TonGiao
        {
            get { return _TonGiao; }
            set { _TonGiao = value; }
        }
      
        
        private string _MaLop;
        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
    }
}
