using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KiemTra.Models
{
    public class Sinhvien
    {
        public int Id { get; set; }
        public string MaSinhVien { get; set; }
        public string HinhfThucPhat { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNopPhat
        {
            get { return DateTime.Now; }
        }
    }
}