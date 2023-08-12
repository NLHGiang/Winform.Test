using System;
using System.Collections.Generic;

namespace GiangNLH_PH26511.Winform.Domain;

public partial class NhanVien
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public string? TenDem { get; set; }

    public string? Ho { get; set; }

    public string? GioiTinh { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? DiaChi { get; set; }

    public string? Sdt { get; set; }

    public string? MatKhau { get; set; }

    public Guid? IdCv { get; set; }

    public int? TrangThai { get; set; }

    public virtual ChucVu? IdCvNavigation { get; set; }
}
