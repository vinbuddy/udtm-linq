using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HuynhTheVinh_2001210660_Linq.DBContext;

namespace HuynhTheVinh_2001210660_Linq
{
    public partial class FormMonHoc : Form
    {
        MonHocDBContext monHocContext = new MonHocDBContext();
        public FormMonHoc()
        {
            InitializeComponent();

            RenderDSMonHoc();
        }

        private void RenderDSMonHoc()
        {
            List<MonHoc> dsMonHoc = monHocContext.LoadDSMonHoc();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dsMonHoc;
        }

        private void RenderMonHoc(string maMH)
        {
            if (maMH == null) {
                textBox_maMH.Text = "";
                textBox_TenMH.Text = "";
                return;
            }

            MonHoc monhoc = monHocContext.GetMonHoc(maMH);
            textBox_maMH.Text = monhoc.MaMonHoc;
            textBox_TenMH.Text = monhoc.TenMonHoc;

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            List<MonHoc> dsMonHoc = (List<MonHoc>)dataGridView1.DataSource;

            bool isDuplicate = dsMonHoc.Any(m => m.MaMonHoc == textBox_maMH.Text);

            if (isDuplicate)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }

            MonHoc mh = new MonHoc();

            mh.TenMonHoc = textBox_TenMH.Text;
            mh.MaMonHoc = textBox_maMH.Text;

            bool result = monHocContext.AddMonHoc(mh);

            if (!result)
            {
                MessageBox.Show("Thêm môn KHÔNG học thành công");
                return;
            }

            RenderDSMonHoc();
            MessageBox.Show("Thêm môn học thành công");
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string maMH = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            bool result = monHocContext.UpdateMonHoc(maMH, textBox_TenMH.Text);

            if (!result)
            {
                MessageBox.Show("Cập nhật môn KHÔNG học thành công");
                return;
            }

            RenderDSMonHoc();
            RenderMonHoc(null);
            MessageBox.Show("Cập nhật môn học thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string maMH = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            RenderMonHoc(maMH);


        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string maMH = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            bool result = monHocContext.DeleteMonHoc(maMH);

            if (!result)
            {
                MessageBox.Show("Xóa môn KHÔNG học thành công");
                return;
            }

            RenderDSMonHoc();
            RenderMonHoc(null);
            MessageBox.Show("Xóa môn học thành công");
        }
    }
}
