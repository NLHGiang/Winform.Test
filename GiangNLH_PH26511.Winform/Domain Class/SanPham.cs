using System;
using System.Collections.Generic;

namespace GiangNLH_PH26511.Winform.Domain;

public partial class SanPham
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySx { get; set; }

    public string? Mota { get; set; }

    public string? Website { get; set; }

    public decimal? GiaBan { get; set; }

    public int? SoLuong { get; set; }

    public Guid? IdLoaiSp { get; set; }

    public int? TrangThai { get; set; }

    public virtual LoaiSp? IdLoaiSpNavigation { get; set; }
}
