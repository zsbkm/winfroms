using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccAuthTokens
{
    public long Id { get; set; }

    public Guid TokenId { get; set; }

    public long UserId { get; set; }

    public DateTime Expires { get; set; }

    public virtual HccUserAccounts User { get; set; } = null!;
}
