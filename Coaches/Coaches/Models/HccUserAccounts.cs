using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccUserAccounts
{
    public long Id { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public int Statuscode { get; set; }

    public string Salt { get; set; } = null!;

    public string ResetKey { get; set; } = null!;

    public virtual ICollection<HccAuthTokens> HccAuthTokens { get; } = new List<HccAuthTokens>();

    public virtual ICollection<HccStoresXusers> HccStoresXusers { get; } = new List<HccStoresXusers>();
}
