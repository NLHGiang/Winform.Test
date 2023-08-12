using GiangNLH_PH26511.Winform.Domain;
using GiangNLH_PH26511.Winform.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiangNLH_PH26511.Winform.Views
{
    public partial class SachForm : Form
    {
        SachServices _sachServices = new();
        Guid? _idCellClick = null;
        List<Sach> _listObj = new();

        public SachForm()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            LoadView();
            LoadDgrid(string.Empty);
        }

        private void LoadView()
        {
            timKiemText.PlaceholderText = "Tìm kiếm";
            cBox100.Checked = true;
        }

        private void LoadDgrid(string textSearch)
        {
            sachDgrid.Rows.Clear();

            sachDgrid.ColumnCount = 5;
            sachDgrid.Columns[0].Name = "STT";
            sachDgrid.Columns[1].Name = "Mã Sách";
            sachDgrid.Columns[2].Name = "Tên Sách";
            sachDgrid.Columns[3].Name = "Số Trang";
            sachDgrid.Columns[4].Name = "Đơn Giá";

            _listObj = _sachServices.GetAll(textSearch);

            foreach (var item in _listObj)
            {
                sachDgrid.Rows.Add((_listObj.IndexOf(item) + 1), item.Ma, item.Ten, item.SoTrang, item.DonGia);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            if (_sachServices.CheckDuplicateMaSach(maText.Text))
            {
                MessageBox.Show("Trùng mã. Hãy nhập mã sách khác.");
            }
            else
            {
                var sachAdd = new Sach()
                {
                    Ma = maText.Text,
                    Ten = tenText.Text,
                    DonGia = Convert.ToDecimal(donGiaText.Text),
                    SoTrang = cBox100.Checked ? 100 : cBox1000.Checked ? 1000 : 0,
                };
                var resultAdd = _sachServices.Add(sachAdd);

                if (resultAdd == true)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDgrid(string.Empty);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (_idCellClick != null)
            {
                var resultDelete = _sachServices.Delete((Guid)_idCellClick);

                if (resultDelete)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDgrid(string.Empty);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tenText.Clear();
            maText.Clear();
            donGiaText.Clear();
            timKiemText.Clear();
            cBox100.Checked = true;
            cBox1000.Checked = false;
        }

        private void cBox100_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox100.Checked)
            {
                cBox1000.Checked = false;
            }
        }

        private void cBox1000_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox1000.Checked)
            {
                cBox100.Checked = false;
            }
        }

        private void sachDgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            var objCellClick = _listObj[index];

            _idCellClick = objCellClick.Id;
        }

        private void timKiemText_TextChanged(object sender, EventArgs e)
        {
            LoadDgrid(timKiemText.Text);
        }
    }
}
