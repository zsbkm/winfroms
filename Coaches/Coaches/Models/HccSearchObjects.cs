using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccSearchObjects
{
    public long Id { get; set; }

    public int ObjectType { get; set; }

    public Guid ObjectId { get; set; }

    public string Title { get; set; } = null!;

    public long SiteId { get; set; }

    public DateTime LastIndexUtc { get; set; }

    public virtual ICollection<HccSearchObjectWords> HccSearchObjectWords { get; } = new List<HccSearchObjectWords>();
}
