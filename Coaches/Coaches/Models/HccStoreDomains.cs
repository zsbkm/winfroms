using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccStoreDomains
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string DomainName { get; set; } = null!;
}
