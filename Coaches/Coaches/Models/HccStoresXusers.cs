using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccStoresXusers
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public long UserId { get; set; }

    public int AccessMode { get; set; }

    public virtual HccStores Store { get; set; } = null!;

    public virtual HccUserAccounts User { get; set; } = null!;
}
