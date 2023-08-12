using System;
using System.Collections.Generic;

namespace GiangNLH_PH26511.Winform.Domain;

public partial class Ban
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? SoThich { get; set; }

    public int? GioiTinh { get; set; }

    public Guid? IdMqh { get; set; }

    public int? TrangThai { get; set; }

    public virtual MoiQuanHe? IdMqhNavigation { get; set; }
}
