using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGCHS_ValueObject
{
    public class EC_tblGiangday
    {
        private string _MaMon;

        public string MaMon
        {
            get { return _MaMon; }
            set { _MaMon = value; }
        }
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _MaGV;

        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }
        private string _Thu;

        public string Thu
        {
            get { return _Thu; }
            set { _Thu = value; }
        }
        private string _Tietday;

        public string Tietday
        {
            get { return _Tietday; }
            set { _Tietday = value; }
        }
    }
}
