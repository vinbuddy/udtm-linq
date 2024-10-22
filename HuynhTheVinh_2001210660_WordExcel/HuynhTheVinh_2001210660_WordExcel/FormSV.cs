using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhTheVinh_2001210660_WordExcel
{
    public partial class FormSV : Form
    {
        QLSINHVIENDataContext dbContext = new QLSINHVIENDataContext();
        public FormSV()
        {
            InitializeComponent();
        }

        private void FormSV_Load(object sender, EventArgs e)
        {

            var result = dbContext.SinhViens.Join(dbContext.Lops,
                      sv => sv.MaLop,
                      lop => lop.MaLop,
                      (sv, lop) => new { sv, lop })
                .Join(dbContext.Khoas,
                      combined => combined.lop.MaKhoa,
                      khoa => khoa.MaKhoa,
                      (combined, khoa) => new
                      {
                          MaSinhVien = combined.sv.MaSinhVien,
                          TenSinhVien = combined.sv.HoTen,
                          NgaySinh = combined.sv.NgaySinh,
                          GioiTinh = "Nam", // Cần xử lý nếu có cả giới tính nữ,
                          NoiSinh = "VinhChau",
                          TenLop = combined.lop.TenLop,
                          TenKhoa = khoa.TenKhoa
                      }).ToList(); // Chuyển đổi thành danh sách

            dataGridView1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                var row = dataGridView1.SelectedRows[0];

                // Lấy thông tin từ các ô trong dòng
                string maSinhVien = row.Cells["MaSinhVien"].Value.ToString();
                string tenSinhVien = row.Cells["TenSinhVien"].Value.ToString();
                string ngaySinh = row.Cells["NgaySinh"].Value.ToString();
                string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
                string tenLop = row.Cells["TenLop"].Value.ToString();
                string tenKhoa = row.Cells["TenKhoa"].Value.ToString();
                string noiSinh = row.Cells["NoiSinh"].Value.ToString();


                WordExport wordHandler = new WordExport();

                wordHandler.InThongTinSinhVien(tenSinhVien, ngaySinh, tenLop, "Nam", noiSinh, tenKhoa);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên.");
            }
        }
    }
}
