using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccSearchLexicon
{
    public long Id { get; set; }

    public string Word { get; set; } = null!;

    public string? Culture { get; set; }

    public virtual ICollection<HccSearchObjectWords> HccSearchObjectWords { get; } = new List<HccSearchObjectWords>();
}
