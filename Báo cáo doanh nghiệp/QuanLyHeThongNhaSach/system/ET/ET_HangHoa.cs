using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HangHoa
    {
        private string maHH, tenHH, loaiHH, donviTinh, nhaPP, moTa, ghiChu, tinhTrang;
        private int giaHH, slTon;

        public ET_HangHoa(string maHH, string tenHH, string loaiHH, int giaHH, string donviTinh, int slTon, string nhaPP, string moTa, string ghiChu, string tinhTrang)
        {
            this.maHH = maHH;
            this.tenHH = tenHH;
            this.loaiHH = loaiHH;
            this.donviTinh = donviTinh;
            this.nhaPP = nhaPP;
            this.moTa = moTa;
            this.ghiChu = ghiChu;
            this.tinhTrang = tinhTrang;
            this.giaHH = giaHH;
            this.slTon = slTon;
        }

        public string MaHH { get => maHH; set => maHH = value; }
        public string TenHH { get => tenHH; set => tenHH = value; }
        public string LoaiHH { get => loaiHH; set => loaiHH = value; }
        public string DonviTinh { get => donviTinh; set => donviTinh = value; }
        public string NhaPP { get => nhaPP; set => nhaPP = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public int GiaHH { get => giaHH; set => giaHH = value; }
        public int SlTon { get => slTon; set => slTon = value; }
    }
}
