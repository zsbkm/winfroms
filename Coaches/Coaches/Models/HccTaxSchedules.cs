using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccTaxSchedules
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string Name { get; set; } = null!;

    public decimal DefaultRate { get; set; }

    public decimal DefaultShippingRate { get; set; }

    public virtual ICollection<HccTaxes> HccTaxes { get; } = new List<HccTaxes>();

    public virtual HccStores Store { get; set; } = null!;
}
