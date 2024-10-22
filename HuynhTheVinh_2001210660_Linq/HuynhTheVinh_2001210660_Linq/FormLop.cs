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
    public partial class FormLop : Form
    {
        LopDBContext lopContext = new LopDBContext();

        public FormLop()
        {
            InitializeComponent();

            RenderDSLop();
            RenderComboboxKhoa();
        }

        private void RenderDSLop()
        {
            List<Lop> dsMonHoc = lopContext.LoadDSLop();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dsMonHoc;
        }

        private void RenderLop(string maLop)
        {
            if (maLop == null)
            {
                textBox_maLop.Text = "";
                textBox_TenLop.Text = "";
                return;
            }


            Lop lop = lopContext.GetLop(maLop);
            textBox_maLop.Text = lop.MaLop;
            textBox_TenLop.Text = lop.TenLop;
            comboBox_khoa.SelectedValue = lop.MaKhoa;

        }

        private void RenderComboboxKhoa()
        {
            List<Khoa> dsKhoa = lopContext.LoadDSKhoa();

            comboBox_khoa.DataSource = null;
            comboBox_khoa.DataSource = dsKhoa;

            comboBox_khoa.DisplayMember = "TenKhoa";
            comboBox_khoa.ValueMember = "MaKhoa";

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            List<Lop> dsLop = (List<Lop>)dataGridView1.DataSource;

            bool isDuplicate = dsLop.Any(m => m.MaLop == textBox_maLop.Text);

            if (isDuplicate)
            {
                MessageBox.Show("Trùng khóa chính");
                return;
            }

            Lop mh = new Lop();

            mh.TenLop = textBox_TenLop.Text;
            mh.MaLop = textBox_maLop.Text;

            bool result = lopContext.AddLop(mh);

            if (!result)
            {
                MessageBox.Show("Thêm lớp KHÔNG thành công");
                return;
            }

            RenderDSLop();
            MessageBox.Show("Thêm lớp học thành công");
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string maLop = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string maKhoa = (string)comboBox_khoa.SelectedValue;
            bool result = lopContext.UpdateLop(maLop, textBox_TenLop.Text, maKhoa);

            if (!result)
            {
                MessageBox.Show("Cập nhật lớp KHÔNG thành công");
                return;
            }

            RenderDSLop();
            RenderLop(null);
            MessageBox.Show("Cập nhật lớp học thành công");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string maLop = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            bool result = lopContext.DeleteLop(maLop);

            if (!result)
            {
                MessageBox.Show("Xóa lớp KHÔNG thành công");
                return;
            }

            RenderDSLop();
            RenderLop(null);
            MessageBox.Show("Xóa lớp học thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string maLop = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            RenderLop(maLop);

        }
    }
}
