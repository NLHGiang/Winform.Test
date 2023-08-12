namespace GiangNLH_PH26511.Winform.Views
{
    partial class SachForm
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
            tenText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            maText = new TextBox();
            label3 = new Label();
            donGiaText = new TextBox();
            label4 = new Label();
            cBox100 = new CheckBox();
            cBox1000 = new CheckBox();
            themBtn = new Button();
            xoaBtn = new Button();
            clearBtn = new Button();
            sachDgrid = new DataGridView();
            timKiemText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)sachDgrid).BeginInit();
            SuspendLayout();
            // 
            // tenText
            // 
            tenText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tenText.Location = new Point(120, 26);
            tenText.Name = "tenText";
            tenText.Size = new Size(294, 34);
            tenText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 28);
            label2.TabIndex = 3;
            label2.Text = "Mã";
            // 
            // maText
            // 
            maText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maText.Location = new Point(120, 84);
            maText.Name = "maText";
            maText.Size = new Size(294, 34);
            maText.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 153);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 5;
            label3.Text = "Đơn giá";
            // 
            // donGiaText
            // 
            donGiaText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            donGiaText.Location = new Point(120, 150);
            donGiaText.Name = "donGiaText";
            donGiaText.Size = new Size(294, 34);
            donGiaText.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 213);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 6;
            label4.Text = "Số trang";
            // 
            // cBox100
            // 
            cBox100.AutoSize = true;
            cBox100.Location = new Point(124, 216);
            cBox100.Name = "cBox100";
            cBox100.Size = new Size(100, 25);
            cBox100.TabIndex = 7;
            cBox100.Text = "100 trang";
            cBox100.UseVisualStyleBackColor = true;
            cBox100.CheckedChanged += cBox100_CheckedChanged;
            // 
            // cBox1000
            // 
            cBox1000.AutoSize = true;
            cBox1000.Location = new Point(314, 218);
            cBox1000.Name = "cBox1000";
            cBox1000.Size = new Size(109, 25);
            cBox1000.TabIndex = 8;
            cBox1000.Text = "1000 trang";
            cBox1000.UseVisualStyleBackColor = true;
            cBox1000.CheckedChanged += cBox1000_CheckedChanged;
            // 
            // themBtn
            // 
            themBtn.Location = new Point(474, 31);
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(269, 38);
            themBtn.TabIndex = 9;
            themBtn.Text = "Thêm";
            themBtn.UseVisualStyleBackColor = true;
            themBtn.Click += themBtn_Click;
            // 
            // xoaBtn
            // 
            xoaBtn.Location = new Point(474, 87);
            xoaBtn.Name = "xoaBtn";
            xoaBtn.Size = new Size(269, 38);
            xoaBtn.TabIndex = 10;
            xoaBtn.Text = "Xóa";
            xoaBtn.UseVisualStyleBackColor = true;
            xoaBtn.Click += xoaBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(474, 153);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(269, 38);
            clearBtn.TabIndex = 11;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // sachDgrid
            // 
            sachDgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sachDgrid.Location = new Point(31, 301);
            sachDgrid.Name = "sachDgrid";
            sachDgrid.RowHeadersWidth = 51;
            sachDgrid.RowTemplate.Height = 31;
            sachDgrid.Size = new Size(712, 228);
            sachDgrid.TabIndex = 12;
            sachDgrid.CellClick += sachDgrid_CellClick;
            // 
            // timKiemText
            // 
            timKiemText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timKiemText.Location = new Point(31, 261);
            timKiemText.Name = "timKiemText";
            timKiemText.Size = new Size(339, 34);
            timKiemText.TabIndex = 13;
            timKiemText.TextChanged += timKiemText_TextChanged;
            // 
            // SachForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 541);
            Controls.Add(timKiemText);
            Controls.Add(sachDgrid);
            Controls.Add(clearBtn);
            Controls.Add(xoaBtn);
            Controls.Add(themBtn);
            Controls.Add(cBox1000);
            Controls.Add(cBox100);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(donGiaText);
            Controls.Add(label2);
            Controls.Add(maText);
            Controls.Add(label1);
            Controls.Add(tenText);
            Name = "SachForm";
            Text = "Sach";
            Load += Sach_Load;
            ((System.ComponentModel.ISupportInitialize)sachDgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tenText;
        private Label label1;
        private Label label2;
        private TextBox maText;
        private Label label3;
        private TextBox donGiaText;
        private Label label4;
        private CheckBox cBox100;
        private CheckBox cBox1000;
        private Button themBtn;
        private Button xoaBtn;
        private Button clearBtn;
        private DataGridView sachDgrid;
        private TextBox timKiemText;
    }
}