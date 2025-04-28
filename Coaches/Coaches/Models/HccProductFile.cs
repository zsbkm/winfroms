using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccProductFile
{
    public Guid Bvin { get; set; }

    public string FileName { get; set; } = null!;

    public string ShortDescription { get; set; } = null!;

    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public virtual ICollection<HccProductFileXproduct> HccProductFileXproduct { get; } = new List<HccProductFileXproduct>();
}
