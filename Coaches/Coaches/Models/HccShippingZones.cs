using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccShippingZones
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string Name { get; set; } = null!;

    public string Areas { get; set; } = null!;

    public virtual HccStores Store { get; set; } = null!;
}
