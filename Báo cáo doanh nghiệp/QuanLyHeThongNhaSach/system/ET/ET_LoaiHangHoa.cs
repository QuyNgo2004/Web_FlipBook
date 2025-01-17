using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiHangHoa
    {
        private string maLHH, tenHH, ghiChu;

        public ET_LoaiHangHoa(string maLHH, string tenHH, string ghiChu)
        {
            this.maLHH = maLHH;
            this.tenHH = tenHH;
            this.ghiChu = ghiChu;
        }

        public string MaLHH { get => maLHH; set => maLHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
