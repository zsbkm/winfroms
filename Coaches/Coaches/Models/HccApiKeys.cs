using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccApiKeys
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string ApiKey { get; set; } = null!;
}
