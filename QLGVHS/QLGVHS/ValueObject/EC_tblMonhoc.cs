using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGCHS_ValueObject
{
    public class EC_tblMonhoc
    {
        private string _MaMon;

        public string MaMon
        {
            get { return _MaMon; }
            set { _MaMon = value; }
        }
        private string _TenMon;

        public string TenMon
        {
            get { return _TenMon; }
            set { _TenMon = value; }
        }
    }
}
