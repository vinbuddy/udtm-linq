using System;
using System.Collections.Generic;
using System.Linq;

namespace HuynhTheVinh_2001210660_Linq.DBContext
{
    class LopDBContext
    {
        QLSINHVIENDataContext context = new QLSINHVIENDataContext();

        public LopDBContext() { }

        public List<Lop> LoadDSLop()
        {
            return context.Lops.Select(l => l).ToList();
        }

        public List<Khoa> LoadDSKhoa()
        {
            return context.Khoas.Select(k => k).ToList();
        }

        public Lop GetLop(string maLop)
        {
            return context.Lops.Where(l => l.MaLop == maLop).FirstOrDefault();
        }

        public bool AddLop(Lop lop)
        {
            try
            {
                context.Lops.InsertOnSubmit(lop);
                context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateLop(string maLop, string tenLop, string maKhoa)
        {
            try
            {
                Lop lop = context.Lops.Where(l => l.MaLop == maLop).FirstOrDefault();

                if (lop != null)
                {
                    lop.TenLop = tenLop;
                    lop.MaKhoa = maKhoa;

                    context.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLop(string maLop)
        {
            try
            {
                Lop lop = context.Lops.Where(l => l.MaLop == maLop).FirstOrDefault();

                if (lop == null) return false;

                context.Lops.DeleteOnSubmit(lop);
                context.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
