using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccSearchObjectWords
{
    public long SearchObjectId { get; set; }

    public long WordId { get; set; }

    public int Score { get; set; }

    public long SiteId { get; set; }

    public virtual HccSearchObjects SearchObject { get; set; } = null!;

    public virtual HccSearchLexicon Word { get; set; } = null!;
}
