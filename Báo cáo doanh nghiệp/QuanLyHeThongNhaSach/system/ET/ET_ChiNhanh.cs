using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiNhanh
    {
        private string maCN;
        private string tenCN;
        private string diaChi;
        private string soDienThoai;
        private string email;
        private string ghiChu;

        public ET_ChiNhanh()
        {
        }

        public ET_ChiNhanh(string maCN, string tenCN, string diaChi, string soDienThoai, string email, string ghiChu)
        {
            this.maCN = maCN;
            this.tenCN = tenCN;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.ghiChu = ghiChu;
        }


        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
