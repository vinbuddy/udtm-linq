using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhTheVinh_2001210660_Linq.DBContext
{
    class MonHocDBContext
    {
        QLSINHVIENDataContext context = new QLSINHVIENDataContext();
        public MonHocDBContext()
        {

        }

        //public iqueryable<monhoc> loaddsmonhoc()
        //{
        //    var dsmonhoc = from mh in context.monhocs select mh;
        //    return dsmonhoc;
        //}

        public List<MonHoc> LoadDSMonHoc()
        {
            //var dsMonHocResult = from mh in context.MonHocs select mh;
            //List<MonHoc> dsMonHoc = dsMonHocResult.ToList<MonHoc>();

            return context.MonHocs.Select(mh => mh).ToList<MonHoc>();
        }

        public MonHoc GetMonHoc(string maMH)
        {
            return context.MonHocs.Where(m => m.MaMonHoc == maMH).FirstOrDefault();
        }

        public bool AddMonHoc(MonHoc monhoc)
        {
            try
            {
                context.MonHocs.InsertOnSubmit(monhoc);
                context.SubmitChanges(); 
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateMonHoc(string maMH, string tenMH)
        {
            try
            {
                MonHoc mh = context.MonHocs.Where(m => m.MaMonHoc == maMH).FirstOrDefault();

                mh.TenMonHoc = tenMH;

                context.SubmitChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteMonHoc(string maMH)
        {
            try
            {
                MonHoc mh = context.MonHocs.Where(m => m.MaMonHoc == maMH).FirstOrDefault();

                if (mh == null) return false;

                context.MonHocs.DeleteOnSubmit(mh);
                context.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
