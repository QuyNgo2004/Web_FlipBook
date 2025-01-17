using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_CaTruc
    {
        private string maCN, tenCT, ghiChu;
        private int maCT;
        private TimeSpan gioBD, gioKT;

        public ET_CaTruc()
        {
            
        }

        public ET_CaTruc(string maCN, string tenCT, string ghiChu, int maCT, TimeSpan gioBD, TimeSpan gioKT)
        {
            this.MaCN = maCN;
            this.TenCT = tenCT;
            this.GhiChu = ghiChu;
            this.MaCT = maCT;
            this.GioBD = gioBD;
            this.GioKT = gioKT;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int MaCT { get => maCT; set => maCT = value; }
        public TimeSpan GioBD { get => gioBD; set => gioBD = value; }
        public TimeSpan GioKT { get => gioKT; set => gioKT = value; }
    }
}
