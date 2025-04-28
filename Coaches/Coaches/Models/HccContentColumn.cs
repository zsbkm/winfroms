using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccContentColumn
{
    public Guid Bvin { get; set; }

    public string DisplayName { get; set; } = null!;

    public int SystemColumn { get; set; }

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<HccContentBlock> HccContentBlock { get; } = new List<HccContentBlock>();
}
