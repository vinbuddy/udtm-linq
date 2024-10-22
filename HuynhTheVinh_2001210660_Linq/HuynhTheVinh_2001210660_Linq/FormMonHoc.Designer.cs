namespace HuynhTheVinh_2001210660_Linq
{
    partial class FormMonHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_maMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TenMH = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 318);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma mon hoc";
            // 
            // textBox_maMH
            // 
            this.textBox_maMH.Location = new System.Drawing.Point(646, 83);
            this.textBox_maMH.Name = "textBox_maMH";
            this.textBox_maMH.Size = new System.Drawing.Size(374, 20);
            this.textBox_maMH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten mon hoc";
            // 
            // textBox_TenMH
            // 
            this.textBox_TenMH.Location = new System.Drawing.Point(646, 175);
            this.textBox_TenMH.Name = "textBox_TenMH";
            this.textBox_TenMH.Size = new System.Drawing.Size(374, 20);
            this.textBox_TenMH.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(646, 245);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(193, 33);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(845, 245);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(175, 33);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Sửa";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(646, 284);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(193, 33);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Xóa";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(845, 284);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(175, 33);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Đóng";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 383);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_TenMH);
            this.Controls.Add(this.textBox_maMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMonHoc";
            this.Text = "FormMonHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_maMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TenMH;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_close;
    }
}