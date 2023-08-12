using System;
using System.Collections.Generic;

namespace GiangNLH_PH26511.Winform.Domain;

public partial class ChucVu
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
