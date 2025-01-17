using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhaPhanPhoi
    {
        private string maNPP;
        private string tenNPP;
        private string diaChiNPP;
        private string sdtNPP;
        private string emailNPP;

        public ET_NhaPhanPhoi()
        {
        }

        public ET_NhaPhanPhoi(string maNPP, string tenNPP, string diaChiNPP, string sdtNPP, string emailNPP)
        {
            this.maNPP = maNPP;
            this.tenNPP = tenNPP;
            this.diaChiNPP = diaChiNPP;
            this.sdtNPP = sdtNPP;
            this.emailNPP = emailNPP;
        }

        public string MaNPP { get => maNPP; set => maNPP = value; }
        public string TenNPP { get => tenNPP; set => tenNPP = value; }
        public string DiaChiNPP { get => diaChiNPP; set => diaChiNPP = value; }
        public string SdtNPP { get => sdtNPP; set => sdtNPP = value; }
        public string EmailNPP { get => emailNPP; set => emailNPP = value; }
    }
}
