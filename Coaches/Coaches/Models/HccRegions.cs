using System;
using System.Collections.Generic;

namespace Coaches.Models;

public partial class HccRegions
{
    public Guid RegionId { get; set; }

    public Guid CountryId { get; set; }

    public string? Abbreviation { get; set; }

    public string? SystemName { get; set; }

    public virtual HccCountries Country { get; set; } = null!;

    public virtual ICollection<HccRegionTranslations> HccRegionTranslations { get; } = new List<HccRegionTranslations>();
}
