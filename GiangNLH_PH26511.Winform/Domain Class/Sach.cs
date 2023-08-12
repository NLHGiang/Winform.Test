using System;
using System.Collections.Generic;

namespace GiangNLH_PH26511.Winform.Domain;

public partial class Sach
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgayXuatBan { get; set; }

    public int? SoTrang { get; set; }

    public decimal? DonGia { get; set; }

    public Guid? IdNxb { get; set; }

    public int? TrangThai { get; set; }

    public virtual Nxb? IdNxbNavigation { get; set; }
}
