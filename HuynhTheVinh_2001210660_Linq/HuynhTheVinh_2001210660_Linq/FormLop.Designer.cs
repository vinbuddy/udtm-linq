namespace HuynhTheVinh_2001210660_Linq
{
    partial class FormLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_close = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_TenLop = new System.Windows.Forms.TextBox();
            this.textBox_maLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_khoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(755, 381);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(175, 33);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "Đóng";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(556, 381);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(193, 33);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Xóa";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(755, 342);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(175, 33);
            this.button_edit.TabIndex = 11;
            this.button_edit.Text = "Sửa";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(556, 342);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(193, 33);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_TenLop
            // 
            this.textBox_TenLop.Location = new System.Drawing.Point(556, 210);
            this.textBox_TenLop.Name = "textBox_TenLop";
            this.textBox_TenLop.Size = new System.Drawing.Size(374, 20);
            this.textBox_TenLop.TabIndex = 7;
            // 
            // textBox_maLop
            // 
            this.textBox_maLop.Location = new System.Drawing.Point(556, 127);
            this.textBox_maLop.Name = "textBox_maLop";
            this.textBox_maLop.Size = new System.Drawing.Size(374, 20);
            this.textBox_maLop.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 318);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã khoa";
            // 
            // comboBox_khoa
            // 
            this.comboBox_khoa.FormattingEnabled = true;
            this.comboBox_khoa.Location = new System.Drawing.Point(556, 297);
            this.comboBox_khoa.Name = "comboBox_khoa";
            this.comboBox_khoa.Size = new System.Drawing.Size(374, 21);
            this.comboBox_khoa.TabIndex = 13;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 527);
            this.Controls.Add(this.comboBox_khoa);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_TenLop);
            this.Controls.Add(this.textBox_maLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLop";
            this.Text = "FormLop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_TenLop;
        private System.Windows.Forms.TextBox textBox_maLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_khoa;
    }
}