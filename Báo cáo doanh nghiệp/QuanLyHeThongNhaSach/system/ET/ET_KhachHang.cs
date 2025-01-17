using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhachHang
    {
        private string maKH, hotenKH, sdtKH, emailKH, gioitinhKH, diachiKH;
        private DateTime ngaysinhKH;

        public ET_KhachHang(string maKH, string hotenKH, DateTime ngaysinhKH, string gioitinhKH, string diachiKH, string sdtKH, string emailKH)
        {
            this.maKH = maKH;
            this.hotenKH = hotenKH;
            this.ngaysinhKH = ngaysinhKH;
            this.gioitinhKH = gioitinhKH;
            this.diachiKH = diachiKH;
            this.sdtKH = sdtKH;
            this.emailKH = emailKH;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HotenKH { get => hotenKH; set => hotenKH = value; }
        public string SdtKH { get => sdtKH; set => sdtKH = value; }
        public string EmailKH { get => emailKH; set => emailKH = value; }
        public string GioitinhKH { get => gioitinhKH; set => gioitinhKH = value; }
        public string DiachiKH { get => diachiKH; set => diachiKH = value; }
        public DateTime NgaysinhKH { get => ngaysinhKH; set => ngaysinhKH = value; }
    }
}
