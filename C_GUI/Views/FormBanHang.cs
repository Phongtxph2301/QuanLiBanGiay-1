using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.Views
{
    public partial class FormBanHang : Form
    {
        private readonly IQLChiTietGiayServices _iQlChiTietGiayServices;
        private readonly IQLKhachHangServices _iQLKhachHangServices;
        public FormBanHang()
        {
            InitializeComponent();
            _iQlChiTietGiayServices = new QLChiTietGiayServices();
            _iQLKhachHangServices = new QLKhachHangServices();
            LoadChiTietGiay();
            LoadComboBox();
        }

        private void LoadChiTietGiay()
        {
            _lsvShowSanPham.Items.Clear();
            foreach (B_BUS.View_Models.QLChiTietGiayView x in _iQlChiTietGiayServices.Getall())
            {
                string[] row = { x.ChiTietGiay.Id.ToString(), x.Giay.TenGiay, x.MauSac.TenMauSac, x.HangGiay.TenHangGiay, x.Nsx.TenNsx, x.Size.TenSize, x.ChieuCaoDeGiay.KichCo.ToString(), x.ChiTietGiay.GiaBan.ToString(), x.ChiTietGiay.SoLuongTon.ToString(), x.ChiTietGiay.MoTa };
                ListViewItem listViewItem = new(row);
                _ = _lsvShowSanPham.Items.Add(listViewItem);
            }
            ListViewItem lstViewItem = new();
            _ = _lsvShowSanPham.Items.Add(lstViewItem);
        }

        private void LoadComboBox()
        {
            _cbxKhachHang.Items.Clear();
            _cbxNhanVien.Items.Clear();
            foreach (B_BUS.View_Models.QLKhachHangView item in _iQLKhachHangServices.Getall())
            {
                _ = _cbxKhachHang.Items.Add(item.MaKhachHang);
            }
        }
    }
}
