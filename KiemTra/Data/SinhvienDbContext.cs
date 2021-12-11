using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KiemTra.Data
{
    public class SinhvienDbContext: DbContext
    {
        public SinhvienDbContext() : base("name=SinhvienDbContext")
        {

        }

        public System.Data.Entity.DbSet<KiemTra.Models.Sinhvien> Sinhviens { get; set; }
    }
}