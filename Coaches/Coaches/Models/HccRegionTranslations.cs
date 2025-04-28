using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccRegionTranslations
{
    public long RegionTranslationId { get; set; }

    public Guid RegionId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual HccRegions Region { get; set; } = null!;
}
